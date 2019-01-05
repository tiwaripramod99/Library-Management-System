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
    public partial class wishlist_list : Form
    {
        static int count = Array_Size();
        SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pramod\Documents\book_details.mdf;Integrated Security=True;Connect Timeout=30");
        Bunifu.Framework.UI.BunifuImageButton[] minus = new Bunifu.Framework.UI.BunifuImageButton[count];
        int[] book_id = new int[count];
        public string user;
        static string user_id;
        public wishlist_list(string user_name)
        {
            user_id = user_name;
            user = user_name;
            InitializeComponent();
        }

        private void wishlist_list_Load(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pramod\Documents\book_details.mdf;Integrated Security=True;Connect Timeout=30");
            sql.Open();
            string quer = "Select Book_Id from [dbo].[wishlist] where Student_Id = "+Convert.ToInt64(user);
            SqlCommand comm = new SqlCommand(quer, sql);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataSet dataSet = new DataSet();
            dataAdapter.SelectCommand = comm;
            dataAdapter.Fill(dataSet);

            count = dataSet.Tables[0].Rows.Count;
            minus = new Bunifu.Framework.UI.BunifuImageButton[count];
            book_id = new int[count];

            int n=1;
            int pb_x = 100, lbl_info_x = 250, lbl_alpha_x = 30,x_plus = 206;
            int pb_y = 90, lbl_info_y = 90, lbl_alpha_y = 50, y_plus = 90;

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
                alpha_book.Size = new Size(50, 23);
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
                string id = dataSet.Tables[0].Rows[i].ItemArray[0].ToString();
                book_id[i] = Convert.ToInt32(id);
                string title = ds.Tables[0].Rows[0].ItemArray[1].ToString();
                string author = ds.Tables[0].Rows[0].ItemArray[2].ToString();
                string category = ds.Tables[0].Rows[0].ItemArray[3].ToString();
                book_info.Text = "Book Id:         " +id+
                               "\nBook Title:      " +title+
                               "\nAuthor:          " +author+ 
                               "\nCategory:     " + category;
                this.Controls.Add(book_info);

                minus[i] = new Bunifu.Framework.UI.BunifuImageButton();
                minus[i].Size = new Size(20, 20);
                minus[i].Location = new Point(x_plus, y_plus);
                minus[i].Image = Image.FromFile(@"F:\Sem-4\Library Management System\Library Management System\Resources\Minus_96px.png");
                minus[i].ImageActive = Image.FromFile(@"F:\Sem-4\Library Management System\Library Management System\Resources\Minus_96px.png");
                minus[i].BackColor = Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
                minus[i].Click += btn_Click;
                this.Controls.Add(minus[i]);

                pb_y += 170;
                lbl_info_y += 170;
                lbl_alpha_y += 170;
                y_plus += 170;
                n++;
                ds.Clear();
            }
            dataSet.Clear();
        }

        private static int Array_Size()
        {
            SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pramod\Documents\book_details.mdf;Integrated Security=True;Connect Timeout=30");
            sql.Open();
            string query = "Select count(Book_Id) from [dbo].[wishlist] where Student_Id="+Convert.ToInt64(user_id);
            SqlCommand cmd = new SqlCommand(query, sql);
            int si = Convert.ToInt32(cmd.ExecuteScalar());
            sql.Close();
            return si;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < count; i++)
            {
                if (sender == minus[i])
                {
                    sql.Open();
                    string query = "Delete from [dbo].[wishlist] where Book_Id=" + book_id[i];
                    SqlCommand cmd = new SqlCommand(query, sql);
                    cmd.ExecuteNonQuery();
                    sql.Close();
                    this.Refresh();
                }
            }
        }
    }
}
