using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace SalesManagementSouvenir_App
{
    public partial class frm_HoaDon : Form
    {
        public frm_HoaDon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                this.Hide();
                frm_Menu d = new frm_Menu();
                d.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public string ToText(string str)
        {
            string[] word = { "", " Một", " Hai", " Ba", " Bốn", " Năm", " Sáu", " Bẩy", " Tám", " Chín" };
            string[] million = { "", " Mươi", " Trăm", "" };
            string[] billion = { "", "", "", " Nghìn", "", "", " Triệu", "", "" };
            string result = "{0}";
            int count = 0;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (count > 0 && count % 9 == 0)
                    result = string.Format(result, "{0} Tỷ");
                if (!(count < str.Length - 3 && count > 2 && str[i].Equals('0') && str[i - 1].Equals('0') && str[i - 2].Equals('0')))
                    result = string.Format(result, "{0}" + billion[count % 9]);
                if (!str[i].Equals('0'))
                    result = string.Format(result, "{0}" + million[count % 3]);
                else if (count % 3 == 1 && count > 1 && !str[i - 1].Equals('0') && !str[i + 1].Equals('0'))
                    result = string.Format(result, "{0} Lẻ");
                var num = Convert.ToInt16(str[i].ToString());
                result = string.Format(result, "{0}" + word[num]);
                count++;
            }
            result = result.Replace("{0}", "");
            return result.Trim();
        }

        public void ThemHoaDon()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO HOADON(MaNV,NgayLap,MaKH) VALUES (" + lb_MaNV.Text + ",'" + lb_Ngay.Text + "'," + lb_MaKhach.Text + ")";
            cmd.Connection = conn;
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                }
                else
                {

                }
            }
            catch
            { }
            HienThiHoaDon();
            conn.Close();
        }

        public void CapNhatDaBan()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO CHITIETHOADON(MaHD,MaHang,SoLuongMua,DonGiaBan,ThanhTien) VALUES(" + lb_MaHD.Text + "," + lb_MaHang.Text + "," + txt_SoLuong.Text + "," + txt_DonGiaBan.Text + "," + txt_ThanhTien.Text + ")";
            cmd.Connection = conn;
            try
            {
                int ret = cmd.ExecuteNonQuery();
                if (ret > 0)
                {
                   // CapNhatSoLuong();
                  //  MessageBox.Show("Thêm chi tiết hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                  //  CapNhatSoLuong();
                  //  MessageBox.Show("Thêm chi tiết hóa đơn thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            { }

            conn.Close();
        }
        public void Them1()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO CHITIETHOADON(MaHD,MaHang,SoLuongMua,DonGiaBan,ThanhTien) VALUES(" + lb_MaHD.Text + "," + lb_MaHang.Text + ",0," + txt_DonGiaBan.Text + "," + txt_ThanhTien.Text + ")";
            cmd.Connection = conn;
            try
            {
                int ret = cmd.ExecuteNonQuery();
                if (ret > 0)
                {
                   // CapNhatSoLuong();
                   // MessageBox.Show("Thêm chi tiết hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                   // CapNhatSoLuong();
                  //  MessageBox.Show("Thêm chi tiết hóa đơn thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            { }
        }
        public void ThemChiTietHoaDon()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO CHITIETHOADON(MaHD,MaHang,SoLuongMua,DonGiaBan,ThanhTien) VALUES(" + lb_MaHD.Text + "," + lb_MaHang.Text + "," + txt_SoLuong.Text + "," + txt_DonGiaBan.Text + "," + txt_ThanhTien.Text + ")";
            cmd.Connection = conn;
            try
            {
                int ret = cmd.ExecuteNonQuery();
                if (ret >0 )
                {
                    CapNhatSoLuong();
                    MessageBox.Show("Thêm chi tiết hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    CapNhatSoLuong();
                    MessageBox.Show("Thêm chi tiết hóa đơn thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            { }

            conn.Close();
        }

        public void KiemTraTrangThai()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT TaiKhoan FROM TrangThai";
            cmd1.Connection = conn;
            SqlDataReader reader = cmd1.ExecuteReader();
            if (reader.Read())
            {
                lb_TrangThai.Text = reader.GetString(0).ToString();
            }
            conn.Close();
        }

        public void LoadMaNV()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT MaNV FROM NHANVIEN WHERE TaiKhoan ='" + lb_TrangThai.Text + "'";
            cmd1.Connection = conn;
            SqlDataReader reader = cmd1.ExecuteReader();
            if (reader.Read())
            {
                string a = reader.GetInt32(0).ToString();
                int b = Convert.ToInt32(a);
                if (b < 10)
                {
                    txt_MaNV.Text = "NV000" + (b).ToString();
                }
                else if (b > 9 && b < 100)
                {
                    txt_MaNV.Text = "NV00" + (b).ToString();
                }
                else if (b > 99 && b < 1000)
                {
                    txt_MaNV.Text = "NV0" + (b).ToString();
                }
            }
            conn.Close();
        }
        public void LoadMaNVCL()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT MaNV FROM NHANVIEN WHERE TaiKhoan ='" + lb_TrangThai.Text + "'";
            cmd1.Connection = conn;
            SqlDataReader reader = cmd1.ExecuteReader();
            if (reader.Read())
            {
                lb_MaNV.Text = reader.GetInt32(0).ToString();

            }
            conn.Close();
        }

        public void LayMaKhach()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT MaKH FROM KHACHHANG WHERE TenKhach = N'" + cbx_TenKhachHang.Text + "'";
            cmd1.Connection = conn;
            SqlDataReader reader = cmd1.ExecuteReader();
            if (reader.Read())
            {
                lb_MaKhach.Text = reader.GetInt32(0).ToString();
            }
            conn.Close();
        }

        public void MaHDMoi()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT MAX(MaHD) FROM HOADON ";
            cmd1.Connection = conn;
            try
            {
                SqlDataReader reader = cmd1.ExecuteReader();

                if (reader.Read())
                {
                    txt_MaHD.Text = "HD0001";
                    string a = reader.GetInt32(0).ToString();
                    int b = Convert.ToInt32(a);
                    if (b < 10)
                    {
                        txt_MaHD.Text = "HD000" + (b + 1).ToString();
                        lb_MaHD.Text = (b + 1).ToString();

                    }
                    else if (b > 9 && b < 100)
                    {
                        txt_MaHD.Text = "HD00" + (b + 1).ToString();
                        lb_MaHD.Text = (b + 1).ToString();
                    }
                    else if (b > 99 && b < 1000)
                    {
                        txt_MaHD.Text = "HD0" + (b + 1).ToString();
                        lb_MaHD.Text = (b + 1).ToString();
                    }
                }
                
                
                    
                
                
            }
            catch { }
            conn.Close();
        }


        public void LayMaHD()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT MaHD FROM CHITIETHOADON WHERE MaHD=" + lb_MaHD.Text + "";
            cmd1.Connection = conn;
            SqlDataReader reader = cmd1.ExecuteReader();
            if (reader.Read())
            {
                string a = reader.GetInt32(0).ToString();
                int b = Convert.ToInt32(a);
                if (b < 10)
                {
                    txt_MaHD.Text = "HD000" + (b).ToString();
                }
                else if (b > 9 && b < 100)
                {
                    txt_MaHD.Text = "HD00" + (b).ToString();
                }
                else if (b > 99 && b < 1000)
                {
                    txt_MaHD.Text = "HD0" + (b).ToString();
                }
            }
            conn.Close();
        }
        public void LayMaHD1()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT MaHD FROM HOADON WHERE NgayLap = '" + lb_NgayThemHoaDon.Text + "'";
            cmd1.Connection = conn;
            SqlDataReader reader = cmd1.ExecuteReader();
            if (reader.Read())
            {
                string a = reader.GetInt32(0).ToString();
                int b = Convert.ToInt32(a);
                if (b < 10)
                {
                    txt_MaHD.Text = "HD000" + (b).ToString();
                }
                else if (b > 9 && b < 100)
                {
                    txt_MaHD.Text = "HD00" + (b).ToString();
                }
                else if (b > 99 && b < 1000)
                {
                    txt_MaHD.Text = "HD0" + (b).ToString();
                }
            }
            conn.Close();
        }
        public void LayHang()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT TenHang FROM HANG";
            cmd1.Connection = conn;
            SqlDataReader reader = cmd1.ExecuteReader();
            while (reader.Read())
            {
                cbx_HangHoa.Items.Add(reader.GetString(0).ToString());
            }
            conn.Close();
        }

        public int ThanhTien()
        {

            int DonGiaNhap = Int32.Parse(txt_DonGiaBan.Text);
            int SoLuong = Int32.Parse(txt_SoLuong.Text);
            return DonGiaNhap * SoLuong;

        }






        public void HienThi()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            string sql = "SELECT HANG.TenHang,SoLuongMua,HANG.DonGiaBan,ThanhTien,HOADON.NGAYLAP,CHITIETHOADON.MaHD FROM CHITIETHOADON,HANG,HOADON WHERE HANG.MaHang = CHITIETHOADON.MaHang AND HOADON.MaHD = CHITIETHOADON.MaHD";
            SqlCommand com = new SqlCommand(sql, conn); //bat dau truy van
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu

            //da.Fill(dt);
            // đổ dữ liệu vào kho

            da.Fill(dt);

            dt.Columns.Add("STT");
            dataGridView1.Columns[0].Width = 200;


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["STT"] = i + 1;

                dataGridView1.DataSource = dt;
                dataGridView1.Columns["STT"].DisplayIndex = 0;
                //dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Cyan;
            }

            conn.Close();  // đóng kết nối
            dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview
        }
        public void TongTien()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT SUM(ThanhTien) as TongThanhToan FROM CHITIETHOADON WHERE MaHD = " + lb_MaHD.Text + "";
            cmd1.Connection = conn;
            try
            {
                SqlDataReader reader = cmd1.ExecuteReader();
                if (reader.Read())
                {
                    txt_TongThanhToan.Text = reader.GetDouble(0).ToString();
                   // txt_ThanhToan.Text = ToText(txt_TongThanhToan.Text);
                    txt_ThanhToan.Text = _DoiTienSoSangTienChu(txt_TongThanhToan.Text);
                }
            }
            catch
            {
            }
        }

        //Load Form Hoá Đơn
        private void frm_HoaDon_Load(object sender, EventArgs e)
        {
            this.lb_GoiY.BackColor = Color.Transparent;
            this.lb_GoiY2.BackColor = Color.Transparent;
            
            btn_XoaHoaDon.Enabled = true;
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT TenKhach FROM KHACHHANG";
            cmd1.Connection = conn;
            SqlDataReader reader = cmd1.ExecuteReader();
            while (reader.Read())
            {
                cbx_TenKhachHang.Items.Add(reader.GetString(0).ToString());
            }

            KiemTraTrangThai();
            LoadMaNV();
            LoadMaNVCL();
            LayHang();
            HienThi();
            HienThiHoaDon();
           // this.pn_HoaDon.BackColor = System.Drawing.Color.White;
            DateTime dt = DateTime.Now;
            txt_NgayThemHoaDon.Text = lb_Ngay.Text;
            txt_NgayThemHoaDon.Text = dt.ToString("dd/MM/yyyy hh:mm:ss");
        }

        #region Code Lỗi
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        #endregion

        public void LaySoLuongTon()
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
                conn.Open();
                SqlCommand cmd1 = new SqlCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "SELECT SUM(SoLuongMua) FROM CHITIETHOADON WHERE MaHang = " + lb_MaHang.Text + "";
                cmd1.Connection = conn;
                SqlDataReader reader = cmd1.ExecuteReader();
                if (reader.Read())
                {
                    lb_SoLuongDaBan.Text = reader.GetInt32(0).ToString();
                }
                else
                {
                    lb_SoLuongDaBan.Text = "0";
                }
            }
            catch
            {
                lb_SoLuongDaBan.Text = "0";
            }
            
           
        }
        public void SoLuongTrongKho()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT SoLuong FROM HANG WHERE MaHang = " + lb_MaHang.Text + "";
            cmd1.Connection = conn;
            SqlDataReader reader = cmd1.ExecuteReader();
            if (reader.Read())
            {
                lb_SoLuongKho.Text = reader.GetInt32(0).ToString();
            }
        }

        public int HangConLai()
        {
            int a = Int32.Parse(lb_SoLuongKho.Text);
            int b = Int32.Parse(lb_SoLuongDaBan.Text);
            return a - b;
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

           // this.pn_HoaDon.BackColor = System.Drawing.Color.White;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        public void HienThiHoaDon()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            string sql = "SELECT MaHD,NgayLap,MaNV,KHACHHANG.TenKhach,TongTien FROM HOADON,KHACHHANG WHERE HOADON.MaKH = KHACHHANG.MaKH";
            SqlCommand com = new SqlCommand(sql, conn); //bat dau truy van
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu

            //da.Fill(dt);
            // đổ dữ liệu vào kho

            da.Fill(dt);
            dt.Columns.Add("STT");
            dataGridView2.Columns[0].Width = 200;


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["STT"] = i + 1;

                dataGridView2.DataSource = dt;
                dataGridView2.Columns["STT"].DisplayIndex = 0;
                //dataGridView2.Rows[i].DefaultCellStyle.BackColor = Color.Cyan;
            }

            conn.Close();  // đóng kết nối
            dataGridView2.DataSource = dt; //đổ dữ liệu vào datagridview
        }

        public void LayMaHang()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT MaHang FROM HANG WHERE TenHang = N'" + cbx_HangHoa.Text + "'";
            cmd1.Connection = conn;
            SqlDataReader reader = cmd1.ExecuteReader();
            if (reader.Read())
            {
                lb_MaHang.Text = reader.GetInt32(0).ToString();
            }
        }

        private void cbx_HangHoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT DonGiaBan,MaHang FROM HANG WHERE TenHang = N'" + cbx_HangHoa.Text + "'";
            cmd1.Connection = conn;
            SqlDataReader reader = cmd1.ExecuteReader();
            while (reader.Read())
            {

                txt_DonGiaBan.Text = reader.GetDouble(0).ToString();
                //txt_DonGiaBan.Text = String.Format("{0:c}");

            }


            LayMaHang();
            LaySoLuongTon();
            SoLuongTrongKho();
            DaBan();
            DateTime dt = DateTime.Now;
            txt_NgayThemHoaDon.Text = lb_Ngay.Text;
            txt_NgayThemHoaDon.Text = dt.ToString("dd/MM/yyyy hh:mm:ss");
        }

        //Tính tiển
        private void btn_ThemDonHnagMi_Click(object sender, EventArgs e)
        {
            


        }

        //Sự Kiện click cell Dtgv
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    txt_MaHD.Text = null;
                    //LayMaIn();
                    cbx_HangHoa.Text = row.Cells[0].Value.ToString();
                    lb_MaHD1.Text = row.Cells[5].Value.ToString(); ;
                    txt_SoLuong.Text = row.Cells[1].Value.ToString();
                    txt_DonGiaBan.Text = row.Cells[2].Value.ToString();
                    txt_ThanhTien.Text = row.Cells[3].Value.ToString();
                    txt_NgayThemHoaDon.Text = row.Cells[4].Value.ToString();
                    lb_STT.Text = row.Cells[5].Value.ToString();
                }
                LayMaHD();
                LayMaIn();

            }
            catch { }
        }

        //Xóa Chi Tiết Hóa Đơn
        public void XoaChiTietHoaDon()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "DELETE FROM CHITIETHOADON WHERE CHITIETHOADON.MaHang = " + lb_MaHang.Text + " AND CHITIETHOADON.MaHD = '" + lb_MaHD1.Text + "'";
            cmd1.Connection = conn;
            try
            {
                int ret = cmd1.ExecuteNonQuery();
                if (ret > 0)
                {
                    MessageBox.Show("Xóa chi tiết đơn hàng thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

            }
            catch { };
            HienThi();
        }

        #region Code Lỗi
        private void btn_Thêm_Click(object sender, EventArgs e)
        {
            
        }
        public void XoaHoaDon()
        {
           
        }
        #endregion

        public void XoaHoaDonRangBuoc()
        {

            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "DELETE FROM HOADON WHERE MaHD = " + lb_MaHD.Text + "";
            cmd1.Connection = conn;
            try
            {
                int ret = cmd1.ExecuteNonQuery();
                if (ret > 0)
                {
                    MessageBox.Show("Xóa hóa đơn thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Xóa hóa đơn thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {

            };
            HienThi();

        }
        private void cbx_TenKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            LayMaKhach();
        }

        #region Code Lỗi
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #endregion

        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            try
            {
                MaHDMoi();
                int b = Convert.ToInt32(lb_MaHD.Text);
                lb_MaHD.Text = (b + 1).ToString();
                DateTime dt = DateTime.Now;
                txt_NgayThemHoaDon.Text = lb_Ngay.Text;
                txt_NgayThemHoaDon.Text = dt.ToString("dd/MM/yyyy hh:mm:ss");
            }
            catch
            { }
        }
        public void XoaNhieuChiTiet()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "DELETE FROM CHITIETHOADON WHERE MaHD = " + lb_MaHD.Text + "";
            cmd1.Connection = conn;
            try
            {
                int ret = cmd1.ExecuteNonQuery();
                if (ret > 0)
                {
                   // MessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                   // MessageBox.Show("Xóa  cthất thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch { };
            HienThi();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

        }




        // Đưa ngày lên biến trên form, Ngày thay đổi 
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lb_Ngay.Text = dt.ToString("dd/MM/yyyy hh:mm:ss");
        }
        
        #region Code Lỗi
        private void btn_XoaHoaDon_Click(object sender, EventArgs e)
        {
            
        }
        #endregion
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView2.SelectedRows)
                {
                    btn_XoaHoaDon.Enabled = true; ;
                    lb_MaHD.Text = row.Cells[0].Value.ToString();
                    lb_NgayThemHoaDon.Text = row.Cells[1].Value.ToString();
                }
                LayMaHD1();
                LayMaIn();

            }
            catch { }
        }
        #region code Lỗi
        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Thêm_MouseMove(object sender, MouseEventArgs e)
        {

            //this.pn_HoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(2)))), ((int)(((byte)(86)))));
            //this.btn_Thêm.BackColor = Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(39)))), ((int)(((byte)(114)))));
            //this.btn_Sua.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            //this.btn_Xoa.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            //this.btn_ThemDonHnagMi.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
        }

        private void btn_Sua_MouseMove(object sender, MouseEventArgs e)
        {
            //this.pn_HoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(2)))), ((int)(((byte)(86)))));
            //this.btn_Sua.BackColor = Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(39)))), ((int)(((byte)(114)))));
            //this.btn_Xoa.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            //this.btn_ThemDonHnagMi.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            //this.btn_Thêm.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
        }

        private void btn_Xoa_MouseMove(object sender, MouseEventArgs e)
        {
            //this.pn_HoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(2)))), ((int)(((byte)(86)))));
            //// this.btn_Xoa.BackColor = Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(39)))), ((int)(((byte)(114)))));
            //this.btn_Xoa.BackColor = Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(39)))), ((int)(((byte)(114)))));
            //this.btn_Sua.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            //// this.btn_Xoa.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            //this.btn_ThemDonHnagMi.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            //this.btn_Thêm.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
        }

        private void btn_ThemDonHnagMi_MouseMove(object sender, MouseEventArgs e)
        {
            //this.pn_HoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(2)))), ((int)(((byte)(86)))));
            //this.btn_ThemDonHnagMi.BackColor = Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(39)))), ((int)(((byte)(114)))));
            //this.btn_Sua.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            //this.btn_Xoa.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            //this.btn_Thêm.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
        }

        private void pn_HoaDon_MouseMove(object sender, MouseEventArgs e)
        {
            //this.pn_HoaDon.BackColor = System.Drawing.Color.White;
            //this.pn_ChiTiet.BackColor = System.Drawing.Color.White;
            //this.button5.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            //this.btn_TaoMoi.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            //this.button4.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            //this.btn_XoaHoaDon.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
        }

        private void frm_HoaDon_MouseMove(object sender, MouseEventArgs e)
        {
            //this.pn_HoaDon.BackColor = System.Drawing.Color.White;
            //this.pn_ChiTiet.BackColor = System.Drawing.Color.White;
            //this.button5.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            //this.btn_TaoMoi.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            //this.button4.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            //this.btn_XoaHoaDon.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));

            //this.btn_Thêm.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            //this.btn_Sua.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            //this.btn_Xoa.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            //this.btn_ThemDonHnagMi.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
        }

        private void btn_TaoMoi_MouseMove(object sender, MouseEventArgs e)
        {
            //this.pn_ChiTiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(2)))), ((int)(((byte)(86)))));
            //this.btn_TaoMoi.BackColor = Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(39)))), ((int)(((byte)(114)))));
            //this.button5.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            //this.button4.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            //this.btn_XoaHoaDon.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
        }

        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            //this.pn_ChiTiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(2)))), ((int)(((byte)(86)))));
            //this.button5.BackColor = Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(39)))), ((int)(((byte)(114)))));
            //this.btn_TaoMoi.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            //this.button4.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            //this.btn_XoaHoaDon.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));

        }

        private void btn_XoaHoaDon_MouseMove(object sender, MouseEventArgs e)
        {
            //this.pn_ChiTiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(2)))), ((int)(((byte)(86)))));
            //this.btn_XoaHoaDon.BackColor = Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(39)))), ((int)(((byte)(114)))));
            //this.button5.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            //this.btn_TaoMoi.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            //this.button4.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            //this.pn_ChiTiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(2)))), ((int)(((byte)(86)))));
            //this.button4.BackColor = Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(39)))), ((int)(((byte)(114)))));
            //this.button5.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            //this.btn_TaoMoi.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            //this.btn_XoaHoaDon.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
        }
        #endregion
        public void CapNhapTongTien()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandType = CommandType.Text;
            try
            {
                cmd1.CommandText = "UPDATE HOADON SET TongTien = " + txt_TongThanhToan.Text + " WHERE MaHD = " + lb_MaHD.Text + "";
                cmd1.Connection = conn;
                int ret = cmd1.ExecuteNonQuery();
                if (ret > 0)
                {
                   // MessageBox.Show("Cập Nhập Thành Công", "Thông báo");
                }
            }
            catch
            {
            }
        }
        private void btn_TongThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                TongTien();
                CapNhapTongTien();
                HienThiHoaDon();
            }
            catch { }
        }
        #region Code Lỗi
        public void SuaChiTiet()
        {
        }


        private void button5_Click(object sender, EventArgs e)
        {
            

        }
        #endregion

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                SuaChiTiet();
                HienThi();
            }
            catch { }
        }

        private void txt_SoLuong_TextChanged(object sender, EventArgs e)
        {
            this.btn_Thêm.Enabled = false;
            this.btn_Sua.Enabled = false;
        }

        public void XemHoaDon()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            string sql = "SELECT HANG.TenHang,SoLuongMua,HANG.DonGiaBan,ThanhTien,HOADON.NGAYLAP,CHITIETHOADON.MaHD FROM CHITIETHOADON,HANG,HOADON WHERE HANG.MaHang = CHITIETHOADON.MaHang AND HOADON.MaHD = CHITIETHOADON.MaHD AND CHITIETHOADON.MaHD = " + txt_XemHoaDon.Text + "";
            SqlCommand com = new SqlCommand(sql, conn); //bat dau truy van
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu

            //da.Fill(dt);
            // đổ dữ liệu vào kho

            da.Fill(dt);
            dt.Columns.Add("STT");
            dataGridView1.Columns[0].Width = 200;


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["STT"] = i + 1;

                dataGridView1.DataSource = dt;
                dataGridView1.Columns["STT"].DisplayIndex = 0;
                //dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Cyan;
            }

            conn.Close();  // đóng kết nối
            dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview
        }
        #region Code Lỗi
        private void btn_XemHoaDon_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            
        }
        #endregion

        #region  Chuyển Tiền Thành Chữ
        private string _ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        
        private string _DoiSoSangChu(int So)
        {
            So = So - 48;
            switch (So)
            {
                case 0:
                    {
                        return "không";
                    }
                case 1:
                    {
                        return "một";
                    }
                case 2:
                    {
                        return "hai";
                    }
                case 3:
                    {
                        return "ba";
                    }
                case 4:
                    {
                        return "bốn";
                    }
                case 5:
                    {
                        return "năm";
                    }
                case 6:
                    {
                        return "sáu";
                    }
                case 7:
                    {
                        return "bảy";
                    }
                case 8:
                    {
                        return "tám";
                    }
                case 9:
                    {
                        return "chín";
                    }
                default:
                    {
                        return "số không hợp lệ";
                    }
            }
        }

        private string _SentenceCase(string input)
        {
            if (input.Length < 1)
                return input;

            string sentence = input.ToLower();
            return sentence[0].ToString().ToUpper() +
               sentence.Substring(1);
        }
        
        private string _DoiTienSoSangTienChu(object SoTien)
        {
            string KetQua = "";
            try
            {
                decimal dSoTien = Convert.ToDecimal(SoTien);
                string strTien = dSoTien.ToString();
                string[] BoNho = new string[strTien.Length];
                strTien = _ReverseString(strTien);

                if (dSoTien == 0)
                {
                    return "Không đồng chẵn";
                }

                for (int i = 0; i < strTien.Length; i++)
                {
                    if (i == 0)
                    {
                        BoNho[i] = _DoiSoSangChu(Convert.ToInt32(strTien[i])) + " ";
                        if (BoNho[i] == "không ")
                        {
                            BoNho[i] = "";
                        }
                    }
                    else if (i == 1)
                    {
                        BoNho[i] = _DoiSoSangChu(Convert.ToInt32(strTien[i])) + " mươi ";
                        if (BoNho[i] == "không mươi ")
                        {
                            if (BoNho[i - 1] == "")
                            {
                                BoNho[i] = "";
                            }
                            else
                            {
                                BoNho[i] = "lẻ ";
                            }
                        }
                    }
                    else if (i == 2)
                    {
                        BoNho[i] = _DoiSoSangChu(Convert.ToInt32(strTien[i])) + " trăm ";
                        if (BoNho[i] == "không trăm ")
                        {
                            BoNho[i] = "";
                        }
                        //else if (BoNho[i] == "không") 
                        //{
                        //    BoNho[i] = "lẻ ";
                        //}
                    }
                    else if (i == 3)
                    {
                        BoNho[i] = _DoiSoSangChu(Convert.ToInt32(strTien[i])) + " ngàn ";
                        if (BoNho[i] == "không ngàn ")
                        {
                            BoNho[i] = "ngàn ";
                        }
                        //else if (BoNho[i] == "không")
                        //{
                        //    BoNho[i] = "lẻ ";
                        //}
                    }
                    else if (i == 4)
                    {
                        BoNho[i] = _DoiSoSangChu(Convert.ToInt32(strTien[i])) + " mươi ";
                        if (BoNho[i] == "không mươi ")
                        {
                            BoNho[i] = "lẻ ";
                        }
                    }
                    else if (i == 5)
                    {
                        BoNho[i] = _DoiSoSangChu(Convert.ToInt32(strTien[i])) + " trăm ";
                        //if (BoNho[i] == "không trăm ")
                        //{
                        //    BoNho[i] = "";
                        //}
                        //else if (BoNho[i] == "không")
                        //{
                        //    BoNho[i] = "lẻ ";
                        //}
                    }
                    else if (i == 6)
                    {
                        BoNho[i] = _DoiSoSangChu(Convert.ToInt32(strTien[i])) + " triệu ";
                        if (BoNho[i] == "không triệu ")
                        {
                            BoNho[i] = "triệu ";
                        }
                        //else if (BoNho[i] == "không")
                        //{
                        //    BoNho[i] = "lẻ ";
                        //}
                    }
                    else if (i == 7)
                    {
                        BoNho[i] = _DoiSoSangChu(Convert.ToInt32(strTien[i])) + " mươi ";
                        if (BoNho[i] == "không mươi ")
                        {
                            BoNho[i] = "lẻ ";
                        }
                        //else if (BoNho[i] == "không")
                        //{
                        //    BoNho[i] = "lẻ ";
                        //}
                    }
                    else if (i == 8)
                    {
                        BoNho[i] = _DoiSoSangChu(Convert.ToInt32(strTien[i])) + " trăm ";
                        //if (BoNho[i] == "không trăm ")
                        //{
                        //    BoNho[i] = "";
                        //}
                        //else if (BoNho[i] == "không")
                        //{
                        //    BoNho[i] = "lẻ ";
                        //}
                    }
                    else if (i == 9)
                    {
                        BoNho[i] = _DoiSoSangChu(Convert.ToInt32(strTien[i])) + " tỉ ";
                        if (BoNho[i] == "không tỉ ")
                        {
                            BoNho[i] = "";
                        }
                        //else if (BoNho[i] == "không")
                        //{
                        //    BoNho[i] = "lẻ ";
                        //}
                    }
                    else if (i == 10)
                    {
                        BoNho[i] = _DoiSoSangChu(Convert.ToInt32(strTien[i])) + " mươi ";
                        if (BoNho[i] == "không mươi ")
                        {
                            BoNho[i] = "lẻ ";
                        }
                        //else if (BoNho[i] == "lẻ")
                        //{
                        //    BoNho[i] = "lẻ ";
                        //}
                    }
                    else if (i == 11)
                    {
                        BoNho[i] = _DoiSoSangChu(Convert.ToInt32(strTien[i])) + " trăm ";
                        //if (BoNho[i] == "không trăm ")
                        //{
                        //    BoNho[i] = "";
                        //}
                        //else if (BoNho[i] == "không")
                        //{
                        //    BoNho[i] = "lẻ ";
                        //}
                    }
                    else if (i == 12)
                    {
                        BoNho[i] = _DoiSoSangChu(Convert.ToInt32(strTien[i])) + " ngàn ";
                        if (BoNho[i] == "không ngàn ")
                        {
                            BoNho[i] = "";
                        }
                        //else if (BoNho[i] == "không")
                        //{
                        //    BoNho[i] = "lẻ ";
                        //}
                    }
                }

                for (int i = strTien.Length - 1; i >= 0; i--)
                {
                    KetQua += BoNho[i];
                }

                KetQua += "đồng chẵn.";
                KetQua = KetQua.Replace("hai mươi một", "hai mươi mốt");
                KetQua = KetQua.Replace("ba mươi một", "ba mươi mốt");
                KetQua = KetQua.Replace("bốn mươi một", "bốn mươi mốt");
                KetQua = KetQua.Replace("năm mươi một", "năm mươi mốt");
                KetQua = KetQua.Replace("sáu mươi một", "sáu mươi mốt");
                KetQua = KetQua.Replace("bảy mươi một", "bảy mươi mốt");
                KetQua = KetQua.Replace("tám mươi một", "tám mươi mốt");
                KetQua = KetQua.Replace("chín mươi một", "chín mươi mốt");
                KetQua = KetQua.Replace("không trăm lẻ ngàn", "");
                KetQua = KetQua.Replace("không trăm lẻ triệu", "");
                KetQua = KetQua.Replace("không trăm lẻ tỉ", "");
                KetQua = KetQua.Replace("triệu lẻ ngàn", "triệu");
                KetQua = KetQua.Replace("mươi một", "mười một");
                KetQua = KetQua.Replace("một mươi", "mười");
                KetQua = KetQua.Replace("lẻ ngàn", "ngàn");
                KetQua = _SentenceCase(KetQua);
            }
            catch (Exception)
            {

            }
            return KetQua;
        }
        #endregion

        public void CapNhatSoLuong()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandType = CommandType.Text;
            try
            {
                cmd1.CommandText = "UPDATE HANG SET DaBan = "+lb_DaBan.Text+" WHERE MaHang = " + lb_MaHang.Text + "";
                cmd1.Connection = conn;
                int ret = cmd1.ExecuteNonQuery();
                if (ret > 0)
                {
                    //MessageBox.Show("Thêm hóa đơn thành công","Thành công",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch
            {
            }
        }

        public void Them()
        {
 
        }

        private void btn_Thêm_Click_1(object sender, EventArgs e)
        {
            //CapNhatSoLuong();
            try
            {
                int c = HangConLai();
                int d = Int32.Parse(txt_SoLuong.Text);
                if (d <= c)
                {
                    ThemChiTietHoaDon();
                    CapNhatSoLuong();
                    //Them1();
                    CapNhatDaBan();
                    CapNhatSoLuong();
                    
                    HienThi();
                    CapNhatSoLuong();
                    Them1();
                    CapNhatSoLuong();
                    //Them1();
                    CapNhatDaBan();
                    CapNhatSoLuong();

                    HienThi();
                    CapNhatSoLuong();
                    txt_SoLuong.ResetText();
                    cbx_HangHoa.ResetText();
                }
                else if (c <= 0)
                {
                    MessageBox.Show("Sản phẩm đã bán hết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

                else
                {
                    MessageBox.Show("Trong kho chỉ còn " + c + " sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch { }
        }
        public void DaBan()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT SUM(SoLuongMua) FROM CHITIETHOADON,HANG WHERE HANG.MaHang = CHITIETHOADON.MaHang AND HANG.MaHang = "+lb_MaHang.Text+" ";
            cmd1.Connection = conn;
            try
            {
                SqlDataReader reader = cmd1.ExecuteReader();
                if (reader.Read())
                {

                    lb_DaBan.Text = reader.GetInt32(0).ToString();
                }
                else
                {
                    lb_DaBan.Text = txt_SoLuong.Text;
                }
            }
            catch
            {
                int a = 0;
                lb_DaBan.Text = a.ToString();
            }
        }

        public void KiemTraSoLuong()
        {
            int a = Int32.Parse(lb_DaBan.Text);
            
            int b = Int32.Parse(txt_SoLuong.Text);
            int c = a - b;
            if (c >= 0)
            { }
            else
            { }
        }


        public void SuaCTHD()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandType = CommandType.Text;
            try
            {


                {
                    cmd1.CommandText = "UPDATE CHITIETHOADON SET SoLuongMua = " + txt_SoLuong.Text + ",ThanhTien = " + txt_ThanhTien.Text + " WHERE MaHD = " + lb_MaHD.Text + " AND MaHang = " + lb_MaHang.Text + "";
                    cmd1.Connection = conn;

                    int ret = cmd1.ExecuteNonQuery();
                    if (ret > 0)
                    {
                        MessageBox.Show("Cập Nhập Thành Công", "Thông báo");
                    }
                }

            }
            catch
            {
            }
        }
        private void btn_Sua_Click_1(object sender, EventArgs e)
        {  
            //try
            //{
               
            //    int d = Int32.Parse(txt_SoLuong.Text);
            //    int c = HangConLai();
            //    if (d <= c)
            //    {
            //        SuaCTHD();
            //        CapNhatSoLuong();
            //        HienThi();
            //        txt_SoLuong.ResetText();
            //        cbx_HangHoa.ResetText();
            //    }
            //    else if (c <= 0)
            //    {
            //        MessageBox.Show("Sản phẩm đã bán hết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    }

            //    else
            //    {
            //        MessageBox.Show("Trong kho chỉ còn " + c + " sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    }
            //}
            //catch { }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                ThemHoaDon();
                HienThiHoaDon();
            }
            catch { };
        }

        private void btn_TaoMoi_Click(object sender, EventArgs e)
        {
            MaHDMoi();
        }
        public void LayMaIn()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT MaHDIn FROM TRANGTHAIIN";
            cmd.Connection = conn;
            //try
            //{
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lb_MaIn1.Text = reader.GetInt32(0).ToString();
                    
                    // MessageBox.Show("Thêm Thông Tin Thành Công !", "Thông báo", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Asterisk);
                }
            //}
            //catch { }
        }
        public void ThemMaIn()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE TRANGTHAIIN SET MaHDIn = "+lb_MaHD.Text+ " WHERE MaHDIn = "+lb_MaIn1.Text+"";
            cmd.Connection = conn;
           // try
            //{
                int ret = cmd.ExecuteNonQuery();
                if (ret > 0)
                {
                   // MessageBox.Show("Thêm Thông Tin Thành Công !", "Thông báo", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Asterisk);
                }
           // }
           // catch
           // { }

            conn.Close();
        }

        private void btn_XoaHoaDon_Click_1(object sender, EventArgs e)
        {
            try
            {
                XoaHoaDonRangBuoc();
                XoaNhieuChiTiet();
                HienThiHoaDon();
            }
            catch
            {

            }
        }

        private void btn_XemHoaDon_Click_1(object sender, EventArgs e)
        {
            try
            {
                XemHoaDon();
            }
            catch
            {
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            
          // conn.Close();

            //try {

            //    
            //}
            //catch {
                
            //}
        }

        private void btn_Home_Click_1(object sender, EventArgs e)
        {
            txt_XemHoaDon.ResetText();
            HienThi();
        }

        private void btn_Xoa_Click_1(object sender, EventArgs e)
        {
            try
            {
                CapNhatSoLuong();
                XoaChiTietHoaDon();

            }
            catch { }
        }

        private void btn_ThemDonHnagMi_Click_1(object sender, EventArgs e)
        {
            this.btn_Thêm.Enabled = true;
            this.btn_Sua.Enabled = true;
            try
            {
                SoLuongTrongKho();
                txt_ThanhTien.Text = ThanhTien().ToString();

            }
            catch
            {
            }
        }

        private void XHD_Click_1(object sender, EventArgs e)
        {
            //LayMaIn();
            ThemMaIn();
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT  * FROM THONGTINSHOP";
            cmd.Connection = conn;
            //try
            //{
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string b = reader.GetString(0);
                    if (b != "")
                    {
                        this.Close();
                        frm_MauHoaDon c = new frm_MauHoaDon();
                        c.Show();
                    };
                }else
                {
                    this.Close();
                    frm_ThongTinCuaHang a = new frm_ThongTinCuaHang();
                    a.Show();
                }
                    
                    // MessageBox.Show("Thêm Thông Tin Thành Công !", "Thông báo", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Asterisk);
                
            //}
            //catch
            //{ }
            conn.Close();
        }

        private void txt_XemHoaDon_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_XemHoaDon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsDigit(e.KeyChar) || e.KeyChar == 8))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void frm_HoaDon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.P)
            {
                this.Hide();
                frm_CaNhan CaNhan = new frm_CaNhan();
                CaNhan.Show();
            }
            if (e.Control == true && e.KeyCode == Keys.E)
            {
                this.Hide();
                frm_NhanVien01 NhanVien = new frm_NhanVien01();
                NhanVien.Show();
            }
            if (e.Control == true && e.KeyCode == Keys.R)
            {
                this.Hide();
                frm_BaoCao BaoCao = new frm_BaoCao();
                BaoCao.Show();
            }
            if (e.Control == true && e.KeyCode == Keys.G)
            {
                this.Hide();
                frm_HangHoa HangHoa = new frm_HangHoa();
                HangHoa.Show();
            }
            if (e.Control == true && e.KeyCode == Keys.B)
            {
                this.Hide();
                frm_HoaDon HoaDon = new frm_HoaDon();
                HoaDon.Show();
            }
            if (e.Control == true && e.KeyCode == Keys.C)
            {
                this.Hide();
                frm_KhachHang KhachHang = new frm_KhachHang();
                KhachHang.Show();

            }
        }
    }
}