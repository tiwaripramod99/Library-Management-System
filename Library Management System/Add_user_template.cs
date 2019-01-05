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
    public partial class Add_user_template : Form
    {
        Admin_Dashboard back;
        public Add_user_template(Admin_Dashboard reference)
        {
            back = reference;
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            back.Show();
            this.Close();
        }

        private void Add_user_Load(object sender, EventArgs e)
        {
            New_registration new_reg = new New_registration();
            btn_new_reg.Normalcolor = Color.Gray;
            new_reg.MdiParent = this;
            new_reg.Show();
            new_reg.Location = new Point(0, 0);
            panel_edit.Hide();
            panel_del.Hide();
        }

        private void btn_new_reg_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            btn_edit_reg.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            btn_del_reg.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            New_registration new_reg = new New_registration();
            new_reg.MdiParent = this;
            new_reg.Show();
            new_reg.Location = new Point(0, 0);
            btn_new_reg.Normalcolor = Color.Gray;
            panel_new.Show();
            panel_edit.Hide();
            panel_del.Hide();
        }

        private void btn_edit_reg_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            btn_new_reg.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            btn_del_reg.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            Edit_registration edit_user = new Edit_registration();
            edit_user.MdiParent = this;
            edit_user.Show();
            edit_user.Location = new Point(0, 0);
            btn_edit_reg.Normalcolor = Color.Gray;
            panel_new.Hide();
            panel_edit.Show();
            panel_del.Hide();
        }

        private void btn_del_reg_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            btn_new_reg.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            btn_edit_reg.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            Delete_regestration del_user = new Delete_regestration();
            del_user.MdiParent = this;
            del_user.Show();
            del_user.Location = new Point(0, 0);
            btn_del_reg.Normalcolor = Color.Gray;
            panel_new.Hide();
            panel_edit.Hide();
            panel_del.Show();
        }

        private void btn_minimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
