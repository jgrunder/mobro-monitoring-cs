using CefSharp;
using CefSharp.WinForms;
using System.Configuration;
using System.Windows.Forms;

namespace mobro_monitoring_cs
{
    public partial class MonitoringCS : Form
    {
        public ChromiumWebBrowser browser;
        // Get all parameters from application configuration file
        private readonly string url = ConfigurationManager.AppSettings.Get("url");
        private Screen screenToGo;
        public void InitBrowser()
        {
            Cef.Initialize(new CefSettings());
            browser = new ChromiumWebBrowser(url);
            Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
        }
        public MonitoringCS()
        {
            // Check all connected screens
            foreach (Screen screen in Screen.AllScreens)
            {
                // A monitoring screen has formally its width <= 1024
                if (screen.Bounds.Width <= 1024)
                {
                    screenToGo = screen;
                }
            }

            // If no monitoring screen found, exit application
            if (screenToGo is null)
            {
                MessageBox.Show("No screen found !");
                System.Environment.Exit(1);
            }

            InitializeComponent();
            // Set application size
            Width = screenToGo.Bounds.Width;
            Height = screenToGo.Bounds.Height;
            // Set start position
            StartPosition = FormStartPosition.Manual;
            Location = screenToGo.WorkingArea.Location;
            InitBrowser();
        }
    }
}
