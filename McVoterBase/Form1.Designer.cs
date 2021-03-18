namespace McVoterBase
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.styleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.votePage = new MetroFramework.Controls.MetroTabPage();
            this.currentStateText = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.votesList = new System.Windows.Forms.ListBox();
            this.votesForLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.votesText = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.stopButton = new MetroFramework.Controls.MetroButton();
            this.startButton = new MetroFramework.Controls.MetroButton();
            this.settingsPage = new MetroFramework.Controls.MetroTabPage();
            this.serversList = new System.Windows.Forms.ListBox();
            this.removeServerButton = new MetroFramework.Controls.MetroButton();
            this.addServerButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.saveButton = new MetroFramework.Controls.MetroButton();
            this.nicknameText = new MetroFramework.Controls.MetroTextBox();
            this.apiKeyText = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.styleManager)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.votePage.SuspendLayout();
            this.settingsPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // styleManager
            // 
            this.styleManager.Owner = this;
            this.styleManager.Style = MetroFramework.MetroColorStyle.Green;
            this.styleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.votePage);
            this.metroTabControl1.Controls.Add(this.settingsPage);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 49);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(754, 364);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // votePage
            // 
            this.votePage.Controls.Add(this.currentStateText);
            this.votePage.Controls.Add(this.metroLabel5);
            this.votePage.Controls.Add(this.votesList);
            this.votePage.Controls.Add(this.votesForLabel);
            this.votePage.Controls.Add(this.metroLabel8);
            this.votePage.Controls.Add(this.votesText);
            this.votePage.Controls.Add(this.metroLabel6);
            this.votePage.Controls.Add(this.stopButton);
            this.votePage.Controls.Add(this.startButton);
            this.votePage.HorizontalScrollbarBarColor = true;
            this.votePage.HorizontalScrollbarHighlightOnWheel = false;
            this.votePage.HorizontalScrollbarSize = 10;
            this.votePage.Location = new System.Drawing.Point(4, 38);
            this.votePage.Name = "votePage";
            this.votePage.Size = new System.Drawing.Size(746, 322);
            this.votePage.TabIndex = 1;
            this.votePage.Text = "Hlasování";
            this.votePage.VerticalScrollbarBarColor = true;
            this.votePage.VerticalScrollbarHighlightOnWheel = false;
            this.votePage.VerticalScrollbarSize = 10;
            // 
            // currentStateText
            // 
            this.currentStateText.AutoSize = true;
            this.currentStateText.ForeColor = System.Drawing.Color.Red;
            this.currentStateText.Location = new System.Drawing.Point(87, 303);
            this.currentStateText.Name = "currentStateText";
            this.currentStateText.Size = new System.Drawing.Size(77, 19);
            this.currentStateText.TabIndex = 11;
            this.currentStateText.Text = "Nespuštěno";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(0, 303);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(81, 19);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "Aktuální stav";
            // 
            // votesList
            // 
            this.votesList.BackColor = System.Drawing.SystemColors.WindowText;
            this.votesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.votesList.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.votesList.ForeColor = System.Drawing.Color.White;
            this.votesList.FormattingEnabled = true;
            this.votesList.ItemHeight = 17;
            this.votesList.Location = new System.Drawing.Point(0, 16);
            this.votesList.Name = "votesList";
            this.votesList.Size = new System.Drawing.Size(746, 221);
            this.votesList.TabIndex = 9;
            // 
            // votesForLabel
            // 
            this.votesForLabel.AutoSize = true;
            this.votesForLabel.Location = new System.Drawing.Point(88, 278);
            this.votesForLabel.Name = "votesForLabel";
            this.votesForLabel.Size = new System.Drawing.Size(0, 0);
            this.votesForLabel.TabIndex = 8;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(0, 279);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(81, 19);
            this.metroLabel8.TabIndex = 7;
            this.metroLabel8.Text = "Hlasování za";
            // 
            // votesText
            // 
            this.votesText.AutoSize = true;
            this.votesText.Location = new System.Drawing.Point(107, 250);
            this.votesText.Name = "votesText";
            this.votesText.Size = new System.Drawing.Size(0, 0);
            this.votesText.TabIndex = 6;
            this.votesText.Click += new System.EventHandler(this.metroLabel7_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(0, 250);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(101, 19);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "Hlasů nasbíráno";
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(426, 250);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(157, 69);
            this.stopButton.TabIndex = 4;
            this.stopButton.Text = "Zastavit";
            this.stopButton.UseSelectable = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(589, 250);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(157, 69);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Spustit";
            this.startButton.UseSelectable = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // settingsPage
            // 
            this.settingsPage.Controls.Add(this.serversList);
            this.settingsPage.Controls.Add(this.removeServerButton);
            this.settingsPage.Controls.Add(this.addServerButton);
            this.settingsPage.Controls.Add(this.metroLabel4);
            this.settingsPage.Controls.Add(this.saveButton);
            this.settingsPage.Controls.Add(this.nicknameText);
            this.settingsPage.Controls.Add(this.apiKeyText);
            this.settingsPage.Controls.Add(this.metroLabel3);
            this.settingsPage.Controls.Add(this.metroLabel2);
            this.settingsPage.HorizontalScrollbarBarColor = true;
            this.settingsPage.HorizontalScrollbarHighlightOnWheel = false;
            this.settingsPage.HorizontalScrollbarSize = 10;
            this.settingsPage.Location = new System.Drawing.Point(4, 38);
            this.settingsPage.Name = "settingsPage";
            this.settingsPage.Size = new System.Drawing.Size(746, 322);
            this.settingsPage.TabIndex = 0;
            this.settingsPage.Text = "Nastavení";
            this.settingsPage.VerticalScrollbarBarColor = true;
            this.settingsPage.VerticalScrollbarHighlightOnWheel = false;
            this.settingsPage.VerticalScrollbarSize = 10;
            // 
            // serversList
            // 
            this.serversList.BackColor = System.Drawing.SystemColors.WindowText;
            this.serversList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.serversList.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serversList.ForeColor = System.Drawing.Color.White;
            this.serversList.FormattingEnabled = true;
            this.serversList.ItemHeight = 20;
            this.serversList.Location = new System.Drawing.Point(4, 107);
            this.serversList.Name = "serversList";
            this.serversList.Size = new System.Drawing.Size(745, 120);
            this.serversList.TabIndex = 14;
            // 
            // removeServerButton
            // 
            this.removeServerButton.Location = new System.Drawing.Point(122, 261);
            this.removeServerButton.Name = "removeServerButton";
            this.removeServerButton.Size = new System.Drawing.Size(112, 23);
            this.removeServerButton.TabIndex = 12;
            this.removeServerButton.Text = "Odebrat";
            this.removeServerButton.UseSelectable = true;
            this.removeServerButton.Click += new System.EventHandler(this.removeServerButton_Click);
            // 
            // addServerButton
            // 
            this.addServerButton.Location = new System.Drawing.Point(4, 261);
            this.addServerButton.Name = "addServerButton";
            this.addServerButton.Size = new System.Drawing.Size(112, 23);
            this.addServerButton.TabIndex = 11;
            this.addServerButton.Text = "Přidat";
            this.addServerButton.UseSelectable = true;
            this.addServerButton.Click += new System.EventHandler(this.addServerButton_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(4, 85);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(121, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "URL adresy serverů";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(595, 261);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(151, 58);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Uložit";
            this.saveButton.UseSelectable = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // nicknameText
            // 
            // 
            // 
            // 
            this.nicknameText.CustomButton.Image = null;
            this.nicknameText.CustomButton.Location = new System.Drawing.Point(224, 1);
            this.nicknameText.CustomButton.Name = "";
            this.nicknameText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nicknameText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nicknameText.CustomButton.TabIndex = 1;
            this.nicknameText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nicknameText.CustomButton.UseSelectable = true;
            this.nicknameText.CustomButton.Visible = false;
            this.nicknameText.Lines = new string[0];
            this.nicknameText.Location = new System.Drawing.Point(122, 20);
            this.nicknameText.MaxLength = 32767;
            this.nicknameText.Name = "nicknameText";
            this.nicknameText.PasswordChar = '\0';
            this.nicknameText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nicknameText.SelectedText = "";
            this.nicknameText.SelectionLength = 0;
            this.nicknameText.SelectionStart = 0;
            this.nicknameText.ShortcutsEnabled = true;
            this.nicknameText.Size = new System.Drawing.Size(246, 23);
            this.nicknameText.TabIndex = 5;
            this.nicknameText.UseSelectable = true;
            this.nicknameText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nicknameText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // apiKeyText
            // 
            // 
            // 
            // 
            this.apiKeyText.CustomButton.Image = null;
            this.apiKeyText.CustomButton.Location = new System.Drawing.Point(286, 1);
            this.apiKeyText.CustomButton.Name = "";
            this.apiKeyText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.apiKeyText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.apiKeyText.CustomButton.TabIndex = 1;
            this.apiKeyText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.apiKeyText.CustomButton.UseSelectable = true;
            this.apiKeyText.CustomButton.Visible = false;
            this.apiKeyText.Lines = new string[0];
            this.apiKeyText.Location = new System.Drawing.Point(60, 49);
            this.apiKeyText.MaxLength = 32767;
            this.apiKeyText.Name = "apiKeyText";
            this.apiKeyText.PasswordChar = '\0';
            this.apiKeyText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.apiKeyText.SelectedText = "";
            this.apiKeyText.SelectionLength = 0;
            this.apiKeyText.SelectionStart = 0;
            this.apiKeyText.ShortcutsEnabled = true;
            this.apiKeyText.Size = new System.Drawing.Size(308, 23);
            this.apiKeyText.TabIndex = 4;
            this.apiKeyText.UseSelectable = true;
            this.apiKeyText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.apiKeyText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 52);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(51, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "API klíč";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 20);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(113, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Uživatelské jméno";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(637, 425);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(161, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "@ Matt 2021 - Současnost";
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "dsf";
            this.notifyIcon.BalloonTipTitle = "dsfsdf";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Minecraft Voter (By Matt)";
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.metroLabel1);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Resizable = false;
            this.Text = "Minecraft Voter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.styleManager)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.votePage.ResumeLayout(false);
            this.votePage.PerformLayout();
            this.settingsPage.ResumeLayout(false);
            this.settingsPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager styleManager;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabPage settingsPage;
        private MetroFramework.Controls.MetroTabPage votePage;
        private MetroFramework.Controls.MetroTextBox nicknameText;
        private MetroFramework.Controls.MetroTextBox apiKeyText;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton saveButton;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton stopButton;
        private MetroFramework.Controls.MetroButton startButton;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel votesText;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel votesForLabel;
        private MetroFramework.Controls.MetroButton removeServerButton;
        private MetroFramework.Controls.MetroButton addServerButton;
        private System.Windows.Forms.ListBox serversList;
        private System.Windows.Forms.ListBox votesList;
        private MetroFramework.Controls.MetroLabel currentStateText;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

