namespace Library_Management_System
{
    partial class Book_details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book_details));
            this.panel_side = new System.Windows.Forms.Panel();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.panel_title = new System.Windows.Forms.Panel();
            this.lbl_dash = new System.Windows.Forms.Label();
            this.lbl_book_img = new System.Windows.Forms.Label();
            this.panel_top = new System.Windows.Forms.Panel();
            this.btn_back = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_minimise = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_close = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbl_book_id = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_book_title = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbl_author = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_book_title = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_book_id = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbl_copies = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_author = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbl_category = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_copies = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_category = new System.Windows.Forms.ComboBox();
            this.lbl_add_user = new System.Windows.Forms.Label();
            this.err_book_id = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_book_title = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_pub_year = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_category = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_copies = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btn_book_add = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_book_img = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_add_user = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel_side.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.panel_title.SuspendLayout();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_book_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_book_title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_pub_year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_category)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_copies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_book_add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_book_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_add_user)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_side
            // 
            this.panel_side.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.panel_side.Controls.Add(this.pb_logo);
            this.panel_side.Controls.Add(this.panel_title);
            this.panel_side.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_side.Location = new System.Drawing.Point(0, 0);
            this.panel_side.Name = "panel_side";
            this.panel_side.Size = new System.Drawing.Size(200, 600);
            this.panel_side.TabIndex = 0;
            // 
            // pb_logo
            // 
            this.pb_logo.BackgroundImage = global::Library_Management_System.Properties.Resources.no_avatar;
            this.pb_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_logo.Location = new System.Drawing.Point(37, 243);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(129, 129);
            this.pb_logo.TabIndex = 35;
            this.pb_logo.TabStop = false;
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
            this.lbl_dash.Location = new System.Drawing.Point(53, 10);
            this.lbl_dash.Name = "lbl_dash";
            this.lbl_dash.Size = new System.Drawing.Size(103, 21);
            this.lbl_dash.TabIndex = 1;
            this.lbl_dash.Text = "Book Details";
            // 
            // lbl_book_img
            // 
            this.lbl_book_img.AutoSize = true;
            this.lbl_book_img.BackColor = System.Drawing.Color.Transparent;
            this.lbl_book_img.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_book_img.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lbl_book_img.Location = new System.Drawing.Point(737, 577);
            this.lbl_book_img.Name = "lbl_book_img";
            this.lbl_book_img.Size = new System.Drawing.Size(74, 17);
            this.lbl_book_img.TabIndex = 34;
            this.lbl_book_img.Text = "Add Image";
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.Silver;
            this.panel_top.Controls.Add(this.btn_back);
            this.panel_top.Controls.Add(this.btn_minimise);
            this.panel_top.Controls.Add(this.btn_close);
            this.panel_top.Location = new System.Drawing.Point(200, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(800, 40);
            this.panel_top.TabIndex = 1;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.Image = global::Library_Management_System.Properties.Resources.left2;
            this.btn_back.ImageActive = global::Library_Management_System.Properties.Resources.left11;
            this.btn_back.Location = new System.Drawing.Point(692, 5);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(31, 31);
            this.btn_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_back.TabIndex = 25;
            this.btn_back.TabStop = false;
            this.btn_back.Zoom = 10;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_minimise
            // 
            this.btn_minimise.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimise.Image = global::Library_Management_System.Properties.Resources.min2;
            this.btn_minimise.ImageActive = global::Library_Management_System.Properties.Resources.min1;
            this.btn_minimise.Location = new System.Drawing.Point(729, 5);
            this.btn_minimise.Name = "btn_minimise";
            this.btn_minimise.Size = new System.Drawing.Size(31, 31);
            this.btn_minimise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_minimise.TabIndex = 26;
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
            this.btn_close.TabIndex = 23;
            this.btn_close.TabStop = false;
            this.btn_close.Zoom = 10;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_book_id
            // 
            this.lbl_book_id.AutoSize = true;
            this.lbl_book_id.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_book_id.Location = new System.Drawing.Point(321, 97);
            this.lbl_book_id.Name = "lbl_book_id";
            this.lbl_book_id.Size = new System.Drawing.Size(65, 20);
            this.lbl_book_id.TabIndex = 17;
            this.lbl_book_id.Text = "Book Id";
            // 
            // txt_book_title
            // 
            this.txt_book_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.txt_book_title.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_book_title.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_book_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_book_title.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.txt_book_title.HintText = "Ex.    Let Us C#";
            this.txt_book_title.isPassword = false;
            this.txt_book_title.LineFocusedColor = System.Drawing.Color.Gray;
            this.txt_book_title.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_book_title.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txt_book_title.LineThickness = 3;
            this.txt_book_title.Location = new System.Drawing.Point(490, 179);
            this.txt_book_title.Margin = new System.Windows.Forms.Padding(4);
            this.txt_book_title.Name = "txt_book_title";
            this.txt_book_title.Size = new System.Drawing.Size(379, 33);
            this.txt_book_title.TabIndex = 19;
            this.txt_book_title.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbl_author
            // 
            this.lbl_author.AutoSize = true;
            this.lbl_author.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_author.Location = new System.Drawing.Point(321, 291);
            this.lbl_author.Name = "lbl_author";
            this.lbl_author.Size = new System.Drawing.Size(58, 20);
            this.lbl_author.TabIndex = 17;
            this.lbl_author.Text = "Author";
            // 
            // lbl_book_title
            // 
            this.lbl_book_title.AutoSize = true;
            this.lbl_book_title.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_book_title.Location = new System.Drawing.Point(321, 192);
            this.lbl_book_title.Name = "lbl_book_title";
            this.lbl_book_title.Size = new System.Drawing.Size(76, 20);
            this.lbl_book_title.TabIndex = 17;
            this.lbl_book_title.Text = "Book Title";
            // 
            // txt_book_id
            // 
            this.txt_book_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.txt_book_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_book_id.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_book_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_book_id.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.txt_book_id.HintText = "Ex.    1001";
            this.txt_book_id.isPassword = false;
            this.txt_book_id.LineFocusedColor = System.Drawing.Color.Gray;
            this.txt_book_id.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_book_id.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txt_book_id.LineThickness = 3;
            this.txt_book_id.Location = new System.Drawing.Point(490, 84);
            this.txt_book_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_book_id.Name = "txt_book_id";
            this.txt_book_id.Size = new System.Drawing.Size(379, 33);
            this.txt_book_id.TabIndex = 18;
            this.txt_book_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbl_copies
            // 
            this.lbl_copies.AutoSize = true;
            this.lbl_copies.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_copies.Location = new System.Drawing.Point(321, 474);
            this.lbl_copies.Name = "lbl_copies";
            this.lbl_copies.Size = new System.Drawing.Size(60, 20);
            this.lbl_copies.TabIndex = 17;
            this.lbl_copies.Text = "Copies";
            // 
            // txt_author
            // 
            this.txt_author.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.txt_author.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_author.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_author.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_author.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.txt_author.HintText = "Ex.   Kal Wardin";
            this.txt_author.isPassword = false;
            this.txt_author.LineFocusedColor = System.Drawing.Color.Gray;
            this.txt_author.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_author.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txt_author.LineThickness = 3;
            this.txt_author.Location = new System.Drawing.Point(490, 278);
            this.txt_author.Margin = new System.Windows.Forms.Padding(4);
            this.txt_author.Name = "txt_author";
            this.txt_author.Size = new System.Drawing.Size(379, 33);
            this.txt_author.TabIndex = 20;
            this.txt_author.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_category.Location = new System.Drawing.Point(321, 382);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(116, 20);
            this.lbl_category.TabIndex = 17;
            this.lbl_category.Text = "Category Type";
            // 
            // txt_copies
            // 
            this.txt_copies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.txt_copies.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_copies.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_copies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_copies.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.txt_copies.HintText = "Ex.    5";
            this.txt_copies.isPassword = false;
            this.txt_copies.LineFocusedColor = System.Drawing.Color.Gray;
            this.txt_copies.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_copies.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txt_copies.LineThickness = 3;
            this.txt_copies.Location = new System.Drawing.Point(490, 461);
            this.txt_copies.Margin = new System.Windows.Forms.Padding(4);
            this.txt_copies.Name = "txt_copies";
            this.txt_copies.Size = new System.Drawing.Size(379, 33);
            this.txt_copies.TabIndex = 22;
            this.txt_copies.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_category
            // 
            this.txt_category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_category.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.txt_category.FormattingEnabled = true;
            this.txt_category.Items.AddRange(new object[] {
            "Reference Book",
            "General",
            "Biography",
            "Auto-Biography",
            "Fiction",
            "Non Fiction",
            "Magazine",
            "Year Book"});
            this.txt_category.Location = new System.Drawing.Point(490, 377);
            this.txt_category.Name = "txt_category";
            this.txt_category.Size = new System.Drawing.Size(379, 25);
            this.txt_category.TabIndex = 21;
            // 
            // lbl_add_user
            // 
            this.lbl_add_user.AutoSize = true;
            this.lbl_add_user.BackColor = System.Drawing.Color.Transparent;
            this.lbl_add_user.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_add_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lbl_add_user.Location = new System.Drawing.Point(922, 577);
            this.lbl_add_user.Name = "lbl_add_user";
            this.lbl_add_user.Size = new System.Drawing.Size(71, 17);
            this.lbl_add_user.TabIndex = 28;
            this.lbl_add_user.Text = "Add Book";
            // 
            // err_book_id
            // 
            this.err_book_id.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.err_book_id.ContainerControl = this.txt_book_id;
            this.err_book_id.Icon = ((System.Drawing.Icon)(resources.GetObject("err_book_id.Icon")));
            // 
            // err_book_title
            // 
            this.err_book_title.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.err_book_title.ContainerControl = this.txt_book_title;
            this.err_book_title.Icon = ((System.Drawing.Icon)(resources.GetObject("err_book_title.Icon")));
            // 
            // err_pub_year
            // 
            this.err_pub_year.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.err_pub_year.ContainerControl = this.txt_author;
            this.err_pub_year.Icon = ((System.Drawing.Icon)(resources.GetObject("err_pub_year.Icon")));
            // 
            // err_category
            // 
            this.err_category.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.err_category.ContainerControl = this;
            this.err_category.Icon = ((System.Drawing.Icon)(resources.GetObject("err_category.Icon")));
            // 
            // err_copies
            // 
            this.err_copies.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.err_copies.ContainerControl = this.txt_copies;
            this.err_copies.Icon = ((System.Drawing.Icon)(resources.GetObject("err_copies.Icon")));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.label1.Location = new System.Drawing.Point(836, 577);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Add Path";
            // 
            // btn_book_add
            // 
            this.btn_book_add.BackColor = System.Drawing.Color.Transparent;
            this.btn_book_add.Image = global::Library_Management_System.Properties.Resources.Add_Folder_96px;
            this.btn_book_add.ImageActive = global::Library_Management_System.Properties.Resources.Add_Folder_96px;
            this.btn_book_add.Location = new System.Drawing.Point(839, 533);
            this.btn_book_add.Name = "btn_book_add";
            this.btn_book_add.Size = new System.Drawing.Size(40, 40);
            this.btn_book_add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_book_add.TabIndex = 36;
            this.btn_book_add.TabStop = false;
            this.btn_book_add.Zoom = 10;
            this.btn_book_add.Click += new System.EventHandler(this.btn_book_add_Click);
            // 
            // btn_book_img
            // 
            this.btn_book_img.BackColor = System.Drawing.Color.Transparent;
            this.btn_book_img.Image = global::Library_Management_System.Properties.Resources.Add_Image_96px;
            this.btn_book_img.ImageActive = global::Library_Management_System.Properties.Resources.Add_Image_96px;
            this.btn_book_img.Location = new System.Drawing.Point(752, 534);
            this.btn_book_img.Name = "btn_book_img";
            this.btn_book_img.Size = new System.Drawing.Size(40, 40);
            this.btn_book_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_book_img.TabIndex = 33;
            this.btn_book_img.TabStop = false;
            this.btn_book_img.Zoom = 10;
            this.btn_book_img.Click += new System.EventHandler(this.btn_book_img_Click);
            // 
            // btn_add_user
            // 
            this.btn_add_user.BackColor = System.Drawing.Color.Transparent;
            this.btn_add_user.Image = global::Library_Management_System.Properties.Resources.Add_List_96px;
            this.btn_add_user.ImageActive = global::Library_Management_System.Properties.Resources.Add_List_96px;
            this.btn_add_user.Location = new System.Drawing.Point(917, 502);
            this.btn_add_user.Name = "btn_add_user";
            this.btn_add_user.Size = new System.Drawing.Size(71, 71);
            this.btn_add_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_add_user.TabIndex = 29;
            this.btn_add_user.TabStop = false;
            this.btn_add_user.Zoom = 10;
            this.btn_add_user.Click += new System.EventHandler(this.btn_add_user_Click);
            // 
            // Book_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.btn_book_add);
            this.Controls.Add(this.lbl_book_img);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_book_img);
            this.Controls.Add(this.lbl_add_user);
            this.Controls.Add(this.btn_add_user);
            this.Controls.Add(this.txt_category);
            this.Controls.Add(this.txt_book_id);
            this.Controls.Add(this.txt_copies);
            this.Controls.Add(this.txt_author);
            this.Controls.Add(this.txt_book_title);
            this.Controls.Add(this.lbl_copies);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.lbl_author);
            this.Controls.Add(this.lbl_book_title);
            this.Controls.Add(this.lbl_book_id);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.panel_side);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Book_details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issue_book";
            this.panel_side.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.panel_title.ResumeLayout(false);
            this.panel_title.PerformLayout();
            this.panel_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_book_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_book_title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_pub_year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_category)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_copies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_book_add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_book_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_add_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_side;
        private System.Windows.Forms.Panel panel_title;
        private System.Windows.Forms.Panel panel_top;
        private Bunifu.Framework.UI.BunifuImageButton btn_close;
        private System.Windows.Forms.Label lbl_dash;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_book_id;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_book_title;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_author;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_book_title;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_book_id;
        private Bunifu.Framework.UI.BunifuImageButton btn_back;
        private Bunifu.Framework.UI.BunifuImageButton btn_minimise;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_copies;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_author;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_category;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_copies;
        private System.Windows.Forms.ComboBox txt_category;
        private System.Windows.Forms.Label lbl_add_user;
        private Bunifu.Framework.UI.BunifuImageButton btn_add_user;
        private System.Windows.Forms.ErrorProvider err_book_id;
        private System.Windows.Forms.ErrorProvider err_book_title;
        private System.Windows.Forms.ErrorProvider err_pub_year;
        private System.Windows.Forms.ErrorProvider err_category;
        private System.Windows.Forms.ErrorProvider err_copies;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.Label lbl_book_img;
        private Bunifu.Framework.UI.BunifuImageButton btn_book_img;
        private Bunifu.Framework.UI.BunifuImageButton btn_book_add;
        private System.Windows.Forms.Label label1;
    }
}