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
    public partial class New_registration : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pramod\Documents\book_details.mdf;Integrated Security=True;Connect Timeout=30");
        int err_counter=0;
        public New_registration()
        {
            InitializeComponent();
        }

        private void btn_add_user_Click(object sender, EventArgs e)
        {
            try
            {
                if (validate_reg())
                {
                    bool flag = true;
                    sqlConnection.Open();
                    string quer = "select Student_id from [dbo].[student_details] where Student_id=" + Convert.ToInt64(txt_enroll.Text);
                    SqlCommand sqlComman = new SqlCommand(quer, sqlConnection);
                    SqlDataReader reader = sqlComman.ExecuteReader();
                    reader.Read();
                    try
                    {
                        if (reader[0].ToString() == txt_enroll.Text)
                        {
                            MessageBox.Show("Student with same id already exists");
                            flag = false;

                        }
                    }
                    catch (Exception)
                    {
                        //do nothing
                    }
                    sqlConnection.Close();

                    if (flag)
                    {
                        sqlConnection.Open();
                        string query = "Insert into [dbo].[student_details] values(" + Convert.ToInt64(txt_enroll.Text) + ",'" + txt_name.Text + "','" + txt_enroll.Text + "','" + txt_dep.Text + "','" + txt_contact.Text + "','" + gen_select() + "','" + txt_dob.Value.ToShortDateString() + "','" + null + "','false')";
                        SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                        sqlCommand.ExecuteNonQuery();
                        sqlConnection.Close();
                        MessageBox.Show("User Added");
                        clear();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Data not inserted", "Insertion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            err_counter = 0;
            
        }

        private string gen_select()
        {
            if (rad_male.Checked == true)
            {
                return "Male";
            }
            else
            {
                return "Female";
            }
        }

        private void clear()
        {
            txt_enroll.Text = null;
            txt_name.Text = null;
            txt_dep.Text = null;
            txt_contact.Text = null;
            txt_dob.Value = System.DateTime.Today;
            rad_female.Checked = false;
            rad_male.Checked = false;
            txt_name.Focus();
        }

        private bool validate_reg()
        {
            string pattern_name = @"[a-z,A-Z]$";
            if (!Regex.IsMatch(txt_name.Text, pattern_name))
            {
                err_name.SetError(txt_name, "Enter proper name\n without numeric values\n and special characters");
            }
            else
            {
                err_counter++;
                err_name.Clear();
            }

            string pattern_enroll = @"[0-9]{11}$";
            if (!Regex.IsMatch(txt_enroll.Text, pattern_enroll))
            {
                err_enroll.SetError(txt_enroll, "Enter numeric value\n of 11 digit");
            }
            else
            {
                err_counter++;
                err_enroll.Clear();
            }

            if (txt_dep.Text == "")
            {
                err_dep.SetError(txt_dep, "Select a department");
            }
            else
            {
                err_counter++;
                err_dep.Clear();
            }

            try
            {
                MailAddress mail = new MailAddress(txt_contact.Text);
                err_counter++;
                err_contact.Clear();
            }
            catch(FormatException e)
            {
                err_contact.SetError(txt_contact, "Enter valid mail id");
            }

            if ((rad_male.Checked == false) && (rad_female.Checked == false))
            {
                err_sex.SetError(lbl_err_mark, "Select sex");
            }
            else
            {
                err_counter++;
                err_sex.Clear();
            }

            int year = Convert.ToInt32(txt_dob.Value.Year.ToString());
            int expected_year = Convert.ToInt32(System.DateTime.Today.Year.ToString());
            if (year >= (expected_year - 6))
            {
                err_dob.SetError(txt_dob, "Enter correct D.O.B");
            }
            else
            {
                err_counter++;
                err_dob.Clear();
            }
            if (err_counter == 6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
