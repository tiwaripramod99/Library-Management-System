using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class Contact_us_user : Form
    {
        User_Dashboard back;
        public Contact_us_user(User_Dashboard reference)
        {
            back = reference;
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            back.Show();
        }

        private void btn_fb_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("chrome.exe", "https://www.facebook.com/tiwari.pramod.99");
        }

        private void btn_insta_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("chrome.exe", "https://www.instagram.com/pramod9164/");
        }
    }
}
