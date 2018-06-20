using MathNet.Numerics.Statistics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LicentaCristeaClaudiu
{
    public partial class StatisticsForm : Form
    {
        private DataGridView dataGridView;
        private StatisticsHelper statisticsHelper;

        public StatisticsForm(DataGridView dataGridView)
        {
            InitializeComponent();
            this.dataGridView = dataGridView;
            this.statisticsHelper = new StatisticsHelper(dataGridView);

            String[] statisticOperations = { "Descriptive Statistics", "Descriptive Statistics for Population", "Correlation", "Simple Linear Regression", "Extrapolation", "One-Way Frequency" };
            comboBox1.Items.AddRange(statisticOperations); 

        }

        private void cSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewExportHelper exportHelper = new DataGridViewExportHelper(dataGridViewStatistics, saveFileDialogStatistics);
            exportHelper.ExportToCsv();
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewExportHelper exportHelper = new DataGridViewExportHelper(dataGridViewStatistics, saveFileDialogStatistics);
            exportHelper.ExportToExcel();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    statisticsHelper.DescriptiveStatistics(dataGridViewStatistics);
                    break;
                case 1:
                    statisticsHelper.DescriptiveStatisticsPopulation(dataGridViewStatistics);
                    break;
                case 2:
                    statisticsHelper.Correlation(dataGridViewStatistics);
                    break;
                case 3:
                    if (dataGridView.ColumnCount >= 2)
                    {
                        int[] selectedColumns = new int[2];
                        StatisticsRegressionForm statisticsRegressionForm = new StatisticsRegressionForm(selectedColumns, dataGridView);
                        statisticsRegressionForm.ShowDialog();
                        if (selectedColumns != null)
                        {
                            statisticsHelper.LinearRegressionSimple(dataGridViewStatistics, selectedColumns);
                        }                                      
                    }
                    else
                    {
                        MessageBox.Show("There are not enough columns in the data set.");
                    }
                    break;
                case 4:
                    int[] selectedColumnNrOfPredictions = new int[2];
                    StatisticsExtrapolationForm statisticsExtrapolationForm = new StatisticsExtrapolationForm(dataGridView, selectedColumnNrOfPredictions);
                    statisticsExtrapolationForm.ShowDialog();
                    statisticsHelper.Extrapolation(dataGridViewStatistics, selectedColumnNrOfPredictions[0], selectedColumnNrOfPredictions[1]);
                    break;
                case 5:
                    int[] selectedColumn = new int[1];
                    StatisticsOneWayFreqForm statisticsOneWayFreqForm = new StatisticsOneWayFreqForm(dataGridView, selectedColumn);
                    statisticsOneWayFreqForm.ShowDialog();
                    statisticsHelper.OneWayFrequency(dataGridViewStatistics, selectedColumn[0]);
                    break;
            }
        }
    }
}
