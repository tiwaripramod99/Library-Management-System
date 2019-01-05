namespace Library_Management_System
{
    partial class Wishlist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wishlist));
            this.panel_side = new System.Windows.Forms.Panel();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.panel_title = new System.Windows.Forms.Panel();
            this.lbl_dash = new System.Windows.Forms.Label();
            this.panel_top = new System.Windows.Forms.Panel();
            this.btn_back = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_minimise = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_close = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel_side.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.panel_title.SuspendLayout();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
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
            this.pb_logo.BackColor = System.Drawing.Color.Transparent;
            this.pb_logo.BackgroundImage = global::Library_Management_System.Properties.Resources.unnamed__3_;
            this.pb_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_logo.Location = new System.Drawing.Point(37, 240);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(126, 121);
            this.pb_logo.TabIndex = 2;
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
            this.lbl_dash.Size = new System.Drawing.Size(63, 21);
            this.lbl_dash.TabIndex = 4;
            this.lbl_dash.Text = "Wishlist";
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
            this.btn_close.Image = global::Library_Management_System.Properties.Resources.cross2;
            this.btn_close.ImageActive = global::Library_Management_System.Properties.Resources.cross1;
            this.btn_close.Location = new System.Drawing.Point(766, 5);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(31, 31);
            this.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_close.TabIndex = 27;
            this.btn_close.TabStop = false;
            this.btn_close.Zoom = 10;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Wishlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.panel_side);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Wishlist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wishlist";
            this.Load += new System.EventHandler(this.Wishlist_Load);
            this.panel_side.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.panel_title.ResumeLayout(false);
            this.panel_title.PerformLayout();
            this.panel_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_side;
        private System.Windows.Forms.Panel panel_title;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label lbl_dash;
        private System.Windows.Forms.PictureBox pb_logo;
        private Bunifu.Framework.UI.BunifuImageButton btn_back;
        private Bunifu.Framework.UI.BunifuImageButton btn_minimise;
        private Bunifu.Framework.UI.BunifuImageButton btn_close;
    }
}