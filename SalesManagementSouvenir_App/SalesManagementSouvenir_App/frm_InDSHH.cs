using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;

namespace SalesManagementSouvenir_App
{
    public partial class frm_InDSHH : Form
    {
        public frm_InDSHH()
        {
            InitializeComponent();
        }

        public void ExportExcell(DataGridView g, String duongDan, String tenTep)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            // obj.Aplication.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for (int i = 1; i < g.Columns.Count + 1; i++)
            {
                obj.Cells[1, i] = g.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < g.Rows.Count; i++)
            {
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(duongDan + tenTep + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }

        public void HangHoa()
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4EU16UDV\SQLEXPRESS;Initial Catalog=QLBHLN;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                string sql = "select MaHang,SoLuong,TenHang,DonGiaNhap,DonGiaBan,NguonGoc,NgayNhapKho,TenChatLieu,ChiPhi from HANG"; // lay het du lieu trong bang sinh vien
                SqlCommand com = new SqlCommand(sql, conn); //bat dau truy van
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
                DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu

                //da.Fill(dt);
                // đổ dữ liệu vào kho

                da.Fill(dt);
                dt.Columns.Add("STT");
                dataGridView1.Columns[0].Width = 25;
                //dt.Columns.Add("Ảnh");
                //dataGridView1.Columns[1].Width = 300;


                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["STT"] = i + 1;

                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns["STT"].DisplayIndex = 0;
                    //dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Cyan;

                    
                }

                conn.Close();  // đóng kết nối
                dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview

            }
            catch
            {
            }
        }
        private void frm_InDS_Load(object sender, EventArgs e)
        {
            HangHoa();
        }

        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == 3)
            {
                timer1.Stop();
                ExportExcell(dataGridView1, @"D:\", "ExcelDanhSachHangHoa");
                MessageBox.Show("In danh sách hàng hóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
              //  frm_CaNhan a = new frm_CaNhan();
               // a.Show();
            }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
