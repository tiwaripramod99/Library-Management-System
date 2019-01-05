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

namespace Library_Management_System
{
    public partial class Return_book : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pramod\Documents\book_details.mdf;Integrated Security=True;Connect Timeout=30");
        int err_count = 0;
        Admin_Dashboard back;
        public Return_book(Admin_Dashboard reference)
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

        private void btn_return_Click(object sender, EventArgs e)
        {
            if (validate_return())
            {
                try
                {
                    bool flag = true;
                    sqlConnection.Open();
                    string query = "Select Issuer_Id,Return_status,Book_Id from [dbo].[issuer_details] where Book_id = " + Convert.ToInt32(txt_book_id.Text) + "and Issuer_Id=" + Convert.ToInt64(txt_enroll.Text);
                    SqlCommand cmd = new SqlCommand(query, sqlConnection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    try
                    {
                        if (reader[0].ToString().Trim() == txt_enroll.Text)
                        {
                            try
                            {
                                if(reader[2].ToString().Trim() == txt_book_id.Text)
                                {
                                    if (reader[1].ToString().Trim() == "true")
                                    {
                                        MessageBox.Show("Book already returned");
                                        flag = false;
                                        clear();
                                    }
                                }
                            }
                            catch
                            {
                                MessageBox.Show("No such book issued");
                            } 
                        }
                    }
                    catch
                    {
                        MessageBox.Show("No such user");
                        flag = false;
                    }
                    reader.Close();
                    if (flag)
                    {
                        query = "Update [dbo].[issuer_details] set Return_date='" + txt_return_date.Value.ToShortDateString() + "' , Return_status ='true' where Book_id=" + Convert.ToInt64(txt_book_id.Text)+" and Issuer_Id = "+Convert.ToInt64(txt_enroll.Text);
                        cmd = new SqlCommand(query, sqlConnection);
                        cmd.ExecuteNonQuery();

                        query = "Update [dbo].[book_details] set Current_copies=Current_copies+1 where Book_Id=" + txt_book_id.Text;
                        cmd = new SqlCommand(query, sqlConnection);
                        cmd.ExecuteNonQuery();

                        sqlConnection.Close();
                        MessageBox.Show("Book Returned");
                        clear();
                    }
                }
                catch
                {
                    //do nothing
                }
            }
            err_count = 0;
        }

        private bool validate_return()
        {
            string pattern_enroll = @"[0-9]{11}$";
            if (!Regex.IsMatch(txt_enroll.Text, pattern_enroll))
            {
                err_enroll.SetError(txt_enroll, "Enter numeric value of 10 digits");
            }
            else
            {
                err_count++;
                err_enroll.Clear();
            }

            int issue_date = txt_issue_date.Value.DayOfYear;
            int return_date = txt_return_date.Value.DayOfYear;
            if (issue_date >= return_date)
            {
                if (txt_issue_date.Value.Year > txt_return_date.Value.Year)
                {
                    err_return_date.SetError(txt_return_date, "Enter proper return date");
                }
                else if (issue_date > return_date)
                {
                    err_return_date.SetError(txt_return_date, "Enter proper return date");
                }
                else
                {
                    err_count++;
                    err_return_date.Clear();
                }
            }
            else
            {
                err_count++;
                err_return_date.Clear();
            }
            if(err_count == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void clear()
        {
            txt_enroll.Text = "";
            txt_book_id.Text = "";
            txt_issue_date.Value = System.DateTime.Today;
            txt_return_date.Value = System.DateTime.Today;

            txt_enroll.Focus();
        }

        private void txt_enroll_Leave(object sender, EventArgs e)
        {
            try
            {
                string query = "Select Issuer_Id from [dbo].[issuer_details] where Issuer_Id=" + Convert.ToInt64(txt_enroll.Text);
                sqlConnection.Open();
                try
                {
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    sqlDataReader.Read();
                    try
                    {
                        if (sqlDataReader[0] != null)
                        {
                            err_enroll.Clear();
                        }
                    }
                    catch
                    {
                        err_enroll.SetError(txt_enroll, "No Such Issuer");
                        txt_enroll.Text = "";
                        txt_enroll.Focus();
                    }
                    sqlDataReader.Close();
                }
                catch
                {
                    //do nothing
                }
                sqlConnection.Close();
            }
            catch
            {
                //do nothing
            }
        }

        private void txt_book_id_Leave(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                try
                {
                    string query = "select Book_Id,Issue_date from [dbo].[issuer_details] where Issuer_id=" + Convert.ToInt64(txt_enroll.Text) + "and Book_id=" + Convert.ToInt32(txt_book_id.Text);
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    sqlDataReader.Read();
                    try
                    {
                        if (sqlDataReader[0].ToString() != null)
                        {
                            err_book_id.Clear();
                            txt_issue_date.Value = Convert.ToDateTime(sqlDataReader[1].ToString());
                        }
                    }
                    catch (Exception)
                    {
                        err_book_id.SetError(txt_book_id, "No such book issued");
                        txt_book_id.Text = "";
                        txt_book_id.Focus();
                    }
                    sqlDataReader.Close();
                }
                catch
                {
                    MessageBox.Show("Error");
                }
                sqlConnection.Close();
            }
            catch
            {
                //do nothing
            }
        }

        private void Return_book_Load(object sender, EventArgs e)
        {
            txt_issue_date.Value = System.DateTime.Today;
            txt_return_date.Value = System.DateTime.Today;
        }
    }
}
