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
    public partial class Book_details : Form
    {
        OpenFileDialog openfile;
        int err_counter = 0;
        Admin_Dashboard back;
        string img_loc;
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pramod\Documents\book_details.mdf;Integrated Security=True;Connect Timeout=30");
        public Book_details(Admin_Dashboard reference)
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

        private void btn_add_user_Click(object sender, EventArgs e)
        {
            if (validate_book())
            {
                sqlConnection.Open();
                string quer = "select Book_id from [dbo].[book_details] where Book_id=" + Convert.ToInt32(txt_book_id.Text);
                SqlCommand sqlComman = new SqlCommand(quer, sqlConnection);
                SqlDataReader reader = sqlComman.ExecuteReader();
                reader.Read();
                try
                {
                    if (reader[0].ToString() == txt_book_id.Text)
                    {
                        MessageBox.Show("Book with same id already exists, check book id again");
                    }
                }
                catch (Exception)
                {
                    //do nothing
                    reader.Close();
                    string filepath = null;
                    try
                    {
                        if (openfile.FileName.ToString() != null)
                        {
                            filepath = openfile.FileName;
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Book Path Not Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    try
                    {
                        string query = "Insert into [dbo].[book_details] values(" + Convert.ToInt32(txt_book_id.Text) + ",'" + txt_book_title.Text + "','" + txt_author.Text + "','" + txt_category.Text + "'," + Convert.ToInt32(txt_copies.Text) + "," + Convert.ToInt32(txt_copies.Text) + ",'" + img_loc + "','" + filepath + "')";
                        SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("New Book Added");
                        clear();
                    }
                    catch
                    {
                        MessageBox.Show("Enter details properly");
                    }
                }
                sqlConnection.Close();
            }
            err_counter = 0;
        }

        private bool validate_book()
        {
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

            string pattern_auth = @"[a-z,A-Z]$";
            if (!Regex.IsMatch(txt_author.Text, pattern_auth))
            {
                err_pub_year.SetError(txt_author, "Enter Author Name");
            }
            else
            {
                err_counter++;
                err_pub_year.Clear();
            }

            if (txt_category.Text == "")
            {
                err_category.SetError(txt_category, "Select category");
            }
            else
            {
                err_counter++;
                err_category.Clear();
            }

            string pattern_copies = @"[0-9]$";
            if (!Regex.IsMatch(txt_copies.Text, pattern_copies))
            {
                err_copies.SetError(txt_copies, "Enter numeric value");
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

        private void btn_book_img_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();
            img_loc = open.FileName.ToString();
        }

        private void btn_book_add_Click(object sender, EventArgs e)
        {
            openfile = new OpenFileDialog();
            openfile.ShowDialog();
        }

        private void clear()
        {
            txt_book_id.Text = null;
            txt_book_title.Text = null;
            txt_author.Text = null;
            txt_category.Text = null;
            txt_copies.Text = null;
            pb_logo.BackgroundImage = Image.FromFile(@"F:\Sem-4\Library Management System\Library Management System\Resources\unnamed (1).png");
            txt_book_id.Focus();
        }
    }
}
