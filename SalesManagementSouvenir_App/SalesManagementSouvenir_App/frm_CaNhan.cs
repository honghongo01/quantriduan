using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace SalesManagementSouvenir_App
{
    public partial class frm_CaNhan : Form
    {
        public frm_CaNhan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.panel18.Show();
            this.panel19.BackColor = System.Drawing.Color.White;
            this.panel23.BackColor = System.Drawing.Color.White;
            this.panel21.BackColor = System.Drawing.Color.White;
            this.panel20.BackColor = System.Drawing.Color.White;
            this.panel22.BackColor = System.Drawing.Color.White;
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
        public void LayTaiKhoan()
        {

            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT TaiKhoan FROM TRANGTHAI";
            cmd1.Connection = conn;
            SqlDataReader reader = cmd1.ExecuteReader();
            if (reader.Read())
            {
                lb_KetNoi.Text = reader.GetString(0);
            }
        }

        public void LayThongBao()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT ThongBao FROM THONGBAO";
            cmd1.Connection = conn;
            SqlDataReader reader = cmd1.ExecuteReader();
            if (reader.Read())
            {
                rtb_ThongBao.Text = reader.GetString(0);
            }
        }

        public void Menu1aaa()
        {
            this.btn_IDSHD.Hide();
            this.btn_IDSHH.Hide();
            this.btn_IDSKH.Hide();
            this.btn_IDSNV.Hide();
            this.btn_IDT.Hide();
            this.btn_NhanVien.Location = new System.Drawing.Point(0, 324);
            this.btn_NhanVien.Size = new System.Drawing.Size(253, 44);
            this.btn_KhachHang.Location = new System.Drawing.Point(0, 369);
            this.btn_KhachHang.Size = new System.Drawing.Size(253, 44);
            this.btn_HoaDon.Location = new System.Drawing.Point(0, 415);
            this.btn_HoaDon.Size = new System.Drawing.Size(253, 44);
            this.btn_ThongKe.Location = new System.Drawing.Point(0, 460);
            this.btn_ThongKe.Size = new System.Drawing.Size(253, 44);
        }

        private void frm_CaNhan_Load(object sender, EventArgs e)
        {
           // this.duongdan.BackColor = Color.Transparent;
            LayTaiKhoan();
            
            LayThongBao();
            rtb_ThongBao.Enabled = true;
            
            Menu1aaa();

            //this.btn_IDT.Enabled = false;
            //this.btn_IDSNV.Enabled = false;
            //this.btn_IDSKH.Enabled = false;
            //this.btn_IDSHH.Enabled = false;
            //this.btn_IDSHD.Enabled = false;
            
            DateTime tn = DateTime.Now;
            lb_Gio.Text = tn.ToString("hh:mm:ss");
            this.panel12.Hide();
            this.panel13.Hide();
            this.panel14.Hide();
            this.panel15.Hide();
            this.panel16.Hide();
            this.panel17.Hide();
            this.panel18.Hide();
            lb_Ngay.Text = tn.ToString("dd/MM/yyyy");

            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT * FROM NHANVIEN WHERE TaiKhoan =N'" + lb_KetNoi.Text + "'";
            cmd1.Connection = conn;
            SqlDataReader reader = cmd1.ExecuteReader();
            if (reader.Read())
            {

                lb_HoTen.Text = reader.GetString(3);
                lb_NgaySinh.Text = reader.GetString(4);
                lb_Email.Text = reader.GetString(7);
                lb_GioiTinh.Text = reader.GetString(5);
                lb_CMND.Text = reader.GetString(8);
                lb_DiaChi.Text = reader.GetString(6);
                lb_SDT.Text = reader.GetString(9);
                lb_NgayBDLV.Text = reader.GetString(12);
                try
                {
                  //  lb_HSL.Text = reader.GetDouble(13).ToString();
                }
                catch 
                { }
                
                int b =reader.GetInt32(0);
                if (b < 10)
                {
                    lb_MaNV.Text = "NV000" + (b).ToString();
                }
                else if (b > 9 && b < 100)
                {
                    lb_MaNV.Text = "NV00" + (b).ToString();
                }
                else if (b > 99 && b < 1000)
                {
                    lb_MaNV.Text = "NV0" + (b).ToString();
                }

               
                lb_ChucVu.Text = reader.GetString(11);
                KiemTraQuyen();
                if (lb_ChucVu.Text == "Nhân Viên")
                {
                    txt_ThongBao.Enabled = false;
                    btn_DangKy.Enabled = false;

                    this.btn_IDT.Enabled = false;
                    this.btn_IDSNV.Enabled = false;
                    this.btn_IDSKH.Enabled = false;
                    this.btn_IDSHH.Enabled = false;
                    this.btn_IDSHD.Enabled = false;

                }
                else
                {
                    txt_ThongBao.Enabled = true;
                    btn_DangKy.Enabled = true;
                    this.btn_IDT.Enabled = true;
                    this.btn_IDSNV.Enabled = true;
                    this.btn_IDSKH.Enabled = true;
                    this.btn_IDSHH.Enabled = true;
                    this.btn_IDSHD.Enabled = true;
                    
                
                }
                try
                {
                    if (reader.HasRows)
                    {
                        string hinhanh;
                        hinhanh = reader[10].ToString();
                        cribox_CaNhan.Image = System.Drawing.Image.FromFile(hinhanh);
                        cribox_CaNhan.SizeMode = PictureBoxSizeMode.StretchImage;
                        conn.Close();
                    }
                }
                catch
                {
 
                }

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime tn = DateTime.Now;
            lb_Gio.Text = tn.ToString("hh:mm:ss tt");
        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            this.panel12.Show();
            this.panel13.Show();
            this.panel14.Show();
            this.panel15.Show();
            this.panel16.Show();
            this.panel17.Show();
        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {

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

        private void panel22_MouseMove(object sender, MouseEventArgs e)
        {
            this.panel22.BackColor = System.Drawing.Color.Blue;
            this.panel19.BackColor = System.Drawing.Color.White;
            this.panel23.BackColor = System.Drawing.Color.White;
            this.panel21.BackColor = System.Drawing.Color.White;
            this.panel20.BackColor = System.Drawing.Color.White;
        }

        private void panel23_MouseUp(object sender, MouseEventArgs e)
        {

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

        private void panel17_MouseMove(object sender, MouseEventArgs e)
        {
            this.panel17.BackColor = System.Drawing.Color.Blue;
            this.panel16.BackColor = System.Drawing.Color.White;
            this.panel15.BackColor = System.Drawing.Color.White;
            this.panel14.BackColor = System.Drawing.Color.White;
            this.panel13.BackColor = System.Drawing.Color.White;
            this.panel12.BackColor = System.Drawing.Color.White;
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

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            this.panel18.Hide();
            this.panel12.Hide();
            this.panel13.Hide();
            this.panel14.Hide();
            this.panel15.Hide();
            this.panel16.Hide();
            this.panel17.Hide();
        }

        private void frm_CaNhan_MouseMove(object sender, MouseEventArgs e)
        {
            this.panel18.Hide();
            this.panel12.Hide();
            this.panel13.Hide();
            this.panel14.Hide();
            this.panel15.Hide();
            this.panel16.Hide();
            this.panel17.Hide();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {


        }
        // OpenFileDialog open;
        private void criPictureBox1_Click(object sender, EventArgs e)
        {
            // OpenFileDialog open;
            // open = new OpenFileDialog();

            // open.InitialDirectory = "D:";
            // DialogResult result = open.ShowDialog();

           
            // duongdan.Text = picPath;
            // t.ImageLocation = picPath;


            // if (result == DialogResult.OK)
            // {

            //  cribox_CaNhan.Image = Image.FromStream(open.OpenFile());
            


            // }





            //}
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
                conn.Open();
                SqlCommand cmd1 = new SqlCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "UPDATE NHANVIEN SET AnhNV= N'" + duongdan.Text + "' WHERE TaiKhoan = N'" + lb_KetNoi.Text + "'";
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
            catch { }
        }
        

        private void panel23_Click(object sender, EventArgs e)
        {
            frm_DangNhap DangNhap = new frm_DangNhap();
            DangNhap.Show();
            this.Hide();
        }

        private void panel23_Paint(object sender, PaintEventArgs e)
        {
            
        }
        public void KiemTraQuyen()
        {
            if (lb_ChucVu.Text == "Quản Lý")
            {
                
            }
            else
            {

                this.btn_HangHoa.Enabled = false;
                this.btn_HoaDon.Enabled = false;
                this.btn_KhachHang.Enabled = false;
                this.btn_NhanVien.Enabled = false;
                this.btn_ThongKe.Enabled = false;

                
                
            }
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn cập nhật thông báo mới", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == System.Windows.Forms.DialogResult.OK)
            {
                if (lb_ChucVu.Text == "Quản Lý")
                {
                    SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
                    conn.Open();
                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = "UPDATE THONGBAO SET THONGBAO= N'" + txt_ThongBao.Text + "'";
                    cmd1.Connection = conn;
                    int ret = cmd1.ExecuteNonQuery();
                    if (ret > 0)
                    {
                        LayThongBao();
                        MessageBox.Show("Cập nhật thông báo thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông báo thất bại ! Kiểm tra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void lb_KetNoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtb_ThongBao_TextChanged(object sender, EventArgs e)
        {

        }

        private void gbx_ThoiGian_Enter(object sender, EventArgs e)
        {

        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void criPictureBox1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png| ALL Files(*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string picPath = dlg.FileName.ToString();
                duongdan.Text = picPath;
                cribox_CaNhan.ImageLocation = picPath;
                cribox_CaNhan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            }
        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void btn_HangHoa_Click(object sender, EventArgs e)
        {
            this.btn_IDSHH.Show();
            this.btn_NhanVien.Location = new System.Drawing.Point(0, 324 + 45);
            this.btn_NhanVien.Size = new System.Drawing.Size(253, 44);
            this.btn_KhachHang.Location = new System.Drawing.Point(0, 369 + 45);
            this.btn_KhachHang.Size = new System.Drawing.Size(253, 44);
            this.btn_HoaDon.Location = new System.Drawing.Point(0, 415 + 45);
            this.btn_HoaDon.Size = new System.Drawing.Size(253, 44);
            this.btn_ThongKe.Location = new System.Drawing.Point(0, 460 + 45);
            this.btn_ThongKe.Size = new System.Drawing.Size(253, 44);
            this.btn_IDSNV.Hide();
            this.btn_IDT.Location = new System.Drawing.Point(33, 641 - 45 - 45 - 45);
            btn_IDT.Hide();
            
        }

        private void btn_HangHoa_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void btn_NhanVien_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void btn_KhachHang_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void btn_HoaDon_MouseMove(object sender, MouseEventArgs e)
        {
            

        }

        private void btn_ThongKe_MouseMove(object sender, MouseEventArgs e)
        {
            
            
        }

        private void btn_IDSHH_MouseMove(object sender, MouseEventArgs e)
        {
            btn_IDSHH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(39)))), ((int)(((byte)(0)))));
        }

        private void btn_IDSNV_MouseMove(object sender, MouseEventArgs e)
        {
            btn_IDSNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(39)))), ((int)(((byte)(0)))));
        }

        private void btn_IDSKH_MouseMove(object sender, MouseEventArgs e)
        {
            btn_IDSKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(39)))), ((int)(((byte)(0)))));
        }

        private void btn_IDSHD_MouseMove(object sender, MouseEventArgs e)
        {
            btn_IDSHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(39)))), ((int)(((byte)(0)))));
        }

        private void btn_IDT_MouseMove(object sender, MouseEventArgs e)
        {
            btn_IDT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(39)))), ((int)(((byte)(0)))));
        }

        private void panel7_MouseMove(object sender, MouseEventArgs e)
        {

            //btn_IDT.Hide();
            //btn_IDSNV.Hide();
            //btn_IDSKH.Hide();
            //btn_IDSHD.Hide();
            //btn_IDSHH.Hide();
        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            this.btn_IDSHH.Hide();
            this.btn_IDSNV.Location = new System.Drawing.Point(33, 415 - 45);
            this.btn_IDSNV.Show();
            this.btn_NhanVien.Location = new System.Drawing.Point(0, 324);
            this.btn_KhachHang.Location = new System.Drawing.Point(0, 460 - 45);
            btn_IDSKH.Hide();
            btn_IDSHD.Hide();
            btn_IDT.Hide();
        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            btn_IDSNV.Hide();
            this.btn_KhachHang.Location = new System.Drawing.Point(0, 460 - 45 - 45);
            btn_IDSKH.Location = new System.Drawing.Point(33, 460 - 45);
            btn_IDSKH.Show();
            btn_IDSHH.Hide();
            btn_IDSHD.Hide();
            this.btn_HoaDon.Location = new System.Drawing.Point(0, 550 - 45 - 45);
            btn_IDT.Hide();
        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            btn_IDSKH.Hide();
            this.btn_HoaDon.Location = new System.Drawing.Point(0, 550 - 45 - 45 - 45);
            btn_IDSHD.Location = new System.Drawing.Point(33, 550 - 45 - 45);
            btn_IDSHD.Show();
            btn_IDSHH.Hide();
            btn_IDSNV.Hide();
            btn_IDT.Hide();
            this.btn_ThongKe.Location = new System.Drawing.Point(0, 550 - 45);
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            this.btn_IDSHD.Hide();
            this.btn_IDT.Location = new System.Drawing.Point(33, 641 - 45 - 45 - 45);
            this.btn_ThongKe.Location = new System.Drawing.Point(0, 550 - 45 - 45);
            btn_IDT.Show();

            //an het
            btn_IDSHH.Hide();
            btn_IDSKH.Hide();
            btn_IDSNV.Hide();
        }

        private void panel4_MouseMove_1(object sender, MouseEventArgs e)
        {
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_IDSHH_Click(object sender, EventArgs e)
        {
            frm_InDSHH a = new frm_InDSHH();
            a.Show();
        }

        private void btn_IDSNV_Click(object sender, EventArgs e)
        {
            frm_InDSNV a = new frm_InDSNV();
            a.Show();
        }

        private void btn_IDSKH_Click(object sender, EventArgs e)
        {
            Frm_InKhachHang a = new Frm_InKhachHang();
            a.Show();
        }

        private void lb_HSL_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_IDSHD_Click(object sender, EventArgs e)
        {
            frm_InDSHD a = new frm_InDSHD();
            a.Show();
        }

        private void btn_IDT_Click(object sender, EventArgs e)
        {
            frm_InDT a = new frm_InDT();
            a.Show();
        }
    }
}
