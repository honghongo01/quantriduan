namespace SalesManagementSouvenir_App
{
    partial class frm_DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DangNhap));
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.txt_TaiKhoan = new System.Windows.Forms.TextBox();
            this.btn_QuenMatKhau = new System.Windows.Forms.Button();
            this.btn_DangKy = new System.Windows.Forms.Button();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.error_TaiKhoan = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_MatKhau = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_TaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_MatKhau)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_MatKhau.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MatKhau.ForeColor = System.Drawing.Color.Red;
            this.txt_MatKhau.Location = new System.Drawing.Point(201, 193);
            this.txt_MatKhau.Multiline = true;
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.PasswordChar = '*';
            this.txt_MatKhau.Size = new System.Drawing.Size(218, 39);
            this.txt_MatKhau.TabIndex = 1;
            this.txt_MatKhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_MatKhau.TextChanged += new System.EventHandler(this.txt_MatKhau_TextChanged);
            this.txt_MatKhau.Validating += new System.ComponentModel.CancelEventHandler(this.txt_MatKhau_Validating);
            // 
            // txt_TaiKhoan
            // 
            this.txt_TaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_TaiKhoan.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TaiKhoan.ForeColor = System.Drawing.Color.Red;
            this.txt_TaiKhoan.Location = new System.Drawing.Point(201, 115);
            this.txt_TaiKhoan.Multiline = true;
            this.txt_TaiKhoan.Name = "txt_TaiKhoan";
            this.txt_TaiKhoan.Size = new System.Drawing.Size(218, 39);
            this.txt_TaiKhoan.TabIndex = 0;
            this.txt_TaiKhoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_TaiKhoan.TextChanged += new System.EventHandler(this.txt_TaiKhoan_TextChanged);
            this.txt_TaiKhoan.Enter += new System.EventHandler(this.txt_TaiKhoan_Enter);
            this.txt_TaiKhoan.Validating += new System.ComponentModel.CancelEventHandler(this.txt_TaiKhoan_Validating);
            // 
            // btn_QuenMatKhau
            // 
            this.btn_QuenMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_QuenMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_QuenMatKhau.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuenMatKhau.ForeColor = System.Drawing.Color.White;
            this.btn_QuenMatKhau.Image = global::SalesManagementSouvenir_App.Properties.Resources.img_QuenMatKhau;
            this.btn_QuenMatKhau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QuenMatKhau.Location = new System.Drawing.Point(402, 244);
            this.btn_QuenMatKhau.Name = "btn_QuenMatKhau";
            this.btn_QuenMatKhau.Size = new System.Drawing.Size(203, 37);
            this.btn_QuenMatKhau.TabIndex = 4;
            this.btn_QuenMatKhau.Text = "    Quên Mật  Khẩu";
            this.btn_QuenMatKhau.UseVisualStyleBackColor = false;
            this.btn_QuenMatKhau.Click += new System.EventHandler(this.btn_QuenMatKhau_Click);
            // 
            // btn_DangKy
            // 
            this.btn_DangKy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_DangKy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_DangKy.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangKy.ForeColor = System.Drawing.Color.White;
            this.btn_DangKy.Image = global::SalesManagementSouvenir_App.Properties.Resources.img_DangKy11;
            this.btn_DangKy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DangKy.Location = new System.Drawing.Point(213, 245);
            this.btn_DangKy.Name = "btn_DangKy";
            this.btn_DangKy.Size = new System.Drawing.Size(183, 37);
            this.btn_DangKy.TabIndex = 3;
            this.btn_DangKy.Text = "    Đăng Ký";
            this.btn_DangKy.UseVisualStyleBackColor = false;
            this.btn_DangKy.Click += new System.EventHandler(this.btn_DangKy_Click);
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_DangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_DangNhap.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangNhap.ForeColor = System.Drawing.Color.White;
            this.btn_DangNhap.Image = global::SalesManagementSouvenir_App.Properties.Resources.img_DangNhap1;
            this.btn_DangNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DangNhap.Location = new System.Drawing.Point(12, 245);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(195, 37);
            this.btn_DangNhap.TabIndex = 2;
            this.btn_DangNhap.Text = "    Đăng Nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = false;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Image = global::SalesManagementSouvenir_App.Properties.Resources.img_NutThoat5;
            this.btn_Thoat.Location = new System.Drawing.Point(582, 5);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(31, 34);
            this.btn_Thoat.TabIndex = 5;
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SalesManagementSouvenir_App.Properties.Resources.img_NenDangNhap1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(617, 311);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // error_TaiKhoan
            // 
            this.error_TaiKhoan.ContainerControl = this;
            // 
            // error_MatKhau
            // 
            this.error_MatKhau.ContainerControl = this;
            // 
            // frm_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(617, 311);
            this.Controls.Add(this.btn_QuenMatKhau);
            this.Controls.Add(this.btn_DangKy);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.txt_MatKhau);
            this.Controls.Add(this.txt_TaiKhoan);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần Mềm Quản Lý Bán Hàng Lưu Niệm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_TaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_MatKhau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_QuenMatKhau;
        private System.Windows.Forms.Button btn_DangKy;
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.TextBox txt_TaiKhoan;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider error_TaiKhoan;
        private System.Windows.Forms.ErrorProvider error_MatKhau;
    }
}

