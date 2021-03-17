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
    public partial class frm_MenuSystem : Form
    {
        public frm_MenuSystem()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            this.panel1.BackColor = System.Drawing.Color.Blue;
        }

        private void frmMenuSystem_Load(object sender, EventArgs e)
        {
            
        }

        private void frmMenuSystem_MouseMove(object sender, MouseEventArgs e)
        {
            this.panel1.BackColor = System.Drawing.Color.White;
        }
    }
}
