using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Net.Mail;

namespace Library_Management_System
{
    public partial class Order_book : Form
    {
        int err_counter = 0;
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pramod\Documents\book_details.mdf;Integrated Security=True;Connect Timeout=30");
        Admin_Dashboard back;
        public Order_book(Admin_Dashboard reference)
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
            this.Close();
            back.Show();
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            if(err_counter==0||err_counter==-5)
            {
                sqlConnection.Open();
                string in_query = "Insert into [dbo].[order_details] values('" + txt_book_title.Text + "','" + txt_order_date.Value.ToShortDateString() + "','" + Convert.ToInt32(txt_copies.Text) + "')";
                SqlCommand cmd = new SqlCommand(in_query, sqlConnection);
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
                order_mail();
                clear();
            }
        }

        private void clear()
        {
            txt_book_title.Text = null;
            txt_author.Text = null;
            txt_order_date.Value = System.DateTime.Today;
            txt_priority.Text = null;
            txt_copies.Text = null;
            txt_book_title.Focus();
        }

        private bool validate_order()
        {
            string pattern_title = @"[0-9,a-z,A-Z]$";
            if (!Regex.IsMatch(txt_book_title.Text, pattern_title))
            {
                err_book_title.SetError(txt_book_title, "Enter proper title\nwithout special characters");
            }
            else
            {
                err_counter++;
                err_book_title.Clear();
            }

            string pattern_author = @"[a-z,A-Z]$";
            if (!Regex.IsMatch(txt_book_title.Text, pattern_author))
            {
                err_author.SetError(txt_author, "Enter proper name without\nnumeric character\n&special character");
            }
            else
            {
                err_counter++;
                err_author.Clear();
            }

            if (txt_priority.Text == "")
            {
                err_priority.SetError(txt_priority, "Select priority");
            }
            else
            {
                err_counter++;
                err_priority.Clear();
            }

            int day = txt_order_date.Value.DayOfYear;
            if (System.DateTime.Today.DayOfYear > day)
            {
                if (txt_order_date.Value.Year != System.DateTime.Today.Year)
                {
                    err_order_date.SetError(txt_order_date, "Set proper order date");
                }
                else
                {
                    err_counter++;
                    err_order_date.Clear();
                }
            }
            else
            {
                err_counter++;
                err_order_date.Clear();
            }

            string pattern_copies = @"[0-9]$";
            if (!Regex.IsMatch(txt_copies.Text, pattern_copies))
            {
                err_copies.SetError(txt_copies, "Enter numeric values");
            }
            else
            {
                err_counter++;
                err_copies.Clear();
            }

            if(err_counter == 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void order_mail()
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("lms.pramod.999@gmail.com");
                mail.To.Add("tpramod64@gmail.com");
                mail.Subject = "Order for Books";
                mail.Body = "We need this book at our library of U.V Patel College Of Engineering:\n" +
                            "Book Title:\n\t" + txt_book_title.Text +
                              "\nAuthor:\n\t" + txt_author.Text +
                      "\nOrder Priority:\n\t" + txt_priority.Text +
                        "\nOrder Copies:\n\t" + txt_copies.Text +
                            "\n\nThis order request was sent on " + txt_order_date.Value.ToShortDateString();

                smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential("lms.pramod.999@gmail.com", "Pramodlms999");
                smtp.EnableSsl = true;

                smtp.Send(mail);
                MessageBox.Show("Order mail sent");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void Order_book_Load(object sender, EventArgs e)
        {
            txt_order_date.Value = System.DateTime.Today;
        }
    }
}
