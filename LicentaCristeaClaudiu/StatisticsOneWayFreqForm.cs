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
    public partial class StatisticsOneWayFreqForm : Form
    {
        DataGridView dataGridView;
        int[] selectedColumn;

        public StatisticsOneWayFreqForm(DataGridView dataGridView, int[] selectedColumn)
        {
            InitializeComponent();
            this.dataGridView = dataGridView;
            this.selectedColumn = selectedColumn;
            LoadColumns();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectColumn();
            this.Close();
        }

        private void LoadColumns()
        {
            for (int i = 0; i < dataGridView.ColumnCount; i++)
            {
                comboBoxOneWayFreqVariable.Items.Add(dataGridView.Columns[i].Name);
            }
        }

        private void SelectColumn()
        {
            selectedColumn[0] = comboBoxOneWayFreqVariable.SelectedIndex;
        }
    }
}
