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
    public partial class issued_book_list : Form
    {
        string user;
        public issued_book_list(string user_info)
        {
            user = user_info;
            InitializeComponent();
        }

        private void issued_book_list_Load(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pramod\Documents\book_details.mdf;Integrated Security=True;Connect Timeout=30");
            sql.Open();

            string quer = "Select Book_Id,Issue_date,Return_status from [dbo].[issuer_details] where Issuer_Id = "+ Convert.ToInt64(user);
            SqlCommand comm = new SqlCommand(quer, sql);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataSet dataSet = new DataSet();
            dataAdapter.SelectCommand = comm;
            dataAdapter.Fill(dataSet);

            int n=1;
            int pb_x = 100, lbl_info_x = 250, lbl_alpha_x = 30;
            int pb_y = 90, lbl_info_y = 90, lbl_alpha_y = 50;

            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                string query = "Select Book_image,Book_title,Author,Category from [dbo].[book_details] where Book_id=" + Convert.ToInt32(dataSet.Tables[0].Rows[i].ItemArray[0].ToString());
                SqlCommand cmd = new SqlCommand(query, sql);
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet ds = new DataSet();
                adapter.SelectCommand = cmd;
                adapter.Fill(ds);

                Label alpha_book = new Label();
                alpha_book.ForeColor = Color.FromArgb(64, 64, 64);
                alpha_book.Font = new Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
                alpha_book.BackColor = Color.Transparent;
                alpha_book.Size = new Size(24, 23);
                alpha_book.Location = new Point(lbl_alpha_x, lbl_alpha_y);
                alpha_book.Text = n.ToString();
                this.Controls.Add(alpha_book);

                PictureBox book = new PictureBox();
                book.Size = new Size(100, 120);
                book.BackgroundImageLayout = ImageLayout.Stretch;
                try
                {
                    book.BackgroundImage = Image.FromFile(ds.Tables[0].Rows[0].ItemArray[0].ToString());
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
                book_info.Text ="Book Id:           "+dataSet.Tables[0].Rows[i].ItemArray[0].ToString()+
                              "\nAuthor:            "+ds.Tables[0].Rows[0].ItemArray[2].ToString()+
                              "\nCategory:        "+ ds.Tables[0].Rows[0].ItemArray[3].ToString()+
                              "\nIssue date:       "+ dataSet.Tables[0].Rows[i].ItemArray[1].ToString()+
                              "\nReturn Status:   "+ dataSet.Tables[0].Rows[i].ItemArray[2].ToString();
                this.Controls.Add(book_info);

                pb_y += 170;
                lbl_info_y += 170;
                lbl_alpha_y += 170;
                n++;
                ds.Clear();
            }
            dataSet.Clear();
        }
    }
}
