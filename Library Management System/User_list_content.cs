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
    public partial class User_list_content : Form
    {
        static int count = Array_Size();
        SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pramod\Documents\book_details.mdf;Integrated Security=True;Connect Timeout=30");
        public User_list_content()
        {
            InitializeComponent();
        }

        private void User_list_content_Load(object sender, EventArgs e)
        {
            sql.Open();

            string query = "Select * from [dbo].[student_details]";
            SqlCommand comm = new SqlCommand(query, sql);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataSet dataSet = new DataSet();
            dataAdapter.SelectCommand = comm;
            dataAdapter.Fill(dataSet);

            int pb_x = 100, lbl_info_x = 250;
            int pb_y = 30, lbl_info_y = 30;

            try
            {
                for (int i = 0; i < count; i++)
                {
                    PictureBox user = new PictureBox();
                    user.Size = new Size(100, 120);
                    user.BackgroundImageLayout = ImageLayout.Stretch;
                    try
                    {
                        user.BackgroundImage = Image.FromFile(dataSet.Tables[0].Rows[i].ItemArray[7].ToString());
                    }
                    catch
                    {
                        user.BackgroundImage = global::Library_Management_System.Properties.Resources.User_96px;
                    }
                    user.Location = new Point(pb_x, pb_y);
                    this.Controls.Add(user);

                    Label user_info = new Label();
                    user_info.Size = new Size(500, 150);
                    user_info.ForeColor = Color.FromArgb(64, 64, 64);
                    user_info.Font = new Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular);
                    user_info.BackColor = Color.Transparent;
                    user_info.Location = new Point(lbl_info_x, lbl_info_y);
                    string id = dataSet.Tables[0].Rows[i].ItemArray[0].ToString().Trim();
                    string name = dataSet.Tables[0].Rows[i].ItemArray[1].ToString().Trim();
                    string dep = dataSet.Tables[0].Rows[i].ItemArray[3].ToString().Trim();
                    string contact = dataSet.Tables[0].Rows[i].ItemArray[4].ToString().Trim();
                    string sex = dataSet.Tables[0].Rows[i].ItemArray[5].ToString().Trim();
                    string dob = dataSet.Tables[0].Rows[i].ItemArray[6].ToString().Trim();
                    string membership = dataSet.Tables[0].Rows[i].ItemArray[8].ToString().Trim();
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

                    pb_y += 170;
                    lbl_info_y += 170;
                }
            }
            catch
            {
                //do nothing
            }
            dataSet.Clear();
        }

        private static int Array_Size()
        {
            try
            {
                SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pramod\Documents\book_details.mdf;Integrated Security=True;Connect Timeout=30");
                sql.Open();
                string query = "Select count(Student_Id) from [dbo].[student_details]";
                SqlCommand cmd = new SqlCommand(query, sql);
                int si = Convert.ToInt32(cmd.ExecuteScalar());
                sql.Close();
                return si;
            }
            catch
            {
                return 0;
            }
        }
    }
}
