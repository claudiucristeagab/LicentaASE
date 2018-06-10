using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LicentaCristeaClaudiu
{
    public partial class InsertForm : Form
    {
        private List<SqlInsertElement> listSqlInsertElement;

        public InsertForm()
        {
            InitializeComponent();
            this.listSqlInsertElement = new List<SqlInsertElement>();
            Thread thread = new Thread(() => { getTableList(); });
            thread.Start();
            
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
                            Action action = () =>
                            {
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
                                    comboBoxInsertTable.Items.Add(sbDT.ToString());
                                }
                            };
                            this.BeginInvoke(action);        
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
                    //loginHelper.StartLoginForm();
                }
                else
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void getSelectionListNotAll(ComboBox cb)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(MainForm.builder.ConnectionString))
                {
                    DataTable dt = new DataTable();

                    connection.Open();
                    StringBuilder sb = new StringBuilder();
                    sb.Append("SELECT column_name, is_nullable, data_type, character_maximum_length ");
                    sb.Append("FROM INFORMATION_SCHEMA.COLUMNS ");
                    String tableName = cb.SelectedItem.ToString();
                    tableName = tableName.Split('.')[1];
                    sb.Append("WHERE TABLE_NAME = '" + tableName + "';");
                    String sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dt.Load(reader);
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                SqlInsertElement s = new SqlInsertElement();

                                CheckBox lb = new CheckBox();
                                lb.Checked = true;
                                lb.AutoSize = true;
                                lb.Text = dt.Rows[i][0].ToString();
                                s.Column= dt.Rows[i][0].ToString();
                                if (dt.Rows[i][1].ToString().Equals("YES"))
                                {
                                    lb.Text += ", is nullable";
                                    s.IsNullable = true;
                                }
                                else
                                {
                                    lb.Text += ", is not nullable";
                                    s.IsNullable = false;
                                }
                                lb.Text += ", "+dt.Rows[i][2].ToString();
                                s.DataType= dt.Rows[i][2].ToString();
                                lb.Text += ", Max characters/number: "+ dt.Rows[i][3].ToString();
                                lb.Location = new Point(30, 50 + i * 50);
                                s.CheckBox = lb;

                                TextBox tb = new TextBox();
                                tb.Name = "TextBox" + i;
                                tb.Width = 200;
                                tb.Location = new Point(30, 75 + i * 50);
                                //tb.Anchor = AnchorStyles.Right;
                                s.TextBox = tb;
                                this.Controls.Add(s.CheckBox);
                                this.Controls.Add(s.TextBox);
                                listSqlInsertElement.Add(s);
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
                    //loginHelper.StartLoginForm();
                }
                else
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void removeInsertElements()
        {
            foreach(SqlInsertElement s in listSqlInsertElement)
            {
                this.Controls.Remove(s.CheckBox);
                this.Controls.Remove(s.TextBox);
            }
            listSqlInsertElement.Clear();
        }

        private void comboBoxInsertTable_SelectionChangeCommitted(object sender, EventArgs e)
        {
            removeInsertElements();
            getSelectionListNotAll(comboBoxInsertTable);
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT INTO ");
            sb.Append(comboBoxInsertTable.SelectedItem.ToString());
            sb.Append(" (");
            foreach (SqlInsertElement s in listSqlInsertElement)
            {
                if (s.CheckBox.Checked)
                {
                    sb.Append(s.Column);
                    sb.Append(",");
                }          
            }
            sb.Remove(sb.Length - 1, 1);
            sb.Append(") VALUES (");
            foreach(SqlInsertElement s in listSqlInsertElement)
            {
                if (s.CheckBox.Checked)
                {
                    sb.Append("@" + s.Column);
                    sb.Append(",");
                }
            }
            sb.Remove(sb.Length - 1, 1);
            sb.Append(")");

            String sql = sb.ToString();

            try
            {
                using (SqlConnection connection = new SqlConnection(MainForm.builder.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        foreach (SqlInsertElement s in listSqlInsertElement)
                        {
                            command.Parameters.AddWithValue("@"+s.Column,s.TextBox.Text);
                        }
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                MessageBox.Show("Data successfully inserted.");
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
                    //startLoginForm();
                }
                else
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
