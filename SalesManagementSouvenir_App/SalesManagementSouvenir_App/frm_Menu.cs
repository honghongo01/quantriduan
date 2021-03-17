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
    public partial class frm_Menu : Form
    {
        public SendMessage send;
        public frm_Menu()
        {
            InitializeComponent();
        }
        public frm_Menu(SendMessage sender)
        {
            InitializeComponent();
            this.send = sender;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.panel18.Show();
            this.panel19.BackColor = System.Drawing.Color.White;
            this.panel23.BackColor = System.Drawing.Color.White;
            this.panel21.BackColor = System.Drawing.Color.White;
            this.panel20.BackColor = System.Drawing.Color.White;
            this.panel22.BackColor = System.Drawing.Color.White;

        }
        
        private void pb_MenuNen01_Click(object sender, EventArgs e)
        {

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.panel12.Hide();
            this.panel13.Hide();
            this.panel14.Hide();
            this.panel15.Hide();
            this.panel16.Hide();
            this.panel17.Hide();
            this.panel18.Hide();
            this.panel23.BackColor = System.Drawing.Color.White;
            this.panel22.BackColor = System.Drawing.Color.White;
            this.panel21.BackColor = System.Drawing.Color.White;
            this.panel19.BackColor = System.Drawing.Color.White;
           // LayTaiKhoan();

           
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.panel12.Show();
            this.panel13.Show();
            this.panel14.Show();
            this.panel15.Show();
            this.panel16.Show();
            this.panel17.Show();
        }

        private void panel23_MouseMove(object sender, MouseEventArgs e)
        {
            this.panel12.Hide();
            this.panel13.Hide();
            this.panel14.Hide();
            this.panel15.Hide();
            this.panel16.Hide();
            this.panel17.Hide();
           // this.panel18.Hide();
            this.panel23.BackColor = System.Drawing.Color.Blue;
            this.panel22.BackColor = System.Drawing.Color.White;
            this.panel21.BackColor = System.Drawing.Color.White;
            this.panel19.BackColor = System.Drawing.Color.White;
            this.panel20.BackColor = System.Drawing.Color.White;
        }

        private void panel22_MouseMove(object sender, MouseEventArgs e)
        {
            this.panel12.Show();
            this.panel13.Show();
            this.panel14.Show();
            this.panel15.Show();
            this.panel16.Show();
            this.panel17.Show();
            this.panel22.BackColor = System.Drawing.Color.Blue;
            this.panel23.BackColor = System.Drawing.Color.White;
            this.panel21.BackColor = System.Drawing.Color.White;
            this.panel19.BackColor = System.Drawing.Color.White;
            this.panel20.BackColor = System.Drawing.Color.White;
        }

        private void panel21_MouseMove(object sender, MouseEventArgs e)
        {
            this.panel12.Hide();
            this.panel13.Hide();
            this.panel14.Hide();
            this.panel15.Hide();
            this.panel16.Hide();
            this.panel17.Hide();
           // this.panel18.Hide();
            this.panel21.BackColor = System.Drawing.Color.Blue;
            this.panel23.BackColor = System.Drawing.Color.White;
            this.panel22.BackColor = System.Drawing.Color.White;
            this.panel19.BackColor = System.Drawing.Color.White;
            this.panel20.BackColor = System.Drawing.Color.White;


        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.panel18.Hide();
            this.panel12.Hide();
            this.panel13.Hide();
            this.panel14.Hide();
            this.panel15.Hide();
            this.panel16.Hide();
            this.panel17.Hide();
            this.pn_ThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
        }

        private void pb_MenuNen01_MouseMove(object sender, MouseEventArgs e)
        {
            this.panel18.Hide();
            this.panel12.Hide();
            this.panel13.Hide();
            this.panel14.Hide();
            this.panel15.Hide();
            this.panel16.Hide();
            this.panel17.Hide();
            this.pn_ThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
        }

        private void panel19_MouseMove(object sender, MouseEventArgs e)
        {
            this.panel19.BackColor = System.Drawing.Color.Blue;
            this.panel23.BackColor = System.Drawing.Color.White;
            this.panel21.BackColor = System.Drawing.Color.White;
            this.panel20.BackColor = System.Drawing.Color.White;
        }

        private void panel20_MouseMove(object sender, MouseEventArgs e)
        {
            this.panel20.BackColor = System.Drawing.Color.Blue;
            this.panel19.BackColor = System.Drawing.Color.White;
            this.panel23.BackColor = System.Drawing.Color.White;
            this.panel21.BackColor = System.Drawing.Color.White;
        }

        private void panel17_MouseMove(object sender, MouseEventArgs e)
        {
            this.panel17.BackColor = System.Drawing.Color.Blue;
            this.panel16.BackColor = System.Drawing.Color.White;
            this.panel15.BackColor = System.Drawing.Color.White;
            this.panel14.BackColor = System.Drawing.Color.White;
            this.panel13.BackColor = System.Drawing.Color.White;
            this.panel12.BackColor = System.Drawing.Color.White;
        }

        private void panel16_MouseMove(object sender, MouseEventArgs e)
        {
            this.panel17.BackColor = System.Drawing.Color.White;
            this.panel16.BackColor = System.Drawing.Color.Blue;
            this.panel15.BackColor = System.Drawing.Color.White;
            this.panel14.BackColor = System.Drawing.Color.White;
            this.panel13.BackColor = System.Drawing.Color.White;
            this.panel12.BackColor = System.Drawing.Color.White;
        }

        private void panel15_MouseMove(object sender, MouseEventArgs e)
        {
            this.panel17.BackColor = System.Drawing.Color.White;
            this.panel16.BackColor = System.Drawing.Color.White;
            this.panel15.BackColor = System.Drawing.Color.Blue;
            this.panel14.BackColor = System.Drawing.Color.White;
            this.panel13.BackColor = System.Drawing.Color.White;
            this.panel12.BackColor = System.Drawing.Color.White;
        }

        private void panel14_MouseMove(object sender, MouseEventArgs e)
        {
            this.panel17.BackColor = System.Drawing.Color.White;
            this.panel16.BackColor = System.Drawing.Color.White;
            this.panel15.BackColor = System.Drawing.Color.White;
            this.panel14.BackColor = System.Drawing.Color.Blue;
            this.panel13.BackColor = System.Drawing.Color.White;
            this.panel12.BackColor = System.Drawing.Color.White;
        }

        private void panel13_MouseMove(object sender, MouseEventArgs e)
        {
            this.panel17.BackColor = System.Drawing.Color.White;
            this.panel16.BackColor = System.Drawing.Color.White;
            this.panel15.BackColor = System.Drawing.Color.White;
            this.panel14.BackColor = System.Drawing.Color.White;
            this.panel13.BackColor = System.Drawing.Color.Blue;
            this.panel12.BackColor = System.Drawing.Color.White;
        }

        private void panel12_MouseMove(object sender, MouseEventArgs e)
        {
            this.panel17.BackColor = System.Drawing.Color.White;
            this.panel16.BackColor = System.Drawing.Color.White;
            this.panel15.BackColor = System.Drawing.Color.White;
            this.panel14.BackColor = System.Drawing.Color.White;
            this.panel13.BackColor = System.Drawing.Color.White;
            this.panel12.BackColor = System.Drawing.Color.Blue;
        }

        private void panel17_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
        }

        private void label12_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.G)
            {
                
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            //frm_KhachHang a = new frm_KhachHang();
            frm_NhanVien01 a = new frm_NhanVien01();
            a.Show();
        }

        private void label8_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.E)
            {

            }
        }

        private void label10_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.R)
            {

            }
        }

        private void label11_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.B)
            {

            }
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
        
        }

        private void panel5_MouseMove(object sender, MouseEventArgs e)
        {
            this.pn_ThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(2)))), ((int)(((byte)(86)))));
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
        }

        private void panel7_MouseMove(object sender, MouseEventArgs e)
        {
            this.pn_ThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(2)))), ((int)(((byte)(86)))));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            this.pn_ThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(2)))), ((int)(((byte)(86)))));
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
           
        }

        private void panel20_Paint(object sender, PaintEventArgs e)
        {
            //
        }

        private void label17_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_DangNhap DangNhap = new frm_DangNhap();
            DangNhap.Show();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel11_MouseMove(object sender, MouseEventArgs e)
        {
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(2)))), ((int)(((byte)(86)))));
            this.pn_ThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
        }

        private void panel8_MouseMove(object sender, MouseEventArgs e)
        {
            this.panel24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(2)))), ((int)(((byte)(86)))));
            this.pn_ThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(2)))), ((int)(((byte)(86)))));
            this.pn_ThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel5_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            frm_CaNhan CaNhan = new frm_CaNhan();
            CaNhan.Show();
            this.Hide();
        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
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

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_CaNhan CaNhan = new frm_CaNhan();
           
            CaNhan.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_NhanVien01 NhanVien = new frm_NhanVien01();
            NhanVien.Show();
           // this.Hide();
        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_KhachHang KhachHang = new frm_KhachHang();
            KhachHang.Show();
           // this.Hide();
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_BaoCao BaoCao = new frm_BaoCao();
            BaoCao.Show();
            //this.Hide();
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_HoaDon HoaDon = new frm_HoaDon();
            HoaDon.Show();
           // this.Hide();
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_HangHoa HangHoa = new frm_HangHoa();
            HangHoa.Show();
           // this.Hide();
        }

        private void panel22_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel21_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel21_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_GioiThieu GioiThieu = new frm_GioiThieu();
           GioiThieu.Show();
           // this.Hide();
            
        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_HangHoa a = new frm_HangHoa();
            a.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_KhachHang a = new frm_KhachHang();
            a.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_BaoCao a = new frm_BaoCao();
            a.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_HoaDon a = new frm_HoaDon();
            a.Show();
        }
    }
}
