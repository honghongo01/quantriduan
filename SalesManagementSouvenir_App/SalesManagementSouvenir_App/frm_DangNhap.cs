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
    public delegate void SendMessage(string Values);
    public partial class frm_DangNhap : Form
    {
        private void SetValues(String Values)
        {
            this.txt_TaiKhoan.Text = Values;
        }
        public void XLDangNhap()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT TaiKhoan,MatKhau FROM NHANVIEN WHERE TaiKhoan = N'"+txt_TaiKhoan.Text+"' AND MatKhau = N'"+txt_MatKhau.Text+"'";
            cmd1.Connection = conn;
            SqlDataReader reader = cmd1.ExecuteReader();
            if (reader.Read())
            {
                string a = reader.GetString(0);
                string b = reader.GetString(1);
                if ((txt_TaiKhoan.Text == a) && (txt_MatKhau.Text == b))
                {
                    frm_Pro Pro = new frm_Pro();
                    Pro.ShowDialog();
                    this.Hide();
                    frm_Banner frm_Menu = new frm_Banner();
                    this.Hide();
                    frm_Menu.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Tài Khoản hoặc Mật Khẩu Không đúng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                frm_Pro Pro = new frm_Pro();
                Pro.ShowDialog();
                MessageBox.Show("Tài Khoản hoặc Mật Khẩu Không đúng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            conn.Close();
        }
        public frm_DangNhap()
        {
            InitializeComponent();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            frm_DangKy DangKy = new frm_DangKy();
            this.Hide();
            DangKy.ShowDialog();
            this.Show();
        }

        private void btn_QuenMatKhau_Click(object sender, EventArgs e)
        {
            frm_QuenMatKhau frm_QuenMatKhau = new frm_QuenMatKhau();
            this.Hide();
            frm_QuenMatKhau.ShowDialog();
            this.Show();
            
            

        }
        public void TrangThai()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "UPDATE TRANGTHAI SET TaiKhoan = N'"+txt_TaiKhoan.Text+"' WHERE CheDo = 1 ";
            cmd1.Connection = conn;
            cmd1.ExecuteNonQuery();
            
            
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if(ValidateChildren(ValidationConstraints.Enabled))
            {
                this.txt_TaiKhoan.Focus();
                if (txt_TaiKhoan.Text == "" || txt_MatKhau.Text == "")
                {
                    MessageBox.Show("Tài Khoản hoặc Mật Khẩu rỗng", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    XLDangNhap();
                    TrangThai();
                }
                //Form1 f1 = new Form1(SetValues);
               
            }

           //XLDangNhap();
            
        }

        private void txt_TaiKhoan_TextChanged(object sender, EventArgs e)
        {
            if (txt_TaiKhoan.Text.Length == 0)
            {
                error_TaiKhoan.SetError(txt_TaiKhoan,"Vui lòng nhập tài khoản");
            }else
            {
                error_TaiKhoan.Clear();
            }
        }

        private void txt_TaiKhoan_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrEmpty(txt_TaiKhoan.Text))
            //{
            //    e.Cancel = true;
            //   // txt_TaiKhoan.Focus();
            //    errorProvider1.SetError(txt_TaiKhoan, "Vui lòng nhập tài khoản!");
            //}
            //else
            //{
            //    e.Cancel = false;
            //    errorProvider1.SetError(txt_TaiKhoan, null);
            //}
        }

        private void txt_MatKhau_TextChanged(object sender, EventArgs e)
        {
            
            if (txt_MatKhau.Text.Length == 0)
            {
                error_MatKhau.SetError(txt_MatKhau,"Vui lòng nhập tài khoản");
            }else
            {
                error_MatKhau.Clear();
            }
        }

        private void txt_MatKhau_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrEmpty(txt_MatKhau.Text))
            //{
            //    e.Cancel = true;
            //    //txt_TaiKhoan.Focus();
            //    errorProvider1.SetError(txt_MatKhau, "Vui lòng nhập mật khẩu!");
            //}
            //else
            //{
            //    e.Cancel = false;
            //    errorProvider1.SetError(txt_MatKhau, null);
            //}
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txt_TaiKhoan_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
