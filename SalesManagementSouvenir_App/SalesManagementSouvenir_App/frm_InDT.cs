using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Imaging;

namespace SalesManagementSouvenir_App
{
    public partial class frm_InDT : Form
    {
        public frm_InDT()
        {
            InitializeComponent();
        }

        private void frm_InDT_Load(object sender, EventArgs e)
        {
           // this.WindowState = FormWindowState.Minimized;
        }

        private void C_InDT_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public void LayThang1()
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
            cmd.CommandText = "SELECT SUM(TongTien) FROM HOADON  WHERE NgayLap LIKE '%06/" + nam.ToString() + "%'";
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
            cmd.CommandText = "SELECT SUM(TongTien) FROM HOADON  WHERE NgayLap LIKE '%07/" + nam.ToString() + "%'";
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
            cmd.CommandText = "SELECT SUM(TongTien) FROM HOADON  WHERE NgayLap LIKE '%08/" + nam.ToString() + "%'";
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
            cmd.CommandText = "SELECT SUM(TongTien) FROM HOADON  WHERE NgayLap LIKE '%09/" + nam.ToString() + "%'";
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
            cmd.CommandText = "SELECT SUM(TongTien) FROM HOADON  WHERE NgayLap LIKE '%10/" + nam.ToString() + "%'";
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
            cmd.CommandText = "SELECT SUM(TongTien) FROM HOADON  WHERE NgayLap LIKE '%11/" + nam.ToString() + "%'";
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
            cmd.CommandText = "SELECT SUM(TongTien) FROM HOADON  WHERE NgayLap LIKE '%12/" + nam.ToString() + "%'";
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
        private void btn_XemThongKe_Click(object sender, EventArgs e)
        {
            LayThang1();
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
                C_InDT.Series["Tháng 1"].Points.AddXY("Doanh Thu Năm " + txt_Nam1.Text, Thang01);
                C_InDT.Series["Tháng 2"].Points.AddXY("Doanh Thu Năm  " + txt_Nam1.Text, Thang02);

                C_InDT.Series["Tháng 3"].Points.AddXY("Doanh Thu Năm" + txt_Nam1.Text, Thang03);

                C_InDT.Series["Tháng 4"].Points.AddXY("Doanh Thu Năm" + txt_Nam1.Text, Thang04);

                C_InDT.Series["Tháng 5"].Points.AddXY("Doanh Thu Năm" + txt_Nam1.Text, Thang05);

                C_InDT.Series["Tháng 6"].Points.AddXY("Doanh Thu Năm" + txt_Nam1.Text, Thang06);
                C_InDT.Series["Tháng 7"].Points.AddXY("Doanh Thu Năm" + txt_Nam1.Text, Thang07);

                C_InDT.Series["Tháng 8"].Points.AddXY("Doanh Thu Năm" + txt_Nam1.Text, Thang08);
                C_InDT.Series["Tháng 9"].Points.AddXY("Doanh Thu Năm" + txt_Nam1.Text, Thang09);
                C_InDT.Series["Tháng 10"].Points.AddXY("Doanh Thu Năm" + txt_Nam1.Text, Thang010);
                C_InDT.Series["Tháng 11"].Points.AddXY("Doanh Thu Năm" + txt_Nam1.Text, Thang011);
                C_InDT.Series["Tháng 12"].Points.AddXY("Doanh Thu Năm" + txt_Nam1.Text, Thang012);
                 
                int Qui1 = Thang01+ Thang02 + Thang03;
                int Qui2 = Thang04+ Thang05 + Thang06;
                int Qui3 = Thang07 + Thang08+ Thang09;
                int Qui4 =  Thang010 + Thang011 + Thang012;
                int CaNam = Qui1+Qui2+Qui3+Qui4;
                btn_Qui1.Text ="Quý 1: "+ Qui1.ToString() +" VNĐ";
                btn_Qui2.Text = "Quý 2: " + Qui2.ToString() + " VNĐ";
                btn_Qui3.Text = "Quý 3: " + Qui3.ToString() + " VNĐ";
                btn_Qui4.Text = "Quý 4: " + Qui4.ToString() + " VNĐ";
                btn_CaNam.Text = "Doanh thu năm " + txt_Nam1.Text + ": " + CaNam.ToString()+ " VNĐ";
                this.btn_XemThongKe.Enabled = false;

                //C_DoanhThu.Series["Thu"].Points.AddXY(c, v);
                // this.C_DoanhThu.BackColor = Color.Transparent;
            }
            conn.Close();
        }
        Bitmap bmp;
        public void In()
        {
            //// int X = 100;
            //  int Y = 100;
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(0,0, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }

        ImageFormat img; Bitmap btm; Graphics g;
        public void ChupMH()
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
               // this.Hide();
                System.Threading.Thread.Sleep(1000);
                Size s = Screen.PrimaryScreen.Bounds.Size;
                btm = new Bitmap(s.Width, s.Height);
                g = Graphics.FromImage(btm);
                g.CopyFromScreen(0, 0, 0, 0, s);
                switch (saveFileDialog1.FilterIndex)
                {
                    case 0: img = ImageFormat.Bmp; break;  
                    case 1 : img = ImageFormat.Png; break;
                    case 2: img = ImageFormat.Jpeg; break;
                }
                btm.Save(saveFileDialog1.FileName, img);
                this.Close();

            }
        }
        private void btn_In_Click(object sender, EventArgs e)
        {
            //In();
            ChupMH();
            this.Close();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
           
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
