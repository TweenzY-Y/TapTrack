using System;
using System.Windows.Forms;
using System.Linq;

namespace TapTrack
{
    static class Program
    {
        public enum State { Normal, Tray};
        public static State state = State.Normal;
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

        public static void SetViewTo(Panel view)
        {
            foreach (Panel panel in TapTrack.Instance.Controls.OfType<Panel>())
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
            Properties.Settings.Default.state = state.ToString();
            Properties.Settings.Default.Save();
        }

        public static void ResetSettings()
        {
            Properties.Settings.Default.accessToken = "";
            Properties.Settings.Default.clientSecret = "";
            Properties.Settings.Default.clientId = "";
            Properties.Settings.Default.Save();
        }

        public static void SetVisibility()
        {
            TapTrack.Instance.ShowInTaskbar = state == State.Normal ? true : false;
            TapTrack.Instance.WindowState = state == State.Normal ? FormWindowState.Normal : FormWindowState.Minimized;
            TapTrack.Instance.trayIcon.Visible = state == State.Normal ? false : true;
            if (state == State.Tray)
            {
                TapTrack.Instance.Hide();
            }
        }
    }
}
