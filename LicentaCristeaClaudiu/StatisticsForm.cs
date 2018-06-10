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

            String[] statisticOperations = { "Descriptive Statistics", "Descriptive Statistics Population", "Correlation", "Linear Regression", "LinearRegressionSimpleOneColumn" };
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
                case (int) EStatistics.DescriptiveStatistics:
                    statisticsHelper.DescriptiveStatistics(dataGridViewStatistics);
                    break;
                case (int)EStatistics.DescriptiveStatisticsPopulation:
                    statisticsHelper.DescriptiveStatisticsPopulation(dataGridViewStatistics);
                    break;
                case (int)EStatistics.Correlation:
                    statisticsHelper.Correlation(dataGridViewStatistics);
                    break;
                case 3:
                    statisticsHelper.LinearRegressionSimple(dataGridViewStatistics, new int[] { 0, 1 });
                    break;
                case 4:
                    statisticsHelper.LinearRegressionSimpleOneColumn(dataGridViewStatistics, 0);
                    break;
            }
        }
    }
}
