using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LicentaCristeaClaudiu
{
    public partial class DeleteForm : Form
    {
        private SqlDeleteCreator sqlDeleteCreator;
        private ISqlCommand parentForm;

        public DeleteForm(ISqlCommand parentForm)
        {
            InitializeComponent();
            this.sqlDeleteCreator = new SqlDeleteCreator();
            this.parentForm = parentForm;
            fillComparatorList();
            getTableList();
        }

        private void getTableList()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(MainForm.builder.ConnectionString))
                {
                    DataTable dt = new DataTable();

                    connection.Open();
                    StringBuilder sb = new StringBuilder();
                    sb.Append("SELECT TABLE_SCHEMA, TABLE_NAME ");
                    sb.Append("FROM INFORMATION_SCHEMA.TABLES ");
                    sb.Append("WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_CATALOG='" + MainForm.builder.InitialCatalog.ToString() + "';");
                    String sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dt.Load(reader);
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                StringBuilder sbDT = new StringBuilder();
                                for (int j = 0; j < dt.Columns.Count; j++)
                                {
                                    sbDT.Append(dt.Rows[i][j].ToString());
                                    if (j < dt.Columns.Count - 1)
                                    {
                                        sbDT.Append(".");
                                    }
                                }
                                listBoxDeleteTabela.Items.Add(sbDT.ToString());
                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.ToString());
            }
            catch (InvalidOperationException ex)
            {
                if (MainForm.builder.ToString() == "")
                {
                    MessageBox.Show("Date de logare incorecte!");
                }
                else
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void getSelectionListNotAll(ListBox lb, ListBox lb2)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(MainForm.builder.ConnectionString))
                {
                    DataTable dt = new DataTable();

                    connection.Open();
                    StringBuilder sb = new StringBuilder();
                    sb.Append("SELECT column_name ");
                    sb.Append("FROM INFORMATION_SCHEMA.COLUMNS ");
                    String tableName = lb.SelectedItem.ToString();
                    tableName = tableName.Split('.')[1];
                    sb.Append("WHERE TABLE_NAME = '" + tableName + "';");
                    String sql = sb.ToString();
                    lb2.Items.Clear();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dt.Load(reader);
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                lb2.Items.Add(dt.Rows[i][0].ToString());
                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.ToString());
            }
            catch (InvalidOperationException ex)
            {
                if (MainForm.builder.ToString() == "")
                {
                    MessageBox.Show("Date de logare incorecte!");
                }
                else
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void fillComparatorList()
        {
            List<String> list = new List<String>();
            list.Add("Egal cu");
            list.Add("Inegal cu");
            list.Add("Mai mare decat");
            list.Add("Mai mic decat");
            list.Add("Mai mare sau egal decat");
            list.Add("Mai mic sau egal decat");
            listBoxDeleteComparator.DataSource = list;
        }

        private String getSelectedComparator()
        {
            String s;
            switch (listBoxDeleteComparator.SelectedItem.ToString())
            {
                case "Egal cu":
                    s = "=";
                    break;
                case "Inegal cu":
                    s = "<>";
                    break;
                case "Mai mare decat":
                    s = ">";
                    break;
                case "Mai mic decat":
                    s = "<";
                    break;
                case "Mai mare sau egal decat":
                    s = ">=";
                    break;
                case "Mai mic sau egal decat":
                    s = "<=";
                    break;
                default:
                    s = "=";
                    break;
            }
            return s;
        }

        private String transformIfString(String s)
        {
            double d;
            Boolean isNumeric = double.TryParse(s, out d);
            if (isNumeric)
                return s;
            else
                return "'" + s + "'";
        }

        private void sendSelectSQL()
        {
            try
            {
                parentForm.SetSqlCommand(sqlDeleteCreator.ToString());
                this.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            catch (InvalidOperationException ex)
            {
                if (MainForm.builder.ToString() == "")
                {
                    MessageBox.Show("Date de logare incorecte!");
                }
                else
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBoxDeleteTabela_SelectedValueChanged(object sender, EventArgs e)
        {
            getSelectionListNotAll((ListBox)sender, listBoxDelete);
        }

        private void buttonAddDeleteCondition_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(listBoxDeleteTabela.SelectedItem.ToString() + "." + listBoxDelete.SelectedItem.ToString());
            sb.Append(getSelectedComparator());
            sb.Append(transformIfString(textBoxWhereDeleteInput.Text.ToString()));
            sqlDeleteCreator.DeleteLocation = listBoxDeleteTabela.SelectedItem.ToString();
            sqlDeleteCreator.DeleteConditions.Add(sb.ToString());
            textBoxDeleteSQL.Text=sqlDeleteCreator.ToString();
        }

        private void buttonDisplayDeleteCommand_Click(object sender, EventArgs e)
        {
            textBoxDeleteSQL.Text = sqlDeleteCreator.ToString();
        }

        private void buttonNewDeleteCommand_Click(object sender, EventArgs e)
        {
            sqlDeleteCreator.DeleteLocation = String.Empty;
            sqlDeleteCreator.DeleteConditions.Clear();
        }

        private void buttonAndDeleteCondition_Click(object sender, EventArgs e)
        {
            if (sqlDeleteCreator.DeleteConditions.Count > 0)
            {
                if (sqlDeleteCreator.DeleteConditions.Last().Equals("AND") || sqlDeleteCreator.DeleteConditions.Last().Equals("OR"))
                {
                    MessageBox.Show("Nu mai puteți adăuga un operator logic! Operatorul precedent nu este conectat cu alta condiție.");
                }
                else
                {
                    if (sqlDeleteCreator.DeleteConditions.Count > 0)
                    {
                        sqlDeleteCreator.DeleteConditions.Add("AND");
                        textBoxDeleteSQL.Text = sqlDeleteCreator.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Va rugăm să adăugați o condiție înainte.");
                    }
                }
            }
        }

        private void buttonOrDeleteCondition_Click(object sender, EventArgs e)
        {
            if (sqlDeleteCreator.DeleteConditions.Count > 0)
            {
                if (sqlDeleteCreator.DeleteConditions.Last().Equals("AND") || sqlDeleteCreator.DeleteConditions.Last().Equals("OR"))
                {
                    MessageBox.Show("Nu mai puteți adăuga un operator logic! Operatorul precedent nu este conectat cu alta condiție.");
                }
                else
                {
                    if (sqlDeleteCreator.DeleteConditions.Count > 0)
                    {
                        sqlDeleteCreator.DeleteConditions.Add("OR");
                        textBoxDeleteSQL.Text = sqlDeleteCreator.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Va rugăm să adăugați o condiție înainte.");
                    }
                }
            }
        }

        private void sqlDeleteFormOK_Click(object sender, EventArgs e)
        {
            if (sqlDeleteCreator.DeleteConditions.Count > 0)
            {
                if (sqlDeleteCreator.DeleteConditions.Last().Equals("AND") || sqlDeleteCreator.DeleteConditions.Last().Equals("OR"))
                {
                    MessageBox.Show("Va rugăm să adăugați și următoarea pereche.");
                }
                else
                {
                    sendSelectSQL();
                }
            }
            else
            {
                sendSelectSQL();
            }
        }

        private void sqlDeleteFormCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
