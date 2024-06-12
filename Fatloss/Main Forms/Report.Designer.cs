namespace Fatloss
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 20D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 50D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint12 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            this.tableLayoutPanelReport = new System.Windows.Forms.TableLayoutPanel();
            this.downToolStripSettings = new System.Windows.Forms.ToolStrip();
            this.toolStripMenu = new System.Windows.Forms.ToolStripButton();
            this.toolStripFood = new System.Windows.Forms.ToolStripButton();
            this.toolStripReport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSettings = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanelChart = new System.Windows.Forms.TableLayoutPanel();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonWeight = new System.Windows.Forms.Button();
            this.tableLayoutPanelButtons = new System.Windows.Forms.TableLayoutPanel();
            this.buttonMonth = new System.Windows.Forms.Button();
            this.buttonWeek = new System.Windows.Forms.Button();
            this.buttonDay = new System.Windows.Forms.Button();
            this.buttonYear = new System.Windows.Forms.Button();
            this.buttonAllTime = new System.Windows.Forms.Button();
            this.buttonKcal = new System.Windows.Forms.Button();
            this.buttonMeal = new System.Windows.Forms.Button();
            this.tableLayoutPanelReport.SuspendLayout();
            this.downToolStripSettings.SuspendLayout();
            this.tableLayoutPanelChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.tableLayoutPanelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelReport
            // 
            this.tableLayoutPanelReport.ColumnCount = 1;
            this.tableLayoutPanelReport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelReport.Controls.Add(this.downToolStripSettings, 0, 1);
            this.tableLayoutPanelReport.Controls.Add(this.tableLayoutPanelChart, 0, 0);
            this.tableLayoutPanelReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelReport.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelReport.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelReport.Name = "tableLayoutPanelReport";
            this.tableLayoutPanelReport.RowCount = 2;
            this.tableLayoutPanelReport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanelReport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelReport.Size = new System.Drawing.Size(802, 453);
            this.tableLayoutPanelReport.TabIndex = 2;
            // 
            // downToolStripSettings
            // 
            this.downToolStripSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.downToolStripSettings.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.downToolStripSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenu,
            this.toolStripFood,
            this.toolStripReport,
            this.toolStripSettings});
            this.downToolStripSettings.Location = new System.Drawing.Point(0, 407);
            this.downToolStripSettings.Name = "downToolStripSettings";
            this.downToolStripSettings.Size = new System.Drawing.Size(802, 46);
            this.downToolStripSettings.TabIndex = 1;
            this.downToolStripSettings.Text = "toolStrip1";
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenu.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenu.Image")));
            this.toolStripMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(94, 43);
            this.toolStripMenu.Text = "Главная";
            this.toolStripMenu.Click += new System.EventHandler(this.toolStripMenu_Click);
            // 
            // toolStripFood
            // 
            this.toolStripFood.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripFood.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.toolStripFood.Image = ((System.Drawing.Image)(resources.GetObject("toolStripFood.Image")));
            this.toolStripFood.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripFood.Name = "toolStripFood";
            this.toolStripFood.Size = new System.Drawing.Size(50, 43);
            this.toolStripFood.Text = "Еда";
            this.toolStripFood.Click += new System.EventHandler(this.toolStripFood_Click);
            // 
            // toolStripReport
            // 
            this.toolStripReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripReport.Enabled = false;
            this.toolStripReport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.toolStripReport.Image = ((System.Drawing.Image)(resources.GetObject("toolStripReport.Image")));
            this.toolStripReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripReport.Name = "toolStripReport";
            this.toolStripReport.Size = new System.Drawing.Size(72, 43);
            this.toolStripReport.Text = "Отчёт";
            // 
            // toolStripSettings
            // 
            this.toolStripSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSettings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.toolStripSettings.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSettings.Image")));
            this.toolStripSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSettings.Name = "toolStripSettings";
            this.toolStripSettings.Size = new System.Drawing.Size(122, 43);
            this.toolStripSettings.Text = "Настройки";
            this.toolStripSettings.Click += new System.EventHandler(this.toolStripSettings_Click);
            // 
            // tableLayoutPanelChart
            // 
            this.tableLayoutPanelChart.ColumnCount = 3;
            this.tableLayoutPanelChart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelChart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelChart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelChart.Controls.Add(this.chart, 0, 1);
            this.tableLayoutPanelChart.Controls.Add(this.buttonWeight, 0, 0);
            this.tableLayoutPanelChart.Controls.Add(this.tableLayoutPanelButtons, 0, 2);
            this.tableLayoutPanelChart.Controls.Add(this.buttonKcal, 2, 0);
            this.tableLayoutPanelChart.Controls.Add(this.buttonMeal, 1, 0);
            this.tableLayoutPanelChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelChart.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelChart.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelChart.Name = "tableLayoutPanelChart";
            this.tableLayoutPanelChart.RowCount = 3;
            this.tableLayoutPanelChart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelChart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanelChart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelChart.Size = new System.Drawing.Size(802, 407);
            this.tableLayoutPanelChart.TabIndex = 2;
            this.tableLayoutPanelChart.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanelChart_Paint);
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.Color.Transparent;
            chartArea3.AxisX.IsLabelAutoFit = false;
            chartArea3.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea3);
            this.tableLayoutPanelChart.SetColumnSpan(this.chart, 3);
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Location = new System.Drawing.Point(3, 43);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series3.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.TileFlipX;
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.Blue;
            series3.CustomProperties = "LabelStyle=Top";
            series3.EmptyPointStyle.BorderWidth = 3;
            series3.EmptyPointStyle.Color = System.Drawing.Color.Blue;
            series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.IsValueShownAsLabel = true;
            series3.IsVisibleInLegend = false;
            series3.LabelBorderWidth = 2;
            series3.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series3.MarkerSize = 7;
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series3.Name = "Series1";
            dataPoint10.BorderWidth = 3;
            dataPoint10.Color = System.Drawing.Color.Blue;
            dataPoint10.IsEmpty = true;
            dataPoint10.IsValueShownAsLabel = false;
            dataPoint11.BorderColor = System.Drawing.Color.Black;
            series3.Points.Add(dataPoint9);
            series3.Points.Add(dataPoint10);
            series3.Points.Add(dataPoint11);
            series3.Points.Add(dataPoint12);
            series3.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.Beige;
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.chart.Series.Add(series3);
            this.chart.Size = new System.Drawing.Size(796, 319);
            this.chart.TabIndex = 0;
            this.chart.Text = " ";
            // 
            // buttonWeight
            // 
            this.buttonWeight.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonWeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonWeight.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonWeight.Location = new System.Drawing.Point(0, 0);
            this.buttonWeight.Margin = new System.Windows.Forms.Padding(0);
            this.buttonWeight.Name = "buttonWeight";
            this.buttonWeight.Size = new System.Drawing.Size(267, 40);
            this.buttonWeight.TabIndex = 1;
            this.buttonWeight.Text = "Вес";
            this.buttonWeight.UseVisualStyleBackColor = false;
            this.buttonWeight.Click += new System.EventHandler(this.buttonWeight_Click);
            // 
            // tableLayoutPanelButtons
            // 
            this.tableLayoutPanelButtons.ColumnCount = 5;
            this.tableLayoutPanelChart.SetColumnSpan(this.tableLayoutPanelButtons, 3);
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelButtons.Controls.Add(this.buttonMonth, 0, 0);
            this.tableLayoutPanelButtons.Controls.Add(this.buttonWeek, 0, 0);
            this.tableLayoutPanelButtons.Controls.Add(this.buttonDay, 0, 0);
            this.tableLayoutPanelButtons.Controls.Add(this.buttonYear, 3, 0);
            this.tableLayoutPanelButtons.Controls.Add(this.buttonAllTime, 4, 0);
            this.tableLayoutPanelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelButtons.Location = new System.Drawing.Point(0, 365);
            this.tableLayoutPanelButtons.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            this.tableLayoutPanelButtons.RowCount = 1;
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelButtons.Size = new System.Drawing.Size(802, 42);
            this.tableLayoutPanelButtons.TabIndex = 4;
            // 
            // buttonMonth
            // 
            this.buttonMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMonth.Location = new System.Drawing.Point(320, 0);
            this.buttonMonth.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMonth.Name = "buttonMonth";
            this.buttonMonth.Size = new System.Drawing.Size(160, 42);
            this.buttonMonth.TabIndex = 4;
            this.buttonMonth.Text = "Месяц";
            this.buttonMonth.UseVisualStyleBackColor = true;
            this.buttonMonth.Click += new System.EventHandler(this.buttonMonth_Click);
            // 
            // buttonWeek
            // 
            this.buttonWeek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonWeek.Location = new System.Drawing.Point(160, 0);
            this.buttonWeek.Margin = new System.Windows.Forms.Padding(0);
            this.buttonWeek.Name = "buttonWeek";
            this.buttonWeek.Size = new System.Drawing.Size(160, 42);
            this.buttonWeek.TabIndex = 3;
            this.buttonWeek.Text = "Неделя";
            this.buttonWeek.UseVisualStyleBackColor = true;
            this.buttonWeek.Click += new System.EventHandler(this.buttonWeek_Click);
            // 
            // buttonDay
            // 
            this.buttonDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDay.Location = new System.Drawing.Point(0, 0);
            this.buttonDay.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDay.Name = "buttonDay";
            this.buttonDay.Size = new System.Drawing.Size(160, 42);
            this.buttonDay.TabIndex = 2;
            this.buttonDay.Text = "День";
            this.buttonDay.UseVisualStyleBackColor = true;
            this.buttonDay.Click += new System.EventHandler(this.buttonDay_Click);
            // 
            // buttonYear
            // 
            this.buttonYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonYear.Location = new System.Drawing.Point(480, 0);
            this.buttonYear.Margin = new System.Windows.Forms.Padding(0);
            this.buttonYear.Name = "buttonYear";
            this.buttonYear.Size = new System.Drawing.Size(160, 42);
            this.buttonYear.TabIndex = 5;
            this.buttonYear.Text = "Год";
            this.buttonYear.UseVisualStyleBackColor = true;
            this.buttonYear.Click += new System.EventHandler(this.buttonYear_Click);
            // 
            // buttonAllTime
            // 
            this.buttonAllTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAllTime.Location = new System.Drawing.Point(640, 0);
            this.buttonAllTime.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAllTime.Name = "buttonAllTime";
            this.buttonAllTime.Size = new System.Drawing.Size(162, 42);
            this.buttonAllTime.TabIndex = 6;
            this.buttonAllTime.Text = "За всё время";
            this.buttonAllTime.UseVisualStyleBackColor = true;
            this.buttonAllTime.Click += new System.EventHandler(this.buttonAllTime_Click);
            // 
            // buttonKcal
            // 
            this.buttonKcal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonKcal.Location = new System.Drawing.Point(534, 0);
            this.buttonKcal.Margin = new System.Windows.Forms.Padding(0);
            this.buttonKcal.Name = "buttonKcal";
            this.buttonKcal.Size = new System.Drawing.Size(268, 40);
            this.buttonKcal.TabIndex = 2;
            this.buttonKcal.Text = "Калории";
            this.buttonKcal.UseVisualStyleBackColor = true;
            this.buttonKcal.Click += new System.EventHandler(this.buttonKcal_Click);
            // 
            // buttonMeal
            // 
            this.buttonMeal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMeal.Location = new System.Drawing.Point(267, 0);
            this.buttonMeal.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMeal.Name = "buttonMeal";
            this.buttonMeal.Size = new System.Drawing.Size(267, 40);
            this.buttonMeal.TabIndex = 5;
            this.buttonMeal.Text = "Приём пищи";
            this.buttonMeal.UseVisualStyleBackColor = true;
            this.buttonMeal.Click += new System.EventHandler(this.buttonMeal_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 453);
            this.Controls.Add(this.tableLayoutPanelReport);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(820, 500);
            this.Name = "Report";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Отчёт";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Report_FormClosing);
            this.Load += new System.EventHandler(this.Report_Load);
            this.tableLayoutPanelReport.ResumeLayout(false);
            this.tableLayoutPanelReport.PerformLayout();
            this.downToolStripSettings.ResumeLayout(false);
            this.downToolStripSettings.PerformLayout();
            this.tableLayoutPanelChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.tableLayoutPanelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelReport;
        private System.Windows.Forms.ToolStrip downToolStripSettings;
        private System.Windows.Forms.ToolStripButton toolStripMenu;
        private System.Windows.Forms.ToolStripButton toolStripFood;
        private System.Windows.Forms.ToolStripButton toolStripReport;
        private System.Windows.Forms.ToolStripButton toolStripSettings;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelChart;
        private System.Windows.Forms.Button buttonKcal;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button buttonWeight;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelButtons;
        private System.Windows.Forms.Button buttonMonth;
        private System.Windows.Forms.Button buttonWeek;
        private System.Windows.Forms.Button buttonDay;
        private System.Windows.Forms.Button buttonYear;
        private System.Windows.Forms.Button buttonAllTime;
        private System.Windows.Forms.Button buttonMeal;
    }
}