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
    public partial class Edit_registration : Form
    {
        SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pramod\Documents\book_details.mdf;Integrated Security=True;Connect Timeout=30");
        int err_counter = 0;
        public Edit_registration()
        {
            InitializeComponent();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (validate_reg())
                {  
                    sql.Open();
                    string query = "Update [dbo].[student_details] set Student_name='" + txt_name.Text + "', Department='" + txt_dep.Text + "',Email='" + txt_contact.Text + "',Sex='" + gen_select() + "',DOB='" + txt_dob.Value.ToShortDateString()+"' where Student_Id="+Convert.ToInt64(txt_enroll.Text);
                    SqlCommand sqlCommand = new SqlCommand(query, sql);
                    sqlCommand.ExecuteNonQuery();
                    sql.Close();
                    MessageBox.Show("User data updated");
                    clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Data not updated", "Updation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            err_counter = 0;
            txt_enroll.Enabled = true;
        }

        private bool validate_reg()
        {
            string pattern_name = @"[a-z,A-Z]$";
            if (!Regex.IsMatch(txt_name.Text, pattern_name))
            {
                err_name.SetError(txt_name, "Enter proper name\nwithout numeric values\n& special characters");
            }
            else
            {
                err_counter++;
                err_name.Clear();
            }

            string pattern_enroll = @"[0-9]{11}$";
            if (!Regex.IsMatch(txt_enroll.Text, pattern_enroll))
            {
                err_enroll.SetError(txt_enroll, "Enter 11 digit \nnumeric value");
            }
            else
            {
                err_counter++;
                err_enroll.Clear();
            }

            if (txt_dep.Text == "")
            {
                err_dep.SetError(txt_dep, "Select Department");
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
            catch (FormatException e)
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
                err_dob.SetError(txt_dob, "Enter proper D.O.B");
            }
            else
            {
                err_counter++;
                err_dob.Clear();
            }

            if(err_counter == 6)
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
            txt_name.Text = null;
            txt_dep.Text = null;
            txt_contact.Text = null;
            txt_dob.Value = System.DateTime.Today;
            rad_female.Checked = false;
            rad_male.Checked = false;
            txt_enroll.Focus();
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

        private void Edit_registration_Load(object sender, EventArgs e)
        {
            btn_update.Enabled = false;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txt_enroll.Text == "")
            {
                MessageBox.Show("Enter Enrollment number");
                txt_enroll.Focus();
            }
            else
            {
                try
                {
                    bool flag = true;
                    sql.Open();
                    string query = "Select * from [dbo].[student_details] where Student_Id=" + Convert.ToInt64(txt_enroll.Text);
                    SqlCommand cmd = new SqlCommand(query, sql);
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    try
                    {
                        reader[0].ToString();
                    }
                    catch
                    {
                        MessageBox.Show("No such user");
                        clear();
                        flag = false;
                    }
                    if (flag)
                    {
                        txt_enroll.Enabled = false;
                        txt_name.Text = reader[1].ToString().Trim();
                        txt_dep.Text = reader[3].ToString().Trim();
                        txt_contact.Text = reader[4].ToString().Trim();
                        if (reader[5].ToString().Trim() == "Male")
                        {
                            rad_male.Checked = true;
                        }
                        else
                        {
                            rad_female.Checked = true;
                        }
                        txt_dob.Value = Convert.ToDateTime(reader[6].ToString().Trim());
                        reader.Close();
                    }
                    sql.Close();
                }
                catch
                {
                    //do nothing
                }
                btn_update.Enabled = true;
            }
        }
    }
}
