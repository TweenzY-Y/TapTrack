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
            GlobalInputHandler._hookID = GlobalInputHandler.SetHook();
            //resetAppConfig();
            setAppViewTo(appSettingsView);
            if (Properties.Settings.Default.accessToken != "")
            {
                SpotifyAPI.accessToken = Properties.Settings.Default.accessToken;
            }
            else if (Properties.Settings.Default.clientId != "" && Properties.Settings.Default.clientSecret != "")
            { 
                SpotifyAPI.clientId = Properties.Settings.Default.clientId;
                SpotifyAPI.clientSecret = Properties.Settings.Default.clientSecret;
                clientIdTb.Text = SpotifyAPI.clientId;
                clientSecretTb.Text = SpotifyAPI.clientSecret;
                setAppViewTo(loginView);
            }
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            SpotifyAPI.MoveToAuthorizePage();
            setAppViewTo(authView);
        }
        private async void submitUrlBtn_Click(object sender, EventArgs e)
        {
            var uri = new Uri(urlTb.Text);
            var query = uri.Query;
            var queryDictionary = HttpUtility.ParseQueryString(query);
            var code = queryDictionary["code"];
            var returnedState = queryDictionary["state"];
            if (returnedState != SpotifyAPI.state)
            {
                throw new InvalidOperationException("State mismatch");
            }    
            SpotifyAPI.authCode = code;
            SpotifyAPI.accessToken = await SpotifyAPI.GetAccessTokenAsync(SpotifyAPI.authCode);
            Properties.Settings.Default.accessToken = SpotifyAPI.accessToken;
            Properties.Settings.Default.Save();
            setAppViewTo(loggedUserView);
        }

        private void submitAppSettingsBtn_Click(object sender, EventArgs e)
        {
            SpotifyAPI.clientId = clientIdTb.Text;
            Properties.Settings.Default.clientId = SpotifyAPI.clientId;

            SpotifyAPI.clientSecret = clientSecretTb.Text;
            Properties.Settings.Default.clientSecret = SpotifyAPI.clientSecret;
            Properties.Settings.Default.Save();
            setAppViewTo(loginView);
        }

        private void TapTrack_FormClosing(object sender, FormClosingEventArgs e)
        {
            GlobalInputHandler.UnhookWindowsHookEx(GlobalInputHandler._hookID);
        }
        private void setAppViewTo(System.Windows.Forms.Panel view)
        {
            foreach (System.Windows.Forms.Panel panel in this.Controls.OfType<System.Windows.Forms.Panel>())
            {
                panel.Visible = false;
                if (panel == view)
                {
                    panel.Visible = true;
                }
            }
        }

        private void resetAppConfig()
        {
            Properties.Settings.Default.accessToken = "";
            Properties.Settings.Default.clientSecret = "";
            Properties.Settings.Default.clientId = "";
            Properties.Settings.Default.Save();
        }
        private void appSettingsBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            setAppViewTo(appSettingsView);
        }
    }
}
