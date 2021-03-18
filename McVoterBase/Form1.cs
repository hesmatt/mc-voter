using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Leaf.xNet;
using System.IO;
using System.Net;

namespace McVoterBase
{
    public partial class Form1 : MetroForm
    {
        delegate void SetTextCallback(string text);

        public Form1()
        {
            InitializeComponent();
            this.SizeChanged += new EventHandler(WindowMinimized);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.StyleManager = styleManager;
            styleManager.Theme = MetroThemeStyle.Dark;
            this.Refresh();

            //Load settings if present
            Functions.LoadSettings();
            nicknameText.Text = Globals.nickname;
            apiKeyText.Text = Globals.apiKey;

            serversList.Items.Clear();
            foreach (var server in Globals.serversList)
            {
                serversList.Items.Add(server);
            }

            votesForLabel.Text = Globals.nickname;

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //Save settings
            Functions.SaveSettings(nicknameText.Text, apiKeyText.Text);
            nicknameText.Text = Globals.nickname;
            apiKeyText.Text = Globals.apiKey;

            MetroMessageBox.Show(this, "Nastavení uloženo", title: "Upozornění");
        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroListView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private async void startButton_Click(object sender, EventArgs e)
        {
            if (Functions.NeedsSetup())
            {
                MetroMessageBox.Show(this, "Je potřeba aplikaci první nastavit", title: "Upozornění");
                return;
            }

            var balance = await Functions.GetBalance();

            if (balance["success"] != 1)
            {
                MetroMessageBox.Show(this, "API klíč pro AntiCaptchu není platný", title: "Upozornění");
                return;
            }

            if (balance["balance"] <= 0.1)
            {
                MetroMessageBox.Show(this, "Nemáte dostatek kreditu na AntiCaptche", title: "Upozornění");
                return;
            }

            startButton.Enabled = false;
            stopButton.Enabled = true;
            Globals.isRunning = true;
            currentStateText.Text = "Běžííí";


            Dictionary<string, DateTime> timeouts = new Dictionary<string, DateTime>();

            foreach (var server in Globals.serversList)
            {
                timeouts[server] = DateTime.Now;
            }

            Thread.Sleep(1000);

            await Task.Run(() => startVoting(timeouts));

        }

        private void SetVotesText(string votes)
        {
            if (this.votesText.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetVotesText);
                this.Invoke(d, new object[] { votes });
            }
            else
            {
                votesText.Text = votes;
            }
        }

        private void AddIntoVotesList(string text)
        {
            if (this.votesList.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(AddIntoVotesList);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                votesList.Items.Add(text);
            }
        }

        private async void startVoting(Dictionary<string, DateTime> timeouts)
        {
            while (Globals.isRunning)
            {
                foreach (KeyValuePair<string, DateTime> server in timeouts.ToDictionary(t => t.Key, t => t.Value))
                {
                    DateTime now = DateTime.Now;
                    HttpRequest req = new HttpRequest();
                    req.IgnoreProtocolErrors = true;
                    req.Cookies = new CookieStorage();
                    bool canContinue = true;
                    string captchaUrl = "",
                    captchaKey = "",
                    postUrl = "",
                    csrfToken = "",
                    getResponse = "",
                    nextVote = "",
                    siteType = "",
                    serverName = "";

                    if (server.Value < now)
                    {
                        if (server.Key.Contains("https://czech-craft.eu"))
                        {
                            postUrl = server.Key.Split('?')[0] + "?user=" + Globals.nickname;
                            captchaUrl = "https://czech-craft.eu/";
                            captchaKey = "6LdG2UkUAAAAALt2hHRqE7k0-9GR7XKYJKGaiqC6";

                            siteType = "czech-craft.eu";
                            serverName = postUrl.Between("server/", "/vote");

                            try
                            {
                                getResponse = req.Get(postUrl).ToString();
                            }
                            catch
                            {
                                getResponse = "";
                            }

                            csrfToken = ((getResponse).Between("csrf_token\" type=\"hidden\" value=\"", "Hlasovat").Replace("<button class=\"button\">", "")).Replace("\">", "").Trim();

                            if (string.IsNullOrEmpty(csrfToken))
                            {
                                canContinue = false;
                            }

                            nextVote = getResponse.Between("Hlasovat pro server můžeš nejdříve v ", "rekl-panel-wrapper").Trim().Before(".");

                            if (!string.IsNullOrEmpty(nextVote))
                            {
                                if (DateTime.Parse(nextVote) > DateTime.Now)
                                {
                                    timeouts[server.Key] = DateTime.Parse(nextVote);

                                    AddIntoVotesList($"Hlasování pro {serverName} na {siteType} bylo přeskočeno, další hlasování je možné v {timeouts[server.Key]}");

                                    canContinue = false;
                                }
                            }


                            foreach (Cookie cookie in req.Cookies.GetCookies(postUrl))
                            {
                                if (cookie.Name == "session")
                                {
                                    req.Cookies.Set("session", cookie.Value, "czech-craft.eu", "/");
                                }
                            }
                        }
                        else if (server.Key.Contains("https://craftlist.org"))
                        {
                            postUrl = postUrl = server.Key.Split('?')[0] + "?nickname=" + Globals.nickname;

                            captchaUrl = "https://craftlist.org/";
                            captchaKey = "6Le10iYTAAAAAHzPo1RtxR7rrdRLnYEATPgSNlcu";

                            siteType = "craftlist.org";
                            serverName = postUrl.Between("org/", "?");

                            try
                            {
                                getResponse = req.Get(postUrl).ToString();
                            }
                            catch
                            {
                                getResponse = "";
                            }

                            nextVote = getResponse.Between("(function () {", "\");").Trim().After("\"");

                            if (!string.IsNullOrEmpty(nextVote))
                            {
                                if (DateTime.Parse(nextVote) > DateTime.Now)
                                {
                                    timeouts[server.Key] = DateTime.Parse(nextVote);

                                    AddIntoVotesList($"Hlasování pro {serverName} na {siteType} bylo přeskočeno, další hlasování je možné v {timeouts[server.Key]}");

                                    canContinue = false;
                                }
                            }
                        }
                        else
                        {
                            AddIntoVotesList($"{server.Key} je neplatná URL adresa pro hlasování, URL adresa dočasně odstraněna");
                            timeouts.Remove(server.Key);
                            canContinue = false;
                        }

                        if (canContinue)
                        {

                            req.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/88.0.4324.182 Safari/537.36 OPR/74.0.3911.203");
                            req.AddHeader("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9");
                            req.AddHeader("Referer", postUrl);

                            if (siteType == "czech-craft.eu" && Globals.czechCraft)
                            {
                                canContinue = false;
                            }
                            else if (siteType == "craftlist.org" && Globals.craftList)
                            {
                                canContinue = false;
                            }

                            if (canContinue)
                            {
                                try
                                {
                                    var result = await Functions.GetResponse(captchaUrl, captchaKey, siteType);

                                    if (!string.IsNullOrEmpty(result["response"]))
                                    {
                                        if (siteType == "czech-craft.eu")
                                        {
                                            var response = req.Post(postUrl, $"username={Globals.nickname}&privacy=y&g-recaptcha-response={result["response"]}&csrf_token={csrfToken}", "application/x-www-form-urlencoded");

                                            if (response.ToString().Contains("Tvůj hlas bude brzy zpracován."))
                                            {
                                                AddIntoVotesList($"Úspešně hlasováno pro {serverName} na {siteType}. URL zařazena do řady pro další hlasování.");
                                                ++Globals.votesGathered;
                                            }
                                            else
                                            {
                                                AddIntoVotesList($"Hlasování pro server {serverName} na {siteType} se nezdařilo, hlasování zařazeno na další pokus");
                                            }
                                        }
                                        else if (siteType == "craftlist.org")
                                        {
                                            var response = req.Post(postUrl, $"nickName={Globals.nickname}&g-recaptcha-response={result["response"]}&_submit=&_do=voteForm-submit", "application/x-www-form-urlencoded").ToString();

                                            if (response.Contains("Další možný hlas za tento server můžeš odeslat"))
                                            {
                                                AddIntoVotesList($"Pokus o hlasování pro {serverName} na {siteType} byl přeskočen, jelikož se pro server již hlasovalo. Přidáno do řady");
                                            }

                                            if (response.ToString().Contains("<div class=\"alert alert-success alert-custom\">Tvůj hlas byl úspěšně přijatý a na serveru tě čeká odměna!</div>"))
                                            {
                                                AddIntoVotesList($"Úspešně hlasováno pro {serverName} na {siteType}. URL zařazena do řady pro další hlasování.");
                                                ++Globals.votesGathered;
                                            }
                                            else
                                            {
                                                AddIntoVotesList($"Hlasování pro server {serverName} na {siteType} se nezdařilo, hlasování zařazeno na další pokus");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        AddIntoVotesList($"Nastala chyba u hlasování pro {serverName} na {siteType}, hlasování přeskočeno. Pro více informací zkontrolujte errors.log");
                                        File.AppendAllText("errors.log", $"---\nHlasování pro {serverName} na {siteType} se nezdařilo protože CAPTCHA odpověď byla prázdná.\n---");
                                    }
                                }
                                catch (Exception ex)
                                {
                                    AddIntoVotesList($"Nastala chyba u hlasování pro {serverName} na {siteType}, hlasování přeskočeno. Pro více informací zkontrolujte errors.log");
                                    File.AppendAllText("errors.log", "---\n" + ex.Message + "\n---");
                                }

                                if (siteType == "czech-craft.eu" && Globals.czechCraft)
                                {
                                    Globals.czechCraft = false;
                                }
                                else if (siteType == "craftlist.org" && Globals.craftList)
                                {
                                    Globals.craftList = false;
                                }
                            }
                        }
                    }
                    else
                    {
                        Thread.Sleep(2500);
                    }
                    SetVotesText(Globals.votesGathered.ToString());
                }
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = true;
            stopButton.Enabled = false;
            Globals.isRunning = false;
            currentStateText.Text = "Pozastaveno";
        }

        private void addServerButton_Click(object sender, EventArgs e)
        {
            Form2 addNewServer = new Form2();
            {
                addNewServer.ShowDialog();
            }

            serversList.Items.Clear();
            foreach (var server in Globals.serversList)
            {
                serversList.Items.Add(server);
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            MessageBox.Show(WindowState.ToString());
        }

        private void removeServerButton_Click(object sender, EventArgs e)
        {
            try
            {
                var currentSelection = serversList.SelectedIndex;
                serversList.Items.RemoveAt(currentSelection);

                Globals.serversList.Clear();
                foreach (var server in serversList.Items)
                {
                    Globals.serversList.Enqueue(server.ToString());
                }
            }
            catch { }
        }

        private void WindowMinimized(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon.Visible = true;
            }     
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
        }
    }
}
