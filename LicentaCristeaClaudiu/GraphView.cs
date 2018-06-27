using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LicentaCristeaClaudiu
{
    public partial class GraphView : Form
    {
        private DataGridView dataGridView;

        public GraphView(DataGridView dgv)
        {
            InitializeComponent();
            this.dataGridView = dgv;

            PopulateComboBox(comboBoxXvalues);
            PopulateComboBox(comboBoxYvalues);

            chartSQL.Series[0] = new Series();
            chartSQL.Series[0].Name = "Test";
            chartSQL.DataSource = dgv.DataSource;
            chartSQL.Series[0].YValueMembers = dgv.Columns[1].DataPropertyName;
            chartSQL.DataBind();   
        }

        private void PopulateComboBox(ComboBox cb)
        {
            for (int i= 0; i<dataGridView.ColumnCount;i++)
            {
                cb.Items.Add(dataGridView.Columns[i].DataPropertyName);
            }
        }  

        private void SaveImage()
        {
            saveFileDialogGraph.Filter = "PNG (*.png)|*.png";
            if (saveFileDialogGraph.ShowDialog() == DialogResult.OK)
            {
                chartSQL.SaveImage(saveFileDialogGraph.FileName, ChartImageFormat.Png);
            }
        }

        private void saveImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBoxXvalues_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //chartSQL.DataSource = dgv.DataSource;
            chartSQL.Series[0].XValueMember = dataGridView.Columns[comboBoxXvalues.SelectedIndex].DataPropertyName;
            chartSQL.DataBind();
        }

        private void comboBoxYvalues_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //chartSQL.DataSource = dgv.DataSource;
            chartSQL.Series[0].YValueMembers = dataGridView.Columns[comboBoxYvalues.SelectedIndex].DataPropertyName;  
            chartSQL.DataBind();
        }

        private void areaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chartSQL.Series[0].ChartType = SeriesChartType.Area;
            chartSQL.Series[0].IsValueShownAsLabel = false;
        }

        private void pieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chartSQL.Series[0].ChartType = SeriesChartType.Pie;
            chartSQL.Series[0].IsValueShownAsLabel = true;
        }

        private void barToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chartSQL.Series[0].ChartType = SeriesChartType.Bar;
            chartSQL.Series[0].IsValueShownAsLabel = false;
        }

        private void pointToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chartSQL.Series[0].ChartType = SeriesChartType.Point;
            chartSQL.Series[0].IsValueShownAsLabel = false;
        }

        private void columnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chartSQL.Series[0].ChartType = SeriesChartType.Column;
            chartSQL.Series[0].IsValueShownAsLabel = false;
        }

        private void lineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chartSQL.Series[0].ChartType = SeriesChartType.Line;
            chartSQL.Series[0].IsValueShownAsLabel = false;
        }
    }
}
