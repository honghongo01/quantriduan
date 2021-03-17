using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;


namespace SalesManagementSouvenir_App
{
    public partial class frm_NhanVien01 : Form
    {
        public frm_NhanVien01()
        {
            InitializeComponent();
        }

        public void ExportExcell(DataGridView g, String duongDan, String tenTep)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            // obj.Aplication.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for (int i = 1; i < g.Columns.Count + 1; i++)
            {
                obj.Cells[1, i] = g.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < g.Rows.Count; i++)
            {
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(duongDan + tenTep + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }
        public void XacNhanKiemQuyen()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ChucVu FROM NHANVIEN WHERE TaiKhoan = '" + lb_TrangThai.Text + "'";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string a = reader.GetString(0).ToString();
                if (a == "Quản Lý")
                {
                    btn_Them.Enabled = true;
                    btn_Sua.Enabled = true;
                    btn_Xoa.Enabled = true;
                    btn_XemThem.Enabled = true;
                }

            }
        }
        public void LayTaiKhoan()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT TaiKhoan FROM TRANGTHAI";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                lb_TrangThai.Text = reader.GetString(0).ToString();
            }


        }


        private void frm_NhanVien01_Load(object sender, EventArgs e)
        {


            this.panel12.Hide();
            this.panel13.Hide();
            this.panel14.Hide();
            this.panel15.Hide();
            this.panel16.Hide();
            this.panel17.Hide();
            this.panel18.Hide();
            btn_Them.Enabled = false;
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_XemThem.Enabled = false;
            LayTaiKhoan();
            XacNhanKiemQuyen();
            HienThi();
            DateTime tn = DateTime.Now;
            lb_Gio.Text = tn.ToString("hh:mm:ss");
            lb_Ngay.Text = tn.ToString("dd/MM/yyyy");

        }
        public void ThongTinBoSung()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT AnhNV FROM NHANVIEN WHERE HoTenNV  = N'" + txt_HoTen.Text + "' AND NgaySinh = N'" + txt_NgaySinh.Text + "'";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
            }

            try
            {
                if (reader.HasRows)
                {
                    string hinhanh;
                    hinhanh = reader[0].ToString();
                    pb_Avatar.Image = System.Drawing.Image.FromFile(hinhanh);
                    pb_Avatar.SizeMode = PictureBoxSizeMode.StretchImage;
                    conn.Close();
                }
            }
            catch
            { }
        }
        public void LaySoThuTu()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            string sql = "select HoTenNV,GioiTinh,NgaySinh,DiaChi,Email,SDT,ChucVu,NgayBDLV from NHANVIEN"; // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, conn); //bat dau truy van
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            System.Data.DataTable dt = new System.Data.DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            //DataTable dt = LayDanhSach();
            //dt.Columns.Add("STT");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].DisplayIndex = 0;

            }
        }
        public void HienThi()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            string sql = "select HoTenNV,GioiTinh,NgaySinh,DiaChi,Email,ChucVu,NgayBDLV from NHANVIEN"; // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, conn); //bat dau truy van
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            System.Data.DataTable dt = new System.Data.DataTable(); //tạo một kho ảo để lưu trữ dữ liệu

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

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.panel12.Show();
            this.panel13.Show();
            this.panel14.Show();
            this.panel15.Show();
            this.panel16.Show();
            this.panel17.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.panel18.Show();
            this.panel19.BackColor = System.Drawing.Color.White;
            this.panel23.BackColor = System.Drawing.Color.White;
            this.panel21.BackColor = System.Drawing.Color.White;
            this.panel20.BackColor = System.Drawing.Color.White;
            this.panel22.BackColor = System.Drawing.Color.White;
        }

        private void panel23_MouseMove(object sender, MouseEventArgs e)
        {
            this.panel12.Hide();
            this.panel13.Hide();
            this.panel14.Hide();
            this.panel15.Hide();
            this.panel16.Hide();
            this.panel17.Hide();
            this.panel23.BackColor = System.Drawing.Color.Blue;
            this.panel19.BackColor = System.Drawing.Color.White;
            this.panel22.BackColor = System.Drawing.Color.White;
            this.panel21.BackColor = System.Drawing.Color.White;
            this.panel20.BackColor = System.Drawing.Color.White;
        }

        private void panel22_MouseMove(object sender, MouseEventArgs e)
        {
            this.panel22.BackColor = System.Drawing.Color.Blue;
            this.panel19.BackColor = System.Drawing.Color.White;
            this.panel23.BackColor = System.Drawing.Color.White;
            this.panel21.BackColor = System.Drawing.Color.White;
            this.panel20.BackColor = System.Drawing.Color.White;
        }

        private void panel21_MouseMove(object sender, MouseEventArgs e)
        {
            this.panel12.Hide();
            this.panel13.Hide();
            this.panel14.Hide();
            this.panel15.Hide();
            this.panel16.Hide();
            this.panel17.Hide();
            this.panel21.BackColor = System.Drawing.Color.Blue;
            this.panel19.BackColor = System.Drawing.Color.White;
            this.panel23.BackColor = System.Drawing.Color.White;
            this.panel20.BackColor = System.Drawing.Color.White;
            this.panel22.BackColor = System.Drawing.Color.White;
        }

        private void panel19_MouseMove(object sender, MouseEventArgs e)
        {
            this.panel12.Hide();
            this.panel13.Hide();
            this.panel14.Hide();
            this.panel15.Hide();
            this.panel16.Hide();
            this.panel17.Hide();
            this.panel19.BackColor = System.Drawing.Color.Blue;
            this.panel23.BackColor = System.Drawing.Color.White;
            this.panel21.BackColor = System.Drawing.Color.White;
            this.panel20.BackColor = System.Drawing.Color.White;
            this.panel22.BackColor = System.Drawing.Color.White;
        }

        private void panel20_MouseMove(object sender, MouseEventArgs e)
        {
            this.panel12.Hide();
            this.panel13.Hide();
            this.panel14.Hide();
            this.panel15.Hide();
            this.panel16.Hide();
            this.panel17.Hide();
            this.panel20.BackColor = System.Drawing.Color.Blue;
            this.panel19.BackColor = System.Drawing.Color.White;
            this.panel23.BackColor = System.Drawing.Color.White;
            this.panel21.BackColor = System.Drawing.Color.White;
            this.panel22.BackColor = System.Drawing.Color.White;
        }

        private void panel17_MouseMove(object sender, MouseEventArgs e)
        {
            this.panel17.BackColor = System.Drawing.Color.Blue;
            this.panel16.BackColor = System.Drawing.Color.White;
            this.panel15.BackColor = System.Drawing.Color.White;
            this.panel14.BackColor = System.Drawing.Color.White;
            this.panel13.BackColor = System.Drawing.Color.White;
            this.panel12.BackColor = System.Drawing.Color.White;
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

        private void panel16_MouseMove(object sender, MouseEventArgs e)
        {
            this.panel16.BackColor = System.Drawing.Color.Blue;
            this.panel17.BackColor = System.Drawing.Color.White;
            this.panel15.BackColor = System.Drawing.Color.White;
            this.panel14.BackColor = System.Drawing.Color.White;
            this.panel13.BackColor = System.Drawing.Color.White;
            this.panel12.BackColor = System.Drawing.Color.White;
        }

        private void panel15_MouseMove(object sender, MouseEventArgs e)
        {
            this.panel15.BackColor = System.Drawing.Color.Blue;
            this.panel16.BackColor = System.Drawing.Color.White;
            this.panel17.BackColor = System.Drawing.Color.White;
            this.panel14.BackColor = System.Drawing.Color.White;
            this.panel13.BackColor = System.Drawing.Color.White;
            this.panel12.BackColor = System.Drawing.Color.White;
        }

        private void panel14_MouseMove(object sender, MouseEventArgs e)
        {
            this.panel14.BackColor = System.Drawing.Color.Blue;
            this.panel16.BackColor = System.Drawing.Color.White;
            this.panel15.BackColor = System.Drawing.Color.White;
            this.panel17.BackColor = System.Drawing.Color.White;
            this.panel13.BackColor = System.Drawing.Color.White;
            this.panel12.BackColor = System.Drawing.Color.White;
        }

        private void panel13_MouseMove(object sender, MouseEventArgs e)
        {
            this.panel13.BackColor = System.Drawing.Color.Blue;
            this.panel16.BackColor = System.Drawing.Color.White;
            this.panel15.BackColor = System.Drawing.Color.White;
            this.panel14.BackColor = System.Drawing.Color.White;
            this.panel17.BackColor = System.Drawing.Color.White;
            this.panel12.BackColor = System.Drawing.Color.White;
        }

        private void panel12_MouseMove(object sender, MouseEventArgs e)
        {
            this.panel12.BackColor = System.Drawing.Color.Blue;
            this.panel16.BackColor = System.Drawing.Color.White;
            this.panel15.BackColor = System.Drawing.Color.White;
            this.panel14.BackColor = System.Drawing.Color.White;
            this.panel13.BackColor = System.Drawing.Color.White;
            this.panel17.BackColor = System.Drawing.Color.White;
        }

        private void frm_NhanVien01_MouseMove(object sender, MouseEventArgs e)
        {
            this.panel18.Hide();
            this.panel12.Hide();
            this.panel13.Hide();
            this.panel14.Hide();
            this.panel15.Hide();
            this.panel16.Hide();
            this.panel17.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime tn = DateTime.Now;
            lb_Gio.Text = tn.ToString("hh:mm:ss tt");
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    txt_HoTen.Text = row.Cells[0].Value.ToString();
                    txt_GioiTinh.Text = row.Cells[1].Value.ToString();
                    txt_NgaySinh.Text = row.Cells[2].Value.ToString();
                    txt_ChucVu.Text = row.Cells[5].Value.ToString();
                    txt_NayBDLV.Text = row.Cells[6].Value.ToString();
                    txt_Email.Text = row.Cells[4].Value.ToString();
                    txt_DiaChi.Text = row.Cells[3].Value.ToString();
                    ThongTinBoSung();
                    txt_CMND.ResetText();
                    txt_TaiKhoan.ResetText();
                    txt_MatKhau.ResetText();
                    txt_SDT.ResetText();

                    //pb_Avatar.BackColor = System.Drawing.SystemColors.ActiveBorder;

                }
            }
            catch
            {

            }
        }
        public void LayAnh()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM NHANVIEN WHERE HoTenNV = N'" + txt_HoTen.Text + "' AND NgaySinh ='" + txt_NgaySinh.Text + "'";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                if (reader.HasRows)
                {
                    string hinhanh;
                    hinhanh = reader[10].ToString();
                    pb_Avatar.Image = System.Drawing.Image.FromFile(hinhanh);
                    pb_Avatar.SizeMode = PictureBoxSizeMode.StretchImage;
                    conn.Close();
                }
            }
            catch
            { }
        }

        private void btn_XemThem_Click(object sender, EventArgs e)
        {

            txt_TaiKhoan.ResetText();
            txt_CMND.ResetText();
            txt_SDT.ResetText();
            txt_MatKhau.ResetText();
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM NHANVIEN WHERE HoTenNV = N'" + txt_HoTen.Text + "' AND NgaySinh ='" + txt_NgaySinh.Text + "'";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {

                txt_TaiKhoan.Text = reader.GetString(1).ToString();
                txt_MatKhau.Text = reader.GetString(2).ToString();
                txt_CMND.Text = reader.GetString(8).ToString();
                txt_SDT.Text = reader.GetString(9).ToString();



            }
            try
            {
                if (reader.HasRows)
                {
                    string hinhanh;
                    hinhanh = reader[10].ToString();
                    pb_Avatar.Image = System.Drawing.Image.FromFile(hinhanh);
                    pb_Avatar.SizeMode = PictureBoxSizeMode.StretchImage;
                    conn.Close();
                }
            }
            catch
            { }
        }
        public void ThemDangKy()
        {
            KiemTraTonTai();
            if (lb_KT.Text == "0")
            {
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO NHANVIEN(TaiKhoan,MatKhau,HoTenNV,NgaySinh,GioiTinh,DiaChi,Email,CMND,SDT,ChucVu,NgayBDLV) VALUES (N'" + txt_TaiKhoan.Text + "',N'" + txt_MatKhau.Text + "',N'" + txt_HoTen.Text + "','" + txt_NgaySinh.Text + "',N'" + txt_GioiTinh.Text + "',N'" + txt_DiaChi.Text + "','" + txt_Email.Text + "','" + txt_CMND.Text + "','" + txt_SDT.Text + "',N'" + txt_ChucVu.Text + "','" + txt_NayBDLV.Text + "')";
                cmd.Connection = conn;
                try
               {
                    int ret = cmd.ExecuteNonQuery();
                    if (ret > 0 )
                    {
               
                            MessageBox.Show("Thêm nhân  viên thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            MessageBox.Show("Thêm nhân viên thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        

                
                    
                }
                catch
               { }

                conn.Close();
            }
        }

        public void KiemTraTonTai()
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
                conn.Open();
                SqlCommand cmd1 = new SqlCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "SELECT HoTenNV, NgaySinh,CMND  FROM NHANVIEN ";
                cmd1.Connection = conn;
                SqlDataReader reader = cmd1.ExecuteReader();
                if (reader.Read())
                {
                    string a = reader.GetString(0);
                    string b = reader.GetString(1);
                    string c = reader.GetString(2);
                    if (txt_HoTen.Text == a && txt_NgaySinh.Text == b && txt_CMND.Text == c)
                    {
                        lb_KT.Text = "1";
                        MessageBox.Show("Đã có có nhân viên " + a + " trong hệ thống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        lb_KT.Text = "0";
                    }

                }
            }
            catch { }
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
        if(txt_ChucVu.Text.Length == 0 || txt_CMND.Text.Length == 0 || txt_CMND.Text.Length == 0 || txt_DiaChi.Text.Length == 0 || txt_Email.Text.Length ==0 || txt_GioiTinh.Text.Length == 0 || txt_NayBDLV.Text.Length == 0 || txt_NgaySinh.Text.Length == 0)
            {
                MessageBox.Show("Thông tin không được phép rỗng! Vui lòng kiểm tra thông tin!", "Nhắc Nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
        else
            {
            ThemDangKy();
            HienThi();
            }
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btn_ThemAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png| ALL Files(*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string picPath = dlg.FileName.ToString();
                duongdan.Text = picPath;

                pb_Avatar.ImageLocation = picPath;
                pb_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            }
            try
            {

                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
                conn.Open();
                SqlCommand cmd1 = new SqlCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "UPDATE NHANVIEN SET AnhNV= N'" + duongdan.Text + "' WHERE HoTenNV = N'" + txt_HoTen.Text + "' AND NgaySinh ='" + txt_NgaySinh.Text + "'";
                cmd1.Connection = conn;
                int ret = cmd1.ExecuteNonQuery();
                if (ret > 0)
                {
                    MessageBox.Show("Lưu Ảnh thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Lưu Ảnh thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                conn.Close();
           }
            catch { }
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }
        public void XoaNhanVien()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "DELETE FROM NHANVIEN WHERE HoTenNV = N'" + txt_HoTen.Text + "' AND NgaySinh = N'" + txt_NgaySinh.Text + "'";
            cmd1.Connection = conn;
            int ret = cmd1.ExecuteNonQuery();
            if (ret > 0)
            {
                MessageBox.Show("Xóa nhân viên thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Xóa nhân viên thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            XoaNhanVien();
            HienThi();
        }

        private void btn_DonDep_Click(object sender, EventArgs e)
        {
            txt_ChucVu.ResetText();
            txt_CMND.ResetText();
            txt_DiaChi.ResetText();
            txt_Email.ResetText();
            txt_GioiTinh.ResetText();
            txt_HoTen.ResetText();
            txt_MatKhau.ResetText();
            txt_NayBDLV.ResetText();
            txt_NgaySinh.ResetText();
            txt_SDT.ResetText();
            txt_TaiKhoan.ResetText();
        }

        void LocTheoTen()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            string sql = "select HoTenNV,GioiTinh,NgaySinh,DiaChi,Email,ChucVu,NgayBDLV from NHANVIEN ORDER BY HoTenNV ASC"; // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, conn); //bat dau truy van
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            System.Data.DataTable dt = new System.Data.DataTable(); //tạo một kho ảo để lưu trữ dữ liệu

            //da.Fill(dt);
            // đổ dữ liệu vào kho

            da.Fill(dt);
            dt.Columns.Add("STT");
            dataGridView1.Columns[0].Width = 200;


            for (int i = 0; i < dt.Rows.Count; i++)
                dt.Rows[i]["STT"] = i + 1;

            dataGridView1.DataSource = dt;
            dataGridView1.Columns["STT"].DisplayIndex = 0;

            conn.Close();  // đóng kết nối
            dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview
        }

        public void LocTheoChucVu()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT TaiKhoan,MatKhau,HoTenNV,NgaySinh,GioiTinh,DiaChi,Email,CMND,SDT,ChucVu,NgayBDLV FROM NHANVIEN WHERE ChucVu = N'Quản lý'";
            cmd1.Connection = conn;
            int ret = cmd1.ExecuteNonQuery();
            if (ret > 0)
            {

            }
            else
            {

            }
        }
        private void btn_Loc_Click(object sender, EventArgs e)
        {
            if (cbx_Loc.Text == "Theo tên")
            {
                LocTheoTen();
                // HienThi();
            }

            if (cbx_Loc.Text == "Chức vụ")
            {
                LocTheoChucVu();
                HienThi();
            }

        }

        private void pb_Avatar_Click(object sender, EventArgs e)
        {

        }

        private void lb_Gio_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ExportExcell(dataGridView1, @"D:\", "ExcelNhanVien");
        }

        private void btn_Import_Click(object sender, EventArgs e)
        {
            OpenFileDialog fopen = new OpenFileDialog();
            fopen.Filter = "(Tất cả các tệp)|*.*|(Các tệp Excel)|*.xlsx";
            fopen.ShowDialog();
            if (fopen.FileName != "")
            {
                txt_DuongDan.Text = fopen.FileName;
                Excel.Application app = new Excel.Application();
                try
                {
                    Excel.Workbook wb = app.Workbooks.Open(fopen.FileName);
                    Excel._Worksheet sheet = wb.Sheets[1];
                    Excel.Range range = sheet.UsedRange;
                    int rows = range.Rows.Count;
                    int cols = range.Columns.Count;

                    for (int c = 1; c <= cols; c++)
                    {
                        string columnname = range.Cells[1, c].Value.ToString();
                        ColumnHeader col = new ColumnHeader();
                        col.Text = columnname;
                        col.Width = 120;
                        //lstCustomer.Cloumns.Add(col);
                    }
                }
                catch { }
            }
            else
            {
                MessageBox.Show("Bạn không chọn tệp tin nào cả", "Nhắc nhở", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        { 
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                //txt_TimKiem.Text = txt_TimKiem.Text.Trim();
                string sql = "select HoTenNV,GioiTinh,NgaySinh,DiaChi,Email,ChucVu,NgayBDLV from NHANVIEN WHERE MaNV =  " + txt_TimKiem.Text + "";
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
                string sql = "select HoTenNV,GioiTinh,NgaySinh,DiaChi,Email,ChucVu,NgayBDLV from NHANVIEN WHERE HoTenNV LIKE N'%" + txt_TimKiem.Text.Trim() + "%'  ";
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
            txt_TimKiem.ResetText();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "UPDATE NHANVIEN SET HoTenNV = N'" + txt_HoTen.Text + "',NgaySinh = '" + txt_NgaySinh.Text + "',DiaChi = N'" + txt_DiaChi.Text + "',Email = N'" + txt_Email.Text + "',SDT = '" + txt_SDT.Text + "',GioiTinh = N'"+txt_GioiTinh.Text+"' WHERE TaiKhoan = '" + txt_TaiKhoan.Text + "'";
            cmd1.Connection = conn;
            int ret = cmd1.ExecuteNonQuery();
            if (ret > 0)
            {
                MessageBox.Show("Cập nhật thông tin nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin nhân viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            HienThi();
        }

        private void txt_SDT_TextChanged(object sender, EventArgs e)
        {
            if (txt_SDT.Text.Length == 0)
            {
                error_SDT.SetError(txt_SDT, "Số điện thoại không được rỗng !");
            }
            if (txt_SDT.Text.Length < 10 || txt_SDT.Text.Length > 12)
            {
                error_SDT.SetError(txt_SDT, "Số điện thoại quá ngắn hoặc quá dài!");
            }

            else
            {
                error_SDT.Clear();

            }
        }

        private void txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_CMND_TextChanged(object sender, EventArgs e)
        {
            if (txt_CMND.Text.Length == 0)
            {
                error_CMND.SetError(txt_CMND, "Số CMND rỗng !");
            }
            if (txt_CMND.Text.Length < 9 || txt_CMND.Text.Length > 9)
            {
                error_CMND.SetError(txt_CMND, "Số CMND quá ngắn hoặc quá dài!");
            }

            else
            {
                error_CMND.Clear();

            }
        }

        private void txt_CMND_KeyPress(object sender, KeyPressEventArgs e)
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

        private void frm_NhanVien01_KeyDown(object sender, KeyEventArgs e)
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

        private void btn_Home_Click(object sender, EventArgs e)
        {
            HienThi();
        }
    }
}
