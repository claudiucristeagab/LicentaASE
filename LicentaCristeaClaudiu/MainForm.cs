using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using System.IO;
using MathNet.Numerics.Statistics;
using MathNet.Numerics.LinearAlgebra;
using System.Globalization;
using DGV2Printer;

namespace LicentaCristeaClaudiu
{
    public partial class MainForm : Form, ISqlCommand 
    {
        public static SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        public static DataTable allTables = new DataTable();
        public static String sqlCommand;

        public MainForm()
        {
            InitializeComponent();
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-GB");
            startLoginForm();
        }

        private void runSQLcommand(SqlConnection connection, String sqlString, DataGridView dgv)
        {
            using (SqlCommand command = new SqlCommand(sqlString, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    DataTable table = new DataTable();
                    table.Load(reader);
                    Action action = () =>
                    {
                        dgv.DataSource = table;
                    };
                    this.BeginInvoke(action);
                }
            }
        }

        private void executeThreadRunSqlCommand(String sql)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    runSQLcommand(connection, sql, dataGridViewMain);
                    connection.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                if (builder.ToString() == "")
                {
                    MessageBox.Show("Date de logare incorecte!");
                    startLoginForm();
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void startLoginForm()
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            toolStripStatusLabelDatabase.Text = builder.InitialCatalog.ToString();
        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewMain.Rows.Count > 0 && dataGridViewMain.Columns.Count > 0)
            {
                StatisticsForm statisticsForm = new StatisticsForm(dataGridViewMain);
                statisticsForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("No data available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginHelper loginHelper = new LoginHelper();
            loginHelper.StartLoginFormPartiallyFilled();
        }

        private void tableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try {
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    //Parsare lista tabele din BD
                    connection.Open();
                    StringBuilder sb = new StringBuilder();
                    sb.Append("SELECT TABLE_SCHEMA, TABLE_NAME ");
                    sb.Append("FROM INFORMATION_SCHEMA.TABLES ");
                    sb.Append("WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_CATALOG='"+builder.InitialCatalog.ToString()+"';");
                    String sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {              
                            allTables.Load(reader);
                        }
                    }
                    connection.Close();

                    //Form de selectare a tabelei
                    String currentTable = String.Empty;
                    LoadTable loadTable = new LoadTable(allTables, ref currentTable);
                    loadTable.ShowDialog();
                    allTables.Clear();

                    //Afisare tabela in MainForm
                    
                    connection.Open();
                    sb = new StringBuilder();
                    sb.Append("SELECT * ");
                    sb.Append("FROM " + currentTable + ";");
                    sql = sb.ToString();
                    executeThreadRunSqlCommand(sql);
                    connection.Close();
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.ToString());
            }
            catch (InvalidOperationException ex)
            {
                if (builder.ToString() == "")
                {
                    MessageBox.Show("Date de logare incorecte!");
                    startLoginForm(); 
                }
                else
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void runCommandToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buttonRunSQL_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread( ()=> { executeThreadRunSqlCommand(textBoxSQLcommand.Text); } );
            thread.Start();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Management
        
        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sqlCommand = String.Empty;
            SelectForm sqlSelectForm = new SelectForm(this);
            sqlSelectForm.ShowDialog();
            if (!String.IsNullOrEmpty(sqlCommand))
            {
                textBoxSQLcommand.Text = sqlCommand;
                executeThreadRunSqlCommand(sqlCommand); 
            }
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertForm sqlInsertForm = new InsertForm();
            sqlInsertForm.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteForm deleteForm = new DeleteForm(this);
            deleteForm.ShowDialog();
            if (!String.IsNullOrEmpty(sqlCommand))
            {
                textBoxSQLcommand.Text = sqlCommand;
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateForm updateForm = new UpdateForm();
            updateForm.ShowDialog();
            if (!String.IsNullOrEmpty(sqlCommand))
            {
                textBoxSQLcommand.Text = sqlCommand;
            }
        }

        private void schemaInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String sql = "SELECT * FROM INFORMATION_SCHEMA.COLUMNS";
            executeThreadRunSqlCommand(sql);
        }

        //Help

        private void despreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proiect de licență făcut de Cristea Claudiu-Gabriel.\nVersiunea din data de 08.06.2018 13:46");
        }

        private void graphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dataGridViewMain.RowCount>0 && dataGridViewMain.ColumnCount > 1)
            {
                GraphView graphView = new GraphView(dataGridViewMain);
                graphView.Show();
            }
            else
            {
                MessageBox.Show("Not enough data.");
            }
        }

        private void cSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewExportHelper exportHelper = new DataGridViewExportHelper(dataGridViewMain, saveFileDialog1);
            exportHelper.ExportToCsv();
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewExportHelper exportHelper = new DataGridViewExportHelper(dataGridViewMain, saveFileDialog1);
            exportHelper.ExportToExcel();
        }

        private void loadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ImportExportHelper t = new ImportExportHelper();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxSQLcommand.Text = t.LoadFromFile(openFileDialog1.FileName);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportExportHelper t = new ImportExportHelper();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                t.SaveToFile(saveFileDialog1.FileName,textBoxSQLcommand.Text);
            }
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            reportForm.Show();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDataGridView printDataGridView = new PrintDataGridView(dataGridViewMain);
            printDataGridView.isRightToLeft = false;
            printDataGridView.Print();

        }

        public void SetSqlCommand(String s)
        {
            sqlCommand = String.Copy(s);
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }
    }
}
