using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

namespace WebView2Browser
{
    public partial class Form1 : Form
    {
        public Form1(string uri, bool viewUrl)
        {
            InitializeComponent(uri,viewUrl);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            webView.NavigationStarting  += WebView_NavigationStarting;
           // webView.NavigationCompleted += WebView_NavigationComplete;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            webView.Size = this.ClientSize - new System.Drawing.Size(webView.Location);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }

        private void webView_Click(object sender, EventArgs e)
        {

        }

        private void WebView_NavigationStarting(object sender, CoreWebView2NavigationStartingEventArgs e)
        {
            if(webView.CoreWebView2 != null)
            {
                webView.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;
                webView.CoreWebView2.Settings.AreDevToolsEnabled = false;
                //MessageBox.Show("CoreWebView2 Suceess");
            }else{
                MessageBox.Show("Starting CoreWebView2 is null");
            }

        }

/*
        private void WebView_NavigationComplete(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            if(webView.CoreWebView2 != null)
            {
                webView.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;
                webView.CoreWebView2.Settings.AreDevToolsEnabled = false;
                //MessageBox.Show("CoreWebView2 Suceess");
            }else{
                MessageBox.Show("Comp CoreWebView2 is null");
            }

        }
*/
    }
}
