namespace Library_Management_System
{
    partial class Order_book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order_book));
            this.panel_side = new System.Windows.Forms.Panel();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.panel_title = new System.Windows.Forms.Panel();
            this.lbl_dash = new System.Windows.Forms.Label();
            this.panel_top = new System.Windows.Forms.Panel();
            this.btn_back = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_minimise = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_close = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbl_book_title = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_order_date = new Bunifu.Framework.UI.BunifuDatepicker();
            this.lbl_order_date = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_author = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_book_title = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbl_priority = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_copies = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_priority = new System.Windows.Forms.ComboBox();
            this.lbl_order_book = new System.Windows.Forms.Label();
            this.txt_copies = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_order = new Bunifu.Framework.UI.BunifuImageButton();
            this.txt_author = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.err_book_title = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_author = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_priority = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_order_date = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_copies = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel_side.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.panel_title.SuspendLayout();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_book_title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_author)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_priority)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_order_date)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_copies)).BeginInit();
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
            this.pb_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.pb_logo.BackgroundImage = global::Library_Management_System.Properties.Resources.download_ebook_icon;
            this.pb_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_logo.Location = new System.Drawing.Point(43, 231);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(109, 109);
            this.pb_logo.TabIndex = 1;
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
            this.lbl_dash.Size = new System.Drawing.Size(96, 21);
            this.lbl_dash.TabIndex = 1;
            this.lbl_dash.Text = "Order Book";
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.Silver;
            this.panel_top.Controls.Add(this.btn_back);
            this.panel_top.Controls.Add(this.btn_minimise);
            this.panel_top.Controls.Add(this.btn_close);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
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
            // lbl_book_title
            // 
            this.lbl_book_title.AutoSize = true;
            this.lbl_book_title.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_book_title.Location = new System.Drawing.Point(285, 100);
            this.lbl_book_title.Name = "lbl_book_title";
            this.lbl_book_title.Size = new System.Drawing.Size(76, 20);
            this.lbl_book_title.TabIndex = 17;
            this.lbl_book_title.Text = "Book title";
            // 
            // txt_order_date
            // 
            this.txt_order_date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_order_date.BorderRadius = 0;
            this.txt_order_date.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_order_date.ForeColor = System.Drawing.Color.White;
            this.txt_order_date.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txt_order_date.FormatCustom = null;
            this.txt_order_date.Location = new System.Drawing.Point(407, 365);
            this.txt_order_date.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_order_date.Name = "txt_order_date";
            this.txt_order_date.Size = new System.Drawing.Size(379, 39);
            this.txt_order_date.TabIndex = 21;
            this.txt_order_date.Value = new System.DateTime(2018, 4, 17, 1, 14, 13, 682);
            // 
            // lbl_order_date
            // 
            this.lbl_order_date.AutoSize = true;
            this.lbl_order_date.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_order_date.Location = new System.Drawing.Point(285, 365);
            this.lbl_order_date.Name = "lbl_order_date";
            this.lbl_order_date.Size = new System.Drawing.Size(92, 20);
            this.lbl_order_date.TabIndex = 17;
            this.lbl_order_date.Text = "Order Date";
            // 
            // lbl_author
            // 
            this.lbl_author.AutoSize = true;
            this.lbl_author.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_author.Location = new System.Drawing.Point(285, 186);
            this.lbl_author.Name = "lbl_author";
            this.lbl_author.Size = new System.Drawing.Size(58, 20);
            this.lbl_author.TabIndex = 17;
            this.lbl_author.Text = "Author";
            // 
            // txt_book_title
            // 
            this.txt_book_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.txt_book_title.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_book_title.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_book_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_book_title.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.txt_book_title.HintText = "Ex.    ANSI C";
            this.txt_book_title.isPassword = false;
            this.txt_book_title.LineFocusedColor = System.Drawing.Color.Gray;
            this.txt_book_title.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_book_title.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txt_book_title.LineThickness = 3;
            this.txt_book_title.Location = new System.Drawing.Point(407, 87);
            this.txt_book_title.Margin = new System.Windows.Forms.Padding(4);
            this.txt_book_title.Name = "txt_book_title";
            this.txt_book_title.Size = new System.Drawing.Size(379, 33);
            this.txt_book_title.TabIndex = 18;
            this.txt_book_title.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbl_priority
            // 
            this.lbl_priority.AutoSize = true;
            this.lbl_priority.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_priority.Location = new System.Drawing.Point(285, 275);
            this.lbl_priority.Name = "lbl_priority";
            this.lbl_priority.Size = new System.Drawing.Size(57, 20);
            this.lbl_priority.TabIndex = 17;
            this.lbl_priority.Text = "Priority";
            // 
            // lbl_copies
            // 
            this.lbl_copies.AutoSize = true;
            this.lbl_copies.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_copies.Location = new System.Drawing.Point(285, 462);
            this.lbl_copies.Name = "lbl_copies";
            this.lbl_copies.Size = new System.Drawing.Size(60, 20);
            this.lbl_copies.TabIndex = 17;
            this.lbl_copies.Text = "Copies";
            // 
            // txt_priority
            // 
            this.txt_priority.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_priority.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_priority.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.txt_priority.FormattingEnabled = true;
            this.txt_priority.Items.AddRange(new object[] {
            "Emergency",
            "High",
            "Intermediate",
            "Low"});
            this.txt_priority.Location = new System.Drawing.Point(407, 275);
            this.txt_priority.Name = "txt_priority";
            this.txt_priority.Size = new System.Drawing.Size(379, 25);
            this.txt_priority.TabIndex = 20;
            // 
            // lbl_order_book
            // 
            this.lbl_order_book.AutoSize = true;
            this.lbl_order_book.BackColor = System.Drawing.Color.Transparent;
            this.lbl_order_book.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_order_book.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lbl_order_book.Location = new System.Drawing.Point(887, 560);
            this.lbl_order_book.Name = "lbl_order_book";
            this.lbl_order_book.Size = new System.Drawing.Size(80, 17);
            this.lbl_order_book.TabIndex = 26;
            this.lbl_order_book.Text = "Order Book";
            // 
            // txt_copies
            // 
            this.txt_copies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.txt_copies.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_copies.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_copies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_copies.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.txt_copies.HintText = "Ex.    1";
            this.txt_copies.isPassword = false;
            this.txt_copies.LineFocusedColor = System.Drawing.Color.Gray;
            this.txt_copies.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_copies.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txt_copies.LineThickness = 3;
            this.txt_copies.Location = new System.Drawing.Point(407, 449);
            this.txt_copies.Margin = new System.Windows.Forms.Padding(4);
            this.txt_copies.Name = "txt_copies";
            this.txt_copies.Size = new System.Drawing.Size(379, 33);
            this.txt_copies.TabIndex = 22;
            this.txt_copies.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_order
            // 
            this.btn_order.BackColor = System.Drawing.Color.Transparent;
            this.btn_order.Image = global::Library_Management_System.Properties.Resources.Books_96px;
            this.btn_order.ImageActive = global::Library_Management_System.Properties.Resources.Books_96px;
            this.btn_order.Location = new System.Drawing.Point(889, 486);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(71, 71);
            this.btn_order.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_order.TabIndex = 27;
            this.btn_order.TabStop = false;
            this.btn_order.Zoom = 10;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // txt_author
            // 
            this.txt_author.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.txt_author.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_author.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_author.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_author.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.txt_author.HintText = "Ex.    E Balagurusamy";
            this.txt_author.isPassword = false;
            this.txt_author.LineFocusedColor = System.Drawing.Color.Gray;
            this.txt_author.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_author.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txt_author.LineThickness = 3;
            this.txt_author.Location = new System.Drawing.Point(407, 173);
            this.txt_author.Margin = new System.Windows.Forms.Padding(4);
            this.txt_author.Name = "txt_author";
            this.txt_author.Size = new System.Drawing.Size(379, 33);
            this.txt_author.TabIndex = 19;
            this.txt_author.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // err_book_title
            // 
            this.err_book_title.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.err_book_title.ContainerControl = this.txt_book_title;
            this.err_book_title.Icon = ((System.Drawing.Icon)(resources.GetObject("err_book_title.Icon")));
            // 
            // err_author
            // 
            this.err_author.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.err_author.ContainerControl = this.txt_author;
            this.err_author.Icon = ((System.Drawing.Icon)(resources.GetObject("err_author.Icon")));
            // 
            // err_priority
            // 
            this.err_priority.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.err_priority.ContainerControl = this;
            this.err_priority.Icon = ((System.Drawing.Icon)(resources.GetObject("err_priority.Icon")));
            // 
            // err_order_date
            // 
            this.err_order_date.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.err_order_date.ContainerControl = this.txt_order_date;
            this.err_order_date.Icon = ((System.Drawing.Icon)(resources.GetObject("err_order_date.Icon")));
            // 
            // err_copies
            // 
            this.err_copies.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.err_copies.ContainerControl = this.txt_copies;
            this.err_copies.Icon = ((System.Drawing.Icon)(resources.GetObject("err_copies.Icon")));
            // 
            // Order_book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.lbl_order_book);
            this.Controls.Add(this.btn_order);
            this.Controls.Add(this.txt_priority);
            this.Controls.Add(this.txt_order_date);
            this.Controls.Add(this.txt_book_title);
            this.Controls.Add(this.txt_copies);
            this.Controls.Add(this.txt_author);
            this.Controls.Add(this.lbl_order_date);
            this.Controls.Add(this.lbl_copies);
            this.Controls.Add(this.lbl_priority);
            this.Controls.Add(this.lbl_author);
            this.Controls.Add(this.lbl_book_title);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.panel_side);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Order_book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issue_book";
            this.Load += new System.EventHandler(this.Order_book_Load);
            this.panel_side.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.panel_title.ResumeLayout(false);
            this.panel_title.PerformLayout();
            this.panel_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_book_title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_author)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_priority)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_order_date)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_copies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_side;
        private System.Windows.Forms.Panel panel_title;
        private System.Windows.Forms.Panel panel_top;
        private Bunifu.Framework.UI.BunifuImageButton btn_close;
        private System.Windows.Forms.Label lbl_dash;
        private System.Windows.Forms.PictureBox pb_logo;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_book_title;
        private Bunifu.Framework.UI.BunifuDatepicker txt_order_date;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_order_date;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_author;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_book_title;
        private Bunifu.Framework.UI.BunifuImageButton btn_back;
        private Bunifu.Framework.UI.BunifuImageButton btn_minimise;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_priority;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_copies;
        private System.Windows.Forms.ComboBox txt_priority;
        private System.Windows.Forms.Label lbl_order_book;
        private Bunifu.Framework.UI.BunifuImageButton btn_order;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_copies;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_author;
        private System.Windows.Forms.ErrorProvider err_book_title;
        private System.Windows.Forms.ErrorProvider err_author;
        private System.Windows.Forms.ErrorProvider err_priority;
        private System.Windows.Forms.ErrorProvider err_order_date;
        private System.Windows.Forms.ErrorProvider err_copies;
    }
}