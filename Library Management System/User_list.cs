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
    public partial class User_list : Form
    {
        Admin_Dashboard back;
        public User_list(Admin_Dashboard reference)
        {
            back = reference;
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            back.Show();
            this.Close();
        }

        private void User_list_Load(object sender, EventArgs e)
        {
            User_list_content list = new User_list_content();
            list.MdiParent = this;
            list.Location = new Point(0, 0);
            list.Show();
        }
    }
}
