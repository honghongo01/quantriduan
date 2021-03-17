using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SalesManagementSouvenir_App
{
    public partial class frm_HangHoa : Form
    {
        public frm_HangHoa()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void btn_ThemAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png| ALL Files(*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string picPath = dlg.FileName.ToString();
                duongdan.Text = picPath;

                pb_AVATAR.ImageLocation = picPath;
                pb_AVATAR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            }
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "UPDATE HANG SET AnhHH= N'" + duongdan.Text + "' WHERE TenHang = N'" + txt_TenHang.Text + "'";
            cmd1.Connection = conn;
            int ret = cmd1.ExecuteNonQuery();
            if (ret > 0)
            {
                MessageBox.Show("Lưu Ảnh thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Lưu Ảnh thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        

        
            public void HienThi()
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                string sql = "select SoLuong,TenHang,DonGiaNhap,DonGiaBan,NguonGoc,NgayNhapKho,TenChatLieu,ChiPhi from HANG"; // lay het du lieu trong bang sinh vien
                SqlCommand com = new SqlCommand(sql, conn); //bat dau truy van
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
                DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu

                //da.Fill(dt);
                // đổ dữ liệu vào kho

                da.Fill(dt);
                dt.Columns.Add("STT");
                dataGridView1.Columns[0].Width = 25;
                //dt.Columns.Add("Ảnh");
                //dataGridView1.Columns[1].Width = 300;


                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["STT"] = i + 1;

                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns["STT"].DisplayIndex = 0;
//dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Cyan;

                    ThongTinBoSung();
                }

                conn.Close();  // đóng kết nối
                dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview
                
            }
                catch
            {
            }
        }
        


        private void frm_HangHoa_Load(object sender, EventArgs e)
        {
            string.Format("{0:0,0}", txt_DonGiaNhap);
            HienThi();
            TaoMoi();
            //ThongTinBoSung();
            //LayHinhAnh();
        }
        public void LayMaHangMoi()
        {
            try
            {
                TaoMoi();
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT Max(MaHang) FROM HANG";
                cmd.Connection = conn;
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int a = reader.GetInt32(0);
                    lb_MaHangMoi.Text = (a).ToString();
                }
            }
            catch { lb_MaHangMoi.Text = "1"; }
        }

        public void MaHangUpdate()
        {
            TaoMoi();
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT MaHang FROM HANG WHERE TenHang = N'"+txt_TenHang.Text+"'";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                int a = reader.GetInt32(0);
                lb_MaHang1.Text = (a).ToString();
            }
        }

        public void LayMaHang()
        {

            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT  MaHang FROM HANG WHERE TenHang=N'"+txt_TenHang.Text+"'";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                int b = reader.GetInt32(0);
                lb_MaHang.Text = (b+1).ToString();
                if (b < 10)
                {
                    txt_MaHang.Text = "HH000" + (b).ToString();
                }
                else if (b > 9 && b < 100)
                {
                    txt_MaHang.Text = "HH00" + (b).ToString();
                }
                else if (b > 99 && b < 1000)
                {
                    txt_MaHang.Text = "HH0" + (b).ToString();
                }
            }
        }

        public void TaoMoi()
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT   MAX(MaHang) FROM HANG";
                cmd.Connection = conn;
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    //int a = reader.GetInt32(0);
                    //lb_MaHang.Text = (a + 1).ToString();
                    int b = reader.GetInt32(0);
                    if (b < 10)
                    {
                        txt_MaHang.Text = "HH000" + (b + 1).ToString();
                    }
                    else if (b > 9 && b < 100)
                    {
                        txt_MaHang.Text = "HH00" + (b + 1).ToString();
                    }
                    else if (b > 99 && b < 1000)
                    {
                        txt_MaHang.Text = "HH0" + (b + 1).ToString();
                    }
                }
            }
            catch { }
        }
        public void ThongTinBoSung()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT MaHang,AnhHH,GhiChu FROM HANG WHERE TenHang  = N'"+txt_TenHang.Text+"'";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                int b = reader.GetInt32(0);
                if (b < 10)
                {
                    txt_MaHang.Text = "HH000" + (b).ToString();
                }
                else if (b > 9 && b < 100)
                {
                    txt_MaHang.Text = "HH00" + (b).ToString();
                }
                else if (b > 99 && b < 1000)
                {
                    txt_MaHang.Text = "HH0" + (b).ToString();
                }
                 txt_MoTa.Text = reader.GetString(2);
               // int a = reader.GetString(3).ToString(); ;
            }
            
                    try
                    {
                        if (reader.HasRows)
                        {
                            string hinhanh;
                            hinhanh = reader[1].ToString();
                            pb_AVATAR.Image = System.Drawing.Image.FromFile(hinhanh);
                            pb_AVATAR.SizeMode = PictureBoxSizeMode.StretchImage;
                           
                        }
                    }
                    catch
                    { }
                    conn.Close();   
            }
  
        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {

                    txt_MoTa.ResetText();
                    
                    txt_TenHang.Text = row.Cells[1].Value.ToString();
                  
                    
                    txt_SoLuong.Text = row.Cells[0].Value.ToString();
                    txt_DonGiaNhap.Text = row.Cells[2].Value.ToString();
                    //txt_DonGiaNhap.Text = _DoiSoSangDonViTienTe(txt_DonGiaNhap.Text.Replace(",", ""));
                    txt_NgayNhapHang.Text = row.Cells[5].Value.ToString();
                    txt_TenChatLieu.Text = row.Cells[6].Value.ToString();
                    txt_NguonGoc.Text = row.Cells[4].Value.ToString();
                    txt_DonGiaBan.Text = row.Cells[3].Value.ToString();
                    txt_ThanhTien.Text = row.Cells[7].Value.ToString();
                    ThongTinBoSung();
                    MaHangUpdate();
                    LayMaHang();
                   
                    
                    
                }




            }
            catch
            { }
        }

        public void CapNhapThanhTien()
        {

            try
            {
                int a = Int32.Parse(lb_MaHangMoi.Text);
                int c = (a + 1);
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;


                cmd.CommandText = "UPDATE HANG SET ChiPhi = " + txt_ThanhTien.Text + " WHERE MaHang = " + c.ToString() + "";
                cmd.Connection = conn;
                // try
                // {
                //SqlDataReader reader = cmd.ExecuteReader();
                //if (reader.Read())
                int ret = cmd.ExecuteNonQuery();
                if (ret > 0)
                {
                    // MessageBox.Show("Cập nhật  Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                //{
                //}
                // }
                // catch
                // { }

                conn.Close();
            }
            catch { }
            
            
        }
        #region Code Lỗi
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        #endregion

        private void btn_DonDep_Click(object sender, EventArgs e)
        {
            TaoMoi();
            txt_DonGiaBan.ResetText();
            txt_DonGiaBan.Text = "0";
            txt_DonGiaNhap.ResetText();
            txt_DonGiaNhap.Text = "0";
           
            //txt_MaHang.ResetText();
            txt_MoTa.ResetText();
            txt_NgayNhapHang.ResetText();
            txt_NguonGoc.ResetText();
            txt_SoLuong.ResetText();
            txt_SoLuong.Text = "0";
            txt_TenChatLieu.ResetText();
            txt_TenHang.ResetText();
        }

        private void btn_XemThem_Click(object sender, EventArgs e)
        {
            ThongTinBoSung();
        }

        #region Code Lỗi
        private void txt_DonGiaBan_TextChanged(object sender, EventArgs e)
        {
            //if (txt_DonGiaBan.Text.Trim().Length > 3)
            //{
            //    txt_DonGiaBan.Text = _DoiSoSangDonViTienTe(txt_DonGiaBan.Text.Replace(",", ""));

            //    txt_DonGiaBan.SelectionStart = txt_DonGiaBan.Text.Length;
            //    txt_DonGiaBan.SelectionLength = 0;
            //}
        }
        #endregion


        public void TinhThanhTien()
        {
            
        }
        public void ThemDangKy()
        {
            KiemTraSanPham();
            if (lb_KT.Text == "0")
            {
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO HANG(TenHang,DonGiaNhap,DonGiaBan,SoLuong,TenChatLieu,GhiChu,NgayNhapKho,NguonGoc,ChiPhi,DaBan) VALUES (N'" + txt_TenHang.Text + "'," + txt_DonGiaNhap.Text + "," + txt_DonGiaBan.Text + "," + txt_SoLuong.Text + ",N'" + txt_TenChatLieu.Text + "',N'" + txt_MoTa.Text + "','" + txt_NgayNhapHang.Text + "',N'" + txt_NguonGoc.Text + "'," + txt_ThanhTien.Text + ",0)";
                cmd.Connection = conn;
                try
                {
                    int ret = cmd.ExecuteNonQuery();
                    if (ret > 0)
                    {
                        MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm sản phẩm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch
                {
                    MessageBox.Show("Kiểm tra thao tác! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

                conn.Close();
            }
        }

        #region Code Lỗi
        private void btn_Them_Click(object sender, EventArgs e)
        {
            
        }
        #endregion

        public void XoaHH()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "DELETE FROM HANG WHERE TenHang = N'" + txt_TenHang.Text + "'";
            cmd1.Connection = conn;
            int ret = cmd1.ExecuteNonQuery();
            if (ret > 0)
            {
                MessageBox.Show("Xóa sản phẩm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Xóa sản phẩm thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            XoaHH();
            HienThi();
        }
        #region Code Lỗi
        private void txt_TenChatLieu_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        public void KiemTraSanPham()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT TenHang  FROM HANG WHERE TenHang = N'"+txt_TenHang.Text+"'";
            cmd1.Connection = conn;
            SqlDataReader reader = cmd1.ExecuteReader();
            if (reader.Read())
            {
                string a = reader.GetString(0);
                if (txt_TenHang.Text == a)
                {
                    lb_KT.Text = "1";
                    MessageBox.Show("Đã có sản phẩm " + a + " trong kho !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    lb_KT.Text = "0";
                }

            }
            else
            {
                lb_KT.Text = "0";
            }
        }
        private void btn_Them_Click_1(object sender, EventArgs e)
        {
            if (txt_DonGiaBan.Text.Length == 0 || txt_TenHang.Text.Length == 0 || txt_ThanhTien.Text.Length == 0 || txt_TenChatLieu.Text.Length == 0 || txt_SoLuong.Text.Length == 0)
            {
                MessageBox.Show("Thông tin không được phép rỗng! Vui lòng kiểm tra thông tin!", "Nhắc Nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ThemDangKy();
                CapNhapThanhTien();
                HienThi();

            }
        }
        #region Code Lỗi
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {


        }
       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void Btn_TinhTien_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(txt_DonGiaNhap.Text);
            int b = Int32.Parse(txt_SoLuong.Text);
            int c = (a * b);
            txt_ThanhTien.Text = c.ToString();
            LayMaHangMoi();
        }
        private string _DoiSoSangDonViTienTe(object _object)
        {
            try
            {
                if (_object.ToString().Trim().Length == 0)
                { return "0,000"; }
                decimal dThanhTien = Convert.ToDecimal(_object);
                string strThanhTien = string.Format("{0:#,#.}", dThanhTien);

                if (strThanhTien.Trim().Length == 0)
                {
                    return "0,000";
                }
                return strThanhTien.Replace(".", ",");
            }
            catch (Exception)
            {

            }
            return "0,000";
        }
        #region Code Lỗi
        private void txt_DonGiaNhap_TextChanged(object sender, EventArgs e)
        {
            //if (txt_DonGiaNhap.Text.Trim().Length > 3)
            //{
            //    txt_DonGiaNhap.Text = _DoiSoSangDonViTienTe(txt_DonGiaNhap.Text.Replace(",", ""));

            //    txt_DonGiaNhap.SelectionStart = txt_DonGiaNhap.Text.Length;
            //    txt_DonGiaNhap.SelectionLength = 0;
            //}
        }

        public void LocTheoSoLuongSanPham()
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                //txt_TimKiem.Text = txt_TimKiem.Text.Trim();
                string sql = "select SoLuong,TenHang,DonGiaNhap,DonGiaBan,NguonGoc,NgayNhapKho,TenChatLieu,ChiPhi FROM HANG ORDER BY SoLuong DESC";
                SqlCommand com = new SqlCommand(sql, conn); //bat dau truy van
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
                DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu

                //da.Fill(dt);
                // đổ dữ liệu vào kho

                da.Fill(dt);
                dt.Columns.Add("STT");
                dataGridView1.Columns[0].Width = 25;
                //dt.Columns.Add("Ảnh");
                //dataGridView1.Columns[1].Width = 300;


                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["STT"] = i + 1;

                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns["STT"].DisplayIndex = 0;
                    //dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Cyan;

                    ThongTinBoSung();
                }

                conn.Close();  // đóng kết nối
                dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview

            }
            catch{}
            
        }

        public void LocThheoGiaTienNhapHang()
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                //txt_TimKiem.Text = txt_TimKiem.Text.Trim();
                string sql = "select SoLuong,TenHang,DonGiaNhap,DonGiaBan,NguonGoc,NgayNhapKho,TenChatLieu,ChiPhi FROM HANG ORDER BY DonGiaNhap DESC";
                SqlCommand com = new SqlCommand(sql, conn); //bat dau truy van
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
                DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu

                //da.Fill(dt);
                // đổ dữ liệu vào kho

                da.Fill(dt);
                dt.Columns.Add("STT");
                dataGridView1.Columns[0].Width = 25;
                //dt.Columns.Add("Ảnh");
                //dataGridView1.Columns[1].Width = 300;


                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["STT"] = i + 1;

                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns["STT"].DisplayIndex = 0;
                    //dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Cyan;

                    ThongTinBoSung();
                }

                conn.Close();  // đóng kết nối
                dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview

            }
            catch { }
        }

        public void LocTheoGiaTienBanRa()
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                //txt_TimKiem.Text = txt_TimKiem.Text.Trim();
                string sql = "select SoLuong,TenHang,DonGiaNhap,DonGiaBan,NguonGoc,NgayNhapKho,TenChatLieu,ChiPhi FROM HANG ORDER BY DonGiaBan DESC";
                SqlCommand com = new SqlCommand(sql, conn); //bat dau truy van
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
                DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu

                //da.Fill(dt);
                // đổ dữ liệu vào kho

                da.Fill(dt);
                dt.Columns.Add("STT");
                dataGridView1.Columns[0].Width = 25;
                //dt.Columns.Add("Ảnh");
                //dataGridView1.Columns[1].Width = 300;


                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["STT"] = i + 1;

                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns["STT"].DisplayIndex = 0;
                    //dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Cyan;

                    ThongTinBoSung();
                }

                conn.Close();  // đóng kết nối
                dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview

            }
            catch { }
        }

        public void LocTheoChiPhi()
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                //txt_TimKiem.Text = txt_TimKiem.Text.Trim();
                string sql = "select SoLuong,TenHang,DonGiaNhap,DonGiaBan,NguonGoc,NgayNhapKho,TenChatLieu,ChiPhi FROM HANG ORDER BY ChiPhi DESC";
                SqlCommand com = new SqlCommand(sql, conn); //bat dau truy van
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
                DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu

                //da.Fill(dt);
                // đổ dữ liệu vào kho

                da.Fill(dt);
                dt.Columns.Add("STT");
                dataGridView1.Columns[0].Width = 25;
                //dt.Columns.Add("Ảnh");
                //dataGridView1.Columns[1].Width = 300;


                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["STT"] = i + 1;

                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns["STT"].DisplayIndex = 0;
                    //dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Cyan;

                    ThongTinBoSung();
                }

                conn.Close();  // đóng kết nối
                dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview

            }
            catch { }
        }

        public void LocTheoNgay()
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                //txt_TimKiem.Text = txt_TimKiem.Text.Trim();
                string sql = "select SoLuong,TenHang,DonGiaNhap,DonGiaBan,NguonGoc,NgayNhapKho,TenChatLieu,ChiPhi FROM HANG ORDER BY NgayNhapKho DESC";
                SqlCommand com = new SqlCommand(sql, conn); //bat dau truy van
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
                DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu

                //da.Fill(dt);
                // đổ dữ liệu vào kho

                da.Fill(dt);
                dt.Columns.Add("STT");
                dataGridView1.Columns[0].Width = 25;
                //dt.Columns.Add("Ảnh");
                //dataGridView1.Columns[1].Width = 300;


                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["STT"] = i + 1;

                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns["STT"].DisplayIndex = 0;
                    //dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Cyan;

                    ThongTinBoSung();
                }

                conn.Close();  // đóng kết nối
                dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview

            }
            catch { }
        }
        private void btn_Loc_Click(object sender, EventArgs e)
        {
            //            //*
            //             * Theo Ngày Nhập
            //Theo Số Lượng Sản Phẩm
            //Theo Giá Tiền Nhập
            //Theo Giá Tiền Bán
            //Theo Chi Phí
            //             */
            if (cbx_Loc.Text == "Theo Số Lượng Sản Phẩm")
            {
                var item = this.cbx_Loc.GetItemText(this.cbx_Loc.FindStringExact("Theo Số Lượng Sản Phẩm"));

                LocTheoSoLuongSanPham();
                //HienThi();
            }
            else if (cbx_Loc.Text == "Theo Giá Tiền Nhập")
            {
                var item = this.cbx_Loc.GetItemText(this.cbx_Loc.FindStringExact("Theo Giá Tiền Nhập"));

                LocThheoGiaTienNhapHang();
            }
            else if (cbx_Loc.Text == "Theo Giá Tiền Bán")
            {
                var item = this.cbx_Loc.GetItemText(this.cbx_Loc.FindStringExact("Theo Giá Tiền Bán"));

                LocTheoGiaTienBanRa();
            }
            else if (cbx_Loc.Text == "Theo Chi Phí")
            {
                var item = this.cbx_Loc.GetItemText(this.cbx_Loc.FindStringExact("Theo Chi Phí"));

                LocTheoChiPhi();
            }
            else if (cbx_Loc.Text == "Theo Ngày")
            {
                var item = this.cbx_Loc.GetItemText(this.cbx_Loc.FindStringExact("Theo Ngày")); 

                LocTheoNgay();
            }
        }
        
        #endregion
        private void btn_S_Click(object sender, EventArgs e)
        {
            
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE HANG SET TenHang = N'"+txt_TenHang.Text+"',DonGiaNhap = "+txt_DonGiaNhap.Text+",DonGiaBan = "+txt_DonGiaBan.Text+",NguonGoc = N'"+txt_NguonGoc.Text+"',TenChatLieu = N'"+txt_TenChatLieu.Text+"',GhiChu = N'"+txt_MoTa.Text+"',SoLuong ="+txt_SoLuong.Text+",NgayNhapKho ='"+txt_NgayNhapHang.Text+"',ChiPhi = "+txt_ThanhTien.Text+" WHERE MaHang = "+lb_MaHang1.Text+ ""; 
            cmd.Connection = conn;
           try
            {
               int ret = cmd.ExecuteNonQuery();
               if (ret > 0)
               {
                   MessageBox.Show("Sửa sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               }
               else
               {
                   MessageBox.Show("Sửa sản phẩm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               }
            }
           catch
           { }
           HienThi();
           conn.Close();
        }
        #region Code Lỗi
        private void label12_Click(object sender, EventArgs e)
        {

        }
        #endregion

        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        
        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                //txt_TimKiem.Text = txt_TimKiem.Text.Trim();
                string sql = "select SoLuong,TenHang,DonGiaNhap,DonGiaBan,NguonGoc,NgayNhapKho,TenChatLieu from HANG WHERE MaHang =  "+txt_TimKiem.Text+" OR TenHang LIKE N'%" +txt_TimKiem.Text.Trim()+ "%'  ";
                SqlCommand com = new SqlCommand(sql, conn); //bat dau truy van
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
                DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu

                //da.Fill(dt);
                // đổ dữ liệu vào kho

                da.Fill(dt);
                dt.Columns.Add("STT");
                dataGridView1.Columns[0].Width = 25;
                //dt.Columns.Add("Ảnh");
                //dataGridView1.Columns[1].Width = 300;


                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["STT"] = i + 1;

                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns["STT"].DisplayIndex = 0;
                    //dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Cyan;

                    ThongTinBoSung();
                }

                conn.Close();  // đóng kết nối
                dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview

            }
            catch
            {
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                //txt_TimKiem.Text = txt_TimKiem.Text.Trim();
                string sql = "select SoLuong,TenHang,DonGiaNhap,DonGiaBan,NguonGoc,NgayNhapKho,TenChatLieu from HANG WHERE TenHang LIKE N'%" +txt_TimKiem.Text.Trim()+ "%'  ";
                SqlCommand com = new SqlCommand(sql, conn); //bat dau truy van
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
                DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu

                //da.Fill(dt);
                // đổ dữ liệu vào kho

                da.Fill(dt);
                dt.Columns.Add("STT");
                dataGridView1.Columns[0].Width = 25;
                //dt.Columns.Add("Ảnh");
                //dataGridView1.Columns[1].Width = 300;


                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["STT"] = i + 1;

                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns["STT"].DisplayIndex = 0;
                    //dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Cyan;

                    ThongTinBoSung();
                }

                conn.Close();  // đóng kết nối
                dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_ThemAnh_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png| ALL Files(*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string picPath = dlg.FileName.ToString();
                duongdan.Text = picPath;

                pb_AVATAR.ImageLocation = picPath;
                pb_AVATAR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            }
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "UPDATE HANG SET AnhHH= N'" + duongdan.Text + "' WHERE TenHang = N'" + txt_TenHang.Text + "'";
            cmd1.Connection = conn;
            int ret = cmd1.ExecuteNonQuery();
            if (ret > 0)
            {
                MessageBox.Show("Lưu Ảnh thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Lưu Ảnh thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btn_TinhTien_Click_1(object sender, EventArgs e)
        {
            int a = Int32.Parse(txt_DonGiaNhap.Text);
            int b = Int32.Parse(txt_SoLuong.Text);
            int c = (a * b);
            txt_ThanhTien.Text = c.ToString();
            LayMaHangMoi();
        }

        private void txt_SoLuong_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_DonGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_DonGiaBan_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btn_Home_Click(object sender, EventArgs e)
        {
            HienThi();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void frm_HangHoa_KeyDown(object sender, KeyEventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
