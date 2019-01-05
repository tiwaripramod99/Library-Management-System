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
using System.IO;

namespace Library_Management_System
{
    public partial class Book_shelf_content : Form
    {
        static int count = Array_Size();
        SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pramod\Documents\book_details.mdf;Integrated Security=True;Connect Timeout=30");
        Bunifu.Framework.UI.BunifuImageButton[] btn_book = new Bunifu.Framework.UI.BunifuImageButton[count];
        Bunifu.Framework.UI.BunifuImageButton[] plus = new Bunifu.Framework.UI.BunifuImageButton[count];
        Bunifu.Framework.UI.BunifuCustomLabel[] lbl_book = new Bunifu.Framework.UI.BunifuCustomLabel[count];
        int[] id = new int[count];
        string user;
        public Book_shelf_content(string user_info)
        {
            user = user_info;
            InitializeComponent();
        }

        private void Book_shelf_content_Load(object sender, EventArgs e)
        {
            sql.Open();
            string query = "Select Book_title,Book_image,Book_id from [dbo].[book_details]";
            SqlCommand cmd = new SqlCommand(query, sql);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet dataSet = new DataSet();
            adapter.SelectCommand = cmd;
            adapter.Fill(dataSet);

            query = "Select Book_Id from [dbo].[wishlist] where Student_Id = "+Convert.ToInt64(user);
            cmd = new SqlCommand(query, sql);
            SqlDataAdapter sqlData = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sqlData.SelectCommand = cmd;
            sqlData.Fill(ds);

            int x=40, y_lab=150,y_butt=40,x_plus=155,y_plus=40;
            int n = 1;

            for(int i=0;i<count;i++)
            {
                btn_book[i] = new Bunifu.Framework.UI.BunifuImageButton();
                plus[i] = new Bunifu.Framework.UI.BunifuImageButton();
                lbl_book[i] = new Bunifu.Framework.UI.BunifuCustomLabel();

                this.Controls.Add(btn_book[i]);
                this.Controls.Add(plus[i]);
                this.Controls.Add(lbl_book[i]);

                btn_book[i].Name= "btn_book_" + n;
                plus[i].Name = "plus" + n;
                lbl_book[i].Name = "lbl_book_" + n;

                lbl_book[i].Text = dataSet.Tables[0].Rows[i].ItemArray[0].ToString();
                lbl_book[i].BackColor = Color.Transparent;
                lbl_book[i].ForeColor = Color.Black;
                lbl_book[i].TextAlign = ContentAlignment.TopLeft;
                lbl_book[i].Font = new Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lbl_book[i].Size = new Size(150, 80);
                lbl_book[i].Location = new Point(x, y_lab);

                btn_book[i].Size = new Size(109, 109);
                btn_book[i].Location = new Point(x, y_butt);
                try
                {
                    btn_book[i].Image = Image.FromFile(dataSet.Tables[0].Rows[i].ItemArray[1].ToString());
                    btn_book[i].ImageActive = Image.FromFile(dataSet.Tables[0].Rows[i].ItemArray[1].ToString());
                }
                catch
                {
                    btn_book[i].Image = global::Library_Management_System.Properties.Resources.Book;
                    btn_book[i].Image = global::Library_Management_System.Properties.Resources.Book;
                }
                btn_book[i].BackColor = Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
                btn_book[i].Click += book_open;

                bool flag = false;
                plus[i].Size = new Size(20, 20);
                plus[i].Location = new Point(x_plus, y_plus);
                for(int j=0;j< ds.Tables[0].Rows.Count;j++)
                {
                    if(dataSet.Tables[0].Rows[i].ItemArray[2].ToString()== ds.Tables[0].Rows[j].ItemArray[0].ToString())
                    {
                        flag = true;
                        break;
                    }
                }
                if(flag)
                {
                    plus[i].Image = Image.FromFile(@"F:\Sem-4\Library Management System\Library Management System\Resources\Ok_48px.png");
                    plus[i].ImageActive = Image.FromFile(@"F:\Sem-4\Library Management System\Library Management System\Resources\Ok_48px.png");
                }
                else
                {
                    plus[i].Image = Image.FromFile(@"F:\Sem-4\Library Management System\Library Management System\Resources\Plus_96px.png");
                    plus[i].ImageActive = Image.FromFile(@"F:\Sem-4\Library Management System\Library Management System\Resources\Plus_96px.png");
                }
                plus[i].BackColor = Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
                plus[i].Click += btn_Click;

                id[i] = Convert.ToInt32(dataSet.Tables[0].Rows[i].ItemArray[2].ToString());

                x += 195;
                x_plus += 195;
                if (x>637)
                {
                    y_lab += 200;
                    y_butt += 200;
                    y_plus += 200;
                    x = 40;
                    x_plus = 155;
                }
                n++;
            }
            ds.Clear();
            dataSet.Clear();
            sql.Close();
        }

        private void book_open(object sender,EventArgs e)
        {
            for (int i = 0; i < count; i++)
            {
                if (sender == btn_book[i])
                {
                    sql.Open();
                    try
                    {
                        string query = "Select Book_location from [dbo].[book_details] where Book_Id = " + id[i];
                        SqlCommand command = new SqlCommand(query, sql);
                        SqlDataReader reader = command.ExecuteReader();
                        reader.Read();
                        System.Diagnostics.Process.Start(reader[0].ToString());
                    }
                    catch
                    {
                        MessageBox.Show("Book not added yet!");
                    }
                    sql.Close();
                }
            }
        }

        private void btn_Click(object sender,EventArgs e)
        {
            SqlCommand command;
            SqlDataReader reader;
            string query;
            bool flag = false;
            for(int i=0;i<count;i++)
            {
                if(sender == plus[i])
                {
                    sql.Open();
                    query = "Select Book_Id from [dbo].[wishlist] where Book_Id = "+id[i]+" and Student_Id = "+Convert.ToInt64(user);
                    command = new SqlCommand(query, sql);
                    reader = command.ExecuteReader(); ;
                    reader.Read();
                    try
                    {
                        if (reader[0].ToString() != null) ;
                    }
                    catch
                    {
                        reader.Close();
                        flag = true;    
                    }
                    if(flag)
                    {
                        command = new SqlCommand();
                        query = "Insert into [dbo].[wishlist] values(" + Convert.ToInt64(user) + "," + id[i] + ")";
                        command = new SqlCommand(query, sql);
                        command.ExecuteNonQuery();
                    }
                    sql.Close();
                }
            }

        }

        private static int Array_Size()
        {
            try
            {
                SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pramod\Documents\book_details.mdf;Integrated Security=True;Connect Timeout=30");
                sql.Open();
                string query = "Select count(Book_Id) from [dbo].[book_details]";
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

                    