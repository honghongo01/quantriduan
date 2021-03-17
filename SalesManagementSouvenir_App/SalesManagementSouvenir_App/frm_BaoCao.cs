using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SalesManagementSouvenir_App
{
    public partial class frm_BaoCao : Form
    {
        public frm_BaoCao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                this.Hide();
                frm_Menu d = new frm_Menu();
                d.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_QuanLyKho_Click(object sender, EventArgs e)
        {
            this.groupBox1.Show();
            this.groupBox2.Hide();
        }

        private void btn_XemDangDanhSach_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            frm_QuanLyKho a = new frm_QuanLyKho();
            a.TopLevel = false;
            panel3.Controls.Add(a);
            a.Show();
        }

        private void frm_BaoCao_Load(object sender, EventArgs e)
        {
            this.groupBox1.Hide();
            this.groupBox2.Hide();
        }

        private void btn_XemDangBieuDo_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            frm_BieuDoNhapXuat a = new frm_BieuDoNhapXuat();
            a.TopLevel = false;
            panel3.Controls.Add(a);
            a.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.groupBox1.Hide();
            this.groupBox2.Hide();
            panel3.Controls.Clear();
            frm_DoanhThu a = new frm_DoanhThu();
            a.TopLevel = false;
            panel3.Controls.Add(a);
            a.Show();
        }

        private void btn_XemChiTiet_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.groupBox2.Show();
            this.groupBox1.Hide();
            //this.groupBox2.Hide();
            panel3.Controls.Clear();
         
        }

        private void btn_XemCV_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            frm_BCNhanVien a = new frm_BCNhanVien();
            a.TopLevel = false;
            panel3.Controls.Add(a);
            a.Show();
        }

        private void btn_GioiTinh_Click(object sender, EventArgs e)
        {

            panel3.Controls.Clear();
            frm_BCGioiTinh a = new frm_BCGioiTinh();
            a.TopLevel = false;
            panel3.Controls.Add(a);
            a.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox2.Hide();
            panel3.Controls.Clear();
            frm_BCHoaDon a = new frm_BCHoaDon();
            a.TopLevel = false;
            panel3.Controls.Add(a);
            a.Show();
        }

        private void frm_BaoCao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.P)
            {
                this.Hide();
                frm_CaNhan CaNhan = new frm_CaNhan();
                CaNhan.Show();
            }
            if (e.Control == true && e.KeyCode == Keys.E)
            {
                this.Hide();
                frm_NhanVien01 NhanVien = new frm_NhanVien01();
                NhanVien.Show();
            }
            if (e.Control == true && e.KeyCode == Keys.R)
            {
                this.Hide();
                frm_BaoCao BaoCao = new frm_BaoCao();
                BaoCao.Show();
            }
            if (e.Control == true && e.KeyCode == Keys.G)
            {
                this.Hide();
                frm_HangHoa HangHoa = new frm_HangHoa();
                HangHoa.Show();
            }
            if (e.Control == true && e.KeyCode == Keys.B)
            {
                this.Hide();
                frm_HoaDon HoaDon = new frm_HoaDon();
                HoaDon.Show();
            }
            if (e.Control == true && e.KeyCode == Keys.C)
            {
                this.Hide();
                frm_KhachHang KhachHang = new frm_KhachHang();
                KhachHang.Show();

            }
        }
    }
}
