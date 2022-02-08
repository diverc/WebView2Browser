using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebView2Browser
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            string url = "";
            bool ViewUrl = false;
            if (args.Length == 0)   {
                url = "https://developer.microsoft.com/ja-jp/microsoft-edge/webview2/";
            }else {
                url = args[0];
            }

            if (args.Length >= 2)   {
                ViewUrl = true;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(url,ViewUrl));
        }
    }
}
