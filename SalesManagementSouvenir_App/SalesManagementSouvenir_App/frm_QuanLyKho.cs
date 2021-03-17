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
    public partial class frm_QuanLyKho : Form
    {
        public frm_QuanLyKho()
        {
            InitializeComponent();
        }

        private void frm_QuanLyKho_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            string sql = "SELECT TenHang,SoLuong,DaBan,SoLuong-DaBan as tonkho,MaHang FROM HANG"; // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, conn); //bat dau truy van
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu

            //da.Fill(dt);
            // đổ dữ liệu vào kho

            da.Fill(dt);

            dt.Columns.Add("STT");
            dataGridView1.Columns[0].Width = 50;


            for (int i = 0; i < dt.Rows.Count; i++)
                dt.Rows[i]["STT"] = i + 1;


            dataGridView1.DataSource = dt;
            dataGridView1.Columns["STT"].DisplayIndex = 0;

            conn.Close();  // đóng kết nối
            dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
