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
    public partial class UpdateForm : Form
    {
        private List<SqlInsertElement> listSqlInsertElement;
        private LoginHelper loginHelper;
        private SqlUpdateWhereCreator sqlUpdateWhereCreator;

        public UpdateForm()
        {
            InitializeComponent();
            this.loginHelper = new LoginHelper();
            this.listSqlInsertElement = new List<SqlInsertElement>();
            this.sqlUpdateWhereCreator = new SqlUpdateWhereCreator();
            List<String> comparatorList = new List<String>();
            fillComparatorList(comparatorList);
            listBoxComparator.DataSource = comparatorList;
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
                                    comboBoxUpdateTable.Items.Add(sbDT.ToString());
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
                    loginHelper.StartLoginForm();
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
                                s.Column = dt.Rows[i][0].ToString();
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
                                lb.Text += ", " + dt.Rows[i][2].ToString();
                                s.DataType = dt.Rows[i][2].ToString();
                                lb.Text += ", Max characters/number: " + dt.Rows[i][3].ToString();
                                lb.Location = new Point(30, 50 + i * 50);
                                s.CheckBox = lb;

                                TextBox tb = new TextBox();
                                tb.Name = "TextBox" + i;
                                tb.Width = 200;
                                tb.Location = new Point(30, 75 + i * 50);
                                //tb.Anchor = AnchorStyles.Right;
                                s.TextBox = tb;
                                this.tabPage1.Controls.Add(s.CheckBox);
                                this.tabPage1.Controls.Add(s.TextBox);
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
                    MessageBox.Show("Incorrect login data!");
                    loginHelper.StartLoginForm();
                }
                else
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void getSelectionListConditions(ListBox lb)
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
                    String tableName = comboBoxUpdateTable.SelectedItem.ToString();
                    tableName = tableName.Split('.')[1];
                    sb.Append("WHERE TABLE_NAME = '" + tableName + "';");
                    String sql = sb.ToString();
                    lb.Items.Clear();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dt.Load(reader);
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                lb.Items.Add(dt.Rows[i][0].ToString());
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
                    MessageBox.Show("Incorrect login data!");
                    loginHelper.StartLoginForm();
                }
                else
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void removeInsertElements()
        {
            foreach (SqlInsertElement s in listSqlInsertElement)
            {
                this.tabPage1.Controls.Remove(s.CheckBox);
                this.tabPage1.Controls.Remove(s.TextBox);
            }
            listSqlInsertElement.Clear();
        }

        private void fillComparatorList(List<String> list)
        {
            list.Clear();
            list.Add("Equal to");
            list.Add("Not equal to");
            list.Add("Greater than");
            list.Add("Lesser than");
            list.Add("Greater or equal than");
            list.Add("Lesser or equal than");
        }

        private String getSelectedComparator()
        {
            String s;
            switch (listBoxComparator.SelectedItem.ToString())
            {
                case "Equal to":
                    s = "=";
                    break;
                case "Not equal to":
                    s = "<>";
                    break;
                case "Greater than":
                    s = ">";
                    break;
                case "Lesser than":
                    s = "<";
                    break;
                case "Greater or equal than":
                    s = ">=";
                    break;
                case "Lesser or equal than":
                    s = "<=";
                    break;
                default:
                    s = "=";
                    break;
            }
            return s;
        }


        private void comboBoxUpdateTable_SelectionChangeCommitted(object sender, EventArgs e)
        {
            removeInsertElements();
            getSelectionListNotAll(comboBoxUpdateTable);
            getSelectionListConditions(listBoxSelect2);
            sqlUpdateWhereCreator.ConditionList.Clear();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Update ");
            sb.Append(comboBoxUpdateTable.SelectedItem.ToString());
            sb.Append(" Set ");
            foreach (SqlInsertElement s in listSqlInsertElement)
            {
                if (s.CheckBox.Checked)
                {
                    sb.Append(s.Column);
                    sb.Append(" = ");
                    sb.Append("@" + s.Column);
                    sb.Append(",");
                }
            }
            sb.Remove(sb.Length - 1, 1);

            if (sqlUpdateWhereCreator.ConditionList.Count > 0)
            {
                sb.Append(" ");
                sb.Append(sqlUpdateWhereCreator.ToString());
            }
            
            String sql = sb.ToString();

            try
            {
                using (SqlConnection connection = new SqlConnection(MainForm.builder.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        foreach (SqlInsertElement s in listSqlInsertElement)
                        {
                            command.Parameters.AddWithValue("@" + s.Column, s.TextBox.Text);
                        }

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                        sqlUpdateWhereCreator.ConditionList.Clear();
                        MessageBox.Show("Data successfully updated.");
                    }
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
                    //startLoginForm();
                }
                else
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void buttonOrCondition_Click(object sender, EventArgs e)
        {
            if (sqlUpdateWhereCreator.ConditionList.Count > 0)
            {
                if (sqlUpdateWhereCreator.ConditionList.Last().Equals("AND") || sqlUpdateWhereCreator.ConditionList.Last().Equals("OR"))
                {
                    MessageBox.Show("You cannot add another logical operator! The previous one is not connected to another condition.");
                }
                else
                {
                    if (sqlUpdateWhereCreator.ConditionList.Count > 0)
                    {
                        sqlUpdateWhereCreator.ConditionList.Add("OR");
                    }
                    else
                    {
                        MessageBox.Show("Please add a condition before.");
                    }
                }
            }
        }

        private void buttonAndCondition_Click(object sender, EventArgs e)
        {
            if (sqlUpdateWhereCreator.ConditionList.Count > 0)
            {
                if (sqlUpdateWhereCreator.ConditionList.Last().Equals("AND") || sqlUpdateWhereCreator.ConditionList.Last().Equals("OR"))
                {
                    MessageBox.Show("You cannot add another logical operator! The previous one is not connected to another condition.");
                }
                else
                {
                    if (sqlUpdateWhereCreator.ConditionList.Count > 0)
                    {
                        sqlUpdateWhereCreator.ConditionList.Add("AND");
                    }
                    else
                    {
                        MessageBox.Show("Please add a condition before.");
                    }
                }
            }
        }

        private void buttonAddCondition_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            NumberStringChecker nsc = new NumberStringChecker();
            sb.Append(listBoxSelect2.SelectedItem.ToString());
            sb.Append(getSelectedComparator());
            sb.Append(nsc.TransformIfString(textBoxWhereInput.Text.ToString()));
            String s = sb.ToString();
            sqlUpdateWhereCreator.ConditionList.Add(s);
            textBoxWhereInput.Clear();
            MessageBox.Show("Condition added.");
        }

        private void listBoxTabela2_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}
