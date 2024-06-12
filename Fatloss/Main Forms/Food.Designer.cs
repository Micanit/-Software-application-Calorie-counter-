namespace Fatloss
{
    partial class Food
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Food));
            this.tableLayoutPanelFood = new System.Windows.Forms.TableLayoutPanel();
            this.downToolStripFood = new System.Windows.Forms.ToolStrip();
            this.toolStripMenu = new System.Windows.Forms.ToolStripButton();
            this.toolStripFood = new System.Windows.Forms.ToolStripButton();
            this.toolStripReport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSettings = new System.Windows.Forms.ToolStripButton();
            this.buttonCreateProduct = new System.Windows.Forms.Button();
            this.tableLayoutPanelSearchEngine = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxSearchEngine = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonCreateMeal = new System.Windows.Forms.Button();
            this.tableLayoutPanelFoodControlButtons = new System.Windows.Forms.TableLayoutPanel();
            this.buttonChangeFood = new System.Windows.Forms.Button();
            this.buttonDeleteFood = new System.Windows.Forms.Button();
            this.tableLayoutPanelFood.SuspendLayout();
            this.downToolStripFood.SuspendLayout();
            this.tableLayoutPanelSearchEngine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tableLayoutPanelFoodControlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelFood
            // 
            this.tableLayoutPanelFood.ColumnCount = 2;
            this.tableLayoutPanelFood.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelFood.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanelFood.Controls.Add(this.downToolStripFood, 0, 4);
            this.tableLayoutPanelFood.Controls.Add(this.buttonCreateProduct, 0, 0);
            this.tableLayoutPanelFood.Controls.Add(this.tableLayoutPanelSearchEngine, 1, 0);
            this.tableLayoutPanelFood.Controls.Add(this.buttonCreateMeal, 0, 1);
            this.tableLayoutPanelFood.Controls.Add(this.tableLayoutPanelFoodControlButtons, 0, 3);
            this.tableLayoutPanelFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelFood.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelFood.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelFood.Name = "tableLayoutPanelFood";
            this.tableLayoutPanelFood.RowCount = 5;
            this.tableLayoutPanelFood.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanelFood.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanelFood.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanelFood.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36F));
            this.tableLayoutPanelFood.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelFood.Size = new System.Drawing.Size(802, 453);
            this.tableLayoutPanelFood.TabIndex = 2;
            // 
            // downToolStripFood
            // 
            this.tableLayoutPanelFood.SetColumnSpan(this.downToolStripFood, 2);
            this.downToolStripFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.downToolStripFood.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.downToolStripFood.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenu,
            this.toolStripFood,
            this.toolStripReport,
            this.toolStripSettings});
            this.downToolStripFood.Location = new System.Drawing.Point(0, 406);
            this.downToolStripFood.Name = "downToolStripFood";
            this.downToolStripFood.Size = new System.Drawing.Size(802, 47);
            this.downToolStripFood.TabIndex = 0;
            this.downToolStripFood.Text = "toolStrip1";
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenu.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenu.Image")));
            this.toolStripMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(94, 44);
            this.toolStripMenu.Text = "Главная";
            this.toolStripMenu.Click += new System.EventHandler(this.toolStripMenu_Click);
            // 
            // toolStripFood
            // 
            this.toolStripFood.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripFood.Enabled = false;
            this.toolStripFood.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.toolStripFood.Image = ((System.Drawing.Image)(resources.GetObject("toolStripFood.Image")));
            this.toolStripFood.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripFood.Name = "toolStripFood";
            this.toolStripFood.Size = new System.Drawing.Size(50, 44);
            this.toolStripFood.Text = "Еда";
            // 
            // toolStripReport
            // 
            this.toolStripReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripReport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.toolStripReport.Image = ((System.Drawing.Image)(resources.GetObject("toolStripReport.Image")));
            this.toolStripReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripReport.Name = "toolStripReport";
            this.toolStripReport.Size = new System.Drawing.Size(72, 44);
            this.toolStripReport.Text = "Отчёт";
            this.toolStripReport.Click += new System.EventHandler(this.toolStripReport_Click);
            // 
            // toolStripSettings
            // 
            this.toolStripSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSettings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.toolStripSettings.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSettings.Image")));
            this.toolStripSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSettings.Name = "toolStripSettings";
            this.toolStripSettings.Size = new System.Drawing.Size(122, 44);
            this.toolStripSettings.Text = "Настройки";
            this.toolStripSettings.Click += new System.EventHandler(this.toolStripSettings_Click);
            // 
            // buttonCreateProduct
            // 
            this.buttonCreateProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCreateProduct.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.buttonCreateProduct.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonCreateProduct.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.buttonCreateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateProduct.Location = new System.Drawing.Point(0, 0);
            this.buttonCreateProduct.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCreateProduct.Name = "buttonCreateProduct";
            this.buttonCreateProduct.Size = new System.Drawing.Size(160, 81);
            this.buttonCreateProduct.TabIndex = 1;
            this.buttonCreateProduct.Text = "Создать Продукт";
            this.buttonCreateProduct.UseVisualStyleBackColor = true;
            this.buttonCreateProduct.Click += new System.EventHandler(this.buttonCreateProduct_Click);
            // 
            // tableLayoutPanelSearchEngine
            // 
            this.tableLayoutPanelSearchEngine.ColumnCount = 3;
            this.tableLayoutPanelSearchEngine.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.81818F));
            this.tableLayoutPanelSearchEngine.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanelSearchEngine.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanelSearchEngine.Controls.Add(this.textBoxSearchEngine, 0, 0);
            this.tableLayoutPanelSearchEngine.Controls.Add(this.dataGridView, 0, 1);
            this.tableLayoutPanelSearchEngine.Controls.Add(this.buttonSearch, 2, 0);
            this.tableLayoutPanelSearchEngine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelSearchEngine.Location = new System.Drawing.Point(163, 3);
            this.tableLayoutPanelSearchEngine.Name = "tableLayoutPanelSearchEngine";
            this.tableLayoutPanelSearchEngine.RowCount = 2;
            this.tableLayoutPanelFood.SetRowSpan(this.tableLayoutPanelSearchEngine, 4);
            this.tableLayoutPanelSearchEngine.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelSearchEngine.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanelSearchEngine.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelSearchEngine.Size = new System.Drawing.Size(636, 400);
            this.tableLayoutPanelSearchEngine.TabIndex = 4;
            // 
            // textBoxSearchEngine
            // 
            this.tableLayoutPanelSearchEngine.SetColumnSpan(this.textBoxSearchEngine, 2);
            this.textBoxSearchEngine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSearchEngine.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchEngine.Location = new System.Drawing.Point(0, 0);
            this.textBoxSearchEngine.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxSearchEngine.Name = "textBoxSearchEngine";
            this.textBoxSearchEngine.Size = new System.Drawing.Size(577, 41);
            this.textBoxSearchEngine.TabIndex = 0;
            this.textBoxSearchEngine.Tag = "Введите продукт или блюдо";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeight = 29;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tableLayoutPanelSearchEngine.SetColumnSpan(this.dataGridView, 3);
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 40);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(636, 360);
            this.dataGridView.TabIndex = 3;
            this.dataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseClick);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(577, 0);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(59, 40);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "✓";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonCreateMeal
            // 
            this.buttonCreateMeal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCreateMeal.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.buttonCreateMeal.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonCreateMeal.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.buttonCreateMeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateMeal.Location = new System.Drawing.Point(0, 81);
            this.buttonCreateMeal.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCreateMeal.Name = "buttonCreateMeal";
            this.buttonCreateMeal.Size = new System.Drawing.Size(160, 81);
            this.buttonCreateMeal.TabIndex = 2;
            this.buttonCreateMeal.Text = "Создать Блюдо";
            this.buttonCreateMeal.UseVisualStyleBackColor = true;
            this.buttonCreateMeal.Click += new System.EventHandler(this.buttonCreateMeal_Click);
            // 
            // tableLayoutPanelFoodControlButtons
            // 
            this.tableLayoutPanelFoodControlButtons.ColumnCount = 1;
            this.tableLayoutPanelFoodControlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelFoodControlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelFoodControlButtons.Controls.Add(this.buttonChangeFood, 0, 0);
            this.tableLayoutPanelFoodControlButtons.Controls.Add(this.buttonDeleteFood, 0, 1);
            this.tableLayoutPanelFoodControlButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelFoodControlButtons.Location = new System.Drawing.Point(3, 246);
            this.tableLayoutPanelFoodControlButtons.Name = "tableLayoutPanelFoodControlButtons";
            this.tableLayoutPanelFoodControlButtons.RowCount = 2;
            this.tableLayoutPanelFoodControlButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelFoodControlButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelFoodControlButtons.Size = new System.Drawing.Size(154, 157);
            this.tableLayoutPanelFoodControlButtons.TabIndex = 5;
            // 
            // buttonChangeFood
            // 
            this.buttonChangeFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonChangeFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangeFood.Location = new System.Drawing.Point(0, 0);
            this.buttonChangeFood.Margin = new System.Windows.Forms.Padding(0);
            this.buttonChangeFood.Name = "buttonChangeFood";
            this.buttonChangeFood.Size = new System.Drawing.Size(154, 78);
            this.buttonChangeFood.TabIndex = 0;
            this.buttonChangeFood.Text = "ИЗМЕНИТЬ";
            this.buttonChangeFood.UseVisualStyleBackColor = true;
            this.buttonChangeFood.Visible = false;
            this.buttonChangeFood.Click += new System.EventHandler(this.buttonChangeFood_Click);
            // 
            // buttonDeleteFood
            // 
            this.buttonDeleteFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDeleteFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteFood.Location = new System.Drawing.Point(0, 78);
            this.buttonDeleteFood.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDeleteFood.Name = "buttonDeleteFood";
            this.buttonDeleteFood.Size = new System.Drawing.Size(154, 79);
            this.buttonDeleteFood.TabIndex = 1;
            this.buttonDeleteFood.Text = "УДАЛИТЬ";
            this.buttonDeleteFood.UseVisualStyleBackColor = true;
            this.buttonDeleteFood.Visible = false;
            this.buttonDeleteFood.Click += new System.EventHandler(this.buttonDeleteFood_Click);
            // 
            // Food
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 453);
            this.Controls.Add(this.tableLayoutPanelFood);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(820, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(820, 500);
            this.Name = "Food";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Еда";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Food_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Food_FormClosed);
            this.Load += new System.EventHandler(this.Food_Load);
            this.tableLayoutPanelFood.ResumeLayout(false);
            this.tableLayoutPanelFood.PerformLayout();
            this.downToolStripFood.ResumeLayout(false);
            this.downToolStripFood.PerformLayout();
            this.tableLayoutPanelSearchEngine.ResumeLayout(false);
            this.tableLayoutPanelSearchEngine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tableLayoutPanelFoodControlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFood;
        private System.Windows.Forms.ToolStrip downToolStripFood;
        private System.Windows.Forms.ToolStripButton toolStripMenu;
        private System.Windows.Forms.ToolStripButton toolStripFood;
        private System.Windows.Forms.ToolStripButton toolStripReport;
        private System.Windows.Forms.ToolStripButton toolStripSettings;
        private System.Windows.Forms.Button buttonCreateProduct;
        private System.Windows.Forms.Button buttonCreateMeal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSearchEngine;
        private System.Windows.Forms.TextBox textBoxSearchEngine;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFoodControlButtons;
        private System.Windows.Forms.Button buttonDeleteFood;
        private System.Windows.Forms.Button buttonChangeFood;
    }
}