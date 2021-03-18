using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading;

namespace McVoterBase
{
    static class Functions
    {
        public static void LoadSettings()
        {
            if(File.Exists("settings.json"))
            {
                var settings = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText("settings.json"));
                Globals.nickname = settings["nickname"];
                Globals.apiKey = settings["apiKey"];
            }

            Globals.serversList.Clear();
            if(File.Exists("servers.mcv"))
            {
                foreach(var line in File.ReadAllLines("servers.mcv"))
                {
                    if(!string.IsNullOrEmpty(line))
                    {
                        Globals.serversList.Enqueue(line);
                    }
                }
            }
        }

        public static void SaveSettings(string nickname, string apiKey)
        {
            Dictionary<string, string> settings = new Dictionary<string, string>();
            settings["nickname"] = nickname;
            settings["apiKey"] = apiKey;

            Globals.nickname = nickname;
            Globals.apiKey = apiKey;

            File.WriteAllText("settings.json", JsonConvert.SerializeObject(settings));

            File.WriteAllText("servers.mcv","");
            foreach(var server in Globals.serversList)
            {
                File.AppendAllText("servers.mcv", server+"\r\n");
            }
        }

        public static bool NeedsSetup()
        {
            if (!string.IsNullOrEmpty(Globals.nickname) && !string.IsNullOrEmpty(Globals.apiKey)) return false;
            return true;
        }

        public static async Task<Dictionary<string, double>> GetBalance()
        {
            var content = new Dictionary<string, object>
            {
                {"clientKey", Globals.apiKey}
            };

            HttpClient httpClient = new HttpClient();
            CancellationToken cT = new CancellationToken();
            var inResponse = await httpClient.PostAsync("https://api.anti-captcha.com/getBalance", new StringContent(JsonConvert.SerializeObject(content)), cT).ConfigureAwait(false);
            var inJson = await inResponse.Content.ReadAsStringAsync().ConfigureAwait(false);

            var result = JsonConvert.DeserializeObject<Dictionary<string,string>>(inJson);
            if (result["errorId"] != "0")
            {
                return new Dictionary<string, double>
                {
                    {"success", 0},
                    {"balance", 0},
                };
            }

            return new Dictionary<string, double>
            {
                {"success", 1},
                {"balance", double.Parse(result["balance"])}
            };
        }

        private struct Response
        {
            public int ErrorId;
            public string Status;
            public Dictionary<string, object> Solution;
        }

        public static async Task<Dictionary<string, string>> GetResponse(string url, string websiteKey, string siteType)
        {
            bool canContinue = true;

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
                if (siteType == "czech-craft.eu")
                {
                    Globals.czechCraft = true;
                }
                else if (siteType == "craftlist.org")
                {
                    Globals.craftList = true;
                }

                var content = new Dictionary<string, object>
                {
                    {"clientKey", Globals.apiKey},
                    {
                        "task", new Dictionary<string, object>
                        {
                            {"type", "RecaptchaV2TaskProxyless"},
                            {"websiteURL", url},
                            {"websiteKey", websiteKey}
                        }
                    }
                };

                HttpClient httpClient = new HttpClient();
                CancellationToken cT = new CancellationToken();


                var inResponse = await httpClient.PostAsync("https://api.anti-captcha.com/createTask", new System.Net.Http.StringContent(JsonConvert.SerializeObject(content)), cT).ConfigureAwait(false);
                var inJson = await inResponse.Content.ReadAsStringAsync().ConfigureAwait(false);


                var deserializedObject = JsonConvert.DeserializeObject<Dictionary<string, string>>(inJson);

                if(int.Parse(deserializedObject["errorId"]) != 0)
                {
                    return new Dictionary<string, string>
                    {
                        {"success", "0"},
                        {"response", null}
                    };
                }

                var taskId = deserializedObject["taskId"].ToString();

                if (string.IsNullOrEmpty(taskId))
                {
                    return new Dictionary<string, string>
                    {
                        {"success", "0"},
                        {"response", null}
                    };
                }

                content = new Dictionary<string, object>
                {
                    {"clientKey", Globals.apiKey},
                    {"taskId", taskId},
                };

                while (true)
                {
                    var response = await httpClient.PostAsync("https://api.anti-captcha.com/getTaskResult", new System.Net.Http.StringContent(JsonConvert.SerializeObject(content)), cT).ConfigureAwait(false);
                    var responseJson = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                    var res = JsonConvert.DeserializeObject<Response>(responseJson);

                    if (res.ErrorId != 0)
                    {
                        return new Dictionary<string, string>
                        {
                            {"success", "0"},
                            {"response", null}
                        };
                    }

                    if (res.Status == "ready")
                    {
                        foreach (KeyValuePair<string, object> solution in res.Solution)
                        {
                            return new Dictionary<string, string>
                            {
                                {"success", "1"},
                                {"response", solution.Value.ToString()}
                            };
                        }
                    }

                    Thread.Sleep(1000);
                }
            }
            else
            {
                return new Dictionary<string, string>
                {
                    {"success", "0"},
                    {"response", null}
                };
            }

        }

        public static string Between(this string value, string a, string b)
        {
            int posA = value.IndexOf(a);
            int posB = value.LastIndexOf(b);
            if (posA == -1)
            {
                return "";
            }
            if (posB == -1)
            {
                return "";
            }
            int adjustedPosA = posA + a.Length;
            if (adjustedPosA >= posB)
            {
                return "";
            }
            return value.Substring(adjustedPosA, posB - adjustedPosA);
        }

        public static string Before(this string value, string a)
        {
            int posA = value.IndexOf(a);
            if (posA == -1)
            {
                return "";
            }
            return value.Substring(0, posA);
        }

        public static string After(this string value, string a)
        {
            int posA = value.LastIndexOf(a);
            if (posA == -1)
            {
                return "";
            }
            int adjustedPosA = posA + a.Length;
            if (adjustedPosA >= value.Length)
            {
                return "";
            }
            return value.Substring(adjustedPosA);
        }

    }
}
