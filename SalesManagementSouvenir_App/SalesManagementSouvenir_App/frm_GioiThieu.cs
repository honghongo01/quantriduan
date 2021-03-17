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
    public partial class frm_GioiThieu : Form
    {
        public frm_GioiThieu()
        {
            InitializeComponent();
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(2)))), ((int)(((byte)(86)))));
        }

        private void frm_GioiThieu_MouseMove(object sender, MouseEventArgs e)
        {
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel4.BackColor = System.Drawing.Color.White;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(2)))), ((int)(((byte)(86)))));
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel3.BackColor = System.Drawing.Color.White;
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(2)))), ((int)(((byte)(86)))));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel3.BackColor = System.Drawing.Color.White;
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

        private void frm_GioiThieu_Load(object sender, EventArgs e)
        {
            this.label1.BackColor = Color.Transparent;
        }

        private void frm_GioiThieu_KeyDown(object sender, KeyEventArgs e)
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
