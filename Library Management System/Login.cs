using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library_Management_System
{
    public partial class Login : Form
    {
        SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pramod\Documents\book_details.mdf;Integrated Security=True;Connect Timeout=30");
        public Login()
        {
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

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_user.Text == "admin" && txt_pass.Text == "admin123")
            {
                Admin_Dashboard admin = new Admin_Dashboard(this);
                admin.Show();
                this.Hide();
            }
            else
            {
                sql.Open();
                string username = txt_user.Text.Trim();
                try
                {
                    string query = "Select Student_Id,Password from [dbo].[student_details] where Student_Id = " + Convert.ToInt64(username);
                    SqlCommand cmd = new SqlCommand(query, sql);
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    try
                    {
                        if ((reader[0].ToString().Trim() == txt_user.Text) && (reader[1].ToString().Trim() == txt_pass.Text))
                        {
                            User_Dashboard user = new User_Dashboard(this, username);
                            user.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Password");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Invalid Username");
                    }
                }
                catch
                {
                    MessageBox.Show("Invalid Username or password");
                }
            }
            sql.Close();
        }

        private void txt_pass_Enter(object sender, EventArgs e)
        {
            txt_pass.isPassword = true;
        }

        private void lbl_resetpass_Click(object sender, EventArgs e)
        {
            Reset_password reset = new Reset_password(this);
            reset.Show();
            this.Hide();
        }

        private void Login_Activated(object sender, EventArgs e)
        {
            txt_pass.Text = "";
        }
    }
}
