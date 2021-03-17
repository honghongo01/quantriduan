using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Data.SqlClient;


namespace SalesManagementSouvenir_App
{
    public partial class frm_DangKy : Form
    {
        public void MoKetNoi()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
        }

        public void DongKetNoi()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Close();
        }

        

        public void ThemDangKy()
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO NHANVIEN(TaiKhoan,MatKhau,HoTenNV,NgaySinh,GioiTinh,DiaChi,Email,CMND,SDT,ChucVu,NgayBDLV) VALUES (@TaiKhoan,@MatKhau,@HoTenNV,@NgaySinh,@GioiTinh,@DiaChi,@Email,@CMND,@SDT,@ChucVu,@NgayBDLV)";
                cmd.Connection = conn;
                cmd.Parameters.Add("@TaiKhoan", SqlDbType.NVarChar).Value = txt_TaiKhoan.Text;
                cmd.Parameters.Add("@MatKhau", SqlDbType.NVarChar).Value = txt_MatKhau.Text;
                cmd.Parameters.Add("@HoTenNV", SqlDbType.NVarChar).Value = txt_HoTen.Text;
                cmd.Parameters.Add("@NgaySinh", SqlDbType.Char).Value = cbx_ThangSinh.Text + "/" + cbx_NgaySinh.Text + "/" + cbx_NamSinh.Text;
                cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = cbx_GioiTinh.Text;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = txt_DiaChi.Text;
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = txt_Email.Text;
                cmd.Parameters.Add("@CMND", SqlDbType.Char).Value = txt_CMND.Text;
                cmd.Parameters.Add("@SDT", SqlDbType.Char).Value = txt_SDT.Text;
                cmd.Parameters.Add("@ChucVu", SqlDbType.NVarChar).Value = cbx_ChucVu.Text;
                cmd.Parameters.Add("@NgayBDLV", SqlDbType.Char).Value = cbx_ThangBDLV.Text + "/" + cbx_NgayBDLV.Text + "/" + cbx_NamBDLV.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Thành công");
                }
                conn.Close();
            }
            catch { }
        }
        public void LayMaNV()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT MAX(MaNV) FROM NHANVIEN";
            cmd1.Connection = conn;
            SqlDataReader reader = cmd1.ExecuteReader();
            if(reader.Read())
            {
               string a = reader.GetInt32(0).ToString();
               int b = Convert.ToInt32(a);
               if (b < 10)
               {
                   txt_MaNhanVien.Text = "NV000" + (b + 1).ToString();
               }
               else if (b > 9 && b < 100)
               {
                   txt_MaNhanVien.Text = "NV00" + (b + 1).ToString();
               }
               else if (b > 99 && b < 1000)
               {
                   txt_MaNhanVien.Text = "NV0" + (b + 1).ToString();
               }

            }
            conn.Close();
        }


        


        public frm_DangKy()
        {
            InitializeComponent();
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void KiemTraTonTai()
        {
           // try
           // {
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
                conn.Open();
                SqlCommand cmd1 = new SqlCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "SELECT HoTenNV,CMND  FROM NHANVIEN WHERE CMND = "+txt_CMND.Text+"";
                cmd1.Connection = conn;
                SqlDataReader reader = cmd1.ExecuteReader();
            if (reader.Read())
            {
                string a = reader.GetString(0);
                string b = reader.GetString(1);
                //  string c = reader.GetString(2);
                if (txt_CMND.Text == b)
                {
                    lb_KT.Text = "1";
                    MessageBox.Show("Đã có có nhân viên " + a + " trong hệ thống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    lb_KT.Text = "0";
                }

            }
            else
            { lb_KT.Text = "0"; }
            //}
            //catch { }
        }
        private void frm_DangKy_Load(object sender, EventArgs e)
        {
            txt_MaNhanVien.Enabled = false;
            if (txt_MaNhanVien.Text == "")
            {
                txt_MaNhanVien.Text = "NV0001";
            }
            try
            {
                MoKetNoi();
                LayMaNV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            for (int i = 1990; i < 2025; i++)
            {
                this.cbx_NamBDLV.Items.Add(i);
            }
            for (int i = 1970; i < 2011; i++)
            {
                this.cbx_NamSinh.Items.Add(i);
            }
            this.cbx_GioiTinh.Items.Add("Nam");
            this.cbx_GioiTinh.Items.Add("Nữ");
        }
        public void GuiMail()
        {
            try
            {
                if (txt_MaNhanVien.Text == "")
                {
                    txt_MaNhanVien.Text = "NV0001";
                }

                frm_Pro Pro = new frm_Pro();
                Pro.ShowDialog();
                SmtpClient mailclient = new SmtpClient("smtp.gmail.com", 587);
                mailclient.EnableSsl = true;
                mailclient.Credentials = new NetworkCredential("doancosonganh01@gmail.com", "@Kenchuong98");

                MailMessage message = new MailMessage("doancosonganh01@gmail.com", txt_Email.Text);
                message.Subject = "Sales Management Souvenir - App";
                message.Body = "                                             THÔNG TIN ĐĂNG KÝ \n" +
            "                Tài Khoản            : " + txt_TaiKhoan.Text + "\n" +
            "                Mật Khẩu             : " + txt_MatKhau.Text + "\n" +
            "                Họ và Tên            : " + txt_HoTen.Text + "\n" +
            "                Ngày Sinh            : " + cbx_NgaySinh.Text + "/" + cbx_ThangSinh.Text + "/" + cbx_NamSinh.Text + "\n" +
            "                Giới Tính             :  " + cbx_GioiTinh.Text + "\n" +
            "                Địa Chỉ                :  " + txt_DiaChi.Text + "\n" +
            "                Email                   :  " + txt_Email.Text + "\n" +
            "                Số Điện Thoại     :  " + txt_SDT.Text + "\n" +
            "                Mã Nhân Viên     :  " + txt_MaNhanVien.Text + "\n" +
            "                CMND                 :  " + txt_CMND.Text + "\n" +
            "                Chức Vụ              : " + cbx_ChucVu.Text + "\n" +
            "                Ngày BĐLV          :  " + cbx_NgayBDLV.Text + "/" + cbx_ThangBDLV.Text + "/" + cbx_NamBDLV.Text + "\n";
                mailclient.Send(message);


                MessageBox.Show("Thông Tin được chuyển về mail ! Xin kiểm tra mail ", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                frm_Pro Pro = new frm_Pro();
                Pro.ShowDialog();

                MessageBox.Show("Vui lòng kiểm tra lại thông tin vừa nhập", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private void btn_DangKy_Click(object sender, EventArgs e)
        {
           // do
           // {
                KiemTraTonTai();
                if (lb_KT.Text == "0")
                {
                    if (txt_MaXacNhan.Text == "SMA_01")
                    {
                        frm_Pro Pro = new frm_Pro();
                        Pro.ShowDialog();
                        ThemDangKy();
                        GuiMail();
                    }
                    else
                    {
                        MessageBox.Show("Mã Xác Nhận của bạn chưa đúng ! Vui Lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Đã tồn tại nhân viên " + txt_HoTen.Text + " trong hệ thống ! Vui Lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            //} while (lb_KT.Text =="1");
            
        }

        

        

        private void txt_Email_Enter(object sender, EventArgs e)
        {
            if(txt_Email.Text =="someone@example.com")
            txt_Email.Text ="";
            txt_Email.ForeColor = Color.Black;
        }

        private void txt_Email_Leave(object sender, EventArgs e)
        {
            if(txt_Email.Text =="")
            txt_Email.Text ="someone@example.com";
            txt_Email.ForeColor = Color.Silver;
        }

        private void txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsDigit(e.KeyChar) || e.KeyChar == 8 ))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void txt_SDT_TextChanged(object sender, EventArgs e)
        {
            if (txt_SDT.Text.Length == 0)
            {
                error_txt_SDT.SetError(txt_SDT, "Số điện thoại không được rỗng !");
            }
            if (txt_SDT.Text.Length < 10 || txt_SDT.Text.Length > 12)
            {
                error_txt_SDT.SetError(txt_SDT, "Số điện thoại quá ngắn hoặc quá dài!");
            }
            
            else
            {
                error_txt_SDT.Clear();
              
            }
            
        }

        private void txt_SDT_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void txt_SDT_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txt_MaNhanVien_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void txt_CMND_TextChanged(object sender, EventArgs e)
        {
            if (txt_CMND.Text.Length == 0)
            {
                error_CMND.SetError(txt_CMND,"Số CMND rỗng !");
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

        private void txt_HoTen_TextChanged(object sender, EventArgs e)
        {
            if (txt_HoTen.Text.Length == 0)
            {
                error_HoTen.SetError(txt_HoTen, "Số CMND rỗng !");
            }
        }

        private void txt_MaXacNhan_TextChanged(object sender, EventArgs e)
        {
            if (txt_MaXacNhan.Text.Length == 0)
            {
                error_MaXacNhan.SetError(txt_MaXacNhan, "Mã xác nhận không được rỗng!");
            }
            if (txt_MaXacNhan.Text != "SMA_01")
            {
                error_MaXacNhan.SetError(txt_MaXacNhan, "Mã xác nhận không đúng!");
            }
            if (txt_MaXacNhan.Text.Length > 6)
            {
                error_MaXacNhan.SetError(txt_MaXacNhan, "Mã xác nhận quá dài!");
            }
            else
            {
                error_MaXacNhan.Clear();
            }
        }

        private void txt_MatKhau_TextChanged(object sender, EventArgs e)
        {
            if (txt_MatKhau.Text.Length == 0)
            {
                error_MatKhau.SetError(txt_MatKhau, "Mật khẩu không được rỗng!");
            }
            else
            {
                error_MatKhau.Clear();
            }
        }

        private void txt_TaiKhoan_TextChanged(object sender, EventArgs e)
        {
            if (txt_TaiKhoan.Text.Length == 0)
            {
                error_TaiKhoan.SetError(txt_TaiKhoan, "Mật khẩu không được rỗng!");
            }
            else
            {
                error_TaiKhoan.Clear();
            }
        }

       
        
       
    }
}
