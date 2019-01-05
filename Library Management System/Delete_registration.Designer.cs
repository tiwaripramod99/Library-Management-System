namespace Library_Management_System
{
    partial class Delete_regestration
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
            this.txt_enroll = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbl_enroll = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_delete = new System.Windows.Forms.Label();
            this.btn_search = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_delete = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.btn_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_delete)).BeginInit();
            this.SuspendLayout();
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
            this.txt_enroll.Location = new System.Drawing.Point(240, 64);
            this.txt_enroll.Margin = new System.Windows.Forms.Padding(4);
            this.txt_enroll.Name = "txt_enroll";
            this.txt_enroll.Size = new System.Drawing.Size(379, 33);
            this.txt_enroll.TabIndex = 5;
            this.txt_enroll.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbl_enroll
            // 
            this.lbl_enroll.AutoSize = true;
            this.lbl_enroll.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_enroll.Location = new System.Drawing.Point(40, 77);
            this.lbl_enroll.Name = "lbl_enroll";
            this.lbl_enroll.Size = new System.Drawing.Size(113, 20);
            this.lbl_enroll.TabIndex = 16;
            this.lbl_enroll.Text = "Enrollment No.";
            // 
            // lbl_delete
            // 
            this.lbl_delete.AutoSize = true;
            this.lbl_delete.BackColor = System.Drawing.Color.Transparent;
            this.lbl_delete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lbl_delete.Location = new System.Drawing.Point(679, 530);
            this.lbl_delete.Name = "lbl_delete";
            this.lbl_delete.Size = new System.Drawing.Size(91, 17);
            this.lbl_delete.TabIndex = 26;
            this.lbl_delete.Text = "Remove User";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.Image = global::Library_Management_System.Properties.Resources.Search_Property_96px;
            this.btn_search.ImageActive = global::Library_Management_System.Properties.Resources.Search_Property_96px;
            this.btn_search.Location = new System.Drawing.Point(682, 45);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(71, 71);
            this.btn_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_search.TabIndex = 27;
            this.btn_search.TabStop = false;
            this.btn_search.Zoom = 10;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.Image = global::Library_Management_System.Properties.Resources.Remove_User_Male_96px;
            this.btn_delete.ImageActive = global::Library_Management_System.Properties.Resources.Remove_User_Male_96px;
            this.btn_delete.Location = new System.Drawing.Point(683, 451);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(71, 71);
            this.btn_delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_delete.TabIndex = 27;
            this.btn_delete.TabStop = false;
            this.btn_delete.Zoom = 10;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // Delete_regestration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(796, 556);
            this.Controls.Add(this.lbl_delete);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.lbl_enroll);
            this.Controls.Add(this.txt_enroll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Delete_regestration";
            this.Text = "Delete_registartion";
            this.Load += new System.EventHandler(this.Delete_regestration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_delete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_enroll;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_enroll;
        private Bunifu.Framework.UI.BunifuImageButton btn_delete;
        private System.Windows.Forms.Label lbl_delete;
        private Bunifu.Framework.UI.BunifuImageButton btn_search;
    }
}