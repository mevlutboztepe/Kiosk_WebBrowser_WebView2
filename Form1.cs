using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

namespace ITSWebBrowser
{
    public partial class WebBrowserForm : Form
    {
        public WebBrowserForm()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.SizeChanged += new System.EventHandler(this.WebBrowserForm_SizeChanged);
            this.TopMost = true;
        }

        private int clickCount = 0;
        private Timer doubleClickTimer;
        private void WebBrowserForm_Load(object sender, EventArgs e)
        {
            // Windows Explorer'ı sonlandır
            Process.Start("taskkill.exe", "/F /IM explorer.exe");

            initbrowser();
            //Browser tam ekran
            webView21.Dock= DockStyle.Fill;
        }
        #region Browser 
        public async Task initizated()
        {
            //Browser öğesinini oluşturulduğunu kontrol eder
            await webView21.EnsureCoreWebView2Async();
        }

        public async  void initbrowser()
        {
            await initizated();
            webView21.CoreWebView2.Settings.AreBrowserAcceleratorKeysEnabled = false;
            //Browser Sağ tıklama kapatma
            webView21.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;
            //Browser Url yönlendirme
            webView21.CoreWebView2.Navigate("https://www.google.com/");
            //Browser Zoom özelliği
            double webZoom =double.Parse(ConfigurationManager.AppSettings["WebZoom"]);
            webView21.ZoomFactor = webZoom;
        }
        #endregion

        #region Şifre Ekranının Gelmesi İçin Buton 
        private void btn_pass_Click(object sender, EventArgs e)
        {
            //Butonuna max 5 sn aralığında tıklandığında çalışıyor
            clickCount++;
            if (clickCount == 2)
            {
                passwordForm();
                clickCount = 0;
            }
            else if (clickCount == 1)
            {
                doubleClickTimer = new Timer();
                doubleClickTimer.Interval = 500; // 0.5 saniye bekle
                doubleClickTimer.Tick += new EventHandler(doubleClickTimer_Tick);
                doubleClickTimer.Start();
            }
        }
        private void doubleClickTimer_Tick(object sender, EventArgs e)
        {           
            clickCount = 0;
            doubleClickTimer.Stop();
        }
        #endregion

        #region Butonun Alt Sağ Köşesine Konumlandırma

        private void WebBrowserForm_SizeChanged(object sender, EventArgs e)
        {
            btn_pass.Location = new Point(this.ClientSize.Width - btn_pass.Size.Width - 10, 10);
        }
        #endregion

        #region Password Formun arka plan ayarları ve açılması
        public void passwordForm()
        {
            Form formBackground = new Form();
            try
            {
                using (PasswordForm form2 = new PasswordForm())
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .50d;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    formBackground.TopMost = true;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();

                    form2.Owner = formBackground;
                    form2.ShowDialog();

                    formBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { formBackground.Dispose(); }
        }
        #endregion
    }
}
