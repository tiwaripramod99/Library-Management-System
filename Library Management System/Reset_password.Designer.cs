namespace Library_Management_System
{
    partial class Reset_password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reset_password));
            this.txt_user = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pb_user = new System.Windows.Forms.PictureBox();
            this.lbl_user = new System.Windows.Forms.Label();
            this.txt_newpass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pb_newpass = new System.Windows.Forms.PictureBox();
            this.lbl_newpass = new System.Windows.Forms.Label();
            this.txt_renewpass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pb_renewpass = new System.Windows.Forms.PictureBox();
            this.lbl_renewpass = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_minmise = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_reset_elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btn_forward = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_otpfor = new Bunifu.Framework.UI.BunifuFlatButton();
            this.err_pass = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_newpass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_renewpass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_pass)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_user
            // 
            this.txt_user.BackColor = System.Drawing.Color.Black;
            this.txt_user.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_user.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_user.ForeColor = System.Drawing.Color.Silver;
            this.txt_user.HintForeColor = System.Drawing.Color.Silver;
            this.txt_user.HintText = "User name";
            this.txt_user.isPassword = false;
            this.txt_user.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_user.LineIdleColor = System.Drawing.Color.White;
            this.txt_user.LineMouseHoverColor = System.Drawing.Color.Teal;
            this.txt_user.LineThickness = 2;
            this.txt_user.Location = new System.Drawing.Point(43, 120);
            this.txt_user.Margin = new System.Windows.Forms.Padding(4);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(174, 28);
            this.txt_user.TabIndex = 13;
            this.txt_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pb_user
            // 
            this.pb_user.BackColor = System.Drawing.Color.Transparent;
            this.pb_user.BackgroundImage = global::Library_Management_System.Properties.Resources.User_96px;
            this.pb_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_user.Location = new System.Drawing.Point(13, 126);
            this.pb_user.Name = "pb_user";
            this.pb_user.Size = new System.Drawing.Size(23, 22);
            this.pb_user.TabIndex = 12;
            this.pb_user.TabStop = false;
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.BackColor = System.Drawing.Color.Transparent;
            this.lbl_user.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ForeColor = System.Drawing.Color.CadetBlue;
            this.lbl_user.Location = new System.Drawing.Point(12, 97);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(95, 21);
            this.lbl_user.TabIndex = 0;
            this.lbl_user.Text = "User-Name";
            // 
            // txt_newpass
            // 
            this.txt_newpass.BackColor = System.Drawing.Color.Black;
            this.txt_newpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_newpass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_newpass.ForeColor = System.Drawing.Color.Silver;
            this.txt_newpass.HintForeColor = System.Drawing.Color.Silver;
            this.txt_newpass.HintText = "Password";
            this.txt_newpass.isPassword = true;
            this.txt_newpass.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_newpass.LineIdleColor = System.Drawing.Color.White;
            this.txt_newpass.LineMouseHoverColor = System.Drawing.Color.Teal;
            this.txt_newpass.LineThickness = 2;
            this.txt_newpass.Location = new System.Drawing.Point(43, 74);
            this.txt_newpass.Margin = new System.Windows.Forms.Padding(4);
            this.txt_newpass.Name = "txt_newpass";
            this.txt_newpass.Size = new System.Drawing.Size(174, 28);
            this.txt_newpass.TabIndex = 16;
            this.txt_newpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_newpass.Enter += new System.EventHandler(this.txt_newpass_Enter);
            // 
            // pb_newpass
            // 
            this.pb_newpass.BackColor = System.Drawing.Color.Transparent;
            this.pb_newpass.BackgroundImage = global::Library_Management_System.Properties.Resources.Password_96px;
            this.pb_newpass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_newpass.Location = new System.Drawing.Point(13, 80);
            this.pb_newpass.Name = "pb_newpass";
            this.pb_newpass.Size = new System.Drawing.Size(23, 22);
            this.pb_newpass.TabIndex = 15;
            this.pb_newpass.TabStop = false;
            // 
            // lbl_newpass
            // 
            this.lbl_newpass.AutoSize = true;
            this.lbl_newpass.BackColor = System.Drawing.Color.Transparent;
            this.lbl_newpass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_newpass.ForeColor = System.Drawing.Color.CadetBlue;
            this.lbl_newpass.Location = new System.Drawing.Point(12, 51);
            this.lbl_newpass.Name = "lbl_newpass";
            this.lbl_newpass.Size = new System.Drawing.Size(167, 21);
            this.lbl_newpass.TabIndex = 14;
            this.lbl_newpass.Text = "Enter New Password";
            // 
            // txt_renewpass
            // 
            this.txt_renewpass.BackColor = System.Drawing.Color.Black;
            this.txt_renewpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_renewpass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_renewpass.ForeColor = System.Drawing.Color.Silver;
            this.txt_renewpass.HintForeColor = System.Drawing.Color.Silver;
            this.txt_renewpass.HintText = "Re-enter Password";
            this.txt_renewpass.isPassword = true;
            this.txt_renewpass.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_renewpass.LineIdleColor = System.Drawing.Color.White;
            this.txt_renewpass.LineMouseHoverColor = System.Drawing.Color.Teal;
            this.txt_renewpass.LineThickness = 2;
            this.txt_renewpass.Location = new System.Drawing.Point(43, 142);
            this.txt_renewpass.Margin = new System.Windows.Forms.Padding(4);
            this.txt_renewpass.Name = "txt_renewpass";
            this.txt_renewpass.Size = new System.Drawing.Size(174, 28);
            this.txt_renewpass.TabIndex = 19;
            this.txt_renewpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_renewpass.OnValueChanged += new System.EventHandler(this.txt_renewpass_OnValueChanged);
            // 
            // pb_renewpass
            // 
            this.pb_renewpass.BackColor = System.Drawing.Color.Transparent;
            this.pb_renewpass.BackgroundImage = global::Library_Management_System.Properties.Resources.Privacy_96px;
            this.pb_renewpass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_renewpass.Location = new System.Drawing.Point(13, 148);
            this.pb_renewpass.Name = "pb_renewpass";
            this.pb_renewpass.Size = new System.Drawing.Size(23, 22);
            this.pb_renewpass.TabIndex = 18;
            this.pb_renewpass.TabStop = false;
            // 
            // lbl_renewpass
            // 
            this.lbl_renewpass.AutoSize = true;
            this.lbl_renewpass.BackColor = System.Drawing.Color.Transparent;
            this.lbl_renewpass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_renewpass.ForeColor = System.Drawing.Color.CadetBlue;
            this.lbl_renewpass.Location = new System.Drawing.Point(12, 119);
            this.lbl_renewpass.Name = "lbl_renewpass";
            this.lbl_renewpass.Size = new System.Drawing.Size(153, 21);
            this.lbl_renewpass.TabIndex = 17;
            this.lbl_renewpass.Text = "Re-enter Password";
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.BackgroundImage = global::Library_Management_System.Properties.Resources.Multiply_100px;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_close.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.Color.Teal;
            this.btn_close.Location = new System.Drawing.Point(413, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(20, 18);
            this.btn_close.TabIndex = 20;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_minmise
            // 
            this.btn_minmise.BackColor = System.Drawing.Color.Transparent;
            this.btn_minmise.BackgroundImage = global::Library_Management_System.Properties.Resources.Expand_Arrow_100px;
            this.btn_minmise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_minmise.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_minmise.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_minmise.FlatAppearance.BorderSize = 0;
            this.btn_minmise.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_minmise.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_minmise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minmise.ForeColor = System.Drawing.Color.Teal;
            this.btn_minmise.Location = new System.Drawing.Point(387, 3);
            this.btn_minmise.Name = "btn_minmise";
            this.btn_minmise.Size = new System.Drawing.Size(20, 18);
            this.btn_minmise.TabIndex = 21;
            this.btn_minmise.UseVisualStyleBackColor = false;
            this.btn_minmise.Click += new System.EventHandler(this.btn_minmise_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_reset.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_reset.FlatAppearance.BorderSize = 0;
            this.btn_reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.Color.White;
            this.btn_reset.Location = new System.Drawing.Point(69, 195);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(82, 29);
            this.btn_reset.TabIndex = 22;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_reset_elipse
            // 
            this.btn_reset_elipse.ElipseRadius = 3;
            this.btn_reset_elipse.TargetControl = this.btn_reset;
            // 
            // btn_forward
            // 
            this.btn_forward.Activecolor = System.Drawing.Color.Transparent;
            this.btn_forward.BackColor = System.Drawing.Color.Transparent;
            this.btn_forward.BackgroundImage = global::Library_Management_System.Properties.Resources.right_white;
            this.btn_forward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_forward.BorderRadius = 0;
            this.btn_forward.ButtonText = "";
            this.btn_forward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_forward.DisabledColor = System.Drawing.Color.Gray;
            this.btn_forward.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_forward.Iconimage = null;
            this.btn_forward.Iconimage_right = null;
            this.btn_forward.Iconimage_right_Selected = null;
            this.btn_forward.Iconimage_Selected = null;
            this.btn_forward.IconMarginLeft = 0;
            this.btn_forward.IconMarginRight = 0;
            this.btn_forward.IconRightVisible = true;
            this.btn_forward.IconRightZoom = 0D;
            this.btn_forward.IconVisible = true;
            this.btn_forward.IconZoom = 90D;
            this.btn_forward.IsTab = false;
            this.btn_forward.Location = new System.Drawing.Point(95, 177);
            this.btn_forward.Name = "btn_forward";
            this.btn_forward.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_forward.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_forward.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_forward.selected = false;
            this.btn_forward.Size = new System.Drawing.Size(29, 29);
            this.btn_forward.TabIndex = 23;
            this.btn_forward.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_forward.Textcolor = System.Drawing.Color.White;
            this.btn_forward.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_forward.Click += new System.EventHandler(this.btn_forward_Click);
            // 
            // btn_otpfor
            // 
            this.btn_otpfor.Activecolor = System.Drawing.Color.Transparent;
            this.btn_otpfor.BackColor = System.Drawing.Color.Transparent;
            this.btn_otpfor.BackgroundImage = global::Library_Management_System.Properties.Resources.right_white;
            this.btn_otpfor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_otpfor.BorderRadius = 0;
            this.btn_otpfor.ButtonText = "";
            this.btn_otpfor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_otpfor.DisabledColor = System.Drawing.Color.Gray;
            this.btn_otpfor.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_otpfor.Iconimage = null;
            this.btn_otpfor.Iconimage_right = null;
            this.btn_otpfor.Iconimage_right_Selected = null;
            this.btn_otpfor.Iconimage_Selected = null;
            this.btn_otpfor.IconMarginLeft = 0;
            this.btn_otpfor.IconMarginRight = 0;
            this.btn_otpfor.IconRightVisible = true;
            this.btn_otpfor.IconRightZoom = 0D;
            this.btn_otpfor.IconVisible = true;
            this.btn_otpfor.IconZoom = 90D;
            this.btn_otpfor.IsTab = false;
            this.btn_otpfor.Location = new System.Drawing.Point(78, 177);
            this.btn_otpfor.Name = "btn_otpfor";
            this.btn_otpfor.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_otpfor.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_otpfor.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_otpfor.selected = false;
            this.btn_otpfor.Size = new System.Drawing.Size(29, 29);
            this.btn_otpfor.TabIndex = 23;
            this.btn_otpfor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_otpfor.Textcolor = System.Drawing.Color.White;
            this.btn_otpfor.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_otpfor.Click += new System.EventHandler(this.btn_otpfor_Click);
            // 
            // err_pass
            // 
            this.err_pass.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.err_pass.ContainerControl = this.txt_renewpass;
            this.err_pass.Icon = ((System.Drawing.Icon)(resources.GetObject("err_pass.Icon")));
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.BackgroundImage = global::Library_Management_System.Properties.Resources.Double_Left_96px;
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_back.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.ForeColor = System.Drawing.Color.Teal;
            this.btn_back.Location = new System.Drawing.Point(361, 3);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(20, 18);
            this.btn_back.TabIndex = 21;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Reset_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.BackgroundImage = global::Library_Management_System.Properties.Resources._7857ae9df63dde2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(435, 236);
            this.Controls.Add(this.btn_otpfor);
            this.Controls.Add(this.btn_forward);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_minmise);
            this.Controls.Add(this.txt_renewpass);
            this.Controls.Add(this.pb_renewpass);
            this.Controls.Add(this.lbl_renewpass);
            this.Controls.Add(this.txt_newpass);
            this.Controls.Add(this.pb_newpass);
            this.Controls.Add(this.lbl_newpass);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.pb_user);
            this.Controls.Add(this.lbl_user);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reset_password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Dashboard";
            this.Load += new System.EventHandler(this.Reset_password_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_newpass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_renewpass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_pass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_user;
        private System.Windows.Forms.PictureBox pb_user;
        private System.Windows.Forms.Label lbl_user;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_newpass;
        private System.Windows.Forms.PictureBox pb_newpass;
        private System.Windows.Forms.Label lbl_newpass;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_renewpass;
        private System.Windows.Forms.PictureBox pb_renewpass;
        private System.Windows.Forms.Label lbl_renewpass;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_minmise;
        private System.Windows.Forms.Button btn_reset;
        private Bunifu.Framework.UI.BunifuElipse btn_reset_elipse;
        private Bunifu.Framework.UI.BunifuFlatButton btn_forward;
        private Bunifu.Framework.UI.BunifuFlatButton btn_otpfor;
        private System.Windows.Forms.ErrorProvider err_pass;
        private System.Windows.Forms.Button btn_back;
    }
}