namespace Library_Management_System
{
    partial class User_Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Dashboard));
            this.panel_side = new System.Windows.Forms.Panel();
            this.lbl_logout = new System.Windows.Forms.Label();
            this.btn_logout = new Bunifu.Framework.UI.BunifuImageButton();
            this.pb_membership = new System.Windows.Forms.PictureBox();
            this.lbl_membership = new System.Windows.Forms.Label();
            this.panel_title = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_dash = new System.Windows.Forms.Label();
            this.lbl_add_user = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel_top = new System.Windows.Forms.Panel();
            this.btn_close = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_minimise = new Bunifu.Framework.UI.BunifuImageButton();
            this.profile_pic_elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pb_profile_img = new System.Windows.Forms.PictureBox();
            this.menu_extras = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.uploadProfilePictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_profile = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lbl_user = new System.Windows.Forms.Label();
            this.books_progress = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.btn_issued = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_wishlist = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_contact = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_read_book = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_refresh = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel_side.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_membership)).BeginInit();
            this.panel_title.SuspendLayout();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_profile_img)).BeginInit();
            this.menu_extras.SuspendLayout();
            this.panel_profile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_issued)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_wishlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_contact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_read_book)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_refresh)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_side
            // 
            this.panel_side.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.panel_side.Controls.Add(this.lbl_logout);
            this.panel_side.Controls.Add(this.btn_logout);
            this.panel_side.Controls.Add(this.pb_membership);
            this.panel_side.Controls.Add(this.lbl_membership);
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
            this.lbl_logout.Location = new System.Drawing.Point(64, 523);
            this.lbl_logout.Name = "lbl_logout";
            this.lbl_logout.Size = new System.Drawing.Size(60, 17);
            this.lbl_logout.TabIndex = 22;
            this.lbl_logout.Text = "Log-Out";
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Transparent;
            this.btn_logout.Image = global::Library_Management_System.Properties.Resources.Exit_96px;
            this.btn_logout.ImageActive = global::Library_Management_System.Properties.Resources.Export_96px_2;
            this.btn_logout.Location = new System.Drawing.Point(58, 449);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(71, 71);
            this.btn_logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_logout.TabIndex = 23;
            this.btn_logout.TabStop = false;
            this.btn_logout.Zoom = 10;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // pb_membership
            // 
            this.pb_membership.BackColor = System.Drawing.Color.Transparent;
            this.pb_membership.BackgroundImage = global::Library_Management_System.Properties.Resources.prime_user;
            this.pb_membership.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_membership.Location = new System.Drawing.Point(33, 188);
            this.pb_membership.Name = "pb_membership";
            this.pb_membership.Size = new System.Drawing.Size(126, 121);
            this.pb_membership.TabIndex = 1;
            this.pb_membership.TabStop = false;
            // 
            // lbl_membership
            // 
            this.lbl_membership.AutoSize = true;
            this.lbl_membership.BackColor = System.Drawing.Color.Transparent;
            this.lbl_membership.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_membership.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(211)))), ((int)(((byte)(110)))));
            this.lbl_membership.Location = new System.Drawing.Point(65, 324);
            this.lbl_membership.Name = "lbl_membership";
            this.lbl_membership.Size = new System.Drawing.Size(64, 22);
            this.lbl_membership.TabIndex = 3;
            this.lbl_membership.Text = "Prime";
            // 
            // panel_title
            // 
            this.panel_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel_title.Controls.Add(this.panel3);
            this.panel_title.Controls.Add(this.lbl_dash);
            this.panel_title.Location = new System.Drawing.Point(0, 0);
            this.panel_title.Name = "panel_title";
            this.panel_title.Size = new System.Drawing.Size(200, 40);
            this.panel_title.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(200, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 30);
            this.panel3.TabIndex = 4;
            // 
            // lbl_dash
            // 
            this.lbl_dash.AutoSize = true;
            this.lbl_dash.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dash.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.lbl_dash.Location = new System.Drawing.Point(39, 9);
            this.lbl_dash.Name = "lbl_dash";
            this.lbl_dash.Size = new System.Drawing.Size(95, 21);
            this.lbl_dash.TabIndex = 3;
            this.lbl_dash.Text = "DashBoard";
            // 
            // lbl_add_user
            // 
            this.lbl_add_user.AutoSize = true;
            this.lbl_add_user.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_add_user.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_add_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lbl_add_user.Location = new System.Drawing.Point(468, 402);
            this.lbl_add_user.Name = "lbl_add_user";
            this.lbl_add_user.Size = new System.Drawing.Size(78, 17);
            this.lbl_add_user.TabIndex = 15;
            this.lbl_add_user.Text = "Read Book";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(731, 402);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(101, 34);
            this.bunifuCustomLabel1.TabIndex = 16;
            this.bunifuCustomLabel1.Text = "Books Issued \r\n   From Wishlist";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(344, 561);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(87, 17);
            this.bunifuCustomLabel2.TabIndex = 17;
            this.bunifuCustomLabel2.Text = "Issued Books";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(627, 561);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(53, 17);
            this.bunifuCustomLabel3.TabIndex = 18;
            this.bunifuCustomLabel3.Text = "Wishlist";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(853, 561);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(88, 17);
            this.bunifuCustomLabel4.TabIndex = 19;
            this.bunifuCustomLabel4.Text = "Contact - Us";
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.Silver;
            this.panel_top.Controls.Add(this.btn_refresh);
            this.panel_top.Controls.Add(this.btn_close);
            this.panel_top.Controls.Add(this.btn_minimise);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(200, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(800, 40);
            this.panel_top.TabIndex = 20;
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
            this.btn_close.TabIndex = 21;
            this.btn_close.TabStop = false;
            this.btn_close.Zoom = 10;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
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
            this.btn_minimise.TabIndex = 21;
            this.btn_minimise.TabStop = false;
            this.btn_minimise.Zoom = 10;
            this.btn_minimise.Click += new System.EventHandler(this.btn_minimise_Click);
            // 
            // profile_pic_elipse
            // 
            this.profile_pic_elipse.ElipseRadius = 300;
            this.profile_pic_elipse.TargetControl = this.pb_profile_img;
            // 
            // pb_profile_img
            // 
            this.pb_profile_img.BackColor = System.Drawing.Color.Transparent;
            this.pb_profile_img.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_profile_img.BackgroundImage")));
            this.pb_profile_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_profile_img.Location = new System.Drawing.Point(576, 4);
            this.pb_profile_img.Name = "pb_profile_img";
            this.pb_profile_img.Size = new System.Drawing.Size(191, 191);
            this.pb_profile_img.TabIndex = 21;
            this.pb_profile_img.TabStop = false;
            this.pb_profile_img.ContextMenuStripChanged += new System.EventHandler(this.pb_profile_img_ContextMenuStripChanged);
            // 
            // menu_extras
            // 
            this.menu_extras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.menu_extras.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem,
            this.toolStripSeparator1,
            this.uploadProfilePictureToolStripMenuItem});
            this.menu_extras.Name = "menu_extras";
            this.menu_extras.Size = new System.Drawing.Size(190, 54);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.changePasswordToolStripMenuItem.Image = global::Library_Management_System.Properties.Resources.Lock_48px;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(186, 6);
            // 
            // uploadProfilePictureToolStripMenuItem
            // 
            this.uploadProfilePictureToolStripMenuItem.Image = global::Library_Management_System.Properties.Resources.Circled_Up_52px;
            this.uploadProfilePictureToolStripMenuItem.Name = "uploadProfilePictureToolStripMenuItem";
            this.uploadProfilePictureToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.uploadProfilePictureToolStripMenuItem.Text = "Upload Profile Picture";
            this.uploadProfilePictureToolStripMenuItem.Click += new System.EventHandler(this.uploadProfilePictureToolStripMenuItem_Click);
            // 
            // panel_profile
            // 
            this.panel_profile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_profile.BackgroundImage")));
            this.panel_profile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_profile.Controls.Add(this.lbl_user);
            this.panel_profile.Controls.Add(this.pb_profile_img);
            this.panel_profile.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_profile.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.panel_profile.GradientBottomRight = System.Drawing.Color.Black;
            this.panel_profile.GradientTopLeft = System.Drawing.Color.White;
            this.panel_profile.GradientTopRight = System.Drawing.Color.White;
            this.panel_profile.Location = new System.Drawing.Point(200, 40);
            this.panel_profile.Name = "panel_profile";
            this.panel_profile.Quality = 10;
            this.panel_profile.Size = new System.Drawing.Size(800, 200);
            this.panel_profile.TabIndex = 22;
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.BackColor = System.Drawing.Color.Transparent;
            this.lbl_user.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lbl_user.Location = new System.Drawing.Point(184, 82);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(237, 39);
            this.lbl_user.TabIndex = 3;
            this.lbl_user.Text = "Pramod Tiwari";
            // 
            // books_progress
            // 
            this.books_progress.animated = false;
            this.books_progress.animationIterval = 5;
            this.books_progress.animationSpeed = 300;
            this.books_progress.BackColor = System.Drawing.Color.Transparent;
            this.books_progress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("books_progress.BackgroundImage")));
            this.books_progress.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.books_progress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.books_progress.LabelVisible = true;
            this.books_progress.LineProgressThickness = 8;
            this.books_progress.LineThickness = 5;
            this.books_progress.Location = new System.Drawing.Point(673, 263);
            this.books_progress.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.books_progress.MaxValue = 100;
            this.books_progress.Name = "books_progress";
            this.books_progress.ProgressBackColor = System.Drawing.Color.Gray;
            this.books_progress.ProgressColor = System.Drawing.Color.SteelBlue;
            this.books_progress.Size = new System.Drawing.Size(130, 130);
            this.books_progress.TabIndex = 14;
            this.books_progress.Value = 0;
            // 
            // btn_issued
            // 
            this.btn_issued.BackColor = System.Drawing.Color.Transparent;
            this.btn_issued.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_issued.Image = global::Library_Management_System.Properties.Resources.unnamed__8_;
            this.btn_issued.ImageActive = global::Library_Management_System.Properties.Resources.unnamed__8_;
            this.btn_issued.InitialImage = null;
            this.btn_issued.Location = new System.Drawing.Point(277, 449);
            this.btn_issued.Name = "btn_issued";
            this.btn_issued.Size = new System.Drawing.Size(109, 109);
            this.btn_issued.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_issued.TabIndex = 13;
            this.btn_issued.TabStop = false;
            this.btn_issued.Zoom = 10;
            this.btn_issued.Click += new System.EventHandler(this.btn_issued_Click);
            // 
            // btn_wishlist
            // 
            this.btn_wishlist.BackColor = System.Drawing.Color.Transparent;
            this.btn_wishlist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_wishlist.Image = global::Library_Management_System.Properties.Resources.unnamed__3_;
            this.btn_wishlist.ImageActive = global::Library_Management_System.Properties.Resources.unnamed__3_;
            this.btn_wishlist.InitialImage = null;
            this.btn_wishlist.Location = new System.Drawing.Point(546, 449);
            this.btn_wishlist.Name = "btn_wishlist";
            this.btn_wishlist.Size = new System.Drawing.Size(109, 109);
            this.btn_wishlist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_wishlist.TabIndex = 12;
            this.btn_wishlist.TabStop = false;
            this.btn_wishlist.Zoom = 10;
            this.btn_wishlist.Click += new System.EventHandler(this.btn_wishlist_Click);
            // 
            // btn_contact
            // 
            this.btn_contact.BackColor = System.Drawing.Color.Transparent;
            this.btn_contact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_contact.Image = global::Library_Management_System.Properties.Resources.unnamed__6_;
            this.btn_contact.ImageActive = global::Library_Management_System.Properties.Resources.unnamed__6_;
            this.btn_contact.InitialImage = null;
            this.btn_contact.Location = new System.Drawing.Point(791, 449);
            this.btn_contact.Name = "btn_contact";
            this.btn_contact.Size = new System.Drawing.Size(109, 109);
            this.btn_contact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_contact.TabIndex = 11;
            this.btn_contact.TabStop = false;
            this.btn_contact.Zoom = 10;
            this.btn_contact.Click += new System.EventHandler(this.btn_contact_Click);
            // 
            // btn_read_book
            // 
            this.btn_read_book.BackColor = System.Drawing.Color.Transparent;
            this.btn_read_book.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_read_book.Image = global::Library_Management_System.Properties.Resources.unnamed__7_;
            this.btn_read_book.ImageActive = global::Library_Management_System.Properties.Resources.unnamed__7_;
            this.btn_read_book.InitialImage = null;
            this.btn_read_book.Location = new System.Drawing.Point(391, 284);
            this.btn_read_book.Name = "btn_read_book";
            this.btn_read_book.Size = new System.Drawing.Size(109, 109);
            this.btn_read_book.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_read_book.TabIndex = 9;
            this.btn_read_book.TabStop = false;
            this.btn_read_book.Zoom = 10;
            this.btn_read_book.Click += new System.EventHandler(this.btn_read_book_Click);
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
            this.btn_refresh.TabIndex = 23;
            this.btn_refresh.TabStop = false;
            this.btn_refresh.Zoom = 10;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // User_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.ContextMenuStrip = this.menu_extras;
            this.Controls.Add(this.panel_profile);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.lbl_add_user);
            this.Controls.Add(this.books_progress);
            this.Controls.Add(this.btn_issued);
            this.Controls.Add(this.btn_wishlist);
            this.Controls.Add(this.btn_contact);
            this.Controls.Add(this.btn_read_book);
            this.Controls.Add(this.panel_side);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "User_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User_Dashboard";
            this.Load += new System.EventHandler(this.User_Dashboard_Load);
            this.panel_side.ResumeLayout(false);
            this.panel_side.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_membership)).EndInit();
            this.panel_title.ResumeLayout(false);
            this.panel_title.PerformLayout();
            this.panel_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_profile_img)).EndInit();
            this.menu_extras.ResumeLayout(false);
            this.panel_profile.ResumeLayout(false);
            this.panel_profile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_issued)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_wishlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_contact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_read_book)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_refresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_side;
        private System.Windows.Forms.Panel panel_title;
        private System.Windows.Forms.PictureBox pb_membership;
        private System.Windows.Forms.Label lbl_dash;
        private Bunifu.Framework.UI.BunifuImageButton btn_read_book;
        private Bunifu.Framework.UI.BunifuImageButton btn_contact;
        private Bunifu.Framework.UI.BunifuImageButton btn_wishlist;
        private Bunifu.Framework.UI.BunifuImageButton btn_issued;
        private Bunifu.Framework.UI.BunifuCircleProgressbar books_progress;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_add_user;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label lbl_membership;
        private Bunifu.Framework.UI.BunifuImageButton btn_minimise;
        private Bunifu.Framework.UI.BunifuImageButton btn_close;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.PictureBox pb_profile_img;
        private Bunifu.Framework.UI.BunifuGradientPanel panel_profile;
        private System.Windows.Forms.Label lbl_logout;
        private Bunifu.Framework.UI.BunifuImageButton btn_logout;
        private Bunifu.Framework.UI.BunifuElipse profile_pic_elipse;
        private System.Windows.Forms.ContextMenuStrip menu_extras;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uploadProfilePictureToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private Bunifu.Framework.UI.BunifuImageButton btn_refresh;
    }
}