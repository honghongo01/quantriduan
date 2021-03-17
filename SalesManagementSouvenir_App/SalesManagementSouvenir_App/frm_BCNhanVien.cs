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
    public partial class frm_BCNhanVien : Form
    {
        public frm_BCNhanVien()
        {
            InitializeComponent();
        }

        public void LayNhanVien()
        {
            
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT COUNT(*) FROM NHANVIEN";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                if (reader.Read())
                {
                    lb_NhanVien.Text = reader.GetInt32(0).ToString(); 
                }
            }
            catch {  }
        }

        public void LayQuanLy()
        {

            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT COUNT(*) FROM NHANVIEN WHERE ChucVu = N'Quản Lý'";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                if (reader.Read())
                {
                    lb_QuanLy.Text = reader.GetInt32(0).ToString();
                }
            }
            catch { }
        }
        public void LayNhanVien1()
        {

            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT COUNT(*) FROM NHANVIEN WHERE ChucVu = N'Nhân Viên'";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                if (reader.Read())
                {
                    lb_NhanVien1.Text = reader.GetInt32(0).ToString();
                }
            }
            catch { }
        }

        private void frm_BCNhanVien_Load(object sender, EventArgs e)
        {
            LayNhanVien();
            LayQuanLy();
            LayNhanVien1();
            int a = Int32.Parse(lb_NhanVien.Text);
            int b = Int32.Parse(lb_QuanLy.Text);
            int c = Int32.Parse(lb_NhanVien1.Text);
            
            C_NhanVien.Series["Tổng Số"].Points.AddXY("Nhân Viên",a);
            C_NhanVien.Series["Quản Lý"].Points.AddXY("Nhân Viên",b);
            C_NhanVien.Series["Nhân Viên"].Points.AddXY("Nhân Viên",c);
        }
    }
}
