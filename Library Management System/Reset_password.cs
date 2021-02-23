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
using System.Net.Mail;

namespace Library_Management_System
{
    public partial class Reset_password : Form
    {
        bool flag=false;
        SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pramod\Documents\book_details.mdf;Integrated Security=True;Connect Timeout=30");
        Login lg;
        int n;
        string user,user_mail;
        public Reset_password(Login login)
        {
            lg = login;
            InitializeComponent();
        }

        User_Dashboard back;
        public Reset_password(User_Dashboard reference,string user_info)
        {
            user = user_info;
            back = reference;
            InitializeComponent();
        }

        private void txt_newpass_Enter(object sender, EventArgs e)
        {
            txt_newpass.isPassword = true;
        }

        private void txt_renewpass_OnValueChanged(object sender, EventArgs e)
        {
            txt_renewpass.isPassword = true;
        }

        private void Reset_password_Load(object sender, EventArgs e)
        {
            btn_otpfor.Visible = false;
            txt_user.Text = user;

            btn_reset.Visible = false;
            lbl_newpass.Visible = false;
            txt_newpass.Visible = false;
            pb_newpass.Visible = false;

            lbl_renewpass.Visible = false;
            txt_renewpass.Visible = false;
            pb_renewpass.Visible = false;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minmise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            if (txt_newpass.Text == txt_renewpass.Text)
            {
                sql.Open();
                string query = "Update [dbo].[student_details] set Password = '" + txt_newpass.Text + "' where Student_Id = "+Convert.ToInt64(user);
                SqlCommand cmd = new SqlCommand(query, sql);
                cmd.ExecuteNonQuery();
                sql.Close();
                Login login = new Login();
                this.Close();
                login.Show();
            }
            else
            {
                err_pass.SetError(txt_renewpass, "Password didn't matched");
            }
        }

        private void btn_forward_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            n = random.Next(10000, 99999);
            if (txt_user.Text == "")
            {
                MessageBox.Show("Enter Username first");
            }
            else
            {
                try
                {
                    sql.Open();
                    string query = "Select Student_Id,Email from [dbo].[student_details] where Student_Id = " + Convert.ToInt64(txt_user.Text);
                    SqlCommand cmd = new SqlCommand(query, sql);
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    if (reader[0].ToString() != null)
                    {
                        user = txt_user.Text;
                        user_mail = reader[1].ToString().Trim();
                        send_otp(n);
                        if (flag)
                        {
                            lbl_user.Text = "Enter OTP";
                            txt_user.HintText = "Enter OTP";
                            txt_user.Enabled = true;
                            txt_user.Text = "";
                            pb_user.Visible = false;
                            btn_forward.Visible = false;
                            btn_otpfor.Visible = true;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("No such user");
                    txt_user.Text = "";
                }
                sql.Close();
            }
        }

        private void btn_otpfor_Click(object sender, EventArgs e)
        {
            if(txt_user.Text == n.ToString())
            {
                btn_otpfor.Visible = false;

                lbl_newpass.Visible = true;
                txt_newpass.Visible = true;
                pb_newpass.Visible = true;

                lbl_renewpass.Visible = true;
                txt_renewpass.Visible = true;
                pb_renewpass.Visible = true;

                lbl_user.Visible = false;
                txt_user.Visible = false;
                pb_user.Visible = false;
                btn_reset.Visible = true;
            }
        }

        private void send_otp(int otp)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("lms.pramod.999@gmail.com");
                mail.To.Add(user_mail);
                mail.Subject = "L.M.S OTP";
                mail.Body = "Your One Time Password for LMS password change is " + otp;

                smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential("Your mail id", "Your password");
                smtp.EnableSsl = true;

                smtp.Send(mail);
                MessageBox.Show("Mail sent");
                flag = true;
            }
            catch
            {
                MessageBox.Show("Mail not sent,Check your connectivity");
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if(lg==null)
            {
                back.Show();
            }
            else
            {
                lg.Show();
            }
            this.Close();
        }
    }
}
