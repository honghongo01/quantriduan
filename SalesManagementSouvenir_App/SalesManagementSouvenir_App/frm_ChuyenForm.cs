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
    public partial class frm_Pro : Form
    {
        public frm_Pro()
        {
            InitializeComponent();
           
        }

        private void frm_Pro_Load(object sender, EventArgs e)
        {
        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == 2)
            {
                timer1.Stop();
                pictureBox1.Hide();
                this.Close();
            }
          
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
