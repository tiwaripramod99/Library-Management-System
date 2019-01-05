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
    public partial class Issued_books : Form
    {
        User_Dashboard back;
        string user;
        public Issued_books(User_Dashboard reference,string user_info)
        {
            user = user_info;
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
            this.Close();
            back.Show();
        }

        private void Issued_books_Load(object sender, EventArgs e)
        {
            issued_book_list Book_List = new issued_book_list(user);
            Book_List.MdiParent = this;
            Book_List.Location = new Point(0, 0);
            Book_List.Show();
        }
    }
}
