using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace LicentaCristeaClaudiu
{
    public class GraphHelper
    {
        private Chart chart;
        int width;
        int height;
        int xValue;
        int yValue;
        SeriesChartType seriesChartType;
        String path;

        public GraphHelper()
        {
            this.chart = new Chart();
        }

        public GraphHelper(int width, int height, int xValue, int yValue)
        {
            this.chart = new Chart();
            this.width = width;
            this.height = height;
            this.xValue = xValue;
            this.yValue = yValue;
        }

        public string Path
        {
            get
            {
                return path;
            }

            set
            {
                path = value;
            }
        }

        public String GenerateChart(ReportItem reportItem, DataTable dataTable)
        {
            chart.Width = width;
            chart.Height = height;
            seriesChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            if (chart.Series.Count==0)
            {
                chart.Series.Add("Series 1");
            }
            chart.DataSource = dataTable;
            //chart.Series[0] = new Series("Series");
            chart.Series[0].XValueMember = dataTable.Columns[xValue].ColumnName;
            chart.Series[0].YValueMembers = dataTable.Columns[yValue].ColumnName;
            chart.Series[0].ChartType = seriesChartType;

            var renderChart = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            chart.ChartAreas.Add(renderChart);
            chart.DataBind();

            String imageLocation = path + "/" + reportItem.ReportItemName + ".png";
            chart.SaveImage(imageLocation, ChartImageFormat.Png);
            return imageLocation;
        }
    }
}
