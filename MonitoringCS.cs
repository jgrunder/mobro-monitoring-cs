using CefSharp;
using CefSharp.WinForms;
using System.Windows.Forms;

namespace mobro_monitoring_cs
{
    public partial class MonitoringCS : Form
    {
        public ChromiumWebBrowser browser;
        public void InitBrowser()
        {
            Cef.Initialize(new CefSettings());
            browser = new ChromiumWebBrowser("www.google.com");
            Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
        }
        public MonitoringCS()
        {
            InitializeComponent();
            InitBrowser();
        }
    }
}
