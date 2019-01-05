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
    public partial class Book_shelf : Form
    {
        User_Dashboard back;
        string user;
        public Book_shelf(User_Dashboard reference,string user_info)
        {
            user = user_info;
            back = reference;
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Book_shelf_Load(object sender, EventArgs e)
        {
            Book_shelf_content list = new Book_shelf_content(user);
            list.MdiParent = this;
            list.Location = new Point(0,0);
            list.Show();
        }

        private void btn_minimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            back.Show();
        }
    }
}
