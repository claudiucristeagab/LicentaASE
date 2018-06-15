namespace LicentaCristeaClaudiu
{
    partial class GraphView
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
            this.chartSQL = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.columnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxXvalues = new System.Windows.Forms.ComboBox();
            this.comboBoxYvalues = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.chartSQL)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartSQL
            // 
            this.chartSQL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartSQL.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartSQL.Legends.Add(legend1);
            this.chartSQL.Location = new System.Drawing.Point(0, 69);
            this.chartSQL.Name = "chartSQL";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            this.chartSQL.Series.Add(series1);
            this.chartSQL.Size = new System.Drawing.Size(622, 364);
            this.chartSQL.TabIndex = 0;
            this.chartSQL.Text = "chart1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.graphToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(622, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStripGraph";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveImageToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveImageToolStripMenuItem
            // 
            this.saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            this.saveImageToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.saveImageToolStripMenuItem.Text = "Save Image";
            this.saveImageToolStripMenuItem.Click += new System.EventHandler(this.saveImageToolStripMenuItem_Click);
            // 
            // graphToolStripMenuItem
            // 
            this.graphToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.typeToolStripMenuItem});
            this.graphToolStripMenuItem.Name = "graphToolStripMenuItem";
            this.graphToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.graphToolStripMenuItem.Text = "Graph";
            // 
            // typeToolStripMenuItem
            // 
            this.typeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.areaToolStripMenuItem,
            this.barToolStripMenuItem,
            this.columnToolStripMenuItem,
            this.lineToolStripMenuItem,
            this.pieToolStripMenuItem,
            this.pointToolStripMenuItem});
            this.typeToolStripMenuItem.Name = "typeToolStripMenuItem";
            this.typeToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.typeToolStripMenuItem.Text = "Type";
            // 
            // areaToolStripMenuItem
            // 
            this.areaToolStripMenuItem.Name = "areaToolStripMenuItem";
            this.areaToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.areaToolStripMenuItem.Text = "Area";
            this.areaToolStripMenuItem.Click += new System.EventHandler(this.areaToolStripMenuItem_Click);
            // 
            // barToolStripMenuItem
            // 
            this.barToolStripMenuItem.Name = "barToolStripMenuItem";
            this.barToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.barToolStripMenuItem.Text = "Bar";
            this.barToolStripMenuItem.Click += new System.EventHandler(this.barToolStripMenuItem_Click);
            // 
            // columnToolStripMenuItem
            // 
            this.columnToolStripMenuItem.Name = "columnToolStripMenuItem";
            this.columnToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.columnToolStripMenuItem.Text = "Column";
            this.columnToolStripMenuItem.Click += new System.EventHandler(this.columnToolStripMenuItem_Click);
            // 
            // pieToolStripMenuItem
            // 
            this.pieToolStripMenuItem.Name = "pieToolStripMenuItem";
            this.pieToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.pieToolStripMenuItem.Text = "Pie";
            this.pieToolStripMenuItem.Click += new System.EventHandler(this.pieToolStripMenuItem_Click);
            // 
            // pointToolStripMenuItem
            // 
            this.pointToolStripMenuItem.Name = "pointToolStripMenuItem";
            this.pointToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.pointToolStripMenuItem.Text = "Point";
            this.pointToolStripMenuItem.Click += new System.EventHandler(this.pointToolStripMenuItem_Click);
            // 
            // comboBoxXvalues
            // 
            this.comboBoxXvalues.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxXvalues.FormattingEnabled = true;
            this.comboBoxXvalues.Location = new System.Drawing.Point(3, 3);
            this.comboBoxXvalues.Name = "comboBoxXvalues";
            this.comboBoxXvalues.Size = new System.Drawing.Size(305, 24);
            this.comboBoxXvalues.TabIndex = 2;
            this.comboBoxXvalues.SelectionChangeCommitted += new System.EventHandler(this.comboBoxXvalues_SelectionChangeCommitted);
            // 
            // comboBoxYvalues
            // 
            this.comboBoxYvalues.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxYvalues.FormattingEnabled = true;
            this.comboBoxYvalues.Location = new System.Drawing.Point(314, 3);
            this.comboBoxYvalues.Name = "comboBoxYvalues";
            this.comboBoxYvalues.Size = new System.Drawing.Size(305, 24);
            this.comboBoxYvalues.TabIndex = 3;
            this.comboBoxYvalues.SelectionChangeCommitted += new System.EventHandler(this.comboBoxYvalues_SelectionChangeCommitted);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.comboBoxXvalues, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxYvalues, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 31);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(622, 32);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // lineToolStripMenuItem
            // 
            this.lineToolStripMenuItem.Name = "lineToolStripMenuItem";
            this.lineToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.lineToolStripMenuItem.Text = "Line";
            this.lineToolStripMenuItem.Click += new System.EventHandler(this.lineToolStripMenuItem_Click);
            // 
            // GraphView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 433);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.chartSQL);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GraphView";
            this.Text = "Graphs";
            ((System.ComponentModel.ISupportInitialize)(this.chartSQL)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartSQL;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem areaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveImageToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxXvalues;
        private System.Windows.Forms.ComboBox comboBoxYvalues;
        private System.Windows.Forms.ToolStripMenuItem pieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pointToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem columnToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem lineToolStripMenuItem;
    }
}