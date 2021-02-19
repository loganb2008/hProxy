using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.IO;
using System.Net;

namespace hProxy
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string pathm = Path.Combine(path, "hProxy");
            if (Directory.Exists(pathm))
            {
                
            }
            else
            {
                Directory.CreateDirectory(pathm);
            }
        }
            private void us_Click(object sender, EventArgs e)
        {
            RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
            registry.SetValue("ProxyEnable", 1);
            registry.SetValue("ProxyServer", "sudao.site:8082");
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string pathm = Path.Combine(path, "hProxy");
            if (Directory.Exists(pathm))
            {

            }
            else
            {
                Directory.CreateDirectory(pathm);
            }
            var connected = new connected();
            connected.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void wlkyus_Click(object sender, EventArgs e)
        {
            RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
            registry.SetValue("ProxyEnable", 1);
            registry.SetValue("ProxyServer", "sudao.site:2082");
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string pathm = Path.Combine(path, "hProxy");
            if (Directory.Exists(pathm))
            {

            }
            else
            {
                Directory.CreateDirectory(pathm);
            }
            var connected = new connected();
            connected.Show();
            this.Hide();
        }
        static void OnProcessExit(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void plist_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string url = plist.Url.AbsoluteUri;
            string proto = url.Substring(0, 8);
            string newurl = url.Replace("proxy://", "").Replace("  ", " ");
            string ntwo = newurl.Replace("/", "").Replace("  ", " ");
            if (proto == "proxy://")
            {
                RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
                registry.SetValue("ProxyEnable", 1);
                registry.SetValue("ProxyServer", ntwo);
                string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string pathm = Path.Combine(path, "hProxy");
                if (Directory.Exists(pathm))
                {

                }
                else
                {
                    Directory.CreateDirectory(pathm);
                }
                var connected = new connected();
                connected.Show();
                this.Hide();
            }
        }
    }
}
