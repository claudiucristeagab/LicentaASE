using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LicentaCristeaClaudiu
{
    public partial class ReportForm : Form, ISqlCommand, IGraph
    {
        ReportBuilder reportBuilder;
        StatisticsHelper statisticsHelper;
        GraphHelper graphHelper;
        string[] statisticsString = { "Descriptive Statistics", "Descriptive Statistics Population", "Correlation" };

        public ReportForm()
        {
            InitializeComponent();
            this.reportBuilder = new ReportBuilder();
            checkedListBoxReportStatistics.Items.AddRange(statisticsString);
        }

        private void buttonAddReportItem_Click(object sender, EventArgs e)
        {
            reportBuilder.ReportName= textBoxReportName.Text;

            ReportItem reportItem = new ReportItem();
            reportItem.ReportItemName = textBoxItemName.Text;
            reportItem.SqlSelectCommand = textBoxSqlCommand.Text;
            if (checkBoxItemOutput.Checked)
            {
                reportItem.isOutput = true;
            }
            for (int i = 0; i < checkedListBoxReportStatistics.Items.Count;i++)
            {
                if (checkedListBoxReportStatistics.GetItemChecked(i))
                {
                    switch (i)
                    {
                        case 0:
                            reportItem.ListStatistics.Add(EStatistics.DescriptiveStatistics);
                            break;
                        case 1:
                            reportItem.ListStatistics.Add(EStatistics.DescriptiveStatisticsPopulation);
                            break;
                        case 2:
                            reportItem.ListStatistics.Add(EStatistics.Correlation);
                            break;
                        default:
                            break;
                    }
                }
            }
            if (checkBoxReportChart.Checked)
            {
                reportItem.GraphHelper = graphHelper;
            }
            reportBuilder.ListReportItems.Add(reportItem);
            textBoxItemName.Clear();
            textBoxSqlCommand.Clear();
            checkBoxItemOutput.Checked = false;
            checkBoxReportChart.Checked = false;

            listViewReportItems.Items.Clear();
            foreach (ReportItem ri in reportBuilder.ListReportItems)
            {
                listViewReportItems.Items.Add(new ListViewItem(ri.ReportItemName));
            }
            
        }

        private void buttonGenerateReport_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(reportBuilder.ReportName) && reportBuilder.ListReportItems.Count>0)
            {
                saveFileDialog1.FileName = reportBuilder.ReportName + ".html";
                saveFileDialog1.Filter = "HTML (*.html)|*.html";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    webBrowser1.DocumentStream = null;
                    richTextBox1.Clear();

                    foreach(ReportItem ri in reportBuilder.ListReportItems)
                    {
                        if (ri.GraphHelper != null)
                        {
                            ri.GraphHelper.Path = Path.GetDirectoryName(saveFileDialog1.FileName);
                        }
                    }
                    String output = reportBuilder.GenerateReport();
                    if (!String.IsNullOrEmpty(output))
                    {
                        richTextBox1.Text = output;
                        ImportExportHelper ieh = new ImportExportHelper();
                        ieh.SaveToFile(saveFileDialog1.FileName, output);
                        webBrowser1.Url = new System.Uri(saveFileDialog1.FileName);
                    }
                    else
                    {
                        MessageBox.Show("The report could not be saved. Attempting to load the text from memory...");
                        webBrowser1.DocumentText = output;
                    }
                    tabControlReport.SelectedIndex = 1;
                }
            }
            else
            {
                MessageBox.Show("Please give your report a name.");
            }
        }

        private void tabControlReport_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControlReport_Selected(object sender, TabControlEventArgs e)
        {
                listViewReportItems.Items.Clear();
                foreach(ReportItem ri in reportBuilder.ListReportItems)
                {
                    listViewReportItems.Items.Add(new ListViewItem(ri.ReportItemName));
                }
        }

        private void listViewReportItems_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void listViewReportItems_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                for (int i = 0; i < listViewReportItems.Items.Count; i++)
                {
                    if (listViewReportItems.Items[i].Selected)
                    {
                        reportBuilder.ListReportItems.RemoveAt(i);
                    }
                }
                listViewReportItems.Items.Clear();
                foreach (ReportItem ri in reportBuilder.ListReportItems)
                {
                    listViewReportItems.Items.Add(new ListViewItem(ri.ReportItemName));
                }
            }
        }

        private void buttonReportReset_Click(object sender, EventArgs e)
        {
            reportBuilder = new ReportBuilder();
            listViewReportItems.Items.Clear();
        }

        private void buttonReportSelectGenerate_Click(object sender, EventArgs e)
        {
            SelectForm sqlSelectForm = new SelectForm(this);
            sqlSelectForm.ShowDialog();
        }

        public void SetSqlCommand(string sqlCommand)
        {
            this.textBoxSqlCommand.Text = String.Copy(sqlCommand);
        }

        private void buttonReportImportCommand_Click(object sender, EventArgs e)
        {
            ImportExportHelper ieh = new ImportExportHelper();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxSqlCommand.Text = ieh.LoadFromFile(openFileDialog1.FileName);
            }
        }

        private void buttonReportChartCustomize_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxReportChart_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxReportChart.Checked)
            {
                ReportGraphForm reportGraphForm = new ReportGraphForm(this);
                if (reportGraphForm.ShowDialog() == DialogResult.OK)
                {

                }
            }
            else
            {

            }

        }

        public void SetGraph(GraphHelper graphHelper)
        {
            this.graphHelper = graphHelper;
        }
    }
}
