using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;

namespace SalesManagementSouvenir_App
{
    public partial class frm_QuenMatKhau : Form
    {

        public void LayMatKhau()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1LAVJVQ\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT MatKhau FROM NHANVIEN WHERE TaiKhoan =N'" + txt_TaiKhoan.Text + "'";
            cmd1.Connection = conn;
            SqlDataReader reader = cmd1.ExecuteReader();

            if (reader.Read())
            {

                txt_MatKhau.Text = reader.GetString(0).ToString();
                frm_Pro Pro = new frm_Pro();
                Pro.ShowDialog();
                MessageBox.Show("Lấy mật khẩu thành công ! Xin kiểm tra email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SmtpClient mailclient = new SmtpClient("smtp.gmail.com", 587);
                mailclient.EnableSsl = true;
                mailclient.Credentials = new NetworkCredential("doancosonganh01@gmail.com", "@Kenchuong98");

                MailMessage message = new MailMessage("doancosonganh01@gmail.com", txt_Email.Text);
                message.Subject = "Sales Management Souvenir - App";
                message.Body = "                                             LẤY LẠI MẬT KHẨU \n" +
            "                Tài Khoản            : " + txt_TaiKhoan.Text + "\n" +
            "                Mật Khẩu             :" + txt_MatKhau.Text;
                mailclient.Send(message);
            }
            else
            {
                frm_Pro Prot = new frm_Pro();
                Prot.ShowDialog();
                MessageBox.Show("Lấy mật khẩu thất bại ! Xin kiểm tra thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
        }


        public frm_QuenMatKhau()
        {
            InitializeComponent();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Laylaimatkhau_Click(object sender, EventArgs e)
        {
            txt_MatKhau.Hide();
            LayMatKhau();
        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {

        }
        }
    }

