namespace SalesManagementSouvenir_App
{
    partial class frm_BieuDoNhapXuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_BieuDoNhapXuat));
            this.C_DaBan = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.C_DaBan)).BeginInit();
            this.SuspendLayout();
            // 
            // C_DaBan
            // 
            this.C_DaBan.BackColor = System.Drawing.Color.Teal;
            this.C_DaBan.BackImageTransparentColor = System.Drawing.SystemColors.Window;
            this.C_DaBan.BackSecondaryColor = System.Drawing.Color.Black;
            this.C_DaBan.BorderlineColor = System.Drawing.SystemColors.Window;
            chartArea1.Name = "ChartArea1";
            this.C_DaBan.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.C_DaBan.Legends.Add(legend1);
            this.C_DaBan.Location = new System.Drawing.Point(-46, -50);
            this.C_DaBan.Name = "C_DaBan";
            this.C_DaBan.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            series1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Cross;
            series1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.DarkGoldenrod;
            series1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.LabelBackColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Số Lượng Nhập";
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            series2.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Cross;
            series2.BorderColor = System.Drawing.Color.White;
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.Magenta;
            series2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Số Lượng Bán";
            this.C_DaBan.Series.Add(series1);
            this.C_DaBan.Series.Add(series2);
            this.C_DaBan.Size = new System.Drawing.Size(1002, 787);
            this.C_DaBan.TabIndex = 0;
            this.C_DaBan.Text = "chart1";
            title1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.DarkCyan;
            title1.Name = "Title1";
            title1.Text = "Sản Phẩm";
            this.C_DaBan.Titles.Add(title1);
            this.C_DaBan.Click += new System.EventHandler(this.C_DaBan_Click);
            // 
            // frm_BieuDoNhapXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(935, 702);
            this.Controls.Add(this.C_DaBan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_BieuDoNhapXuat";
            this.Text = "Phần Mềm Quản Lý Bán Hàng Lưu Niệm";
            this.Load += new System.EventHandler(this.frm_BieuDoNhapXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.C_DaBan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart C_DaBan;
    }
}