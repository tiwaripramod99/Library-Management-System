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
    public partial class Admin_Dashboard : Form
    {
        Login back;
        public Admin_Dashboard(Login reference)
        {
            back = reference;
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_add_user_Click(object sender, EventArgs e)
        {
            Add_user_template new_user = new Add_user_template(this);
            new_user.Show();
            this.Hide();
        }

        private void btn_minimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_issue_book_Click(object sender, EventArgs e)
        {
            Issue_book borrow = new Issue_book(this);
            borrow.Show();
            this.Hide();
        }

        private void btn_return_book_Click(object sender, EventArgs e)
        {
            Return_book return_Book = new Return_book(this);
            return_Book.Show();
            this.Hide();
        }

        private void btn_order_books_Click(object sender, EventArgs e)
        {
            Order_book order = new Order_book(this);
            order.Show();
            this.Hide();
        }

        private void btn_book_details_Click(object sender, EventArgs e)
        {
            Book_details book_Details = new Book_details(this);
            book_Details.Show();
            this.Hide();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            back.Show();
            this.Close();
        }

        private void btn_contactus_Click(object sender, EventArgs e)
        {
            Contact_us_admin contact = new Contact_us_admin(this);
            contact.Show();
            this.Hide();
        }

        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pramod\Documents\book_details.mdf;Integrated Security=True;Connect Timeout=30");
                sql.Open();

                string query = "Select sum(Current_copies) from [dbo].[book_details]";
                SqlCommand cmd = new SqlCommand(query, sql);
                int current = Convert.ToInt32(cmd.ExecuteScalar());

                query = "Select sum(Actual_copies) from [dbo].[book_details]";
                cmd = new SqlCommand(query, sql);
                int actual = Convert.ToInt32(cmd.ExecuteScalar());

                books_progress.MaxValue = actual;
                books_progress.Value = current;
                books_progress.LineThickness = 7;
                sql.Close();
            }
            catch
            {
                //do nothing
            }
        }

        private void btn_booklist_Click(object sender, EventArgs e)
        {
            Book_list book_List = new Book_list(this);
            book_List.Show();
            this.Hide();
        }

        private void btn_userlist_Click(object sender, EventArgs e)
        {
            User_list user = new User_list(this);
            user.Show();
            this.Hide();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Admin_Dashboard_Load(sender, e);
        }
    }
}
