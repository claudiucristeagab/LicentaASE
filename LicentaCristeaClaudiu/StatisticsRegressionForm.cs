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
    public partial class StatisticsRegressionForm: Form
    {
        DataGridView dataGridView;
        int[] selectedColumns;

        public StatisticsRegressionForm(int[] selectedColumns, DataGridView dataGridView)
        {
            InitializeComponent();
            this.selectedColumns = selectedColumns;
            this.dataGridView = dataGridView;
            LoadColumns();
        }

        private void LoadColumns()
        {
            for (int i = 0; i < dataGridView.ColumnCount; i++)
            {
                comboBoxIndependentVariable.Items.Add(dataGridView.Columns[i].Name);
                comboBoxDependentVariable.Items.Add(dataGridView.Columns[i].Name);
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            selectedColumns[0] = comboBoxIndependentVariable.SelectedIndex;
            selectedColumns[1] = comboBoxDependentVariable.SelectedIndex;
            this.Close();
        }
    }
}
