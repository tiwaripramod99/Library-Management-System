namespace Library_Management_System
{
    partial class Admin_Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Dashboard));
            this.panel_side = new System.Windows.Forms.Panel();
            this.lbl_logout = new System.Windows.Forms.Label();
            this.lbl_prog_book = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel_title = new System.Windows.Forms.Panel();
            this.lbl_dash = new System.Windows.Forms.Label();
            this.panel_top = new System.Windows.Forms.Panel();
            this.lbl_add_user = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_issue_book = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_order_books = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_return_books = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_contactus = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_book_details = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_booklist = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_userlist = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_booklist = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_return_book = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_book_details = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_userlist = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_contactus = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_issue_book = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_order_books = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_add_user = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_refresh = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_minimise = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_close = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_logout = new Bunifu.Framework.UI.BunifuImageButton();
            this.books_progress = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.panel_side.SuspendLayout();
            this.panel_title.SuspendLayout();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_booklist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_return_book)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_book_details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_userlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_contactus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_issue_book)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_order_books)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_add_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_logout)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_side
            // 
            this.panel_side.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.panel_side.Controls.Add(this.lbl_logout);
            this.panel_side.Controls.Add(this.btn_logout);
            this.panel_side.Controls.Add(this.lbl_prog_book);
            this.panel_side.Controls.Add(this.books_progress);
            this.panel_side.Controls.Add(this.panel_title);
            this.panel_side.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_side.Location = new System.Drawing.Point(0, 0);
            this.panel_side.Name = "panel_side";
            this.panel_side.Size = new System.Drawing.Size(200, 600);
            this.panel_side.TabIndex = 0;
            // 
            // lbl_logout
            // 
            this.lbl_logout.AutoSize = true;
            this.lbl_logout.BackColor = System.Drawing.Color.Transparent;
            this.lbl_logout.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.lbl_logout.Location = new System.Drawing.Point(62, 530);
            this.lbl_logout.Name = "lbl_logout";
            this.lbl_logout.Size = new System.Drawing.Size(60, 17);
            this.lbl_logout.TabIndex = 0;
            this.lbl_logout.Text = "Log-Out";
            // 
            // lbl_prog_book
            // 
            this.lbl_prog_book.AutoSize = true;
            this.lbl_prog_book.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_prog_book.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prog_book.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.lbl_prog_book.Location = new System.Drawing.Point(12, 270);
            this.lbl_prog_book.Name = "lbl_prog_book";
            this.lbl_prog_book.Size = new System.Drawing.Size(163, 17);
            this.lbl_prog_book.TabIndex = 20;
            this.lbl_prog_book.Text = "Books Currently in library";
            // 
            // panel_title
            // 
            this.panel_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel_title.Controls.Add(this.lbl_dash);
            this.panel_title.Location = new System.Drawing.Point(0, 0);
            this.panel_title.Name = "panel_title";
            this.panel_title.Size = new System.Drawing.Size(200, 40);
            this.panel_title.TabIndex = 0;
            // 
            // lbl_dash
            // 
            this.lbl_dash.AutoSize = true;
            this.lbl_dash.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dash.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.lbl_dash.Location = new System.Drawing.Point(51, 11);
            this.lbl_dash.Name = "lbl_dash";
            this.lbl_dash.Size = new System.Drawing.Size(95, 21);
            this.lbl_dash.TabIndex = 0;
            this.lbl_dash.Text = "DashBoard";
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.Silver;
            this.panel_top.Controls.Add(this.btn_refresh);
            this.panel_top.Controls.Add(this.btn_minimise);
            this.panel_top.Controls.Add(this.btn_close);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(200, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(800, 40);
            this.panel_top.TabIndex = 1;
            // 
            // lbl_add_user
            // 
            this.lbl_add_user.AutoSize = true;
            this.lbl_add_user.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_add_user.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_add_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lbl_add_user.Location = new System.Drawing.Point(272, 254);
            this.lbl_add_user.Name = "lbl_add_user";
            this.lbl_add_user.Size = new System.Drawing.Size(113, 17);
            this.lbl_add_user.TabIndex = 14;
            this.lbl_add_user.Text = "User Registration";
            // 
            // lbl_issue_book
            // 
            this.lbl_issue_book.AutoSize = true;
            this.lbl_issue_book.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_issue_book.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lbl_issue_book.Location = new System.Drawing.Point(499, 254);
            this.lbl_issue_book.Name = "lbl_issue_book";
            this.lbl_issue_book.Size = new System.Drawing.Size(73, 17);
            this.lbl_issue_book.TabIndex = 15;
            this.lbl_issue_book.Text = "Issue Book";
            // 
            // lbl_order_books
            // 
            this.lbl_order_books.AutoSize = true;
            this.lbl_order_books.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_order_books.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lbl_order_books.Location = new System.Drawing.Point(300, 510);
            this.lbl_order_books.Name = "lbl_order_books";
            this.lbl_order_books.Size = new System.Drawing.Size(85, 17);
            this.lbl_order_books.TabIndex = 16;
            this.lbl_order_books.Text = "Order Books";
            // 
            // lbl_return_books
            // 
            this.lbl_return_books.AutoSize = true;
            this.lbl_return_books.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_return_books.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lbl_return_books.Location = new System.Drawing.Point(700, 254);
            this.lbl_return_books.Name = "lbl_return_books";
            this.lbl_return_books.Size = new System.Drawing.Size(85, 17);
            this.lbl_return_books.TabIndex = 17;
            this.lbl_return_books.Text = "Return Book";
            // 
            // lbl_contactus
            // 
            this.lbl_contactus.AutoSize = true;
            this.lbl_contactus.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contactus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lbl_contactus.Location = new System.Drawing.Point(889, 510);
            this.lbl_contactus.Name = "lbl_contactus";
            this.lbl_contactus.Size = new System.Drawing.Size(88, 17);
            this.lbl_contactus.TabIndex = 18;
            this.lbl_contactus.Text = "Contact - Us";
            // 
            // lbl_book_details
            // 
            this.lbl_book_details.AutoSize = true;
            this.lbl_book_details.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_book_details.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lbl_book_details.Location = new System.Drawing.Point(901, 254);
            this.lbl_book_details.Name = "lbl_book_details";
            this.lbl_book_details.Size = new System.Drawing.Size(87, 17);
            this.lbl_book_details.TabIndex = 19;
            this.lbl_book_details.Text = "Book Details";
            // 
            // lbl_booklist
            // 
            this.lbl_booklist.AutoSize = true;
            this.lbl_booklist.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_booklist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lbl_booklist.Location = new System.Drawing.Point(509, 510);
            this.lbl_booklist.Name = "lbl_booklist";
            this.lbl_booklist.Size = new System.Drawing.Size(68, 17);
            this.lbl_booklist.TabIndex = 17;
            this.lbl_booklist.Text = "Books List";
            // 
            // lbl_userlist
            // 
            this.lbl_userlist.AutoSize = true;
            this.lbl_userlist.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userlist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lbl_userlist.Location = new System.Drawing.Point(724, 510);
            this.lbl_userlist.Name = "lbl_userlist";
            this.lbl_userlist.Size = new System.Drawing.Size(61, 17);
            this.lbl_userlist.TabIndex = 18;
            this.lbl_userlist.Text = "Users List";
            // 
            // btn_booklist
            // 
            this.btn_booklist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.btn_booklist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_booklist.Image = global::Library_Management_System.Properties.Resources.book_details;
            this.btn_booklist.ImageActive = global::Library_Management_System.Properties.Resources.book_details;
            this.btn_booklist.Location = new System.Drawing.Point(442, 386);
            this.btn_booklist.Name = "btn_booklist";
            this.btn_booklist.Size = new System.Drawing.Size(109, 109);
            this.btn_booklist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_booklist.TabIndex = 13;
            this.btn_booklist.TabStop = false;
            this.btn_booklist.Zoom = 10;
            this.btn_booklist.Click += new System.EventHandler(this.btn_booklist_Click);
            // 
            // btn_return_book
            // 
            this.btn_return_book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.btn_return_book.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_return_book.Image = global::Library_Management_System.Properties.Resources.unnamed__10_;
            this.btn_return_book.ImageActive = global::Library_Management_System.Properties.Resources.unnamed__10_;
            this.btn_return_book.Location = new System.Drawing.Point(648, 131);
            this.btn_return_book.Name = "btn_return_book";
            this.btn_return_book.Size = new System.Drawing.Size(109, 109);
            this.btn_return_book.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_return_book.TabIndex = 13;
            this.btn_return_book.TabStop = false;
            this.btn_return_book.Zoom = 10;
            this.btn_return_book.Click += new System.EventHandler(this.btn_return_book_Click);
            // 
            // btn_book_details
            // 
            this.btn_book_details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.btn_book_details.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_book_details.Image = global::Library_Management_System.Properties.Resources.no_avatar;
            this.btn_book_details.ImageActive = global::Library_Management_System.Properties.Resources.no_avatar;
            this.btn_book_details.Location = new System.Drawing.Point(851, 131);
            this.btn_book_details.Name = "btn_book_details";
            this.btn_book_details.Size = new System.Drawing.Size(109, 109);
            this.btn_book_details.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_book_details.TabIndex = 12;
            this.btn_book_details.TabStop = false;
            this.btn_book_details.Zoom = 10;
            this.btn_book_details.Click += new System.EventHandler(this.btn_book_details_Click);
            // 
            // btn_userlist
            // 
            this.btn_userlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.btn_userlist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_userlist.Image = global::Library_Management_System.Properties.Resources.Circle_icons_profle_svg;
            this.btn_userlist.ImageActive = global::Library_Management_System.Properties.Resources.Circle_icons_profle_svg;
            this.btn_userlist.Location = new System.Drawing.Point(648, 386);
            this.btn_userlist.Name = "btn_userlist";
            this.btn_userlist.Size = new System.Drawing.Size(109, 109);
            this.btn_userlist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_userlist.TabIndex = 11;
            this.btn_userlist.TabStop = false;
            this.btn_userlist.Zoom = 10;
            this.btn_userlist.Click += new System.EventHandler(this.btn_userlist_Click);
            // 
            // btn_contactus
            // 
            this.btn_contactus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.btn_contactus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_contactus.Image = global::Library_Management_System.Properties.Resources.Mobile_Smartphone_icon;
            this.btn_contactus.ImageActive = global::Library_Management_System.Properties.Resources.Mobile_Smartphone_icon;
            this.btn_contactus.Location = new System.Drawing.Point(851, 386);
            this.btn_contactus.Name = "btn_contactus";
            this.btn_contactus.Size = new System.Drawing.Size(109, 109);
            this.btn_contactus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_contactus.TabIndex = 11;
            this.btn_contactus.TabStop = false;
            this.btn_contactus.Zoom = 10;
            this.btn_contactus.Click += new System.EventHandler(this.btn_contactus_Click);
            // 
            // btn_issue_book
            // 
            this.btn_issue_book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.btn_issue_book.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_issue_book.Image = global::Library_Management_System.Properties.Resources.unnamed__1_;
            this.btn_issue_book.ImageActive = global::Library_Management_System.Properties.Resources.unnamed__1_;
            this.btn_issue_book.Location = new System.Drawing.Point(442, 131);
            this.btn_issue_book.Name = "btn_issue_book";
            this.btn_issue_book.Size = new System.Drawing.Size(109, 109);
            this.btn_issue_book.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_issue_book.TabIndex = 10;
            this.btn_issue_book.TabStop = false;
            this.btn_issue_book.Zoom = 10;
            this.btn_issue_book.Click += new System.EventHandler(this.btn_issue_book_Click);
            // 
            // btn_order_books
            // 
            this.btn_order_books.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.btn_order_books.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_order_books.Image = ((System.Drawing.Image)(resources.GetObject("btn_order_books.Image")));
            this.btn_order_books.ImageActive = global::Library_Management_System.Properties.Resources.download_ebook_icon;
            this.btn_order_books.Location = new System.Drawing.Point(235, 386);
            this.btn_order_books.Name = "btn_order_books";
            this.btn_order_books.Size = new System.Drawing.Size(109, 109);
            this.btn_order_books.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_order_books.TabIndex = 9;
            this.btn_order_books.TabStop = false;
            this.btn_order_books.Zoom = 10;
            this.btn_order_books.Click += new System.EventHandler(this.btn_order_books_Click);
            // 
            // btn_add_user
            // 
            this.btn_add_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.btn_add_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add_user.Image = global::Library_Management_System.Properties.Resources.unnamed;
            this.btn_add_user.ImageActive = global::Library_Management_System.Properties.Resources.unnamed;
            this.btn_add_user.InitialImage = null;
            this.btn_add_user.Location = new System.Drawing.Point(235, 131);
            this.btn_add_user.Name = "btn_add_user";
            this.btn_add_user.Size = new System.Drawing.Size(109, 109);
            this.btn_add_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_add_user.TabIndex = 8;
            this.btn_add_user.TabStop = false;
            this.btn_add_user.Zoom = 10;
            this.btn_add_user.Click += new System.EventHandler(this.btn_add_user_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.Transparent;
            this.btn_refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_refresh.Image = global::Library_Management_System.Properties.Resources.Refresh_96px_3;
            this.btn_refresh.ImageActive = global::Library_Management_System.Properties.Resources.Refresh_96px_3;
            this.btn_refresh.Location = new System.Drawing.Point(692, 5);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(31, 31);
            this.btn_refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_refresh.TabIndex = 22;
            this.btn_refresh.TabStop = false;
            this.btn_refresh.Zoom = 10;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_minimise
            // 
            this.btn_minimise.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_minimise.Image = global::Library_Management_System.Properties.Resources.min2;
            this.btn_minimise.ImageActive = global::Library_Management_System.Properties.Resources.min1;
            this.btn_minimise.Location = new System.Drawing.Point(729, 5);
            this.btn_minimise.Name = "btn_minimise";
            this.btn_minimise.Size = new System.Drawing.Size(31, 31);
            this.btn_minimise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_minimise.TabIndex = 22;
            this.btn_minimise.TabStop = false;
            this.btn_minimise.Zoom = 10;
            this.btn_minimise.Click += new System.EventHandler(this.btn_minimise_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.Image = global::Library_Management_System.Properties.Resources.cross2;
            this.btn_close.ImageActive = global::Library_Management_System.Properties.Resources.cross1;
            this.btn_close.Location = new System.Drawing.Point(766, 5);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(31, 31);
            this.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_close.TabIndex = 22;
            this.btn_close.TabStop = false;
            this.btn_close.Zoom = 10;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Transparent;
            this.btn_logout.Image = global::Library_Management_System.Properties.Resources.Exit_96px;
            this.btn_logout.ImageActive = global::Library_Management_System.Properties.Resources.Export_96px_2;
            this.btn_logout.Location = new System.Drawing.Point(55, 456);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(71, 71);
            this.btn_logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_logout.TabIndex = 21;
            this.btn_logout.TabStop = false;
            this.btn_logout.Zoom = 10;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // books_progress
            // 
            this.books_progress.animated = false;
            this.books_progress.animationIterval = 5;
            this.books_progress.animationSpeed = 300;
            this.books_progress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.books_progress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("books_progress.BackgroundImage")));
            this.books_progress.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.books_progress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.books_progress.LabelVisible = true;
            this.books_progress.LineProgressThickness = 8;
            this.books_progress.LineThickness = 5;
            this.books_progress.Location = new System.Drawing.Point(29, 131);
            this.books_progress.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.books_progress.MaxValue = 100;
            this.books_progress.Name = "books_progress";
            this.books_progress.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.books_progress.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(65)))), ((int)(((byte)(84)))));
            this.books_progress.Size = new System.Drawing.Size(140, 140);
            this.books_progress.TabIndex = 1;
            this.books_progress.Value = 0;
            // 
            // Admin_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.lbl_book_details);
            this.Controls.Add(this.lbl_userlist);
            this.Controls.Add(this.lbl_contactus);
            this.Controls.Add(this.lbl_booklist);
            this.Controls.Add(this.lbl_return_books);
            this.Controls.Add(this.lbl_order_books);
            this.Controls.Add(this.lbl_issue_book);
            this.Controls.Add(this.lbl_add_user);
            this.Controls.Add(this.btn_booklist);
            this.Controls.Add(this.btn_return_book);
            this.Controls.Add(this.btn_book_details);
            this.Controls.Add(this.btn_userlist);
            this.Controls.Add(this.btn_contactus);
            this.Controls.Add(this.btn_issue_book);
            this.Controls.Add(this.btn_order_books);
            this.Controls.Add(this.btn_add_user);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.panel_side);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Dashboard";
            this.Load += new System.EventHandler(this.Admin_Dashboard_Load);
            this.panel_side.ResumeLayout(false);
            this.panel_side.PerformLayout();
            this.panel_title.ResumeLayout(false);
            this.panel_title.PerformLayout();
            this.panel_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_booklist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_return_book)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_book_details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_userlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_contactus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_issue_book)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_order_books)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_add_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_logout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_side;
        private System.Windows.Forms.Panel panel_title;
        private System.Windows.Forms.Label lbl_dash;
        private System.Windows.Forms.Panel panel_top;
        private Bunifu.Framework.UI.BunifuImageButton btn_add_user;
        private Bunifu.Framework.UI.BunifuImageButton btn_order_books;
        private Bunifu.Framework.UI.BunifuImageButton btn_issue_book;
        private Bunifu.Framework.UI.BunifuImageButton btn_contactus;
        private Bunifu.Framework.UI.BunifuImageButton btn_book_details;
        private Bunifu.Framework.UI.BunifuImageButton btn_return_book;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_add_user;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_issue_book;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_order_books;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_return_books;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_contactus;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_book_details;
        private Bunifu.Framework.UI.BunifuCircleProgressbar books_progress;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_prog_book;
        private Bunifu.Framework.UI.BunifuImageButton btn_close;
        private Bunifu.Framework.UI.BunifuImageButton btn_minimise;
        private Bunifu.Framework.UI.BunifuImageButton btn_logout;
        private System.Windows.Forms.Label lbl_logout;
        private Bunifu.Framework.UI.BunifuImageButton btn_booklist;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_booklist;
        private Bunifu.Framework.UI.BunifuImageButton btn_userlist;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_userlist;
        private Bunifu.Framework.UI.BunifuImageButton btn_refresh;
    }
}