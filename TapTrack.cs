using System;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace TapTrack
{
    public partial class TapTrack : Form
    {
        public TapTrack()
        {
            InitializeComponent();
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            SpotifyAPI.MoveToAuthorizePage();
            Program.SetViewTo(this, authView);
        }
        private async void submitUrlBtn_Click(object sender, EventArgs e)
        {    
            SpotifyAPI.authCode = Utils.ExtractAuthCodeFrom(urlTb.Text);
            SpotifyAPI.accessToken = await SpotifyAPI.GetAccessTokenAsync(SpotifyAPI.authCode);
            Program.SaveSettings();
            Program.SetViewTo(this, loggedUserView);
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
            Program.SetViewTo(this, loginView);
        }

        private void TapTrack_FormClosing(object sender, FormClosingEventArgs e)
        {
            GlobalInputHandler.UnhookWindowsHookEx(GlobalInputHandler._hookID);
        }

        private void appSettingsBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.SetViewTo(this,appSettingsView);
        }

        private void TapTrack_Load(object sender, EventArgs e)
        {
            /* TESTING PURPOSE              
            Program.ResetSettings();
            */
            GlobalInputHandler._hookID = GlobalInputHandler.SetHook();
            if (Properties.Settings.Default.accessToken != "")
            {
                SpotifyAPI.accessToken = Properties.Settings.Default.accessToken;
                Program.SetViewTo(this, loggedUserView);
                return;
            }
            else if (Properties.Settings.Default.clientId != "" && Properties.Settings.Default.clientSecret != "")
            {
                SpotifyAPI.clientId = Properties.Settings.Default.clientId;
                SpotifyAPI.clientSecret = Properties.Settings.Default.clientSecret;
                Program.SetViewTo(this, loginView);
                return;
            }
            Program.SetViewTo(this, appSettingsView);
        }
    }
}
