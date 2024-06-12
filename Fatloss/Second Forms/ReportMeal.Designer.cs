namespace Fatloss.Second_Forms
{
    partial class ReportMeal
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
            this.tableLayoutPanelReportMeal = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewProductAndDish = new System.Windows.Forms.DataGridView();
            this.labelProductAndDish = new System.Windows.Forms.Label();
            this.dataGridViewMeals = new System.Windows.Forms.DataGridView();
            this.labelMeal = new System.Windows.Forms.Label();
            this.tableLayoutPanelReportMeal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductAndDish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeals)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelReportMeal
            // 
            this.tableLayoutPanelReportMeal.ColumnCount = 2;
            this.tableLayoutPanelReportMeal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelReportMeal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelReportMeal.Controls.Add(this.dataGridViewProductAndDish, 0, 3);
            this.tableLayoutPanelReportMeal.Controls.Add(this.labelProductAndDish, 0, 2);
            this.tableLayoutPanelReportMeal.Controls.Add(this.dataGridViewMeals, 0, 1);
            this.tableLayoutPanelReportMeal.Controls.Add(this.labelMeal, 0, 0);
            this.tableLayoutPanelReportMeal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelReportMeal.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelReportMeal.Name = "tableLayoutPanelReportMeal";
            this.tableLayoutPanelReportMeal.RowCount = 4;
            this.tableLayoutPanelReportMeal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelReportMeal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanelReportMeal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelReportMeal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanelReportMeal.Size = new System.Drawing.Size(682, 453);
            this.tableLayoutPanelReportMeal.TabIndex = 0;
            // 
            // dataGridViewProductAndDish
            // 
            this.dataGridViewProductAndDish.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanelReportMeal.SetColumnSpan(this.dataGridViewProductAndDish, 2);
            this.dataGridViewProductAndDish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProductAndDish.Location = new System.Drawing.Point(3, 274);
            this.dataGridViewProductAndDish.Name = "dataGridViewProductAndDish";
            this.dataGridViewProductAndDish.RowHeadersWidth = 51;
            this.dataGridViewProductAndDish.RowTemplate.Height = 24;
            this.dataGridViewProductAndDish.Size = new System.Drawing.Size(676, 176);
            this.dataGridViewProductAndDish.TabIndex = 3;
            // 
            // labelProductAndDish
            // 
            this.labelProductAndDish.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelProductAndDish.AutoSize = true;
            this.tableLayoutPanelReportMeal.SetColumnSpan(this.labelProductAndDish, 2);
            this.labelProductAndDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductAndDish.Location = new System.Drawing.Point(207, 232);
            this.labelProductAndDish.Name = "labelProductAndDish";
            this.labelProductAndDish.Size = new System.Drawing.Size(268, 32);
            this.labelProductAndDish.TabIndex = 2;
            this.labelProductAndDish.Text = "Продукты и Блюда:";
            // 
            // dataGridViewMeals
            // 
            this.dataGridViewMeals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanelReportMeal.SetColumnSpan(this.dataGridViewMeals, 2);
            this.dataGridViewMeals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMeals.Location = new System.Drawing.Point(3, 48);
            this.dataGridViewMeals.Name = "dataGridViewMeals";
            this.dataGridViewMeals.RowHeadersWidth = 51;
            this.dataGridViewMeals.RowTemplate.Height = 24;
            this.dataGridViewMeals.Size = new System.Drawing.Size(676, 175);
            this.dataGridViewMeals.TabIndex = 0;
            this.dataGridViewMeals.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMeals_CellClick);
            // 
            // labelMeal
            // 
            this.labelMeal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMeal.AutoSize = true;
            this.tableLayoutPanelReportMeal.SetColumnSpan(this.labelMeal, 2);
            this.labelMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMeal.Location = new System.Drawing.Point(237, 6);
            this.labelMeal.Name = "labelMeal";
            this.labelMeal.Size = new System.Drawing.Size(208, 32);
            this.labelMeal.TabIndex = 1;
            this.labelMeal.Text = "Приёмы пищи:";
            // 
            // ReportMeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.tableLayoutPanelReportMeal);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportMeal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Отчёт о приёмах пищи";
            this.Load += new System.EventHandler(this.ReportMeal_Load);
            this.tableLayoutPanelReportMeal.ResumeLayout(false);
            this.tableLayoutPanelReportMeal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductAndDish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeals)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelReportMeal;
        private System.Windows.Forms.DataGridView dataGridViewMeals;
        private System.Windows.Forms.Label labelMeal;
        private System.Windows.Forms.DataGridView dataGridViewProductAndDish;
        private System.Windows.Forms.Label labelProductAndDish;
    }
}