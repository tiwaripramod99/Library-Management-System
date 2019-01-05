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
    public partial class User_Dashboard : Form
    {
        SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pramod\Documents\book_details.mdf;Integrated Security=True;Connect Timeout=30");
        Login back;
        string user;
        public User_Dashboard(Login reference,string user_info)
        {
            user = user_info;
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

        private void btn_logout_Click(object sender, EventArgs e)
        {
            back.Show();
            this.Close();
        }

        private void btn_read_book_Click(object sender, EventArgs e)
        {
            Book_shelf read_book = new Book_shelf(this,user);
            read_book.Show();
            this.Hide();
        }

        private void btn_contact_Click(object sender, EventArgs e)
        {
            Contact_us_user contact = new Contact_us_user(this);
            contact.Show();
            this.Hide();
        }

        private void btn_wishlist_Click(object sender, EventArgs e)
        {
            Wishlist wish = new Wishlist(this,user);
            wish.Show();
            this.Hide();
        }

        private void btn_issued_Click(object sender, EventArgs e)
        {
            Issued_books issued_Books = new Issued_books(this,user);
            issued_Books.Show();
            this.Hide();
        }

        private void User_Dashboard_Load(object sender, EventArgs e)
        {
            sql.Open();
            string query = "Select Membership,Student_name,Profile_image from student_details where Student_Id = "+Convert.ToInt64(user);
            SqlCommand cmd = new SqlCommand(query, sql);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            if (reader[0].ToString().Trim() == "false")
            {
                pb_membership.BackgroundImage = global::Library_Management_System.Properties.Resources.unnamed__9_;
                lbl_membership.Text = "Non\nPrime";
                lbl_membership.ForeColor = Color.FromArgb(212,118,93);
                menu_extras.ItemClicked += new ToolStripItemClickedEventHandler(item_Click);

            }
            lbl_user.Text = reader[1].ToString().Trim();
            try
            {
                pb_profile_img.BackgroundImage = Image.FromFile(reader[2].ToString());
            }
            catch
            {
                pb_profile_img.BackgroundImage = global::Library_Management_System.Properties.Resources.User_96px;
            }
            reader.Close();
            sql.Close();

            try
            {
                sql.Open();
                query = "Select count(Book_Id) from [dbo].[wishlist] where Student_Id = " + Convert.ToInt64(user);
                cmd = new SqlCommand(query, sql);
                int n = Convert.ToInt32(cmd.ExecuteScalar());
                string[] id = new string[n];

                query = "Select Book_Id from [dbo].[wishlist] where Student_Id = " + Convert.ToInt64(user);
                cmd = new SqlCommand(query, sql);
                reader = cmd.ExecuteReader();

                for (int i = 0; reader.Read(); i++)
                {
                    id[i] = reader[0].ToString();
                }
                reader.Close();

                query = "Select Book_Id from [dbo].[issuer_details] where Issuer_Id = " + Convert.ToInt64(user);
                cmd = new SqlCommand(query, sql);
                reader = cmd.ExecuteReader();

                int count = 0;
                while (reader.Read())
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (reader[0].ToString() == id[j])
                        {
                            count++;
                        }
                    }
                }

                reader.Close();

                books_progress.LineProgressThickness = 7;
                books_progress.MaxValue = n;
                books_progress.Value = count;
                sql.Close();
            }
            catch
            {
                //do nothing
            }
        }

        private void item_Click(object sender, ToolStripItemClickedEventArgs e)
        {
            menu_extras.Close();
        }

        private void pb_profile_img_ContextMenuStripChanged(object sender, EventArgs e)
        {
            pb_profile_img.ContextMenuStrip = menu_extras;
        }

        private void uploadProfilePictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog();
                op.ShowDialog();
                pb_profile_img.BackgroundImage = Image.FromFile(op.FileName);
                sql.Open();
                string query = "Update [dbo].[student_details] set Profile_image = '" + op.FileName + "' where Student_Id = " + Convert.ToInt64(user);
                MessageBox.Show(query);
                SqlCommand cmd = new SqlCommand(query, sql);
                cmd.ExecuteNonQuery();
                sql.Close();
            }
            catch
            {
                //do nothing
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reset_password reset = new Reset_password(this,user);
            reset.Show();
            this.Hide();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            User_Dashboard_Load(sender, e);
        }
    }
}
