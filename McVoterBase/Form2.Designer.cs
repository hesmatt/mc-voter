namespace McVoterBase
{
    partial class Form2
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
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.czUrlAddress = new MetroFramework.Controls.MetroTextBox();
            this.namebox1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // czUrlAddress
            // 
            // 
            // 
            // 
            this.czUrlAddress.CustomButton.Image = null;
            this.czUrlAddress.CustomButton.Location = new System.Drawing.Point(235, 1);
            this.czUrlAddress.CustomButton.Name = "";
            this.czUrlAddress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.czUrlAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.czUrlAddress.CustomButton.TabIndex = 1;
            this.czUrlAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.czUrlAddress.CustomButton.UseSelectable = true;
            this.czUrlAddress.CustomButton.Visible = false;
            this.czUrlAddress.Lines = new string[0];
            this.czUrlAddress.Location = new System.Drawing.Point(13, 59);
            this.czUrlAddress.MaxLength = 32767;
            this.czUrlAddress.Name = "czUrlAddress";
            this.czUrlAddress.PasswordChar = '\0';
            this.czUrlAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.czUrlAddress.SelectedText = "";
            this.czUrlAddress.SelectionLength = 0;
            this.czUrlAddress.SelectionStart = 0;
            this.czUrlAddress.ShortcutsEnabled = true;
            this.czUrlAddress.Size = new System.Drawing.Size(257, 23);
            this.czUrlAddress.TabIndex = 0;
            this.czUrlAddress.UseSelectable = true;
            this.czUrlAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.czUrlAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // namebox1
            // 
            this.namebox1.AutoSize = true;
            this.namebox1.Location = new System.Drawing.Point(101, 28);
            this.namebox1.Name = "namebox1";
            this.namebox1.Size = new System.Drawing.Size(69, 19);
            this.namebox1.TabIndex = 1;
            this.namebox1.Text = "Url adresa";
            this.namebox1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(195, 88);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Přidat";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 127);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.namebox1);
            this.Controls.Add(this.czUrlAddress);
            this.Name = "Form2";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel namebox1;
        private MetroFramework.Controls.MetroTextBox czUrlAddress;
    }
}