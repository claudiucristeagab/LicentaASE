using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LicentaCristeaClaudiu
{
    class DataGridViewExportHelper
    {
        DataGridView dataGridView;
        SaveFileDialog saveFileDialog;

        public DataGridViewExportHelper (DataGridView dataGridView, SaveFileDialog saveFileDialog)
        {
            this.dataGridView = dataGridView;
            this.saveFileDialog = saveFileDialog;
        }

        public void ExportToExcel()
        {
            if (dataGridView.Rows.Count > 0)
            {
                saveFileDialog.RestoreDirectory = false;
                saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                    Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                    Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                    worksheet = workbook.Sheets["Export sheet"];
                    worksheet = workbook.ActiveSheet;
                    worksheet.Name = "Export Table";
                    for (int i = 1; i < dataGridView.Columns.Count + 1; i++)
                    {
                        worksheet.Cells[1, i] = dataGridView.Columns[i - 1].HeaderText;
                    }
                    for (int i = 0; i < dataGridView.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, 
                        Type.Missing, Type.Missing, Type.Missing, 
                        Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, 
                        Type.Missing, Type.Missing);
                    app.Quit();
                }
            }
            else
            {
                MessageBox.Show("Not enough data.");
            }
        }

        public void ExportToCsv()
        {
            if (dataGridView.Rows.Count > 0)
            {
                saveFileDialog.Filter = "CSV (*.csv)|*.csv";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Thread thread = new Thread(() =>
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.Append(dataGridView.Columns[0].Name);
                        for (int j = 1; j < dataGridView.Columns.Count; j++)
                        {
                            sb.Append(";");
                            sb.Append(dataGridView.Columns[j].Name);
                        }
                        sb.AppendLine();
                        for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
                        {
                            sb.Append(dataGridView.Rows[i].Cells[0].Value);
                            for (int j = 1; j < dataGridView.Columns.Count; j++)
                            {
                                sb.Append(";");
                                sb.Append(dataGridView.Rows[i].Cells[j].Value);
                            }
                            sb.AppendLine();
                        }
                        File.WriteAllText(saveFileDialog.FileName, sb.ToString(), Encoding.UTF8);
                    });
                    thread.Start();
                }
                else
                {
                    MessageBox.Show("Not enough data.");
                }
            }
        }
    }
}
