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
    public partial class Issue_book : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pramod\Documents\book_details.mdf;Integrated Security=True;Connect Timeout=30");
        int err_counter = 0;
        Admin_Dashboard back;
        public Issue_book(Admin_Dashboard reference)
        {
            back = reference;
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_right_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_left_Click(object sender, EventArgs e)
        {
            this.Close();
            back.Show();
        }

        private void btn_issue_Click(object sender, EventArgs e)
        {
            if (err_counter == 0 || err_counter == -3)
            {
                try
                {

                    bool flag = true;
                    sqlConnection.Open();
                    string check = "Select Issuer_Id,Book_Id,Return_status from [dbo].[issuer_details] where Issuer_Id=" + Convert.ToInt64(txt_enroll.Text) + "and Book_Id=" + txt_book_id.Text;
                    SqlCommand cmd = new SqlCommand(check, sqlConnection);
                    SqlDataReader read = cmd.ExecuteReader();
                    read.Read();
                    try
                    {
                        if(read[0].ToString().Trim() == txt_enroll.Text)
                        {
                            try
                            {
                                if ((read[1].ToString().Trim() == txt_book_id.Text) && (read[2].ToString().Trim() == "false"))
                                {
                                    MessageBox.Show("Already issued");
                                    clear();
                                    flag = false;
                                }
                                else
                                {
                                    read.Close();
                                    check = "Update [dbo].[issuer_details] set Return_status = 'false' , Issue_date='" + txt_issue_date.Value.ToShortDateString() + "', Return_date='" + txt_return_date.Value.ToShortDateString() + "' where Book_Id = " + Convert.ToInt32(txt_book_id.Text) + " and Issuer_Id = "+Convert.ToInt64(txt_enroll.Text);
                                    cmd = new SqlCommand(check, sqlConnection);
                                    cmd.ExecuteNonQuery();

                                    check = "Update [dbo].[book_details] set Current_copies = Current_copies - 1 where Book_Id=" + Convert.ToInt32(txt_book_id.Text);
                                    cmd = new SqlCommand(check, sqlConnection);
                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Book Issued");
                                    clear();
                                    flag = false;
                                }
                            }
                            catch
                            {
                                //do nothing
                            }
                        }   
                    }
                    catch
                    {
                        //do nothing
                    }
                    read.Close();

                    if (flag)
                    {
                        try
                        {
                            string queri = "select Current_copies from [dbo].[book_details] where Book_id=" + Convert.ToInt32(txt_book_id.Text);
                            SqlCommand sqlCommani = new SqlCommand(queri, sqlConnection);
                            SqlDataReader readeri = sqlCommani.ExecuteReader();
                            readeri.Read();
                            int curr_count = Convert.ToInt32(readeri[0].ToString()) - 1;
                            readeri.Close();

                            string update_query = "update [dbo].[book_details] set Current_copies=" + curr_count + " where Book_id=" + Convert.ToInt32(txt_book_id.Text);
                            SqlCommand cmdo = new SqlCommand(update_query, sqlConnection);
                            cmdo.ExecuteNonQuery();
                            string return_status = "false";

                            string query = "Insert into [dbo].[issuer_details] values(" + Convert.ToInt64(txt_enroll.Text) + "," + Convert.ToInt32(txt_book_id.Text) + ",'" + txt_issue_date.Value.ToShortDateString() + "','" + txt_return_date.Value.ToShortDateString() + "','" + return_status + "')";
                            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                            sqlCommand.ExecuteNonQuery();
                            MessageBox.Show("Book Issued");

                            clear();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Book Not Issued", "Issue error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    sqlConnection.Close();
                }
                catch
                {
                    //do nothing
                }
                err_counter = 0;
            }
        }

        private bool validate_issue()
        {
            string pattern_enroll = @"[0-9]{11}$";
            if (!Regex.IsMatch(txt_enroll.Text, pattern_enroll))
            {
                err_enroll.SetError(txt_enroll, "Enter numeric 10 digit value");
            }
            else
            {
                err_counter++;
                err_enroll.Clear();
            }

            string pattern_id = @"[0-9]$";
            if (!Regex.IsMatch(txt_book_id.Text, pattern_id))
            {
                err_book_id.SetError(txt_book_id, "Enter numeric value");
            }
            else
            {
                err_counter++;
                err_book_id.Clear();
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
                    err_counter++;
                    err_return_date.Clear();
                }

            }
            else
            {
                err_counter++;
                err_return_date.Clear();
            }

            if(err_counter == 3)
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
            int issue_date = Convert.ToInt32(txt_issue_date.Value.DayOfYear.ToString());
            int return_date = issue_date + 10;
            int year = System.DateTime.Today.Year;

            DateTime date = new DateTime(year, 1, 1).AddDays(return_date - 1);

            txt_enroll.Text = "";
            txt_book_id.Text = "";
            txt_issue_date.Value = System.DateTime.Today;
            txt_return_date.Value = Convert.ToDateTime(date);

            txt_enroll.Focus();
        }

        private void txt_enroll_Leave(object sender, EventArgs e)
        {
            try
            {
                string query = "Select Student_Id from [dbo].[student_details] where Student_Id=" + Convert.ToInt64(txt_enroll.Text);
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
                        err_enroll.SetError(txt_enroll, "No Such User");
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
                bool flag = true;
                sqlConnection.Open();
                try
                {
                    string query = "select Book_Id,Current_copies from [dbo].[book_details] where Book_id=" + Convert.ToInt32(txt_book_id.Text);
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    sqlDataReader.Read();
                    try
                    {
                        if (sqlDataReader[0].ToString() != null)
                        {
                            err_book_id.Clear();
                        }
                    }
                    catch (Exception)
                    {
                        err_book_id.SetError(txt_book_id, "No such book");
                        txt_book_id.Text = "";
                        txt_book_id.Focus();
                        flag = false;
                    }
                    if (flag)
                    {
                        if (sqlDataReader[1].ToString() == "0")
                        {
                            MessageBox.Show("Book Stack Empty");
                            err_counter++;
                        }
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

        private void Issue_book_Load(object sender, EventArgs e)
        {
            txt_issue_date.Value = System.DateTime.Today;

            int issue_date = Convert.ToInt32(txt_issue_date.Value.DayOfYear.ToString());
            int return_date = issue_date + 10;
            int year = System.DateTime.Today.Year;

            DateTime date = new DateTime(year, 1, 1).AddDays(return_date - 1);

            txt_return_date.Value = Convert.ToDateTime(date);
        }
    }
}
