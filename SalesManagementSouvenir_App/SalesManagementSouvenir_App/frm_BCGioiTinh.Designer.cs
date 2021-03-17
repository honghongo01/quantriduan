namespace SalesManagementSouvenir_App
{
    partial class frm_BCGioiTinh
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_BCGioiTinh));
            this.C_GioiTinh = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lb_Nam = new System.Windows.Forms.Label();
            this.lb_Nu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.C_GioiTinh)).BeginInit();
            this.SuspendLayout();
            // 
            // C_GioiTinh
            // 
            this.C_GioiTinh.BackColor = System.Drawing.Color.Teal;
            this.C_GioiTinh.BorderlineColor = System.Drawing.Color.DarkGreen;
            chartArea1.Name = "ChartArea1";
            this.C_GioiTinh.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.C_GioiTinh.Legends.Add(legend1);
            this.C_GioiTinh.Location = new System.Drawing.Point(-33, -30);
            this.C_GioiTinh.Name = "C_GioiTinh";
            this.C_GioiTinh.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Cross;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Nam";
            series2.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Cross;
            series2.ChartArea = "ChartArea1";
            series2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Nữ";
            this.C_GioiTinh.Series.Add(series1);
            this.C_GioiTinh.Series.Add(series2);
            this.C_GioiTinh.Size = new System.Drawing.Size(975, 763);
            this.C_GioiTinh.TabIndex = 0;
            this.C_GioiTinh.Text = "Nhân Viên";
            title1.Name = "Giới Tính";
            this.C_GioiTinh.Titles.Add(title1);
            this.C_GioiTinh.Click += new System.EventHandler(this.chart1_Click);
            // 
            // lb_Nam
            // 
            this.lb_Nam.AutoSize = true;
            this.lb_Nam.ForeColor = System.Drawing.Color.Teal;
            this.lb_Nam.Location = new System.Drawing.Point(870, 574);
            this.lb_Nam.Name = "lb_Nam";
            this.lb_Nam.Size = new System.Drawing.Size(35, 13);
            this.lb_Nam.TabIndex = 1;
            this.lb_Nam.Text = "label1";
            // 
            // lb_Nu
            // 
            this.lb_Nu.AutoSize = true;
            this.lb_Nu.ForeColor = System.Drawing.Color.Teal;
            this.lb_Nu.Location = new System.Drawing.Point(337, 680);
            this.lb_Nu.Name = "lb_Nu";
            this.lb_Nu.Size = new System.Drawing.Size(35, 13);
            this.lb_Nu.TabIndex = 2;
            this.lb_Nu.Text = "label2";
            // 
            // frm_BCGioiTinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(935, 702);
            this.Controls.Add(this.lb_Nu);
            this.Controls.Add(this.lb_Nam);
            this.Controls.Add(this.C_GioiTinh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_BCGioiTinh";
            this.Text = "Phần Mềm Quản Lý Bán Hàng Lưu Niệm";
            this.Load += new System.EventHandler(this.frm_BCGioiTinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.C_GioiTinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart C_GioiTinh;
        private System.Windows.Forms.Label lb_Nam;
        private System.Windows.Forms.Label lb_Nu;
    }
}