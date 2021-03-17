namespace SalesManagementSouvenir_App
{
    partial class frm_BCNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_BCNhanVien));
            this.C_NhanVien = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lb_NhanVien = new System.Windows.Forms.Label();
            this.lb_QuanLy = new System.Windows.Forms.Label();
            this.lb_NhanVien1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.C_NhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // C_NhanVien
            // 
            this.C_NhanVien.BackColor = System.Drawing.Color.Teal;
            chartArea1.Name = "ChartArea1";
            this.C_NhanVien.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.C_NhanVien.Legends.Add(legend1);
            this.C_NhanVien.Location = new System.Drawing.Point(-33, -2);
            this.C_NhanVien.Name = "C_NhanVien";
            this.C_NhanVien.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Cross;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Tổng Số";
            series2.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Cross;
            series2.ChartArea = "ChartArea1";
            series2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Quản Lý";
            series3.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Cross;
            series3.ChartArea = "ChartArea1";
            series3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "Nhân Viên";
            this.C_NhanVien.Series.Add(series1);
            this.C_NhanVien.Series.Add(series2);
            this.C_NhanVien.Series.Add(series3);
            this.C_NhanVien.Size = new System.Drawing.Size(985, 730);
            this.C_NhanVien.TabIndex = 0;
            this.C_NhanVien.Text = "Nhân Viên";
            title1.Name = "Nhân Viên";
            this.C_NhanVien.Titles.Add(title1);
            // 
            // lb_NhanVien
            // 
            this.lb_NhanVien.AutoSize = true;
            this.lb_NhanVien.BackColor = System.Drawing.Color.Teal;
            this.lb_NhanVien.ForeColor = System.Drawing.Color.Teal;
            this.lb_NhanVien.Location = new System.Drawing.Point(296, 679);
            this.lb_NhanVien.Name = "lb_NhanVien";
            this.lb_NhanVien.Size = new System.Drawing.Size(35, 13);
            this.lb_NhanVien.TabIndex = 1;
            this.lb_NhanVien.Text = "label1";
            // 
            // lb_QuanLy
            // 
            this.lb_QuanLy.AutoSize = true;
            this.lb_QuanLy.BackColor = System.Drawing.Color.Teal;
            this.lb_QuanLy.ForeColor = System.Drawing.Color.Teal;
            this.lb_QuanLy.Location = new System.Drawing.Point(389, 679);
            this.lb_QuanLy.Name = "lb_QuanLy";
            this.lb_QuanLy.Size = new System.Drawing.Size(35, 13);
            this.lb_QuanLy.TabIndex = 2;
            this.lb_QuanLy.Text = "label1";
            // 
            // lb_NhanVien1
            // 
            this.lb_NhanVien1.AutoSize = true;
            this.lb_NhanVien1.BackColor = System.Drawing.Color.Teal;
            this.lb_NhanVien1.ForeColor = System.Drawing.Color.Teal;
            this.lb_NhanVien1.Location = new System.Drawing.Point(498, 679);
            this.lb_NhanVien1.Name = "lb_NhanVien1";
            this.lb_NhanVien1.Size = new System.Drawing.Size(35, 13);
            this.lb_NhanVien1.TabIndex = 3;
            this.lb_NhanVien1.Text = "label1";
            // 
            // frm_BCNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(935, 702);
            this.Controls.Add(this.lb_NhanVien1);
            this.Controls.Add(this.lb_QuanLy);
            this.Controls.Add(this.lb_NhanVien);
            this.Controls.Add(this.C_NhanVien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_BCNhanVien";
            this.Text = "Phần Mềm Quản Lý Bán Hàng Lưu Niệm";
            this.Load += new System.EventHandler(this.frm_BCNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.C_NhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart C_NhanVien;
        private System.Windows.Forms.Label lb_NhanVien;
        private System.Windows.Forms.Label lb_QuanLy;
        private System.Windows.Forms.Label lb_NhanVien1;
    }
}