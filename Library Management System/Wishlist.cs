﻿using System;
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
    public partial class Wishlist : Form
    {
        User_Dashboard back;
        string user;
        public Wishlist(User_Dashboard reference,string user_name)
        {
            user = user_name;
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

        private void Wishlist_Load(object sender, EventArgs e)
        {
            wishlist_list wishlist = new wishlist_list(user);
            wishlist.MdiParent = this;
            wishlist.Location = new Point(0, 0);
            wishlist.Show();
        }
    }
}
