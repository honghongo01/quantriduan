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
    public partial class frm_Banner : Form
    {
        public frm_Banner()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                Application.Exit();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
           // this.button1.ForeColor = System.Drawing.Color.LightSteelBlue;
            //this.button2.ForeColor = System.Drawing.Color.LightSteelBlue;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
           // 
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            //this.button1.ForeColor = System.Drawing.Color.Yellow;
        }
        
        private void Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void Menu_MouseMove(object sender, MouseEventArgs e)
        {
            this.button2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.button1.ForeColor = System.Drawing.Color.LightSteelBlue;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            this.button1.ForeColor = System.Drawing.Color.White;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            this.button2.ForeColor = System.Drawing.Color.White;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            this.button2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.button1.ForeColor = System.Drawing.Color.LightSteelBlue;
        }
        int x = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            x++;
            if (x == 3)
            {
                timer1.Stop();
                this.Close();
                frm_Menu frm_LuaChon = new frm_Menu();
                frm_LuaChon.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
