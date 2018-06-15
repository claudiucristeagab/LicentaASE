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
    public partial class StatisticsExtrapolationForm : Form
    {
        DataGridView dataGridView;
        int[] selectedColumnnrOfPredictions;

        public StatisticsExtrapolationForm(DataGridView dataGridView, int[] selectedColumnnrOfPredictions)
        {
            InitializeComponent();
            this.dataGridView = dataGridView;
            this.selectedColumnnrOfPredictions = selectedColumnnrOfPredictions;
            numericUpDownPredictions.Maximum = Int32.MaxValue;
            LoadColumns();
        }

        private void LoadColumns()
        {
            for (int i = 0; i < dataGridView.ColumnCount; i++)
            {
                comboBoxVariable.Items.Add(dataGridView.Columns[i].Name);
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            selectedColumnnrOfPredictions[0] = comboBoxVariable.SelectedIndex;
            selectedColumnnrOfPredictions[1] = (int) numericUpDownPredictions.Value;
            this.Close();
        }
    }
}
