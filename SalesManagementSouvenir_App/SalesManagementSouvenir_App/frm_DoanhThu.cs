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
    public partial class frm_DoanhThu : Form
    {
        public frm_DoanhThu()
        {
            InitializeComponent();
        }
        public void LayThang01()
        {
            int nam = Int32.Parse(txt_Nam1.Text);
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT SUM(TongTien) FROM HOADON  WHERE NgayLap LIKE '%01/" + nam.ToString() + "%'";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
            if (reader.Read())
            {
                T1.Text = reader.GetDouble(0).ToString();
            }
            else T1.Text = "0";
            }
            catch { T1.Text = "0"; }

        }
        public void LayThang2()
        {
            int nam = Int32.Parse(txt_Nam1.Text);
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT SUM(TongTien) FROM HOADON  WHERE NgayLap LIKE '%02/" + nam.ToString() + "%'";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                if (reader.Read())
                {
                    T2.Text = reader.GetDouble(0).ToString();
                }
                else T2.Text = "0";
            }
            catch { T2.Text = "0"; }

        }
        public void LayThang3()
        {
            int nam = Int32.Parse(txt_Nam1.Text);
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT SUM(TongTien) FROM HOADON  WHERE NgayLap LIKE '%03/" + nam.ToString() + "%'";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                if (reader.Read())
                {
                    T3.Text = reader.GetDouble(0).ToString();
                }
                else T3.Text = "0";
            }
            catch { T3.Text = "0"; }

        }
        public void LayThang4()
        {
            int nam = Int32.Parse(txt_Nam1.Text);
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT SUM(TongTien) FROM HOADON  WHERE NgayLap LIKE '%04/" + nam.ToString() + "%'";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                if (reader.Read())
                {
                    T4.Text = reader.GetDouble(0).ToString();
                }
                else T4.Text = "0";
            }
            catch { T4.Text = "0"; }

        }
        public void LayThang5()
        {
            int nam = Int32.Parse(txt_Nam1.Text);
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT SUM(TongTien) FROM HOADON  WHERE NgayLap LIKE '%05/" + nam.ToString() + "%'";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                if (reader.Read())
                {
                    T5.Text = reader.GetDouble(0).ToString();
                }
                else T5.Text = "0";
            }
            catch { T5.Text = "0"; }

        }
        public void LayThang6()
        {
            int nam = Int32.Parse(txt_Nam1.Text);
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT SUM(TongTien) FROM HOADON WHERE NgayLap LIKE '%06/" + nam.ToString() + "%'";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                if (reader.Read())
                {
                    T6.Text = reader.GetDouble(0).ToString();
                }
                else T6.Text = "0";
            }
            catch { T6.Text = "0"; }

        }
        public void LayThang7()
        {
            int nam = Int32.Parse(txt_Nam1.Text);
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT SUM(TongTien) FROM HOADON WHERE NgayLap LIKE '%07/" + nam.ToString() + "%'";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                if (reader.Read())
                {
                    T7.Text = reader.GetDouble(0).ToString();
                }
                else T7.Text = "0";
            }
            catch { T7.Text = "0"; }

        }
        public void LayThang8()
        {
            int nam = Int32.Parse(txt_Nam1.Text);
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT SUM(TongTien) FROM HOADON WHERE NgayLap LIKE '%08/" + nam.ToString() + "%'";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                if (reader.Read())
                {
                    T8.Text = reader.GetDouble(0).ToString();
                }
                else T8.Text = "0";
            }
            catch { T8.Text = "0"; }

        }
        public void LayThang9()
        {
            int nam = Int32.Parse(txt_Nam1.Text);
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT SUM(TongTien) FROM HOADON WHERE NgayLap LIKE '%09/" + nam.ToString() + "%'";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                if (reader.Read())
                {
                    T9.Text = reader.GetDouble(0).ToString();
                }
                else T9.Text = "0";
            }
            catch { T9.Text = "0"; }

        }
        public void LayThang10()
        {
            int nam = Int32.Parse(txt_Nam1.Text);
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT SUM(TongTien) FROM HOADON WHERE NgayLap LIKE '%10/" + nam.ToString() + "%'";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                if (reader.Read())
                {
                    T10.Text = reader.GetDouble(0).ToString();
                }
                else T10.Text = "0";
            }
            catch { T10.Text = "0"; }

        }
        public void LayThang11()
        {
            int nam = Int32.Parse(txt_Nam1.Text);
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT SUM(TongTien) FROM HOADON WHERE NgayLap LIKE '%11/" + nam.ToString() + "%'";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                if (reader.Read())
                {
                    T11.Text = reader.GetDouble(0).ToString();
                }
                else T11.Text = "0";
            }
            catch { T11.Text = "0"; }
        }


        public void LayThang12()
        {
            int nam = Int32.Parse(txt_Nam1.Text);
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT SUM(TongTien) FROM HOADON WHERE NgayLap LIKE '%12/" + nam.ToString() + "%'";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                if (reader.Read())
                {
                    T12.Text = reader.GetDouble(0).ToString();
                }
                else T12.Text = "0";
            }
            catch { T12.Text = "0"; }

        }
        private void frm_DoanhThu_Load(object sender, EventArgs e)
        {
            this.T1.Hide();
            this.T2.Hide();
            this.T3.Hide();
            this.T4.Hide();
            this.T5.Hide();
            this.T6.Hide();
            this.T7.Hide();
            this.T8.Hide();
            this.T9.Hide();
            this.T10.Hide();
            this.T11.Hide();
            this.T12.Hide();
        }

        private void btn_XemThongKe_Click(object sender, EventArgs e)
        {try
            {
                LayThang01();
                LayThang2();
                LayThang3();
                LayThang4();
                LayThang5();
                LayThang6();
                LayThang7();
                LayThang8();
                LayThang9();
                LayThang10();
                LayThang11();
                LayThang12();

                this.T1.Show();
                this.T2.Show();
                this.T3.Show();
                this.T4.Show();
                this.T5.Show();
                this.T6.Show();
                this.T7.Show();
                this.T8.Show();
                this.T9.Show();
                this.T10.Show();
                this.T11.Show();
                this.T12.Show();
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
                conn.Open();
                SqlCommand cmd1 = new SqlCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "SELECT SUM(TongTien) FROM HOADON";
                cmd1.Connection = conn;
                SqlDataReader reader = cmd1.ExecuteReader();
                while (reader.Read())
                {
                    string a = reader.GetDouble(0).ToString();
                    int b = Convert.ToInt32(a);
                    int Thang01 = Int32.Parse(T1.Text);
                    int Thang02 = Int32.Parse(T2.Text);
                    int Thang03 = Int32.Parse(T3.Text);
                    int Thang04 = Int32.Parse(T4.Text);
                    int Thang05 = Int32.Parse(T5.Text);
                    int Thang06 = Int32.Parse(T6.Text);
                    int Thang07 = Int32.Parse(T7.Text);
                    int Thang08 = Int32.Parse(T8.Text);
                    int Thang09 = Int32.Parse(T9.Text);
                    int Thang010 = Int32.Parse(T10.Text);
                    int Thang011 = Int32.Parse(T11.Text);
                    int Thang012 = Int32.Parse(T12.Text);
                    // string d = reader.GetInt32(2).ToString();
                    // int v = Convert.ToInt32(d);
                    //string c = reader.GetString(0);
                    C_DoanhThu.Series["Tháng 1"].Points.AddXY("Doanh Thu Năm " + txt_Nam1.Text, Thang01);
                    C_DoanhThu.Series["Tháng 2"].Points.AddXY("Doanh Thu Năm  " + txt_Nam1.Text, Thang02);

                    C_DoanhThu.Series["Tháng 3"].Points.AddXY("Doanh Thu Năm" + txt_Nam1.Text, Thang03);

                    C_DoanhThu.Series["Tháng 4"].Points.AddXY("Doanh Thu Năm" + txt_Nam1.Text, Thang04);

                    C_DoanhThu.Series["Tháng 5"].Points.AddXY("Doanh Thu Năm" + txt_Nam1.Text, Thang05);

                    C_DoanhThu.Series["Tháng 6"].Points.AddXY("Doanh Thu Năm" + txt_Nam1.Text, Thang06);
                    C_DoanhThu.Series["Tháng 7"].Points.AddXY("Doanh Thu Năm" + txt_Nam1.Text, Thang07);

                    C_DoanhThu.Series["Tháng 8"].Points.AddXY("Doanh Thu Năm" + txt_Nam1.Text, Thang08);
                    C_DoanhThu.Series["Tháng 9"].Points.AddXY("Doanh Thu Năm" + txt_Nam1.Text, Thang09);
                    C_DoanhThu.Series["Tháng 10"].Points.AddXY("Doanh Thu Năm" + txt_Nam1.Text, Thang010);
                    C_DoanhThu.Series["Tháng 11"].Points.AddXY("Doanh Thu Năm" + txt_Nam1.Text, Thang011);
                    C_DoanhThu.Series["Tháng 12"].Points.AddXY("Doanh Thu Năm" + txt_Nam1.Text, Thang012);

                    //C_DoanhThu.Series["Thu"].Points.AddXY(c, v);
                    // this.C_DoanhThu.BackColor = Color.Transparent;
                }
                conn.Close();
            }
            catch { }

        }

        private void C_DoanhThu_Click(object sender, EventArgs e)
        {

        }
    }
}
