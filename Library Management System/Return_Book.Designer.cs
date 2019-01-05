namespace Library_Management_System
{
    partial class Return_book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Return_book));
            this.panel_side = new System.Windows.Forms.Panel();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.panel_title = new System.Windows.Forms.Panel();
            this.lbl_dash = new System.Windows.Forms.Label();
            this.panel_top = new System.Windows.Forms.Panel();
            this.btn_back = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_minimise = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_close = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbl_enroll = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_book_id = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_issue_date = new Bunifu.Framework.UI.BunifuDatepicker();
            this.lbl_issue_date = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_book_id = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_enroll = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_return_date = new Bunifu.Framework.UI.BunifuDatepicker();
            this.lbl_return_date = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_return = new System.Windows.Forms.Label();
            this.btn_return = new Bunifu.Framework.UI.BunifuImageButton();
            this.err_enroll = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_return_date = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_book_id = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel_side.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.panel_title.SuspendLayout();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_return)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_enroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_return_date)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_book_id)).BeginInit();
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
            this.pb_logo.BackgroundImage = global::Library_Management_System.Properties.Resources.unnamed__10_;
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
            this.lbl_dash.Size = new System.Drawing.Size(103, 21);
            this.lbl_dash.TabIndex = 1;
            this.lbl_dash.Text = "Return Book";
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
            // lbl_enroll
            // 
            this.lbl_enroll.AutoSize = true;
            this.lbl_enroll.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_enroll.Location = new System.Drawing.Point(273, 106);
            this.lbl_enroll.Name = "lbl_enroll";
            this.lbl_enroll.Size = new System.Drawing.Size(113, 20);
            this.lbl_enroll.TabIndex = 17;
            this.lbl_enroll.Text = "Enrollment No.";
            // 
            // txt_book_id
            // 
            this.txt_book_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.txt_book_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_book_id.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_book_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_book_id.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.txt_book_id.HintText = "Ex.    1005";
            this.txt_book_id.isPassword = false;
            this.txt_book_id.LineFocusedColor = System.Drawing.Color.Gray;
            this.txt_book_id.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_book_id.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txt_book_id.LineThickness = 3;
            this.txt_book_id.Location = new System.Drawing.Point(471, 204);
            this.txt_book_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_book_id.Name = "txt_book_id";
            this.txt_book_id.Size = new System.Drawing.Size(379, 33);
            this.txt_book_id.TabIndex = 19;
            this.txt_book_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_book_id.Leave += new System.EventHandler(this.txt_book_id_Leave);
            // 
            // txt_issue_date
            // 
            this.txt_issue_date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_issue_date.BorderRadius = 0;
            this.txt_issue_date.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_issue_date.ForeColor = System.Drawing.Color.White;
            this.txt_issue_date.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txt_issue_date.FormatCustom = null;
            this.txt_issue_date.Location = new System.Drawing.Point(471, 340);
            this.txt_issue_date.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_issue_date.Name = "txt_issue_date";
            this.txt_issue_date.Size = new System.Drawing.Size(379, 39);
            this.txt_issue_date.TabIndex = 20;
            this.txt_issue_date.Value = new System.DateTime(2018, 4, 17, 1, 14, 13, 682);
            // 
            // lbl_issue_date
            // 
            this.lbl_issue_date.AutoSize = true;
            this.lbl_issue_date.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_issue_date.Location = new System.Drawing.Point(273, 340);
            this.lbl_issue_date.Name = "lbl_issue_date";
            this.lbl_issue_date.Size = new System.Drawing.Size(85, 20);
            this.lbl_issue_date.TabIndex = 17;
            this.lbl_issue_date.Text = "Issue Date";
            // 
            // lbl_book_id
            // 
            this.lbl_book_id.AutoSize = true;
            this.lbl_book_id.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_book_id.Location = new System.Drawing.Point(273, 217);
            this.lbl_book_id.Name = "lbl_book_id";
            this.lbl_book_id.Size = new System.Drawing.Size(65, 20);
            this.lbl_book_id.TabIndex = 17;
            this.lbl_book_id.Text = "Book Id";
            // 
            // txt_enroll
            // 
            this.txt_enroll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.txt_enroll.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_enroll.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_enroll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_enroll.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.txt_enroll.HintText = "Ex.    16012011066";
            this.txt_enroll.isPassword = false;
            this.txt_enroll.LineFocusedColor = System.Drawing.Color.Gray;
            this.txt_enroll.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_enroll.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txt_enroll.LineThickness = 3;
            this.txt_enroll.Location = new System.Drawing.Point(471, 93);
            this.txt_enroll.Margin = new System.Windows.Forms.Padding(4);
            this.txt_enroll.Name = "txt_enroll";
            this.txt_enroll.Size = new System.Drawing.Size(379, 33);
            this.txt_enroll.TabIndex = 18;
            this.txt_enroll.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_enroll.Leave += new System.EventHandler(this.txt_enroll_Leave);
            // 
            // txt_return_date
            // 
            this.txt_return_date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_return_date.BorderRadius = 0;
            this.txt_return_date.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_return_date.ForeColor = System.Drawing.Color.White;
            this.txt_return_date.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txt_return_date.FormatCustom = null;
            this.txt_return_date.Location = new System.Drawing.Point(471, 458);
            this.txt_return_date.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_return_date.Name = "txt_return_date";
            this.txt_return_date.Size = new System.Drawing.Size(379, 39);
            this.txt_return_date.TabIndex = 21;
            this.txt_return_date.Value = new System.DateTime(2018, 4, 17, 1, 14, 13, 682);
            // 
            // lbl_return_date
            // 
            this.lbl_return_date.AutoSize = true;
            this.lbl_return_date.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_return_date.Location = new System.Drawing.Point(273, 458);
            this.lbl_return_date.Name = "lbl_return_date";
            this.lbl_return_date.Size = new System.Drawing.Size(96, 20);
            this.lbl_return_date.TabIndex = 17;
            this.lbl_return_date.Text = "Return Date";
            // 
            // lbl_return
            // 
            this.lbl_return.AutoSize = true;
            this.lbl_return.BackColor = System.Drawing.Color.Transparent;
            this.lbl_return.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_return.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lbl_return.Location = new System.Drawing.Point(899, 560);
            this.lbl_return.Name = "lbl_return";
            this.lbl_return.Size = new System.Drawing.Size(85, 17);
            this.lbl_return.TabIndex = 22;
            this.lbl_return.Text = "Return Book";
            // 
            // btn_return
            // 
            this.btn_return.BackColor = System.Drawing.Color.Transparent;
            this.btn_return.Image = global::Library_Management_System.Properties.Resources.Return_Book_96px;
            this.btn_return.ImageActive = global::Library_Management_System.Properties.Resources.Return_Book_96px;
            this.btn_return.Location = new System.Drawing.Point(901, 486);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(71, 71);
            this.btn_return.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_return.TabIndex = 23;
            this.btn_return.TabStop = false;
            this.btn_return.Zoom = 10;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // err_enroll
            // 
            this.err_enroll.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.err_enroll.ContainerControl = this.txt_enroll;
            this.err_enroll.Icon = ((System.Drawing.Icon)(resources.GetObject("err_enroll.Icon")));
            // 
            // err_return_date
            // 
            this.err_return_date.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.err_return_date.ContainerControl = this.txt_return_date;
            this.err_return_date.Icon = ((System.Drawing.Icon)(resources.GetObject("err_return_date.Icon")));
            // 
            // err_book_id
            // 
            this.err_book_id.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.err_book_id.ContainerControl = this.txt_book_id;
            this.err_book_id.Icon = ((System.Drawing.Icon)(resources.GetObject("err_book_id.Icon")));
            // 
            // Return_book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.lbl_return);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.txt_return_date);
            this.Controls.Add(this.txt_issue_date);
            this.Controls.Add(this.txt_enroll);
            this.Controls.Add(this.txt_book_id);
            this.Controls.Add(this.lbl_return_date);
            this.Controls.Add(this.lbl_issue_date);
            this.Controls.Add(this.lbl_book_id);
            this.Controls.Add(this.lbl_enroll);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.panel_side);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Return_book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issue_book";
            this.Load += new System.EventHandler(this.Return_book_Load);
            this.panel_side.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.panel_title.ResumeLayout(false);
            this.panel_title.PerformLayout();
            this.panel_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_return)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_enroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_return_date)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_book_id)).EndInit();
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
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_enroll;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_book_id;
        private Bunifu.Framework.UI.BunifuDatepicker txt_issue_date;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_issue_date;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_book_id;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_enroll;
        private Bunifu.Framework.UI.BunifuImageButton btn_back;
        private Bunifu.Framework.UI.BunifuImageButton btn_minimise;
        private Bunifu.Framework.UI.BunifuDatepicker txt_return_date;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_return_date;
        private System.Windows.Forms.Label lbl_return;
        private Bunifu.Framework.UI.BunifuImageButton btn_return;
        private System.Windows.Forms.ErrorProvider err_enroll;
        private System.Windows.Forms.ErrorProvider err_return_date;
        private System.Windows.Forms.ErrorProvider err_book_id;
    }
}