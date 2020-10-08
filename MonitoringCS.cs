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
        private readonly int screenId = int.Parse(ConfigurationManager.AppSettings.Get("screen_id"));
        private readonly int screenWidth = int.Parse(ConfigurationManager.AppSettings.Get("screen_width"));
        private readonly int screenHeight = int.Parse(ConfigurationManager.AppSettings.Get("screen_height"));
        public void InitBrowser()
        {
            Cef.Initialize(new CefSettings());
            browser = new ChromiumWebBrowser(url);
            Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
        }
        public MonitoringCS()
        {
            InitializeComponent();
            // Set application size
            Width = screenWidth;
            Height = screenHeight;
            // Set start position
            StartPosition = FormStartPosition.Manual;
            Location = Screen.AllScreens[screenId].WorkingArea.Location;
            InitBrowser();
        }
    }
}
