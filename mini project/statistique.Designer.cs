namespace mini_project
{
    partial class statistique
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(statistique));
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bunifuThinButton25 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.chart2);
            this.panel1.Location = new System.Drawing.Point(459, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 235);
            this.panel1.TabIndex = 200;
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(3, 3);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Purple;
            series1.Legend = "Legend1";
            series1.Name = "absence/mois/pile";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(415, 229);
            this.chart2.TabIndex = 170;
            this.chart2.Text = "chart2";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Red;
            this.flowLayoutPanel1.Controls.Add(this.Chart1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 68);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(408, 238);
            this.flowLayoutPanel1.TabIndex = 198;
            // 
            // Chart1
            // 
            this.Chart1.BackColor = System.Drawing.SystemColors.Control;
            this.Chart1.BorderlineColor = System.Drawing.SystemColors.Control;
            chartArea2.BackSecondaryColor = System.Drawing.SystemColors.Control;
            chartArea2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.Name = "ChartArea1";
            chartArea2.ShadowColor = System.Drawing.SystemColors.Control;
            this.Chart1.ChartAreas.Add(chartArea2);
            this.Chart1.IsSoftShadows = false;
            legend2.BackColor = System.Drawing.SystemColors.Control;
            legend2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            legend2.BackImageTransparentColor = System.Drawing.SystemColors.Control;
            legend2.BackSecondaryColor = System.Drawing.SystemColors.Control;
            legend2.BorderColor = System.Drawing.SystemColors.Control;
            legend2.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend2.Name = "Legend1";
            legend2.ShadowColor = System.Drawing.SystemColors.Control;
            this.Chart1.Legends.Add(legend2);
            this.Chart1.Location = new System.Drawing.Point(3, 3);
            this.Chart1.Name = "Chart1";
            this.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series2.BackImage = "Control";
            series2.BackSecondaryColor = System.Drawing.SystemColors.Control;
            series2.BorderColor = System.Drawing.SystemColors.Control;
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Red;
            series2.LabelBackColor = System.Drawing.SystemColors.Control;
            series2.LabelBorderColor = System.Drawing.SystemColors.Control;
            series2.Legend = "Legend1";
            series2.MarkerColor = System.Drawing.SystemColors.Control;
            series2.MarkerImageTransparentColor = System.Drawing.SystemColors.Control;
            series2.Name = "absence/mois/line";
            this.Chart1.Series.Add(series2);
            this.Chart1.Size = new System.Drawing.Size(401, 232);
            this.Chart1.TabIndex = 103;
            this.Chart1.Text = "Chart1";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(2, 3);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(198, 44);
            this.bunifuCustomLabel2.TabIndex = 197;
            this.bunifuCustomLabel2.Text = "Statistique";
            // 
            // chart3
            // 
            this.chart3.BackColor = System.Drawing.SystemColors.Control;
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart3.Legends.Add(legend3);
            this.chart3.Location = new System.Drawing.Point(3, 3);
            this.chart3.Name = "chart3";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.Color = System.Drawing.Color.Purple;
            series3.Legend = "Legend1";
            series3.Name = "produit";
            this.chart3.Series.Add(series3);
            this.chart3.Size = new System.Drawing.Size(628, 231);
            this.chart3.TabIndex = 199;
            this.chart3.Text = "chart3";
            // 
            // bunifuThinButton25
            // 
            this.bunifuThinButton25.ActiveBorderThickness = 1;
            this.bunifuThinButton25.ActiveCornerRadius = 20;
            this.bunifuThinButton25.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(52)))), ((int)(((byte)(43)))));
            this.bunifuThinButton25.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton25.ActiveLineColor = System.Drawing.Color.SaddleBrown;
            this.bunifuThinButton25.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton25.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton25.BackgroundImage")));
            this.bunifuThinButton25.ButtonText = "Enregistré";
            this.bunifuThinButton25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton25.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton25.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton25.IdleBorderThickness = 1;
            this.bunifuThinButton25.IdleCornerRadius = 20;
            this.bunifuThinButton25.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton25.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(52)))), ((int)(((byte)(43)))));
            this.bunifuThinButton25.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(52)))), ((int)(((byte)(43)))));
            this.bunifuThinButton25.Location = new System.Drawing.Point(442, 5);
            this.bunifuThinButton25.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton25.Name = "bunifuThinButton25";
            this.bunifuThinButton25.Size = new System.Drawing.Size(111, 42);
            this.bunifuThinButton25.TabIndex = 203;
            this.bunifuThinButton25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.flowLayoutPanel2.Controls.Add(this.chart3);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(141, 324);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(634, 238);
            this.flowLayoutPanel2.TabIndex = 204;
            // 
            // statistique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.bunifuThinButton25);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Name = "statistique";
            this.Size = new System.Drawing.Size(959, 585);
            this.Load += new System.EventHandler(this.statistique_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton25;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        internal System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}
