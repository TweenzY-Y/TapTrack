using System;
using System.Windows.Forms;

namespace TapTrack
{
    public partial class TapTrack : Form
    {
        public static TapTrack Instance { get; private set; }
        public TapTrack()
        {
            InitializeComponent();
            GlobalInputHandler._hookID = GlobalInputHandler.SetHook();
            Instance = this;
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            SpotifyAPI.MoveToAuthorizePage();
            Program.SetViewTo(authView);
        }
        private async void submitUrlBtn_Click(object sender, EventArgs e)
        {    
            SpotifyAPI.authCode = Utils.ExtractAuthCodeFrom(urlTb.Text);
            SpotifyAPI.accessToken = await SpotifyAPI.GetAccessTokenAsync(SpotifyAPI.authCode);
            Program.SetViewTo(loggedUserView);
        }

        private void submitAppSettingsBtn_Click(object sender, EventArgs e)
        {
            if (clientIdTb.Text.Length != 32 || clientSecretTb.Text.Length != 32)
            {
                MessageBox.Show("Client ID and Client secret must be 32 characters long. Try again.");
                return;
            }
            SpotifyAPI.clientId = clientIdTb.Text;
            SpotifyAPI.clientSecret = clientSecretTb.Text;
            Program.SetViewTo(loginView);
        }

        private void TapTrack_FormClosing(object sender, FormClosingEventArgs e)
        {
            GlobalInputHandler.UnhookWindowsHookEx(GlobalInputHandler._hookID);
            Program.SaveSettings();
        }

        private void appSettingsBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.SetViewTo(appSettingsView);
        }

        private void TapTrack_Load(object sender, EventArgs e)
        {
            /* TESTING PURPOSE              
            Program.ResetSettings();
            */
            if (Properties.Settings.Default.state != "")
            {
                Program.state = (Program.State)Enum.Parse(typeof(Program.State), Properties.Settings.Default.state);
            }
            Program.SetVisibility();
            if (Properties.Settings.Default.accessToken != "")
            {
                SpotifyAPI.accessToken = Properties.Settings.Default.accessToken;
                Program.SetViewTo(loggedUserView);
                return;
            }
            else if (Properties.Settings.Default.clientId != "" && Properties.Settings.Default.clientSecret != "")
            {
                SpotifyAPI.clientId = Properties.Settings.Default.clientId;
                SpotifyAPI.clientSecret = Properties.Settings.Default.clientSecret;
                Program.SetViewTo(loginView);
                return;
            }
            Program.SetViewTo(appSettingsView);
        }

        private void trayBtn_Click(object sender, EventArgs e)
        {
            Program.state = Program.State.Tray;
            Program.SetVisibility();
        }

        // Tray Menu Items

        // EXIT
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // OPEN
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.state = Program.State.Normal;
            Program.SetVisibility();
        }
    }
}
