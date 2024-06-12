namespace Fatloss
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.tableLayoutPanelSettings = new System.Windows.Forms.TableLayoutPanel();
            this.downToolStripSettings = new System.Windows.Forms.ToolStrip();
            this.toolStripMenu = new System.Windows.Forms.ToolStripButton();
            this.toolStripFood = new System.Windows.Forms.ToolStripButton();
            this.toolStripReport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSettings = new System.Windows.Forms.ToolStripButton();
            this.comboBoxWeightChange = new System.Windows.Forms.ComboBox();
            this.labelWeigntChange = new System.Windows.Forms.Label();
            this.buttonChangePersonalSettings = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanelSettings.SuspendLayout();
            this.downToolStripSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelSettings
            // 
            resources.ApplyResources(this.tableLayoutPanelSettings, "tableLayoutPanelSettings");
            this.tableLayoutPanelSettings.Controls.Add(this.downToolStripSettings, 0, 4);
            this.tableLayoutPanelSettings.Controls.Add(this.comboBoxWeightChange, 1, 0);
            this.tableLayoutPanelSettings.Controls.Add(this.labelWeigntChange, 0, 0);
            this.tableLayoutPanelSettings.Controls.Add(this.buttonChangePersonalSettings, 0, 2);
            this.tableLayoutPanelSettings.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanelSettings.Controls.Add(this.comboBox1, 1, 1);
            this.tableLayoutPanelSettings.Name = "tableLayoutPanelSettings";
            // 
            // downToolStripSettings
            // 
            this.tableLayoutPanelSettings.SetColumnSpan(this.downToolStripSettings, 2);
            resources.ApplyResources(this.downToolStripSettings, "downToolStripSettings");
            this.downToolStripSettings.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.downToolStripSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenu,
            this.toolStripFood,
            this.toolStripReport,
            this.toolStripSettings});
            this.downToolStripSettings.Name = "downToolStripSettings";
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.toolStripMenu, "toolStripMenu");
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Click += new System.EventHandler(this.toolStripMenu_Click);
            // 
            // toolStripFood
            // 
            this.toolStripFood.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.toolStripFood, "toolStripFood");
            this.toolStripFood.Name = "toolStripFood";
            this.toolStripFood.Click += new System.EventHandler(this.toolStripFood_Click);
            // 
            // toolStripReport
            // 
            this.toolStripReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.toolStripReport, "toolStripReport");
            this.toolStripReport.Name = "toolStripReport";
            this.toolStripReport.Click += new System.EventHandler(this.toolStripReport_Click);
            // 
            // toolStripSettings
            // 
            this.toolStripSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.toolStripSettings, "toolStripSettings");
            this.toolStripSettings.Name = "toolStripSettings";
            // 
            // comboBoxWeightChange
            // 
            resources.ApplyResources(this.comboBoxWeightChange, "comboBoxWeightChange");
            this.comboBoxWeightChange.Items.AddRange(new object[] {
            resources.GetString("comboBoxWeightChange.Items"),
            resources.GetString("comboBoxWeightChange.Items1"),
            resources.GetString("comboBoxWeightChange.Items2"),
            resources.GetString("comboBoxWeightChange.Items3"),
            resources.GetString("comboBoxWeightChange.Items4")});
            this.comboBoxWeightChange.Name = "comboBoxWeightChange";
            // 
            // labelWeigntChange
            // 
            resources.ApplyResources(this.labelWeigntChange, "labelWeigntChange");
            this.labelWeigntChange.Name = "labelWeigntChange";
            // 
            // buttonChangePersonalSettings
            // 
            this.tableLayoutPanelSettings.SetColumnSpan(this.buttonChangePersonalSettings, 2);
            resources.ApplyResources(this.buttonChangePersonalSettings, "buttonChangePersonalSettings");
            this.buttonChangePersonalSettings.Name = "buttonChangePersonalSettings";
            this.buttonChangePersonalSettings.UseVisualStyleBackColor = true;
            this.buttonChangePersonalSettings.Click += new System.EventHandler(this.buttonChangePersonalSettings_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // comboBox1
            // 
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Name = "comboBox1";
            // 
            // Settings
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelSettings);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.ShowIcon = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Settings_FormClosed);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.tableLayoutPanelSettings.ResumeLayout(false);
            this.tableLayoutPanelSettings.PerformLayout();
            this.downToolStripSettings.ResumeLayout(false);
            this.downToolStripSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSettings;
        private System.Windows.Forms.ToolStrip downToolStripSettings;
        private System.Windows.Forms.ToolStripButton toolStripMenu;
        private System.Windows.Forms.ToolStripButton toolStripFood;
        private System.Windows.Forms.ToolStripButton toolStripReport;
        private System.Windows.Forms.ToolStripButton toolStripSettings;
        private System.Windows.Forms.Label labelWeigntChange;
        private System.Windows.Forms.ComboBox comboBoxWeightChange;
        private System.Windows.Forms.Button buttonChangePersonalSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}