using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LicentaCristeaClaudiu
{
    public class ReportItem
    {
        String reportItemName;
        String sqlSelectCommand;
        Boolean hasOutput;
        List<EStatistics> listStatistics;
        StringBuilder itemStringBuilder;
        GraphHelper graphHelper;

        DataTable table;

        public ReportItem()
        {
            this.reportItemName = String.Empty;
            this.sqlSelectCommand = String.Empty;
            this.hasOutput = false;
            listStatistics = new List<EStatistics>();
            this.itemStringBuilder = new StringBuilder();
            this.table = new DataTable();
        }

        public ReportItem(String reportItemName, String sqlSelectCommand, Boolean output)
        {
            this.reportItemName = reportItemName;
            this.sqlSelectCommand = sqlSelectCommand;
            this.hasOutput = output;
            listStatistics = new List<EStatistics>();
            this.itemStringBuilder = new StringBuilder();
            this.table = new DataTable();
            this.graphHelper = new GraphHelper();
        }

        public string ReportItemName
        {
            get
            {
                return reportItemName;
            }

            set
            {
                reportItemName = value;
            }
        }

        public string SqlSelectCommand
        {
            get
            {
                return sqlSelectCommand;
            }

            set
            {
                sqlSelectCommand = value;
            }
        }

        public bool isOutput
        {
            get
            {
                return hasOutput;
            }

            set
            {
                hasOutput = value;
            }
        }

        public List<EStatistics> ListStatistics
        {
            get
            {
                return listStatistics;
            }

            set
            {
                listStatistics = value;
            }
        }

        public GraphHelper GraphHelper
        {
            get
            {
                return graphHelper;
            }

            set
            {
                graphHelper = value;
            }
        }

        public void RunCommands()
        {
            if (RunSqlSelectCommand(sqlSelectCommand))
            {
                //itemStringBuilder.Clear();
                if (hasOutput)
                {
                    OutputCommand(table);
                }
                StatisticsHelper statisticsHelper = new StatisticsHelper(table);
                foreach (EStatistics ess in listStatistics)
                {
                    switch (ess)
                    {
                        case EStatistics.DescriptiveStatistics:
                            itemStringBuilder.AppendLine("<p>Descriptive Statistics</p>");
                            OutputCommand(statisticsHelper.OutputDescriptiveStatistics());
                            break;
                        case EStatistics.DescriptiveStatisticsPopulation:
                            itemStringBuilder.AppendLine("<p>Descriptive Statistics for Population</p>");
                            OutputCommand(statisticsHelper.OutputDescriptiveStatisticsPopulation());
                            break;
                        case EStatistics.Correlation:
                            itemStringBuilder.AppendLine("<p>Correlation</p>");
                            OutputCommand(statisticsHelper.OutputCorrelation());
                            break;
                    }
                }
                if (this.graphHelper != null)
                {
                    //graphHelper = new GraphHelper(this, table, 1, 0, System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie, 1280, 960);
                    String path = graphHelper.GenerateChart(this, table);
                    itemStringBuilder.AppendLine("<img src='" + path + "' alt='" + this.reportItemName + "'>");
                }
                
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("There was an error while generating the report for item {0}",this.reportItemName);
            }
            
        } 

        private Boolean RunSqlSelectCommand(String sql)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(MainForm.builder.ConnectionString))
                {
                    connection.Open();
                    
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sql, connection))
                    {
                        adapter.Fill(table);
                    }
                    connection.Close();
                }
                return true;
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
            catch (InvalidOperationException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void OutputCommand(DataTable outputTable)
        {

            itemStringBuilder.AppendLine("<table border='1'>");
            itemStringBuilder.AppendLine("<tr>");
            for (int j = 0; j < outputTable.Columns.Count; j++)
            {
                itemStringBuilder.AppendLine("<th>" + outputTable.Columns[j].ColumnName.ToString() + "</th>");
            }
            itemStringBuilder.AppendLine("</tr>");

            for (int i = 0; i < outputTable.Rows.Count; i++)
            {
                itemStringBuilder.AppendLine("<tr>");
                for (int j = 0; j < outputTable.Columns.Count; j++)
                {
                    itemStringBuilder.AppendLine("<td>" + outputTable.Rows[i][j].ToString() + "</td>");
                }
                itemStringBuilder.AppendLine("</tr>");
            }
            itemStringBuilder.AppendLine("</table>");
        }

        public string GenerateItemReport() 
        {
            itemStringBuilder.Clear();
            itemStringBuilder.AppendLine("<div>");
            itemStringBuilder.AppendLine("<h2>"+this.reportItemName+"</h2>");
            RunCommands();
            itemStringBuilder.AppendLine("</div>");
            return itemStringBuilder.ToString();
        }
    }
}
