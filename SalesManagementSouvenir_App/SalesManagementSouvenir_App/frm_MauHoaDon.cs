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
    public partial class frm_MauHoaDon : Form
    {
        public frm_MauHoaDon()
        {
            InitializeComponent();
        }

        public void LayMaHd()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT MaHDIn FROM TRANGTHAIIN";
            cmd.Connection = conn;
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lb_MaHD.Text = reader.GetInt32(0).ToString();
                    // MessageBox.Show("Thêm Thông Tin Thành Công !", "Thông báo", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Asterisk);
                }
            }
            catch { }
        }
        public void LayThongTin()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT TenCH,DiaChi, SDTCH,EmailCH FROM THONGTINSHOP";
            cmd.Connection = conn;
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lb_DiaChiShop.Text = reader.GetString(1);
                    lb_EmailShop.Text = reader.GetString(3);
                    lb_SDTShop.Text = reader.GetString(2);
                    lb_CuaHang.Text = reader.GetString(0);
                    // MessageBox.Show("Thêm Thông Tin Thành Công !", "Thông báo", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Asterisk);
                }
            }
            catch { }
        }

        public void LayThongTinKhach()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT KHACHHANG.TenKhach,KHACHHANG.DiaChiKH,KHACHHANG.SDTKH,TongTien FROM HOADON,KHACHHANG WHERE HOADON.MaKH = KHACHHANG.MaKH AND MAHD = "+lb_MaHD.Text+"";
            cmd.Connection = conn;
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lb_TenKhachHang.Text = reader.GetString(0);
                    lb_DiaChi.Text = reader.GetString(1);
                    lb_SDT.Text = reader.GetString(2);
                    lb_TT1.Text = reader.GetDouble(3).ToString();
                    lb_TongCong.Text = reader.GetDouble(3).ToString("#,###") + " VNĐ";
                    
                   
                    int b = Int32.Parse(lb_MaHD.Text);
                    if (b < 10)
                    {
                        lb_MaHD1.Text = "HD000" + (b).ToString();
                    }
                    else if (b > 9 && b < 100)
                    {
                        lb_MaHD1.Text = "HD00" + (b).ToString();
                    }
                    else if (b > 99 && b < 1000)
                    {
                        lb_MaHD1.Text = "HD0" + (b).ToString();
                    }
                    // MessageBox.Show("Thêm Thông Tin Thành Công !", "Thông báo", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Asterisk);
                }
            }
            catch { }
           // SELECT MaHD,NgayLap,MaNV,KHACHHANG.TenKhach,TongTien FROM HOADON,KHACHHANG WHERE HOADON.MaKH = KHACHHANG.MaKH";
        }
        public void HienThi()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            string sql = "SELECT HANG.TenHang,CHITIETHOADON.SoLuongMua,HANG.DonGiaBan,CHITIETHOADON.ThanhTien FROM CHITIETHOADON,HANG,HOADON WHERE HANG.MaHang = CHITIETHOADON.MaHang AND HOADON.MaHD = CHITIETHOADON.MaHD AND CHITIETHOADON.MaHD = "+lb_MaHD.Text+" ";
            SqlCommand com = new SqlCommand(sql, conn); //bat dau truy van
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu

            //da.Fill(dt);
            // đổ dữ liệu vào kho

            da.Fill(dt);
            dt.Columns.Add("STT");
            dataGridView1.Columns[0].Width = 100;


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
        public void DocTien()
        {
            lb_BangChu.Text = _DoiTienSoSangTienChu(lb_TT1.Text);
        }
        private void frm_MauHoaDon_Load(object sender, EventArgs e)
        {
            LayMaHd();
            LayThongTin();
            LayThongTinKhach();
            DocTien();
            HienThi();
            //In();
        }

        
        private void lb_MaHD_Click(object sender, EventArgs e)
        {

        }
        Bitmap bmp;

        public void In()
        {
           //// int X = 100;
          //  int Y = 100;
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == 1)
            {
                timer1.Stop();
                In();
                this.Close();
                frm_HoaDon a = new frm_HoaDon();
                a.Show();
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void lb_BangChu_Click(object sender, EventArgs e)
        {

        }

        private void lb_TongCong_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
