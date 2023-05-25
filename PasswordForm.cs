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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ITSWebBrowser
{
    public partial class PasswordForm : Form
    {
        public PasswordForm()
        {
            InitializeComponent();
        }

        private void btn_numberzero_Click(object sender, EventArgs e)
        {
            txt_password.Text += "0";
            txt_password.SelectionStart = txt_password.Text.Length;
            txt_password.ScrollToCaret();
        }

        private void btn_numbernine_Click(object sender, EventArgs e)
        {
            txt_password.Text += "9";
            txt_password.SelectionStart = txt_password.Text.Length;
            txt_password.ScrollToCaret();
        }

        private void btn_numbersix_Click(object sender, EventArgs e)
        {
            txt_password.Text += "6";
            txt_password.SelectionStart = txt_password.Text.Length;
            txt_password.ScrollToCaret();
        }

        private void btn_numberthree_Click(object sender, EventArgs e)
        {
            txt_password.Text += "3";
            txt_password.SelectionStart = txt_password.Text.Length;
            txt_password.ScrollToCaret();
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            string password = ConfigurationManager.AppSettings["Password"];
            if (password == txt_password.Text)
            {
                // Windows Explorer'ı başlat
                Process.Start(@"C:\\Windows\\explorer.exe");
                // Uygulamayı Kapat 
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Parola Doğru Değil!");
            }
        }

        private void btn_numbereight_Click(object sender, EventArgs e)
        {
            txt_password.Text += "8";
            txt_password.SelectionStart = txt_password.Text.Length;
            txt_password.ScrollToCaret();
        }

        private void btn_numberfive_Click(object sender, EventArgs e)
        {
            txt_password.Text += "5";
            txt_password.SelectionStart = txt_password.Text.Length;
            txt_password.ScrollToCaret();
        }

        private void btn_numbertwo_Click(object sender, EventArgs e)
        {
            txt_password.Text += "2";
            txt_password.SelectionStart = txt_password.Text.Length;
            txt_password.ScrollToCaret();
        }

        private void btn_backspace_Click(object sender, EventArgs e)
        {
            if (txt_password.Text.Length > 0)
            {
                txt_password.Text = txt_password.Text.Remove(txt_password.Text.Length - 1);
            }
        }

        private void btn_numberseven_Click(object sender, EventArgs e)
        {
            txt_password.Text += "7";
            txt_password.SelectionStart = txt_password.Text.Length;
            txt_password.ScrollToCaret();
        }

        private void btn_numberfour_Click(object sender, EventArgs e)
        {
            txt_password.Text += "4";
            txt_password.SelectionStart = txt_password.Text.Length;
            txt_password.ScrollToCaret();
        }

        private void btn_numberone_Click(object sender, EventArgs e)
        {
            txt_password.Text += "1";
            txt_password.SelectionStart = txt_password.Text.Length;
            txt_password.ScrollToCaret();
        }

        private void PasswordForm_Load(object sender, EventArgs e)
        {

        }
    }
}
