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
    public partial class frm_BCGioiTinh : Form
    {
        public frm_BCGioiTinh()
        {
            InitializeComponent();
        }

        public void LayNam()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT COUNT(*) FROM NHANVIEN WHERE GioiTinh = N'Nam'";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                if (reader.Read())
                {
                    lb_Nam.Text = reader.GetInt32(0).ToString();
                }
            }
            catch { }
        }

        public void LayNu()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT COUNT(*) FROM NHANVIEN WHERE GioiTinh = N'Nữ'";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                if (reader.Read())
                {
                    lb_Nu.Text = reader.GetInt32(0).ToString();
                }
            }
            catch { }
        }
        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void frm_BCGioiTinh_Load(object sender, EventArgs e)
        {
            LayNam();
            LayNu();
            int a = Int32.Parse(lb_Nam.Text);
            int b = Int32.Parse(lb_Nu.Text);
            C_GioiTinh.Series["Nam"].Points.AddXY("Giới Tính", a);
            C_GioiTinh.Series["Nữ"].Points.AddXY("Giới Tính", b);
        }
    }
}
