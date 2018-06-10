namespace LicentaCristeaClaudiu
{
    partial class ReportForm
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabPageRawOutput = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabPageHtmlOutput = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabPageSetup = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewReportItems = new System.Windows.Forms.ListView();
            this.buttonReportSelectGenerate = new System.Windows.Forms.Button();
            this.buttonReportReset = new System.Windows.Forms.Button();
            this.checkBoxReportChart = new System.Windows.Forms.CheckBox();
            this.checkedListBoxReportStatistics = new System.Windows.Forms.CheckedListBox();
            this.buttonGenerateReport = new System.Windows.Forms.Button();
            this.buttonReportImportCommand = new System.Windows.Forms.Button();
            this.buttonAddReportItem = new System.Windows.Forms.Button();
            this.checkBoxItemOutput = new System.Windows.Forms.CheckBox();
            this.textBoxSqlCommand = new System.Windows.Forms.TextBox();
            this.textBoxItemName = new System.Windows.Forms.TextBox();
            this.textBoxReportName = new System.Windows.Forms.TextBox();
            this.labelSqlCommand = new System.Windows.Forms.Label();
            this.labelItemName = new System.Windows.Forms.Label();
            this.labelReportName = new System.Windows.Forms.Label();
            this.tabControlReport = new System.Windows.Forms.TabControl();
            this.tabPageRawOutput.SuspendLayout();
            this.tabPageHtmlOutput.SuspendLayout();
            this.tabPageSetup.SuspendLayout();
            this.tabControlReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabPageRawOutput
            // 
            this.tabPageRawOutput.Controls.Add(this.richTextBox1);
            this.tabPageRawOutput.Location = new System.Drawing.Point(4, 25);
            this.tabPageRawOutput.Name = "tabPageRawOutput";
            this.tabPageRawOutput.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRawOutput.Size = new System.Drawing.Size(683, 404);
            this.tabPageRawOutput.TabIndex = 1;
            this.tabPageRawOutput.Text = "Raw HTML Output";
            this.tabPageRawOutput.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(677, 398);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // tabPageHtmlOutput
            // 
            this.tabPageHtmlOutput.Controls.Add(this.webBrowser1);
            this.tabPageHtmlOutput.Location = new System.Drawing.Point(4, 25);
            this.tabPageHtmlOutput.Name = "tabPageHtmlOutput";
            this.tabPageHtmlOutput.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHtmlOutput.Size = new System.Drawing.Size(683, 404);
            this.tabPageHtmlOutput.TabIndex = 3;
            this.tabPageHtmlOutput.Text = "Output";
            this.tabPageHtmlOutput.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(677, 398);
            this.webBrowser1.TabIndex = 0;
            // 
            // tabPageSetup
            // 
            this.tabPageSetup.Controls.Add(this.label1);
            this.tabPageSetup.Controls.Add(this.listViewReportItems);
            this.tabPageSetup.Controls.Add(this.buttonReportSelectGenerate);
            this.tabPageSetup.Controls.Add(this.buttonReportReset);
            this.tabPageSetup.Controls.Add(this.checkBoxReportChart);
            this.tabPageSetup.Controls.Add(this.checkedListBoxReportStatistics);
            this.tabPageSetup.Controls.Add(this.buttonGenerateReport);
            this.tabPageSetup.Controls.Add(this.buttonReportImportCommand);
            this.tabPageSetup.Controls.Add(this.buttonAddReportItem);
            this.tabPageSetup.Controls.Add(this.checkBoxItemOutput);
            this.tabPageSetup.Controls.Add(this.textBoxSqlCommand);
            this.tabPageSetup.Controls.Add(this.textBoxItemName);
            this.tabPageSetup.Controls.Add(this.textBoxReportName);
            this.tabPageSetup.Controls.Add(this.labelSqlCommand);
            this.tabPageSetup.Controls.Add(this.labelItemName);
            this.tabPageSetup.Controls.Add(this.labelReportName);
            this.tabPageSetup.Location = new System.Drawing.Point(4, 25);
            this.tabPageSetup.Name = "tabPageSetup";
            this.tabPageSetup.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSetup.Size = new System.Drawing.Size(683, 404);
            this.tabPageSetup.TabIndex = 0;
            this.tabPageSetup.Text = "Report Setup";
            this.tabPageSetup.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(546, 28);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Report Items";
            // 
            // listViewReportItems
            // 
            this.listViewReportItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewReportItems.Location = new System.Drawing.Point(506, 48);
            this.listViewReportItems.Name = "listViewReportItems";
            this.listViewReportItems.Size = new System.Drawing.Size(168, 277);
            this.listViewReportItems.TabIndex = 16;
            this.listViewReportItems.UseCompatibleStateImageBehavior = false;
            this.listViewReportItems.View = System.Windows.Forms.View.List;
            this.listViewReportItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewReportItems_KeyDown);
            // 
            // buttonReportSelectGenerate
            // 
            this.buttonReportSelectGenerate.Location = new System.Drawing.Point(294, 132);
            this.buttonReportSelectGenerate.Name = "buttonReportSelectGenerate";
            this.buttonReportSelectGenerate.Size = new System.Drawing.Size(100, 23);
            this.buttonReportSelectGenerate.TabIndex = 14;
            this.buttonReportSelectGenerate.Text = "Generate";
            this.buttonReportSelectGenerate.UseVisualStyleBackColor = true;
            this.buttonReportSelectGenerate.Click += new System.EventHandler(this.buttonReportSelectGenerate_Click);
            // 
            // buttonReportReset
            // 
            this.buttonReportReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonReportReset.Location = new System.Drawing.Point(8, 352);
            this.buttonReportReset.Name = "buttonReportReset";
            this.buttonReportReset.Size = new System.Drawing.Size(75, 44);
            this.buttonReportReset.TabIndex = 13;
            this.buttonReportReset.Text = "Reset";
            this.buttonReportReset.UseVisualStyleBackColor = true;
            this.buttonReportReset.Click += new System.EventHandler(this.buttonReportReset_Click);
            // 
            // checkBoxReportChart
            // 
            this.checkBoxReportChart.AutoSize = true;
            this.checkBoxReportChart.Location = new System.Drawing.Point(117, 254);
            this.checkBoxReportChart.Name = "checkBoxReportChart";
            this.checkBoxReportChart.Size = new System.Drawing.Size(64, 21);
            this.checkBoxReportChart.TabIndex = 12;
            this.checkBoxReportChart.Text = "Chart";
            this.checkBoxReportChart.UseVisualStyleBackColor = true;
            this.checkBoxReportChart.CheckedChanged += new System.EventHandler(this.checkBoxReportChart_CheckedChanged);
            // 
            // checkedListBoxReportStatistics
            // 
            this.checkedListBoxReportStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxReportStatistics.FormattingEnabled = true;
            this.checkedListBoxReportStatistics.Location = new System.Drawing.Point(117, 159);
            this.checkedListBoxReportStatistics.Name = "checkedListBoxReportStatistics";
            this.checkedListBoxReportStatistics.Size = new System.Drawing.Size(383, 89);
            this.checkedListBoxReportStatistics.TabIndex = 11;
            // 
            // buttonGenerateReport
            // 
            this.buttonGenerateReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGenerateReport.Location = new System.Drawing.Point(509, 352);
            this.buttonGenerateReport.Name = "buttonGenerateReport";
            this.buttonGenerateReport.Size = new System.Drawing.Size(168, 44);
            this.buttonGenerateReport.TabIndex = 10;
            this.buttonGenerateReport.Text = "Generate Report";
            this.buttonGenerateReport.UseVisualStyleBackColor = true;
            this.buttonGenerateReport.Click += new System.EventHandler(this.buttonGenerateReport_Click);
            // 
            // buttonReportImportCommand
            // 
            this.buttonReportImportCommand.Location = new System.Drawing.Point(400, 132);
            this.buttonReportImportCommand.Name = "buttonReportImportCommand";
            this.buttonReportImportCommand.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonReportImportCommand.Size = new System.Drawing.Size(100, 23);
            this.buttonReportImportCommand.TabIndex = 9;
            this.buttonReportImportCommand.Text = "Import";
            this.buttonReportImportCommand.UseVisualStyleBackColor = true;
            this.buttonReportImportCommand.Click += new System.EventHandler(this.buttonReportImportCommand_Click);
            // 
            // buttonAddReportItem
            // 
            this.buttonAddReportItem.Location = new System.Drawing.Point(117, 281);
            this.buttonAddReportItem.Name = "buttonAddReportItem";
            this.buttonAddReportItem.Size = new System.Drawing.Size(161, 44);
            this.buttonAddReportItem.TabIndex = 8;
            this.buttonAddReportItem.Text = "Add item";
            this.buttonAddReportItem.UseVisualStyleBackColor = true;
            this.buttonAddReportItem.Click += new System.EventHandler(this.buttonAddReportItem_Click);
            // 
            // checkBoxItemOutput
            // 
            this.checkBoxItemOutput.AutoSize = true;
            this.checkBoxItemOutput.Location = new System.Drawing.Point(117, 132);
            this.checkBoxItemOutput.Name = "checkBoxItemOutput";
            this.checkBoxItemOutput.Size = new System.Drawing.Size(140, 21);
            this.checkBoxItemOutput.TabIndex = 6;
            this.checkBoxItemOutput.Text = "Command Output";
            this.checkBoxItemOutput.UseVisualStyleBackColor = true;
            // 
            // textBoxSqlCommand
            // 
            this.textBoxSqlCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSqlCommand.Location = new System.Drawing.Point(117, 76);
            this.textBoxSqlCommand.Multiline = true;
            this.textBoxSqlCommand.Name = "textBoxSqlCommand";
            this.textBoxSqlCommand.Size = new System.Drawing.Size(383, 50);
            this.textBoxSqlCommand.TabIndex = 5;
            // 
            // textBoxItemName
            // 
            this.textBoxItemName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxItemName.Location = new System.Drawing.Point(117, 48);
            this.textBoxItemName.Name = "textBoxItemName";
            this.textBoxItemName.Size = new System.Drawing.Size(383, 22);
            this.textBoxItemName.TabIndex = 3;
            // 
            // textBoxReportName
            // 
            this.textBoxReportName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxReportName.Location = new System.Drawing.Point(117, 8);
            this.textBoxReportName.Name = "textBoxReportName";
            this.textBoxReportName.Size = new System.Drawing.Size(383, 22);
            this.textBoxReportName.TabIndex = 1;
            // 
            // labelSqlCommand
            // 
            this.labelSqlCommand.AutoSize = true;
            this.labelSqlCommand.Location = new System.Drawing.Point(8, 79);
            this.labelSqlCommand.Name = "labelSqlCommand";
            this.labelSqlCommand.Size = new System.Drawing.Size(103, 17);
            this.labelSqlCommand.TabIndex = 4;
            this.labelSqlCommand.Text = "SQL Command";
            // 
            // labelItemName
            // 
            this.labelItemName.AutoSize = true;
            this.labelItemName.Location = new System.Drawing.Point(8, 51);
            this.labelItemName.Name = "labelItemName";
            this.labelItemName.Size = new System.Drawing.Size(73, 17);
            this.labelItemName.TabIndex = 2;
            this.labelItemName.Text = "Item name";
            // 
            // labelReportName
            // 
            this.labelReportName.AutoSize = true;
            this.labelReportName.Location = new System.Drawing.Point(8, 11);
            this.labelReportName.Name = "labelReportName";
            this.labelReportName.Size = new System.Drawing.Size(90, 17);
            this.labelReportName.TabIndex = 0;
            this.labelReportName.Text = "Report name";
            // 
            // tabControlReport
            // 
            this.tabControlReport.Controls.Add(this.tabPageSetup);
            this.tabControlReport.Controls.Add(this.tabPageHtmlOutput);
            this.tabControlReport.Controls.Add(this.tabPageRawOutput);
            this.tabControlReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlReport.Location = new System.Drawing.Point(0, 0);
            this.tabControlReport.Name = "tabControlReport";
            this.tabControlReport.SelectedIndex = 0;
            this.tabControlReport.Size = new System.Drawing.Size(691, 433);
            this.tabControlReport.TabIndex = 0;
            this.tabControlReport.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControlReport_Selected);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 433);
            this.Controls.Add(this.tabControlReport);
            this.Name = "ReportForm";
            this.Text = "Report Builder";
            this.tabPageRawOutput.ResumeLayout(false);
            this.tabPageHtmlOutput.ResumeLayout(false);
            this.tabPageSetup.ResumeLayout(false);
            this.tabPageSetup.PerformLayout();
            this.tabControlReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TabPage tabPageRawOutput;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabPage tabPageHtmlOutput;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TabPage tabPageSetup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewReportItems;
        private System.Windows.Forms.Button buttonReportSelectGenerate;
        private System.Windows.Forms.Button buttonReportReset;
        private System.Windows.Forms.CheckBox checkBoxReportChart;
        private System.Windows.Forms.CheckedListBox checkedListBoxReportStatistics;
        private System.Windows.Forms.Button buttonGenerateReport;
        private System.Windows.Forms.Button buttonReportImportCommand;
        private System.Windows.Forms.Button buttonAddReportItem;
        private System.Windows.Forms.CheckBox checkBoxItemOutput;
        private System.Windows.Forms.TextBox textBoxSqlCommand;
        private System.Windows.Forms.TextBox textBoxItemName;
        private System.Windows.Forms.TextBox textBoxReportName;
        private System.Windows.Forms.Label labelSqlCommand;
        private System.Windows.Forms.Label labelItemName;
        private System.Windows.Forms.Label labelReportName;
        private System.Windows.Forms.TabControl tabControlReport;
    }
}