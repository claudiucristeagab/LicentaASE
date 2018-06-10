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
    public partial class LoadTable : Form
    {
        String currentTable;

        public LoadTable(DataTable dt, ref String currentTable)
        {
            InitializeComponent();
            this.currentTable = currentTable;

            listView1.Items.Clear();
            for(int i=0;i<dt.Rows.Count;i++)
            {
                StringBuilder sb = new StringBuilder();
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    sb.Append(dt.Rows[i][j].ToString());
                    if(j< dt.Columns.Count - 1)
                    {
                        sb.Append(".");
                    }
                }
                listView1.Items.Add(sb.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentTable = listView1.SelectedItems[0].Text;
            //currentTable = listView1.SelectedItems[0].Text;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
