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
    public partial class frm_BieuDoNhapXuat : Form
    {
        public frm_BieuDoNhapXuat()
        {
            InitializeComponent();
        }

        private void frm_BieuDoNhapXuat_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT TenHang,SoLuong,DaBan  FROM HANG";
            cmd1.Connection = conn;
            SqlDataReader reader = cmd1.ExecuteReader();
            while (reader.Read())
            {
                string a = reader.GetInt32(1).ToString();
                int b = Convert.ToInt32(a);
                string d = reader.GetInt32(2).ToString();
                int v = Convert.ToInt32(d);
                string c = reader.GetString(0);
                C_DaBan.Series["Số Lượng Nhập"].Points.AddXY(c,b);
                C_DaBan.Series["Số Lượng Bán"].Points.AddXY(c,v);
            }
            conn.Close();
            
        }

        private void C_DaBan_Click(object sender, EventArgs e)
        {

        }
    }
}
