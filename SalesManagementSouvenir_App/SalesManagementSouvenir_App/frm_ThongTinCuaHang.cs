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
    public partial class frm_ThongTinCuaHang : Form
    {
        public frm_ThongTinCuaHang()
        {
            InitializeComponent();
        }

        public void Them()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO THONGTINSHOP(TenCH,DiaChi,SDTCH,EmailCH) VALUES (N'" + txt_TenCH.Text + "',N'" + txt_DiaChi.Text + "',N'" + txt_SDT.Text + "',N'" + txt_Email.Text + "')";
            cmd.Connection = conn;
            //try
            //{
                int ret = cmd.ExecuteNonQuery();

                if (ret > 0)
                {
                    MessageBox.Show("Thêm Thông Tin Thành Công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else {
                    MessageBox.Show("Thêm Thông Tin Thất Bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            //}
            //catch
            //{ }

            conn.Close();
        }


        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_HoaDon a = new frm_HoaDon();
            a.Show();
            
        }


        
        private void btn_Them_Click(object sender, EventArgs e)
        {
            Them();
        }

        private void frm_ThongTinCuaHang_Load(object sender, EventArgs e)
        {

        }
    }
}
