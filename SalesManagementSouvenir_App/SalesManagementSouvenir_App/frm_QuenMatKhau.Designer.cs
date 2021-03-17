namespace SalesManagementSouvenir_App
{
    partial class frm_QuenMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QuenMatKhau));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_TaiKhoan = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.btn_Laylaimatkhau = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SalesManagementSouvenir_App.Properties.Resources.img_FormQuenMatKhau01;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(603, 291);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txt_TaiKhoan
            // 
            this.txt_TaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_TaiKhoan.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TaiKhoan.ForeColor = System.Drawing.Color.Red;
            this.txt_TaiKhoan.Location = new System.Drawing.Point(188, 110);
            this.txt_TaiKhoan.Multiline = true;
            this.txt_TaiKhoan.Name = "txt_TaiKhoan";
            this.txt_TaiKhoan.Size = new System.Drawing.Size(237, 30);
            this.txt_TaiKhoan.TabIndex = 10;
            this.txt_TaiKhoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Email
            // 
            this.txt_Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Email.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.ForeColor = System.Drawing.Color.Red;
            this.txt_Email.Location = new System.Drawing.Point(188, 185);
            this.txt_Email.Multiline = true;
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(237, 30);
            this.txt_Email.TabIndex = 11;
            this.txt_Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Email.TextChanged += new System.EventHandler(this.txt_Email_TextChanged);
            // 
            // btn_Laylaimatkhau
            // 
            this.btn_Laylaimatkhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Laylaimatkhau.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Laylaimatkhau.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Laylaimatkhau.ForeColor = System.Drawing.Color.White;
            this.btn_Laylaimatkhau.Image = global::SalesManagementSouvenir_App.Properties.Resources.img_QuenMatKhau;
            this.btn_Laylaimatkhau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Laylaimatkhau.Location = new System.Drawing.Point(196, 231);
            this.btn_Laylaimatkhau.Name = "btn_Laylaimatkhau";
            this.btn_Laylaimatkhau.Size = new System.Drawing.Size(229, 37);
            this.btn_Laylaimatkhau.TabIndex = 14;
            this.btn_Laylaimatkhau.Text = "      Lấy Lại Mật  Khẩu";
            this.btn_Laylaimatkhau.UseVisualStyleBackColor = false;
            this.btn_Laylaimatkhau.Click += new System.EventHandler(this.btn_Laylaimatkhau_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Image = global::SalesManagementSouvenir_App.Properties.Resources.img_NutThoat5;
            this.btn_Thoat.Location = new System.Drawing.Point(567, 5);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(31, 34);
            this.btn_Thoat.TabIndex = 15;
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_MatKhau.Enabled = false;
            this.txt_MatKhau.Font = new System.Drawing.Font("Times New Roman", 2.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MatKhau.ForeColor = System.Drawing.Color.White;
            this.txt_MatKhau.Location = new System.Drawing.Point(179, 192);
            this.txt_MatKhau.Multiline = true;
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Size = new System.Drawing.Size(10, 16);
            this.txt_MatKhau.TabIndex = 16;
            this.txt_MatKhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frm_QuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 292);
            this.Controls.Add(this.txt_MatKhau);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Laylaimatkhau);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_TaiKhoan);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_QuenMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_TaiKhoan;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Button btn_Laylaimatkhau;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.TextBox txt_MatKhau;
    }
}