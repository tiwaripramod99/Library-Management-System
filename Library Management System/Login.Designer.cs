namespace Library_Management_System
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.btn_minimise = new System.Windows.Forms.Button();
            this.pb_user = new System.Windows.Forms.PictureBox();
            this.pb_pass = new System.Windows.Forms.PictureBox();
            this.txt_user = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_pass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_login_elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_resetpass = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pass)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.BackColor = System.Drawing.Color.Transparent;
            this.lbl_user.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ForeColor = System.Drawing.Color.CadetBlue;
            this.lbl_user.Location = new System.Drawing.Point(12, 54);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(95, 21);
            this.lbl_user.TabIndex = 1;
            this.lbl_user.Text = "User-Name";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pass.ForeColor = System.Drawing.Color.CadetBlue;
            this.lbl_pass.Location = new System.Drawing.Point(9, 117);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(82, 21);
            this.lbl_pass.TabIndex = 2;
            this.lbl_pass.Text = "Password";
            // 
            // btn_minimise
            // 
            this.btn_minimise.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimise.BackgroundImage = global::Library_Management_System.Properties.Resources.Expand_Arrow_100px;
            this.btn_minimise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_minimise.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_minimise.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_minimise.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_minimise.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_minimise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimise.ForeColor = System.Drawing.Color.Teal;
            this.btn_minimise.Location = new System.Drawing.Point(386, 3);
            this.btn_minimise.Name = "btn_minimise";
            this.btn_minimise.Size = new System.Drawing.Size(20, 18);
            this.btn_minimise.TabIndex = 5;
            this.btn_minimise.UseVisualStyleBackColor = false;
            this.btn_minimise.Click += new System.EventHandler(this.btn_minimise_Click);
            // 
            // pb_user
            // 
            this.pb_user.BackColor = System.Drawing.Color.Transparent;
            this.pb_user.BackgroundImage = global::Library_Management_System.Properties.Resources.User_96px;
            this.pb_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_user.Location = new System.Drawing.Point(13, 83);
            this.pb_user.Name = "pb_user";
            this.pb_user.Size = new System.Drawing.Size(23, 22);
            this.pb_user.TabIndex = 6;
            this.pb_user.TabStop = false;
            // 
            // pb_pass
            // 
            this.pb_pass.BackColor = System.Drawing.Color.Transparent;
            this.pb_pass.BackgroundImage = global::Library_Management_System.Properties.Resources.Password_96px;
            this.pb_pass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_pass.Location = new System.Drawing.Point(13, 146);
            this.pb_pass.Name = "pb_pass";
            this.pb_pass.Size = new System.Drawing.Size(23, 22);
            this.pb_pass.TabIndex = 7;
            this.pb_pass.TabStop = false;
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
            this.txt_user.Location = new System.Drawing.Point(43, 77);
            this.txt_user.Margin = new System.Windows.Forms.Padding(4);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(174, 28);
            this.txt_user.TabIndex = 10;
            this.txt_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.Color.Black;
            this.txt_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_pass.ForeColor = System.Drawing.Color.Silver;
            this.txt_pass.HintForeColor = System.Drawing.Color.Silver;
            this.txt_pass.HintText = "Password";
            this.txt_pass.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt_pass.isPassword = true;
            this.txt_pass.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_pass.LineIdleColor = System.Drawing.Color.White;
            this.txt_pass.LineMouseHoverColor = System.Drawing.Color.Teal;
            this.txt_pass.LineThickness = 2;
            this.txt_pass.Location = new System.Drawing.Point(43, 140);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(174, 28);
            this.txt_pass.TabIndex = 15;
            this.txt_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_pass.Enter += new System.EventHandler(this.txt_pass_Enter);
            // 
            // btn_login_elipse
            // 
            this.btn_login_elipse.ElipseRadius = 3;
            this.btn_login_elipse.TargetControl = this.btn_login;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(85, 188);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(82, 29);
            this.btn_login.TabIndex = 17;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.BackgroundImage = global::Library_Management_System.Properties.Resources.Multiply_100px;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_close.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.Color.Teal;
            this.btn_close.Location = new System.Drawing.Point(412, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(20, 18);
            this.btn_close.TabIndex = 5;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_resetpass
            // 
            this.lbl_resetpass.AutoSize = true;
            this.lbl_resetpass.BackColor = System.Drawing.Color.Transparent;
            this.lbl_resetpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_resetpass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resetpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(164)))), ((int)(((byte)(167)))));
            this.lbl_resetpass.Location = new System.Drawing.Point(64, 220);
            this.lbl_resetpass.Name = "lbl_resetpass";
            this.lbl_resetpass.Size = new System.Drawing.Size(123, 17);
            this.lbl_resetpass.TabIndex = 2;
            this.lbl_resetpass.Text = "Forgot Password?";
            this.lbl_resetpass.Click += new System.EventHandler(this.lbl_resetpass_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_Management_System.Properties.Resources._7857ae9df63dde2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btn_minimise;
            this.ClientSize = new System.Drawing.Size(435, 246);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.pb_pass);
            this.Controls.Add(this.pb_user);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_minimise);
            this.Controls.Add(this.lbl_resetpass);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_user);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.Login_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.pb_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Button btn_minimise;
        private System.Windows.Forms.PictureBox pb_user;
        private System.Windows.Forms.PictureBox pb_pass;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_user;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_pass;
        private Bunifu.Framework.UI.BunifuElipse btn_login_elipse;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_resetpass;
    }
}

