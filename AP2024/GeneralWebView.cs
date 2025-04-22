using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP2024
{
    public partial class GeneralWebView : Form
    {
        string _url = "https://www.youtube.com";
        public GeneralWebView(string url)
        {
            InitializeComponent();
            _url = url;
            LoadWebPage();
        }

        private async void LoadWebPage()
        {
            await webView21.EnsureCoreWebView2Async();
            webView21.Source = new Uri(_url);
        }
    }
}
