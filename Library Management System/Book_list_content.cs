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
    public partial class Book_list_content : Form
    {
        SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pramod\Documents\book_details.mdf;Integrated Security=True;Connect Timeout=30");
        public Book_list_content()
        {
            InitializeComponent();
        }

        private void Book_list_content_Load(object sender, EventArgs e)
        {
            try
            {
                sql.Open();

                string quer = "Select * from [dbo].[book_details]";
                SqlCommand comm = new SqlCommand(quer, sql);
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                DataSet dataSet = new DataSet();
                dataAdapter.SelectCommand = comm;
                dataAdapter.Fill(dataSet);

                int pb_x = 100, lbl_info_x = 250;
                int pb_y = 30, lbl_info_y = 30;

                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    PictureBox book = new PictureBox();
                    book.Size = new Size(100, 120);
                    book.BackgroundImageLayout = ImageLayout.Stretch;
                    try
                    {
                        book.BackgroundImage = Image.FromFile(dataSet.Tables[0].Rows[i].ItemArray[6].ToString());
                    }
                    catch
                    {
                        book.BackgroundImage = global::Library_Management_System.Properties.Resources.Book;
                    }
                    book.Location = new Point(pb_x, pb_y);
                    this.Controls.Add(book);

                    Label book_info = new Label();
                    book_info.Size = new Size(500, 150);
                    book_info.ForeColor = Color.FromArgb(64, 64, 64);
                    book_info.Font = new Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular);
                    book_info.BackColor = Color.Transparent;
                    book_info.Location = new Point(lbl_info_x, lbl_info_y);
                    string id = dataSet.Tables[0].Rows[i].ItemArray[0].ToString();
                    string title = dataSet.Tables[0].Rows[i].ItemArray[1].ToString();
                    string author = dataSet.Tables[0].Rows[i].ItemArray[2].ToString();
                    string category = dataSet.Tables[0].Rows[i].ItemArray[3].ToString();
                    string current = dataSet.Tables[0].Rows[i].ItemArray[5].ToString();
                    string actual = dataSet.Tables[0].Rows[i].ItemArray[4].ToString();
                    book_info.Text = "Book Id:                  " + id +
                                   "\nBook Title:               " + title +
                                   "\nAuthor:                   " + author +
                                   "\nCategory:              " + category +
                                   "\nCurrent Copies       " + current +
                                   "\nActual Copies        " + actual;
                    this.Controls.Add(book_info);

                    pb_y += 170;
                    lbl_info_y += 170;
                }
                dataSet.Clear();
            }
            catch
            {
                MessageBox.Show("Database Connectivity Failed");
            }
        }
    }
}
