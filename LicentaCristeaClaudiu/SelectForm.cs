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
    public partial class SelectForm : Form
    {
        private SqlSelectCreator sqlSelectCreator;
        private String[] aggregatorCommands = { "COUNT", "AVG", "SUM", "MIN", "MAX" };
        private ISqlCommand parentForm;

        public SelectForm()
        {
            InitializeComponent();
            comboBoxAggregator.DataSource = aggregatorCommands;
            List<String> comparatorList = new List<String>();
            fillComparatorList(comparatorList);
            listBoxComparator.DataSource = comparatorList;

            this.sqlSelectCreator = new SqlSelectCreator();
            getTableList();  
        }

        public SelectForm(ISqlCommand parentForm)
        {
            InitializeComponent();
            comboBoxAggregator.DataSource = aggregatorCommands;
            List<String> comparatorList = new List<String>();
            fillComparatorList(comparatorList);
            listBoxComparator.DataSource = comparatorList;
            this.parentForm = parentForm;
            this.sqlSelectCreator = new SqlSelectCreator();
            getTableList();
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
                                listBoxTabela.Items.Add(sbDT.ToString());
                                listBoxTabela2.Items.Add(sbDT.ToString());
                                listBoxTabela3.Items.Add(sbDT.ToString());
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
                    MessageBox.Show("Incorrect login data.");
                }
                else
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void getSelectionList(ListBox lb, ListBox lb2)
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
                    String tableName= lb.SelectedItem.ToString();
                    tableName=tableName.Split('.')[1];
                    sb.Append("WHERE TABLE_NAME = '"+ tableName + "';");
                    String sql = sb.ToString();
                    lb2.Items.Clear();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dt.Load(reader);
                            lb2.Items.Add("*");
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
                    MessageBox.Show("Incorrect login data.");
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
                    MessageBox.Show("Incorrect login data.");
                }
                else
                {
                    MessageBox.Show(ex.ToString());
                }
            }
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
                parentForm.SetSqlCommand(sqlSelectCreator.ToString());
                this.Close();
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.ToString());
            }
            catch (InvalidOperationException ex)
            {
                if (MainForm.builder.ToString() == "")
                {
                    MessageBox.Show("Incorrect login data.");
                    //startLoginForm();
                }
                else
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            switch (e.TabPageIndex)
            {
                case 3:
                    comboBoxOrderBy.DataSource = null;
                    comboBoxOrderBy.DataBindings.Clear();
                    comboBoxOrderBy.DataSource = sqlSelectCreator.SelectList;
                    break;
                case 2:
                    comboBoxGroupBy.DataSource = null;
                    comboBoxGroupBy.DataBindings.Clear();
                    comboBoxGroupBy.DataSource = sqlSelectCreator.SelectList;
                    break;
            }
        }

        private void sqlSelectFormOK_Click(object sender, EventArgs e)
        {
            if (sqlSelectCreator.WhereList.Count > 0)
            {
                if (sqlSelectCreator.WhereList.Last().Equals("AND") || sqlSelectCreator.WhereList.Last().Equals("OR"))
                {
                    MessageBox.Show("Please add the next pair as well.");
                }
                else
                {
                    if (testCommand(sqlSelectCreator.ToString()))
                    {
                        sendSelectSQL();
                    }
                }
            }
            else
            {
                if (testCommand(sqlSelectCreator.ToString()))
                {
                    sendSelectSQL();
                }
            }
        }

        private void sqlSelectFormCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddSelectFrom_Click(object sender, EventArgs e)
        {
            if (!sqlSelectCreator.FromList.Contains(listBoxTabela.SelectedItem.ToString()))
            {
                sqlSelectCreator.FromList.Add(listBoxTabela.SelectedItem.ToString());
            }
            for (int i = 0; i < listBoxSelect.SelectedItems.Count; i++)
            {
                StringBuilder sb = new StringBuilder();
                if (checkBoxAggregator.Checked)
                {
                    sb.Append(comboBoxAggregator.SelectedItem.ToString() + "(");
                }                
                sb.Append(listBoxTabela.SelectedItem.ToString());
                sb.Append(".");
                sb.Append(listBoxSelect.SelectedItems[i].ToString());
                if (!sqlSelectCreator.SelectList.Contains(sb.ToString()))
                {
                    if (checkBoxAggregator.Checked)
                    {
                        sb.Append(")");
                    }
                    if (!String.Empty.Equals(textBoxAlias.Text))
                    {
                        sb.Append(" " + textBoxAlias.Text);
                    }
                    sqlSelectCreator.SelectList.Add(sb.ToString());
                }
                
            }
            listBoxSelect.ClearSelected();
            checkBoxAggregator.Checked = false;
            textBoxSQL.Text = sqlSelectCreator.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refreshCommand();
        }

        private void refreshCommand()
        {
            textBoxSQL.Text = sqlSelectCreator.ToString();
        }

        private void listBoxTabela_SelectedValueChanged(object sender, EventArgs e)
        {
            getSelectionList(listBoxTabela,listBoxSelect);
        }

        private void listBoxTabela2_SelectedValueChanged(object sender, EventArgs e)
        {
            getSelectionListNotAll(listBoxTabela2, listBoxSelect2);
        }

        private void listBoxTabela3_SelectedValueChanged(object sender, EventArgs e)
        {
            getSelectionListNotAll(listBoxTabela3, listBoxSelect3);
        }

        private void buttonAddCondition_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            NumberStringChecker nsc = new NumberStringChecker();
            if (radioButtonColumnInput.Checked)
            {
                sb.Append(listBoxTabela2.SelectedItem.ToString() + "." + listBoxSelect2.SelectedItem.ToString());
                sb.Append(getSelectedComparator());
                sb.Append(nsc.TransformIfString(textBoxWhereInput.Text.ToString()));
            }
            else
            {
                if (radioButtonColumnColumn.Checked)
                {
                    sb.Append(listBoxTabela2.SelectedItem.ToString() + "." + listBoxSelect2.SelectedItem.ToString());
                    sb.Append(getSelectedComparator());
                    sb.Append(listBoxTabela3.SelectedItem.ToString() + "." + listBoxSelect3.SelectedItem.ToString());
                }
            }
            String s = sb.ToString();
            sqlSelectCreator.WhereList.Add(s);
            textBoxSQL.Text = sqlSelectCreator.ToString();
        }

        private void buttonNewCommand_Click(object sender, EventArgs e)
        {
            this.sqlSelectCreator.ClearAllCommands();
            textBoxSQL.Clear();
        }

        private void buttonAndCondition_Click(object sender, EventArgs e)
        {
            if (sqlSelectCreator.WhereList.Count > 0)
            {
                if (sqlSelectCreator.WhereList.Last().Equals("AND") || sqlSelectCreator.WhereList.Last().Equals("OR"))
                {
                    MessageBox.Show("You cannot add another logical operator! The previous one is not connected to another condition.");
                }
                else
                {
                    if (sqlSelectCreator.WhereList.Count > 0)
                    {
                        sqlSelectCreator.WhereList.Add("AND");
                        textBoxSQL.Text = sqlSelectCreator.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Please add a condition before.");
                    }
                }
            }
            
            
        }

        private void buttonOrCondition_Click(object sender, EventArgs e)
        {
            if (sqlSelectCreator.WhereList.Count > 0)
            {
                if (sqlSelectCreator.WhereList.Last().Equals("AND") || sqlSelectCreator.WhereList.Last().Equals("OR"))
                {
                    MessageBox.Show("You cannot add another logical operator! The previous one is not connected to another condition.");
                }
                else
                {
                    if (sqlSelectCreator.WhereList.Count > 0)
                    {
                        sqlSelectCreator.WhereList.Add("OR");
                        textBoxSQL.Text = sqlSelectCreator.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Va rugăm să adăugați o condiție înainte.");
                    }
                }
            }
        }

        private void buttonAddOrderBy_Click(object sender, EventArgs e)
        {
            OrderBySqlComponent component = new OrderBySqlComponent();
            if (!String.IsNullOrEmpty(comboBoxOrderBy.SelectedItem.ToString()))
            {
                component.Column = comboBoxOrderBy.SelectedItem.ToString();
                if (radioButtonOrderByAsc.Checked)
                {
                    component.IsAscendent = true;
                }
                else
                {
                    component.IsAscendent = false;
                }
                sqlSelectCreator.OrderByList.Add(component);
                textBoxSQL.Text = sqlSelectCreator.ToString();
            }
            else
            {
                MessageBox.Show("You have not selected an ordering criteria selected!");
            }
        }

        private void buttonAddGroupBy_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(comboBoxGroupBy.SelectedItem.ToString()))
            {
                sqlSelectCreator.GroupByList.Add(comboBoxGroupBy.SelectedItem.ToString());
                textBoxSQL.Text = sqlSelectCreator.ToString();
            }
            else
            {
                MessageBox.Show("You have not selected a grouping criteria.");
            }
        }

        private Boolean testCommand(String sqlCommand)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(MainForm.builder.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sqlCommand, connection))
                    {
                        var test = command.ExecuteScalar();
                    }
                    connection.Close();
                    MessageBox.Show("Command tested successfully!");
                    return true;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            catch (InvalidOperationException ex)
            {
                if (MainForm.builder.ToString() == "")
                {
                    MessageBox.Show("Incorrect login data.");
                    return false;
                }
                else
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
        }

        private void buttonTestCommand_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(MainForm.builder.ConnectionString))
                {
                    connection.Open();
                    String sql= sqlSelectCreator.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        var test = command.ExecuteScalar();
                    }
                    connection.Close();
                    MessageBox.Show("Command executed successfully!");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                if (MainForm.builder.ToString() == "")
                {
                    MessageBox.Show("Incorrect login data.");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void listViewDeleteSelection_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                for (int i = listViewDeleteSelection.Items.Count - 1; i >=0; i--)
                {
                    if (listViewDeleteSelection.Items[i].Selected)
                    {
                        sqlSelectCreator.SelectList.RemoveAt(i);
                    }
                }
                fillListViewDeleteSelection();
                refreshCommand();
            }
        }

        private void fillListViewDeleteSelection()
        {
            listViewDeleteSelection.Items.Clear();
            foreach (String s in sqlSelectCreator.SelectList)
            {
                listViewDeleteSelection.Items.Add(new ListViewItem(s));
            }
        }

        private void fillListViewDeleteConditions()
        {
            listViewDeleteConditions.Items.Clear();
            foreach (String s in sqlSelectCreator.WhereList)
            {
                listViewDeleteConditions.Items.Add(new ListViewItem(s));
            }
        }

        private void fillListViewDeleteGroups()
        {
            listViewDeleteGroups.Items.Clear();
            foreach (String s in sqlSelectCreator.GroupByList)
            {
                listViewDeleteGroups.Items.Add(new ListViewItem(s));
            }
        }

        private void fillListViewDeleteOrdering()
        {
            listViewDeleteOrdering.Items.Clear();
            foreach (OrderBySqlComponent o in sqlSelectCreator.OrderByList)
            {
                listViewDeleteOrdering.Items.Add(new ListViewItem(o.ToString()));
            }
        }

        private void tabControlSelect_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControlSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillListViewDeleteSelection();
            fillListViewDeleteConditions();
            fillListViewDeleteGroups();
            fillListViewDeleteOrdering();
        }

        private void listViewDeleteConditions_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                for (int i = listViewDeleteConditions.Items.Count - 1; i >= 0; i--)
                {
                    if (listViewDeleteConditions.Items[i].Selected)
                    {
                        sqlSelectCreator.WhereList.RemoveAt(i);
                    }
                }
                fillListViewDeleteConditions();
                refreshCommand();
            }
        }

        private void listViewDeleteGroups_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                for (int i = listViewDeleteGroups.Items.Count - 1; i >= 0; i--)
                {
                    if (listViewDeleteGroups.Items[i].Selected)
                    {
                        sqlSelectCreator.GroupByList.RemoveAt(i);
                    }
                }
                fillListViewDeleteGroups();
                refreshCommand();
            }
        }

        private void listViewDeleteOrdering_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                for (int i = listViewDeleteOrdering.Items.Count - 1; i >= 0; i--)
                {
                    if (listViewDeleteOrdering.Items[i].Selected)
                    {
                        sqlSelectCreator.OrderByList.RemoveAt(i);
                    }
                }
                fillListViewDeleteOrdering();
                refreshCommand();
            }
        }
    }
}

