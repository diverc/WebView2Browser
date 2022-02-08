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
            this.Resize += new System.EventHandler(this.Form_Resize);
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            webView.Size = this.ClientSize - new System.Drawing.Size(webView.Location);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void webView_Click(object sender, EventArgs e)
        {

        }
    }
}
