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
    public partial class frm_KhachHang : Form
    {
        public frm_KhachHang()
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

        public void DieuKienNhap()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT TenKhach,DiaChiKH,SDTKH FROM KHACHHANG WHERE TenKhach = N'" + txt_TenKhachHang.Text + "' AND DiaChiKH = N'" + txt_DiaChi.Text + "'";
            cmd1.Connection = conn;
            SqlDataReader reader = cmd1.ExecuteReader();
            if (reader.Read())
            {
                string a = reader.GetString(0);
                string b = reader.GetString(1);
                string c = reader.GetString(2);
                if (a == txt_TenKhachHang.Text && b == txt_DiaChi.Text)
                {
                    MessageBox.Show("Đã tồn tại khách hàng " + a + " trong danh sách !", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //return 1;
                }
                else
                {
                    ThemDangKy();
                    //  HienThi();
                    // return 0;
                }
            }
            else
            { ThemDangKy(); }
            conn.Close();
        }
        public void HienThi()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            string sql = "select TenKhach,DiaChiKH,SDTKH FROM KHACHHANG"; // lay het du lieu trong bang sinh vien
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
                dt.Rows[i]["STT"] = i + 1;

            dataGridView1.DataSource = dt;
            dataGridView1.Columns["STT"].DisplayIndex = 0;

            conn.Close();  // đóng kết nối
            dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview
        }

        private void frm_KhachHang_Load(object sender, EventArgs e)
        {
            LayMa();
            HienThi();
 
        }

        #region Code lỗi
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #endregion
        public void ThemDangKy()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO KHACHHANG(TenKhach,DiaChiKH,SDTKH) VALUES (N'"+txt_TenKhachHang.Text+"',N'"+txt_DiaChi.Text+"','"+txt_SoDienThoai.Text+"')";
            cmd.Connection = conn;
            try
            {
                int ret = cmd.ExecuteNonQuery();
                if (ret>0)
                {
                    MessageBox.Show("Thêm nhân viên thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); 
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

        public void LayMaKH()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT MaKH FROM KHACHHANG WHERE TenKhach = N'"+txt_TenKhachHang.Text+"' AND DiaChiKH = N'"+txt_DiaChi.Text+"'";
            cmd1.Connection = conn;
            SqlDataReader reader = cmd1.ExecuteReader();
            if (reader.Read())
            {
                string a = reader.GetInt32(0).ToString();
                int b = Convert.ToInt32(a);
                if (b < 10)
                {
                    txt_MaKH.Text = "KH000" + (b).ToString();
                    lb_MaKhach.Text = b.ToString();
                }
                else if (b > 9 && b < 100)
                {
                    txt_MaKH.Text = "KH00" + (b).ToString();
                    lb_MaKhach.Text = b.ToString();
                }
                else if (b > 99 && b < 1000)
                {
                    txt_MaKH.Text = "KH0" + (b).ToString();
                    lb_MaKhach.Text = b.ToString();
                }

            }
            conn.Close();
        }
        #region Code Lỗi
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            
        }
        #endregion

        public void Sua()
        {
 
        }

        public void MaKhach()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT MaKhach FROM KHACHHANG WHERE TenKhach = " + txt_TenKhachHang.Text + " AND SDTKH = "+txt_SoDienThoai.Text+"";
            cmd.Connection = conn;
            //try
           // {
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lb_MaKhach.Text = reader.GetInt32(0).ToString();
                }
                else
                {

                }
            //}
            //catch
            //{ }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE KHACHHANG SET TenKhach = N'"+txt_TenKhachHang.Text+"',DiaChiKH = N'"+txt_DiaChi.Text+"',SDTKH = "+txt_SoDienThoai.Text+" WHERE MaKH = "+lb_MaKhach.Text+"";
            cmd.Connection = conn;
            try
            {
                int ret = cmd.ExecuteNonQuery();
                if (ret>0)
                {
                    MessageBox.Show("Sửa thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sửa thông tin thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            { }
            HienThi();
        }
        #region Code Lỗi
        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                //txt_TimKiem.Text = txt_TimKiem.Text.Trim();
                string sql = "select TenKhach,DiaChiKH,SDTKH FROM KHACHHANG WHERE TenKhach LIKE N'%" + txt_TimKiem.Text.Trim() + "%' OR DiaChiKH LIKE  N'%" + txt_TimKiem.Text.Trim() + "%'";
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
                string sql = "select TenKhach,DiaChiKH,SDTKH FROM KHACHHANG";
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

                    
                }

                conn.Close();  // đóng kết nối
                dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview
            }
        }
        #endregion

        private void btn_DonDep_Click(object sender, EventArgs e)
        {
            txt_MaKH.ResetText();
            txt_DiaChi.ResetText();
            txt_TenKhachHang.ResetText();
            txt_SoDienThoai.ResetText();
            txt_TimKiem.ResetText();
            LayMa();
        }
        public void LayMa()
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
                conn.Open();
                SqlCommand cmd1 = new SqlCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "SELECT Max(MaKH) FROM KHACHHANG";
                cmd1.Connection = conn;
                SqlDataReader reader = cmd1.ExecuteReader();
                if (reader.Read())
                {
                    string a = reader.GetInt32(0).ToString();
                    int b = Convert.ToInt32(a);
                    if (b < 10)
                    {
                        txt_MaKH.Text = "KH000" + (b + 1).ToString();
                    }
                    else if (b > 9 && b < 100)
                    {
                        txt_MaKH.Text = "KH00" + (b + 1).ToString();
                    }
                    else if (b > 99 && b < 1000)
                    {
                        txt_MaKH.Text = "KH0" + (b + 1).ToString();
                    }

                }
                conn.Close();
            }
            catch { }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    txt_TenKhachHang.Text = row.Cells[0].Value.ToString();
                    txt_DiaChi.Text = row.Cells[1].Value.ToString();
                    txt_SoDienThoai.Text = row.Cells[2].Value.ToString();
                    
                    LayMaKH();
                   
                }
                MaKhach();
            }
            catch
            { }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            DieuKienNhap();
            HienThi();
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "DELETE FROM KHACHHANG WHERE TenKhach = N'" + txt_TenKhachHang.Text + "' AND DiaChiKH = N'"+txt_DiaChi.Text+"'";
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
            HienThi();
        }

        private void txt_SoDienThoai_TextChanged(object sender, EventArgs e)
        {
            if (txt_SoDienThoai.Text.Length == 0)
            {
                error_SDT.SetError(txt_SoDienThoai, "Số điện thoại không được rỗng !");
            }
            if (txt_SoDienThoai.Text.Length < 10 || txt_SoDienThoai.Text.Length > 12)
            {
                error_SDT.SetError(txt_SoDienThoai, "Số điện thoại quá ngắn hoặc quá dài!");
            }

            else
            {
                error_SDT.Clear();

            }
        }

        private void txt_SoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
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

        private void frm_KhachHang_KeyDown(object sender, KeyEventArgs e)
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
