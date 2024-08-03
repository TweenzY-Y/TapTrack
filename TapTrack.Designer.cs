
namespace TapTrack
{
    partial class TapTrack
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
            this.loginBtn = new System.Windows.Forms.Button();
            this.loginView = new System.Windows.Forms.Panel();
            this.appSettingsBtn1 = new System.Windows.Forms.LinkLabel();
            this.authView = new System.Windows.Forms.Panel();
            this.appSettingsBtn = new System.Windows.Forms.LinkLabel();
            this.submitUrlBtn = new System.Windows.Forms.Button();
            this.redirectUriLabel = new System.Windows.Forms.Label();
            this.urlTb = new System.Windows.Forms.TextBox();
            this.appSettingsView = new System.Windows.Forms.Panel();
            this.submitAppSettingsBtn = new System.Windows.Forms.Button();
            this.clientSecretLabel = new System.Windows.Forms.Label();
            this.clientIdLabel = new System.Windows.Forms.Label();
            this.clientSecretTb = new System.Windows.Forms.TextBox();
            this.clientIdTb = new System.Windows.Forms.TextBox();
            this.loggedUserView = new System.Windows.Forms.Panel();
            this.hideAppCheck = new System.Windows.Forms.CheckBox();
            this.runOnStartupCheck = new System.Windows.Forms.CheckBox();
            this.loginView.SuspendLayout();
            this.authView.SuspendLayout();
            this.appSettingsView.SuspendLayout();
            this.loggedUserView.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Location = new System.Drawing.Point(63, 59);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(127, 25);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "Login through Spotify";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // loginView
            // 
            this.loginView.Controls.Add(this.appSettingsBtn1);
            this.loginView.Controls.Add(this.loginBtn);
            this.loginView.Location = new System.Drawing.Point(0, 0);
            this.loginView.Name = "loginView";
            this.loginView.Size = new System.Drawing.Size(251, 152);
            this.loginView.TabIndex = 1;
            // 
            // appSettingsBtn1
            // 
            this.appSettingsBtn1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.appSettingsBtn1.AutoSize = true;
            this.appSettingsBtn1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.appSettingsBtn1.Location = new System.Drawing.Point(163, 3);
            this.appSettingsBtn1.Name = "appSettingsBtn1";
            this.appSettingsBtn1.Size = new System.Drawing.Size(85, 13);
            this.appSettingsBtn1.TabIndex = 6;
            this.appSettingsBtn1.TabStop = true;
            this.appSettingsBtn1.Text = "Edit app settings";
            this.appSettingsBtn1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.appSettingsBtn_LinkClicked);
            // 
            // authView
            // 
            this.authView.Controls.Add(this.appSettingsBtn);
            this.authView.Controls.Add(this.submitUrlBtn);
            this.authView.Controls.Add(this.redirectUriLabel);
            this.authView.Controls.Add(this.urlTb);
            this.authView.Location = new System.Drawing.Point(0, 0);
            this.authView.Name = "authView";
            this.authView.Size = new System.Drawing.Size(251, 155);
            this.authView.TabIndex = 2;
            // 
            // appSettingsBtn
            // 
            this.appSettingsBtn.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.appSettingsBtn.AutoSize = true;
            this.appSettingsBtn.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.appSettingsBtn.Location = new System.Drawing.Point(163, 3);
            this.appSettingsBtn.Name = "appSettingsBtn";
            this.appSettingsBtn.Size = new System.Drawing.Size(85, 13);
            this.appSettingsBtn.TabIndex = 5;
            this.appSettingsBtn.TabStop = true;
            this.appSettingsBtn.Text = "Edit app settings";
            this.appSettingsBtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.appSettingsBtn_LinkClicked);
            // 
            // submitUrlBtn
            // 
            this.submitUrlBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.submitUrlBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.submitUrlBtn.FlatAppearance.BorderSize = 0;
            this.submitUrlBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitUrlBtn.Location = new System.Drawing.Point(63, 117);
            this.submitUrlBtn.Name = "submitUrlBtn";
            this.submitUrlBtn.Size = new System.Drawing.Size(127, 21);
            this.submitUrlBtn.TabIndex = 4;
            this.submitUrlBtn.Text = "Submit";
            this.submitUrlBtn.UseVisualStyleBackColor = false;
            this.submitUrlBtn.Click += new System.EventHandler(this.submitUrlBtn_Click);
            // 
            // redirectUriLabel
            // 
            this.redirectUriLabel.AutoSize = true;
            this.redirectUriLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.redirectUriLabel.Location = new System.Drawing.Point(12, 46);
            this.redirectUriLabel.Name = "redirectUriLabel";
            this.redirectUriLabel.Size = new System.Drawing.Size(69, 13);
            this.redirectUriLabel.TabIndex = 3;
            this.redirectUriLabel.Text = "Redirect URI";
            // 
            // urlTb
            // 
            this.urlTb.Location = new System.Drawing.Point(12, 62);
            this.urlTb.Name = "urlTb";
            this.urlTb.Size = new System.Drawing.Size(227, 20);
            this.urlTb.TabIndex = 0;
            // 
            // appSettingsView
            // 
            this.appSettingsView.Controls.Add(this.submitAppSettingsBtn);
            this.appSettingsView.Controls.Add(this.clientSecretLabel);
            this.appSettingsView.Controls.Add(this.clientIdLabel);
            this.appSettingsView.Controls.Add(this.clientSecretTb);
            this.appSettingsView.Controls.Add(this.clientIdTb);
            this.appSettingsView.Location = new System.Drawing.Point(0, 0);
            this.appSettingsView.Name = "appSettingsView";
            this.appSettingsView.Size = new System.Drawing.Size(251, 155);
            this.appSettingsView.TabIndex = 3;
            // 
            // submitAppSettingsBtn
            // 
            this.submitAppSettingsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.submitAppSettingsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.submitAppSettingsBtn.FlatAppearance.BorderSize = 0;
            this.submitAppSettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitAppSettingsBtn.Location = new System.Drawing.Point(63, 113);
            this.submitAppSettingsBtn.Name = "submitAppSettingsBtn";
            this.submitAppSettingsBtn.Size = new System.Drawing.Size(127, 21);
            this.submitAppSettingsBtn.TabIndex = 4;
            this.submitAppSettingsBtn.Text = "Submit";
            this.submitAppSettingsBtn.UseVisualStyleBackColor = false;
            this.submitAppSettingsBtn.Click += new System.EventHandler(this.submitAppSettingsBtn_Click);
            // 
            // clientSecretLabel
            // 
            this.clientSecretLabel.AutoSize = true;
            this.clientSecretLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.clientSecretLabel.Location = new System.Drawing.Point(12, 56);
            this.clientSecretLabel.Name = "clientSecretLabel";
            this.clientSecretLabel.Size = new System.Drawing.Size(65, 13);
            this.clientSecretLabel.TabIndex = 3;
            this.clientSecretLabel.Text = "Client secret";
            // 
            // clientIdLabel
            // 
            this.clientIdLabel.AutoSize = true;
            this.clientIdLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.clientIdLabel.Location = new System.Drawing.Point(12, 12);
            this.clientIdLabel.Name = "clientIdLabel";
            this.clientIdLabel.Size = new System.Drawing.Size(47, 13);
            this.clientIdLabel.TabIndex = 2;
            this.clientIdLabel.Text = "Client ID";
            // 
            // clientSecretTb
            // 
            this.clientSecretTb.Location = new System.Drawing.Point(12, 72);
            this.clientSecretTb.Name = "clientSecretTb";
            this.clientSecretTb.Size = new System.Drawing.Size(227, 20);
            this.clientSecretTb.TabIndex = 1;
            // 
            // clientIdTb
            // 
            this.clientIdTb.Location = new System.Drawing.Point(12, 28);
            this.clientIdTb.Name = "clientIdTb";
            this.clientIdTb.Size = new System.Drawing.Size(227, 20);
            this.clientIdTb.TabIndex = 0;
            // 
            // loggedUserView
            // 
            this.loggedUserView.Controls.Add(this.hideAppCheck);
            this.loggedUserView.Controls.Add(this.runOnStartupCheck);
            this.loggedUserView.Location = new System.Drawing.Point(0, 0);
            this.loggedUserView.Name = "loggedUserView";
            this.loggedUserView.Size = new System.Drawing.Size(251, 155);
            this.loggedUserView.TabIndex = 6;
            // 
            // hideAppCheck
            // 
            this.hideAppCheck.AutoSize = true;
            this.hideAppCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.hideAppCheck.Location = new System.Drawing.Point(53, 77);
            this.hideAppCheck.Name = "hideAppCheck";
            this.hideAppCheck.Size = new System.Drawing.Size(130, 17);
            this.hideAppCheck.TabIndex = 1;
            this.hideAppCheck.Text = "Hide app (In progress)";
            this.hideAppCheck.UseVisualStyleBackColor = true;
            // 
            // runOnStartupCheck
            // 
            this.runOnStartupCheck.AutoSize = true;
            this.runOnStartupCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.runOnStartupCheck.Location = new System.Drawing.Point(53, 54);
            this.runOnStartupCheck.Name = "runOnStartupCheck";
            this.runOnStartupCheck.Size = new System.Drawing.Size(157, 17);
            this.runOnStartupCheck.TabIndex = 0;
            this.runOnStartupCheck.Text = "Run on startup (In progress)";
            this.runOnStartupCheck.UseVisualStyleBackColor = true;
            // 
            // TapTrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(251, 150);
            this.Controls.Add(this.loggedUserView);
            this.Controls.Add(this.authView);
            this.Controls.Add(this.loginView);
            this.Controls.Add(this.appSettingsView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TapTrack";
            this.ShowIcon = false;
            this.Text = "TapTrack";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TapTrack_FormClosing);
            this.Load += new System.EventHandler(this.TapTrack_Load);
            this.loginView.ResumeLayout(false);
            this.loginView.PerformLayout();
            this.authView.ResumeLayout(false);
            this.authView.PerformLayout();
            this.appSettingsView.ResumeLayout(false);
            this.appSettingsView.PerformLayout();
            this.loggedUserView.ResumeLayout(false);
            this.loggedUserView.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Panel loginView;
        private System.Windows.Forms.Panel authView;
        private System.Windows.Forms.TextBox urlTb;
        private System.Windows.Forms.Panel appSettingsView;
        private System.Windows.Forms.Label clientSecretLabel;
        private System.Windows.Forms.Label clientIdLabel;
        private System.Windows.Forms.TextBox clientSecretTb;
        private System.Windows.Forms.TextBox clientIdTb;
        private System.Windows.Forms.Label redirectUriLabel;
        private System.Windows.Forms.Button submitAppSettingsBtn;
        private System.Windows.Forms.Button submitUrlBtn;
        private System.Windows.Forms.LinkLabel appSettingsBtn;
        private System.Windows.Forms.LinkLabel appSettingsBtn1;
        private System.Windows.Forms.Panel loggedUserView;
        private System.Windows.Forms.CheckBox runOnStartupCheck;
        private System.Windows.Forms.CheckBox hideAppCheck;
    }
}

