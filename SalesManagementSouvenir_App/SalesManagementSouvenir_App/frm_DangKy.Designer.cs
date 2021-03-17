namespace SalesManagementSouvenir_App
{
    partial class frm_DangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DangKy));
            this.cbx_GioiTinh = new System.Windows.Forms.ComboBox();
            this.cbx_NamSinh = new System.Windows.Forms.ComboBox();
            this.cbx_NamBDLV = new System.Windows.Forms.ComboBox();
            this.cbx_ThangSinh = new System.Windows.Forms.ComboBox();
            this.cbx_NgaySinh = new System.Windows.Forms.ComboBox();
            this.cbx_ThangBDLV = new System.Windows.Forms.ComboBox();
            this.cbx_NgayBDLV = new System.Windows.Forms.ComboBox();
            this.cbx_ChucVu = new System.Windows.Forms.ComboBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.txt_CMND = new System.Windows.Forms.TextBox();
            this.txt_MaNhanVien = new System.Windows.Forms.TextBox();
            this.txt_MaXacNhan = new System.Windows.Forms.TextBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_TaiKhoan = new System.Windows.Forms.TextBox();
            this.btn_Dong = new System.Windows.Forms.Button();
            this.btn_DangKy = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.error_txt_SDT = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_CMND = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_HoTen = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_TaiKhoan = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_MatKhau = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_MaXacNhan = new System.Windows.Forms.ErrorProvider(this.components);
            this.lb_KT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.error_txt_SDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_CMND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_HoTen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_TaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_MatKhau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_MaXacNhan)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_GioiTinh
            // 
            this.cbx_GioiTinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_GioiTinh.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_GioiTinh.ForeColor = System.Drawing.Color.Black;
            this.cbx_GioiTinh.FormattingEnabled = true;
            this.cbx_GioiTinh.Location = new System.Drawing.Point(802, 284);
            this.cbx_GioiTinh.Name = "cbx_GioiTinh";
            this.cbx_GioiTinh.Size = new System.Drawing.Size(240, 30);
            this.cbx_GioiTinh.TabIndex = 49;
            // 
            // cbx_NamSinh
            // 
            this.cbx_NamSinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_NamSinh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_NamSinh.FormattingEnabled = true;
            this.cbx_NamSinh.Location = new System.Drawing.Point(953, 223);
            this.cbx_NamSinh.Name = "cbx_NamSinh";
            this.cbx_NamSinh.Size = new System.Drawing.Size(93, 29);
            this.cbx_NamSinh.TabIndex = 48;
            // 
            // cbx_NamBDLV
            // 
            this.cbx_NamBDLV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_NamBDLV.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_NamBDLV.FormattingEnabled = true;
            this.cbx_NamBDLV.Location = new System.Drawing.Point(446, 551);
            this.cbx_NamBDLV.Name = "cbx_NamBDLV";
            this.cbx_NamBDLV.Size = new System.Drawing.Size(86, 29);
            this.cbx_NamBDLV.TabIndex = 47;
            // 
            // cbx_ThangSinh
            // 
            this.cbx_ThangSinh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbx_ThangSinh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_ThangSinh.FormattingEnabled = true;
            this.cbx_ThangSinh.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cbx_ThangSinh.Location = new System.Drawing.Point(863, 221);
            this.cbx_ThangSinh.Name = "cbx_ThangSinh";
            this.cbx_ThangSinh.Size = new System.Drawing.Size(66, 29);
            this.cbx_ThangSinh.TabIndex = 46;
            // 
            // cbx_NgaySinh
            // 
            this.cbx_NgaySinh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbx_NgaySinh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_NgaySinh.FormattingEnabled = true;
            this.cbx_NgaySinh.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbx_NgaySinh.Location = new System.Drawing.Point(789, 220);
            this.cbx_NgaySinh.Name = "cbx_NgaySinh";
            this.cbx_NgaySinh.Size = new System.Drawing.Size(53, 29);
            this.cbx_NgaySinh.TabIndex = 45;
            // 
            // cbx_ThangBDLV
            // 
            this.cbx_ThangBDLV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbx_ThangBDLV.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_ThangBDLV.FormattingEnabled = true;
            this.cbx_ThangBDLV.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cbx_ThangBDLV.Location = new System.Drawing.Point(362, 551);
            this.cbx_ThangBDLV.Name = "cbx_ThangBDLV";
            this.cbx_ThangBDLV.Size = new System.Drawing.Size(53, 29);
            this.cbx_ThangBDLV.TabIndex = 44;
            // 
            // cbx_NgayBDLV
            // 
            this.cbx_NgayBDLV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbx_NgayBDLV.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_NgayBDLV.FormattingEnabled = true;
            this.cbx_NgayBDLV.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbx_NgayBDLV.Location = new System.Drawing.Point(277, 550);
            this.cbx_NgayBDLV.Name = "cbx_NgayBDLV";
            this.cbx_NgayBDLV.Size = new System.Drawing.Size(51, 29);
            this.cbx_NgayBDLV.TabIndex = 43;
            // 
            // cbx_ChucVu
            // 
            this.cbx_ChucVu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbx_ChucVu.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_ChucVu.ForeColor = System.Drawing.Color.Black;
            this.cbx_ChucVu.FormattingEnabled = true;
            this.cbx_ChucVu.ItemHeight = 22;
            this.cbx_ChucVu.Items.AddRange(new object[] {
            "Quản Lý",
            "Nhân Viên"});
            this.cbx_ChucVu.Location = new System.Drawing.Point(287, 483);
            this.cbx_ChucVu.Name = "cbx_ChucVu";
            this.cbx_ChucVu.Size = new System.Drawing.Size(243, 30);
            this.cbx_ChucVu.TabIndex = 41;
            // 
            // txt_Email
            // 
            this.txt_Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Email.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_Email.Location = new System.Drawing.Point(288, 615);
            this.txt_Email.Multiline = true;
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(243, 28);
            this.txt_Email.TabIndex = 40;
            this.txt_Email.Text = "someone@example.com";
            this.txt_Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Email.Enter += new System.EventHandler(this.txt_Email_Enter);
            this.txt_Email.Leave += new System.EventHandler(this.txt_Email_Leave);
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_DiaChi.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiaChi.ForeColor = System.Drawing.Color.Black;
            this.txt_DiaChi.Location = new System.Drawing.Point(288, 420);
            this.txt_DiaChi.Multiline = true;
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(243, 28);
            this.txt_DiaChi.TabIndex = 39;
            this.txt_DiaChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_MatKhau.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MatKhau.ForeColor = System.Drawing.Color.Black;
            this.txt_MatKhau.Location = new System.Drawing.Point(288, 355);
            this.txt_MatKhau.Multiline = true;
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.PasswordChar = '*';
            this.txt_MatKhau.Size = new System.Drawing.Size(243, 28);
            this.txt_MatKhau.TabIndex = 38;
            this.txt_MatKhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_MatKhau.TextChanged += new System.EventHandler(this.txt_MatKhau_TextChanged);
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_HoTen.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HoTen.ForeColor = System.Drawing.Color.Black;
            this.txt_HoTen.Location = new System.Drawing.Point(288, 221);
            this.txt_HoTen.Multiline = true;
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(243, 28);
            this.txt_HoTen.TabIndex = 37;
            this.txt_HoTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_HoTen.TextChanged += new System.EventHandler(this.txt_HoTen_TextChanged);
            // 
            // txt_CMND
            // 
            this.txt_CMND.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_CMND.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CMND.ForeColor = System.Drawing.Color.Black;
            this.txt_CMND.Location = new System.Drawing.Point(801, 553);
            this.txt_CMND.Multiline = true;
            this.txt_CMND.Name = "txt_CMND";
            this.txt_CMND.Size = new System.Drawing.Size(243, 28);
            this.txt_CMND.TabIndex = 32;
            this.txt_CMND.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_CMND.TextChanged += new System.EventHandler(this.txt_CMND_TextChanged);
            this.txt_CMND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CMND_KeyPress);
            // 
            // txt_MaNhanVien
            // 
            this.txt_MaNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_MaNhanVien.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaNhanVien.ForeColor = System.Drawing.Color.Black;
            this.txt_MaNhanVien.Location = new System.Drawing.Point(802, 486);
            this.txt_MaNhanVien.Multiline = true;
            this.txt_MaNhanVien.Name = "txt_MaNhanVien";
            this.txt_MaNhanVien.Size = new System.Drawing.Size(243, 28);
            this.txt_MaNhanVien.TabIndex = 33;
            this.txt_MaNhanVien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_MaNhanVien.TextChanged += new System.EventHandler(this.txt_MaNhanVien_TextChanged);
            // 
            // txt_MaXacNhan
            // 
            this.txt_MaXacNhan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_MaXacNhan.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaXacNhan.ForeColor = System.Drawing.Color.Black;
            this.txt_MaXacNhan.Location = new System.Drawing.Point(801, 415);
            this.txt_MaXacNhan.Multiline = true;
            this.txt_MaXacNhan.Name = "txt_MaXacNhan";
            this.txt_MaXacNhan.Size = new System.Drawing.Size(243, 28);
            this.txt_MaXacNhan.TabIndex = 34;
            this.txt_MaXacNhan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_MaXacNhan.TextChanged += new System.EventHandler(this.txt_MaXacNhan_TextChanged);
            // 
            // txt_SDT
            // 
            this.txt_SDT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_SDT.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SDT.ForeColor = System.Drawing.Color.Black;
            this.txt_SDT.Location = new System.Drawing.Point(801, 354);
            this.txt_SDT.Multiline = true;
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(243, 28);
            this.txt_SDT.TabIndex = 35;
            this.txt_SDT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_SDT.TextChanged += new System.EventHandler(this.txt_SDT_TextChanged);
            this.txt_SDT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_SDT_KeyDown);
            this.txt_SDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SDT_KeyPress);
            this.txt_SDT.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_SDT_KeyUp);
            // 
            // txt_TaiKhoan
            // 
            this.txt_TaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_TaiKhoan.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.txt_TaiKhoan.Location = new System.Drawing.Point(288, 288);
            this.txt_TaiKhoan.Multiline = true;
            this.txt_TaiKhoan.Name = "txt_TaiKhoan";
            this.txt_TaiKhoan.Size = new System.Drawing.Size(243, 28);
            this.txt_TaiKhoan.TabIndex = 36;
            this.txt_TaiKhoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_TaiKhoan.TextChanged += new System.EventHandler(this.txt_TaiKhoan_TextChanged);
            // 
            // btn_Dong
            // 
            this.btn_Dong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Dong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Dong.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dong.ForeColor = System.Drawing.Color.Red;
            this.btn_Dong.Image = global::SalesManagementSouvenir_App.Properties.Resources.img_DangNhap;
            this.btn_Dong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Dong.Location = new System.Drawing.Point(875, 625);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(151, 52);
            this.btn_Dong.TabIndex = 31;
            this.btn_Dong.Text = "Đóng";
            this.btn_Dong.UseVisualStyleBackColor = false;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // btn_DangKy
            // 
            this.btn_DangKy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_DangKy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_DangKy.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangKy.ForeColor = System.Drawing.Color.Red;
            this.btn_DangKy.Image = global::SalesManagementSouvenir_App.Properties.Resources.img_DangKy1;
            this.btn_DangKy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DangKy.Location = new System.Drawing.Point(718, 625);
            this.btn_DangKy.Name = "btn_DangKy";
            this.btn_DangKy.Size = new System.Drawing.Size(151, 52);
            this.btn_DangKy.TabIndex = 30;
            this.btn_DangKy.Text = " Đăng Ký";
            this.btn_DangKy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DangKy.UseVisualStyleBackColor = false;
            this.btn_DangKy.Click += new System.EventHandler(this.btn_DangKy_Click);
            // 
            // error_txt_SDT
            // 
            this.error_txt_SDT.ContainerControl = this;
            // 
            // error_CMND
            // 
            this.error_CMND.ContainerControl = this;
            // 
            // error_HoTen
            // 
            this.error_HoTen.ContainerControl = this;
            // 
            // error_TaiKhoan
            // 
            this.error_TaiKhoan.ContainerControl = this;
            // 
            // error_MatKhau
            // 
            this.error_MatKhau.ContainerControl = this;
            // 
            // error_MaXacNhan
            // 
            this.error_MaXacNhan.ContainerControl = this;
            // 
            // lb_KT
            // 
            this.lb_KT.AutoSize = true;
            this.lb_KT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lb_KT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lb_KT.Location = new System.Drawing.Point(768, 661);
            this.lb_KT.Name = "lb_KT";
            this.lb_KT.Size = new System.Drawing.Size(35, 13);
            this.lb_KT.TabIndex = 50;
            this.lb_KT.Text = "label1";
            // 
            // frm_DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SalesManagementSouvenir_App.Properties.Resources.img_MauDangKy_offical04;
            this.ClientSize = new System.Drawing.Size(1190, 770);
            this.Controls.Add(this.lb_KT);
            this.Controls.Add(this.cbx_GioiTinh);
            this.Controls.Add(this.cbx_NamSinh);
            this.Controls.Add(this.cbx_NamBDLV);
            this.Controls.Add(this.cbx_ThangSinh);
            this.Controls.Add(this.cbx_NgaySinh);
            this.Controls.Add(this.cbx_ThangBDLV);
            this.Controls.Add(this.cbx_NgayBDLV);
            this.Controls.Add(this.cbx_ChucVu);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.txt_MatKhau);
            this.Controls.Add(this.txt_HoTen);
            this.Controls.Add(this.txt_CMND);
            this.Controls.Add(this.txt_MaNhanVien);
            this.Controls.Add(this.txt_MaXacNhan);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.txt_TaiKhoan);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.btn_DangKy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_DangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần Mềm Quản Lý Bán Hàng Lưu Niệm";
            this.TransparencyKey = System.Drawing.Color.Purple;
            this.Load += new System.EventHandler(this.frm_DangKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error_txt_SDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_CMND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_HoTen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_TaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_MatKhau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_MaXacNhan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_GioiTinh;
        private System.Windows.Forms.ComboBox cbx_NamSinh;
        private System.Windows.Forms.ComboBox cbx_NamBDLV;
        private System.Windows.Forms.ComboBox cbx_ThangSinh;
        private System.Windows.Forms.ComboBox cbx_NgaySinh;
        private System.Windows.Forms.ComboBox cbx_ThangBDLV;
        private System.Windows.Forms.ComboBox cbx_NgayBDLV;
        private System.Windows.Forms.ComboBox cbx_ChucVu;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.TextBox txt_CMND;
        private System.Windows.Forms.TextBox txt_MaNhanVien;
        private System.Windows.Forms.TextBox txt_MaXacNhan;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.TextBox txt_TaiKhoan;
        private System.Windows.Forms.Button btn_Dong;
        private System.Windows.Forms.Button btn_DangKy;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ErrorProvider error_txt_SDT;
        private System.Windows.Forms.ErrorProvider error_CMND;
        private System.Windows.Forms.ErrorProvider error_HoTen;
        private System.Windows.Forms.ErrorProvider error_TaiKhoan;
        private System.Windows.Forms.ErrorProvider error_MatKhau;
        private System.Windows.Forms.ErrorProvider error_MaXacNhan;
        private System.Windows.Forms.Label lb_KT;
    }
}