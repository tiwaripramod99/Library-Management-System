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
    public partial class Delete_regestration : Form
    {
        PictureBox user = new PictureBox();
        Label user_info = new Label();
        SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pramod\Documents\book_details.mdf;Integrated Security=True;Connect Timeout=30");
        public Delete_regestration()
        {
            InitializeComponent();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                sql.Open();

                string query = "Delete from [dbo].[issuer_details] where Issuer_Id = " + Convert.ToInt64(txt_enroll.Text);
                SqlCommand comm = new SqlCommand(query, sql);
                comm.ExecuteNonQuery();

                query = "Delete from [dbo].[wishlist] where Student_Id = " + Convert.ToInt64(txt_enroll.Text);
                comm = new SqlCommand(query, sql);
                comm.ExecuteNonQuery();

                query = "Delete from [dbo].[student_details] where Student_Id = " + Convert.ToInt64(txt_enroll.Text);
                comm = new SqlCommand(query, sql);
                comm.ExecuteNonQuery();

                sql.Close();
                MessageBox.Show("User Deleted");
                user.BackgroundImage = null;
                user_info.Text = "";
                txt_enroll.Text = "";
            }
            catch
            {
                //do nothing
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            user.BackgroundImage = null;
            user_info.Text = "";
            sql.Open();
            try
            {
                string query = "Select * from [dbo].[student_details] where Student_Id = " + Convert.ToInt64(txt_enroll.Text);
                SqlCommand comm = new SqlCommand(query, sql);
                SqlDataReader reader = comm.ExecuteReader();
                reader.Read();

                user.Size = new Size(120, 135);
                user.BackgroundImageLayout = ImageLayout.Stretch;
                try
                {
                    if (reader[0].ToString() != null)
                    {
                        try
                        {
                            user.BackgroundImage = Image.FromFile(reader[7].ToString());
                        }
                        catch
                        {
                            user.BackgroundImage = global::Library_Management_System.Properties.Resources.User_96px;
                        }
                    }
                }
                catch
                {
                    user.BackgroundImage = null;
                }
                user.Location = new Point(70, 200);
                this.Controls.Add(user);

                user_info.Size = new Size(500, 150);
                user_info.ForeColor = Color.FromArgb(64, 64, 64);
                user_info.Font = new Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular);
                user_info.BackColor = Color.Transparent;
                user_info.Location = new Point(270, 200);
                try
                {
                    string id = reader[0].ToString().Trim();
                    string name = reader[1].ToString().Trim();
                    string dep = reader[3].ToString().Trim();
                    string contact = reader[4].ToString().Trim();
                    string sex = reader[5].ToString().Trim();
                    string dob = reader[6].ToString().Trim();
                    string membership = reader[8].ToString().Trim();
                    if (membership == "true")
                    {
                        membership = "Prime";
                    }
                    else
                    {
                        membership = "Non-Prime";
                    }
                    user_info.Text = "Student Id:            " + id +
                                   "\nStudent Name:     " + name +
                                   "\nDepartment:        " + dep +
                                   "\nContact:              " + contact +
                                   "\nSex:                       " + sex +
                                   "\nD.O.B:                   " + dob +
                                   "\nMembership:         " + membership;
                    this.Controls.Add(user_info);
                    btn_delete.Enabled = true;
                    reader.Close();
                }
                catch
                {
                    MessageBox.Show("No such user");
                    txt_enroll.Text = "";
                }
                sql.Close();
            }
            catch
            {
                MessageBox.Show("No such user");
            }

        }

        private void Delete_regestration_Load(object sender, EventArgs e)
        {
            btn_delete.Enabled = false;
        }
    }
}
