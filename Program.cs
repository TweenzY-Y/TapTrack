using System;
using System.Windows.Forms;
using System.Linq;

namespace TapTrack
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TapTrack());
        }

        public static void SetViewTo(Control parent, Panel view)
        {
            foreach (Panel panel in parent.Controls.OfType<Panel>())
            {
                panel.Visible = false;
                if (panel == view)
                {
                    panel.Visible = true;
                }
            }
        }

        public static void SaveSettings()
        {
            Properties.Settings.Default.accessToken = SpotifyAPI.accessToken;
            Properties.Settings.Default.clientId = SpotifyAPI.clientId;
            Properties.Settings.Default.clientSecret = SpotifyAPI.clientSecret;
            Properties.Settings.Default.Save();
        }

        public static void ResetSettings()
        {
            Properties.Settings.Default.accessToken = "";
            Properties.Settings.Default.clientSecret = "";
            Properties.Settings.Default.clientId = "";
            Properties.Settings.Default.Save();
        }
    }
}
