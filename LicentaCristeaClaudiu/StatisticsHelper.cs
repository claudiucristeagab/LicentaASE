using MathNet.Numerics.Statistics;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LicentaCristeaClaudiu
{
    class StatisticsHelper
    {
        private DataGridView dataGridView;
        private DataTable dataTable;

        public StatisticsHelper (DataGridView dataGridView)
        {
            this.dataGridView = dataGridView;
        }

        public StatisticsHelper(DataTable dataTable)
        {
            this.dataTable = dataTable;
        }

        public void DescriptiveStatistics(DataGridView dataGridViewStatistics)
        {
            NumberStringChecker nsc = new NumberStringChecker();
            DataTable descriptiveStatisticsDataTable = new DataTable("Descriptive Statistics");

            DataColumn nameDataColumn = new DataColumn("Name");
            DataColumn sizeDataColumn = new DataColumn("Size");
            DataColumn maximumDataColumn = new DataColumn("Maximum");
            DataColumn minimumDataColumn = new DataColumn("Minimum");
            DataColumn meanDataColumn = new DataColumn("Mean");
            DataColumn medianDataColumn = new DataColumn("Median");
            DataColumn varianceDataColumn = new DataColumn("Variance");
            DataColumn standardDeviationDataColumn = new DataColumn("StandardDeviation");
            DataColumn kurtosisDataColumn = new DataColumn("Kurtosis");
            DataColumn skewnessDataColumn = new DataColumn("Skewness");

            descriptiveStatisticsDataTable.Columns.Add(nameDataColumn);
            descriptiveStatisticsDataTable.Columns.Add(sizeDataColumn);
            descriptiveStatisticsDataTable.Columns.Add(maximumDataColumn);
            descriptiveStatisticsDataTable.Columns.Add(minimumDataColumn);
            descriptiveStatisticsDataTable.Columns.Add(meanDataColumn);
            descriptiveStatisticsDataTable.Columns.Add(medianDataColumn);
            descriptiveStatisticsDataTable.Columns.Add(varianceDataColumn);
            descriptiveStatisticsDataTable.Columns.Add(standardDeviationDataColumn);
            descriptiveStatisticsDataTable.Columns.Add(kurtosisDataColumn);
            descriptiveStatisticsDataTable.Columns.Add(skewnessDataColumn);

            for (int j = 0; j < dataGridView.ColumnCount; j++)
            {
                List<double> list = new List<double>();
                //verifica daca elem initial al coloanei e numeric
                if (!nsc.IsString(dataGridView.Rows[0].Cells[j].Value.ToString()))
                {
                    for (int i = 0; i < dataGridView.Rows.Count; i++)
                    {
                        String s = dataGridView.Rows[i].Cells[j].Value.ToString();
                        Double d = 0;
                        //adauga in lista doar daca celula poate fi convertita la double
                        if (Double.TryParse(s, out d))
                        {
                            list.Add(d);
                        }
                    }

                    DataRow dataRow = descriptiveStatisticsDataTable.NewRow();

                    dataRow["Name"] = dataGridView.Columns[j].Name.ToString();
                    dataRow["Size"] = list.Count();

                    double maximum = Statistics.Maximum(list);
                    double minimum = Statistics.Minimum(list);
                    double mean = Statistics.Mean(list);
                    double median = Statistics.Median(list);
                    double variance = Statistics.Variance(list);
                    double standardDeviation = Statistics.StandardDeviation(list);
                    double kurtosis = Statistics.Kurtosis(list);
                    double skewness = Statistics.Skewness(list);

                    dataRow["Maximum"] = maximum;
                    dataRow["Minimum"] = minimum;
                    dataRow["Mean"] = mean;
                    dataRow["Median"] = median;
                    dataRow["Variance"] = variance;
                    dataRow["StandardDeviation"] = standardDeviation;
                    dataRow["Kurtosis"] = kurtosis;
                    dataRow["Skewness"] = skewness;
                    descriptiveStatisticsDataTable.Rows.Add(dataRow);
                    list.Clear();
                }
            }
            dataGridViewStatistics.DataSource = null;
            dataGridViewStatistics.DataSource = descriptiveStatisticsDataTable;
        }

        public void DescriptiveStatisticsPopulation(DataGridView dataGridViewStatistics)
        {
            NumberStringChecker nsc = new NumberStringChecker();
            DataTable descriptiveStatisticsDataTable = new DataTable("Descriptive Statistics");

            DataColumn nameDataColumn = new DataColumn("Name");
            DataColumn sizeDataColumn = new DataColumn("Size");
            DataColumn maximumDataColumn = new DataColumn("Maximum");
            DataColumn minimumDataColumn = new DataColumn("Minimum");
            DataColumn meanDataColumn = new DataColumn("Mean");
            DataColumn medianDataColumn = new DataColumn("Median");
            DataColumn varianceDataColumn = new DataColumn("Variance");
            DataColumn standardDeviationDataColumn = new DataColumn("StandardDeviation");
            DataColumn kurtosisDataColumn = new DataColumn("Kurtosis");
            DataColumn skewnessDataColumn = new DataColumn("Skewness");

            descriptiveStatisticsDataTable.Columns.Add(nameDataColumn);
            descriptiveStatisticsDataTable.Columns.Add(sizeDataColumn);
            descriptiveStatisticsDataTable.Columns.Add(maximumDataColumn);
            descriptiveStatisticsDataTable.Columns.Add(minimumDataColumn);
            descriptiveStatisticsDataTable.Columns.Add(meanDataColumn);
            descriptiveStatisticsDataTable.Columns.Add(medianDataColumn);
            descriptiveStatisticsDataTable.Columns.Add(varianceDataColumn);
            descriptiveStatisticsDataTable.Columns.Add(standardDeviationDataColumn);
            descriptiveStatisticsDataTable.Columns.Add(kurtosisDataColumn);
            descriptiveStatisticsDataTable.Columns.Add(skewnessDataColumn);

            for (int j = 0; j < dataGridView.ColumnCount; j++)
            {
                List<double> list = new List<double>();
                //verifica daca elem initial al coloanei e numeric
                if (!nsc.IsString(dataGridView.Rows[0].Cells[j].Value.ToString()))
                {
                    for (int i = 0; i < dataGridView.Rows.Count; i++)
                    {
                        String s = dataGridView.Rows[i].Cells[j].Value.ToString();
                        Double d = 0;
                        //adauga in lista doar daca celula poate fi convertita la double
                        if (Double.TryParse(s, out d))
                        {
                            list.Add(d);
                        }
                    }

                    DataRow dataRow = descriptiveStatisticsDataTable.NewRow();

                    dataRow["Name"] = dataGridView.Columns[j].Name.ToString();
                    dataRow["Size"] = list.Count();

                    double maximum = Statistics.Maximum(list);
                    double minimum = Statistics.Minimum(list);
                    double mean = Statistics.Mean(list);
                    double median = Statistics.Median(list);
                    double variance = Statistics.PopulationVariance(list);
                    double standardDeviation = Statistics.PopulationStandardDeviation(list);
                    double kurtosis = Statistics.PopulationKurtosis(list);
                    double skewness = Statistics.PopulationSkewness(list);

                    dataRow["Maximum"] = maximum;
                    dataRow["Minimum"] = minimum;
                    dataRow["Mean"] = mean;
                    dataRow["Median"] = median;
                    dataRow["Variance"] = variance;
                    dataRow["StandardDeviation"] = standardDeviation;
                    dataRow["Kurtosis"] = kurtosis;
                    dataRow["Skewness"] = skewness;
                    descriptiveStatisticsDataTable.Rows.Add(dataRow);
                    list.Clear();
                }
            }
            dataGridViewStatistics.DataSource = null;
            dataGridViewStatistics.DataSource = descriptiveStatisticsDataTable;
        }

        public void Correlation(DataGridView dataGridViewStatistics)
        {
            NumberStringChecker nsc = new NumberStringChecker();
            List<List<double>> listOfLists = new List<List<double>>();

            DataTable correlationDataTable = new DataTable("Correlation");

            for (int j = 0; j < dataGridView.ColumnCount; j++)
            {
                List<double> list = new List<double>();
                //verifica daca elem initial al coloanei e numeric
                if (!nsc.IsString(dataGridView.Rows[0].Cells[j].Value.ToString()))
                {
                    for (int i = 0; i < dataGridView.Rows.Count; i++)
                    {
                        String s = dataGridView.Rows[i].Cells[j].Value.ToString();
                        Double d = 0;
                        //adauga in lista doar daca celula poate fi convertita la double
                        if (Double.TryParse(s, out d))
                        {
                            list.Add(d);
                        }
                    }
                    listOfLists.Add(list);
                    DataColumn nameDataColumn = new DataColumn(dataGridView.Columns[j].Name.ToString());
                    correlationDataTable.Columns.Add(nameDataColumn);
                }
            }

            double[][] matrix = new double[listOfLists.Count][];
            
            for(int increment =0; increment<listOfLists.Count;increment++)
            {
                matrix[increment] = listOfLists[increment].ToArray();
            }
            listOfLists.Clear();

            //verific daca matricea e simetrica
            Boolean isSymmetricMatrix = true;
            int numberElementsFirstRow = matrix[0].ToArray().Length;
            for (int increment = 0; increment < matrix.Length && isSymmetricMatrix == true; increment++)
            {
                if (matrix[increment].Length != numberElementsFirstRow)
                {
                    isSymmetricMatrix = false;
                }
            }

            if (isSymmetricMatrix)
            {
                var corr = MathNet.Numerics.Statistics.Correlation.SpearmanMatrix(matrix);

                for (int increment = 0; increment < corr.ColumnCount; increment++)
                {
                    DataRow dataRow = correlationDataTable.NewRow();
                    for (int increment2 = 0; increment2 < corr.RowCount; increment2++)
                    {
                        dataRow[increment2] = corr[increment2, increment];
                    }
                    correlationDataTable.Rows.Add(dataRow);
                }
                dataGridViewStatistics.DataSource = null;
                dataGridViewStatistics.DataSource = correlationDataTable;
                dataGridViewStatistics.RowHeadersWidth = 150;
                for (int i = 0; i < dataGridViewStatistics.RowCount; i++)
                {
                    dataGridViewStatistics.Rows[i].HeaderCell.Value= dataGridView.Columns[i].Name.ToString();
                }
            }
            else
            {
                MessageBox.Show("Data is invalid.");
            }
        }

        public void LinearRegressionSimple(DataGridView dataGridViewStatistics, int[] columns)
        {
            NumberStringChecker nsc = new NumberStringChecker();
            List<double> listX = new List<double>();
            List<double> listY = new List<double>();

            for (int j = 0; j < columns.Length && columns.Length == 2 && dataGridView.Columns.Count>=2; j++ )
            {
                int selectedColumn = columns[j];
                if (!nsc.IsString(dataGridView.Rows[0].Cells[selectedColumn].Value.ToString()))
                {
                    for (int i = 0; i < dataGridView.Rows.Count; i++)
                    {
                        String s = dataGridView.Rows[i].Cells[selectedColumn].Value.ToString();
                        Double d = 0;
                        if (Double.TryParse(s, out d))
                        {
                            if (selectedColumn == columns[0])
                            {
                                listX.Add(d);
                            }
                            else if (selectedColumn == columns[1])
                            {
                                listY.Add(d);
                            }  
                        }
                    }
                }
            }

            double[] xdata = listX.ToArray();
            listX.Clear();
            double[] ydata = listY.ToArray();
            listY.Clear();
            if (xdata.Length == ydata.Length)
            {
                Tuple<double, double> t = MathNet.Numerics.LinearRegression.SimpleRegression.Fit(xdata, ydata);
                double a = t.Item1;
                double b = t.Item2;
                
                Console.WriteLine("y = {0} + {1} * x", a, b);

                DataTable linearRegressionDataTable = new DataTable("Linear regression");

                DataColumn nameDataColumn = new DataColumn("Name");
                DataColumn sizeDataColumn = new DataColumn("Size");
                DataColumn interceptDataColumn = new DataColumn("Intercept");
                DataColumn slopeDataColumn = new DataColumn("Slope");

                linearRegressionDataTable.Columns.Add(nameDataColumn);
                linearRegressionDataTable.Columns.Add(sizeDataColumn);
                linearRegressionDataTable.Columns.Add(interceptDataColumn);
                linearRegressionDataTable.Columns.Add(slopeDataColumn);

                DataRow dataRow = linearRegressionDataTable.NewRow();
                dataRow["Name"] = dataGridView.Columns[columns[0]].Name.ToString() + " " + dataGridView.Columns[columns[1]].Name.ToString();
                dataRow["Size"] = xdata.Length;
                dataRow["Intercept"] = a;
                dataRow["Slope"] = b;
                linearRegressionDataTable.Rows.Add(dataRow);

                dataGridViewStatistics.DataSource = null;
                dataGridViewStatistics.DataSource = linearRegressionDataTable;
            }
            else
            {
                MessageBox.Show("Simple regression failed.");
            }
        }

        public void Extrapolation(DataGridView dataGridViewStatistics, int selectedColumn, int nrOfPredictions)
        {
            NumberStringChecker nsc = new NumberStringChecker();
            List<double> listX = new List<double>();
            List<double> listY = new List<double>();
            if (!nsc.IsString(dataGridView.Rows[0].Cells[selectedColumn].Value.ToString()))
            {
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    String s = dataGridView.Rows[i].Cells[selectedColumn].Value.ToString();
                    Double d = 0;
                    if (Double.TryParse(s, out d))
                    {
                        listY.Add(d);
                    }
                }
            }
            double[] xdata = new double[dataGridView.Rows.Count];
            for (int i = 0; i < xdata.Length; i++)
            {
                xdata[i] = i+1;
            }
            listX.Clear();
            double[] ydata = listY.ToArray();
            listY.Clear();
            if (xdata.Length == ydata.Length)
            {
                Tuple<double, double> t = MathNet.Numerics.LinearRegression.SimpleRegression.Fit(xdata, ydata);
                double a = t.Item1;
                double b = t.Item2;

                Console.WriteLine("y = {0} + {1} * x", a, b);

                DataTable extrapolationDataTable = new DataTable("Extrapolation");

                DataColumn numberDataColumn = new DataColumn("Number");
                DataColumn valueDataColumn = new DataColumn("Value");
                DataColumn extrapolatedDataColumn = new DataColumn("Extrapolated");

                extrapolationDataTable.Columns.Add(numberDataColumn);
                extrapolationDataTable.Columns.Add(valueDataColumn);
                extrapolationDataTable.Columns.Add(extrapolatedDataColumn);

                for (int i = 0; i < xdata.Length + nrOfPredictions; i++)
                {
                    if (i < xdata.Length)
                    {
                        DataRow dataRow = extrapolationDataTable.NewRow();
                        dataRow["Number"] = xdata[i];
                        dataRow["Value"] = ydata[i];
                        extrapolationDataTable.Rows.Add(dataRow);
                    }
                    else
                    {
                        DataRow dataRow = extrapolationDataTable.NewRow();
                        dataRow["Number"] = i + 1;
                        dataRow["Value"] = a + b * (i + 1);
                        dataRow["Extrapolated"] = "Yes";
                        extrapolationDataTable.Rows.Add(dataRow);
                    }
                    
                }
                dataGridViewStatistics.DataSource = null;
                dataGridViewStatistics.DataSource = extrapolationDataTable;
            }
            else
            {
                MessageBox.Show("Extrapolation failed.");
            }
        }

        public void OneWayFrequency(DataGridView dataGridViewStatistics, int selectedColumn)
        {
            NumberStringChecker nsc = new NumberStringChecker();
            List<String> listOfUniqueValues = new List<String>();
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (!listOfUniqueValues.Contains(dataGridView.Rows[i].Cells[selectedColumn].Value.ToString()))
                {
                    listOfUniqueValues.Add(dataGridView.Rows[i].Cells[selectedColumn].Value.ToString());
                }
            }
            
            int numberOfValues = dataGridView.Rows.Count;

            DataTable oneWayFreqDataTable = new DataTable("One-Way Frequency");
            DataColumn columnDataColumn = new DataColumn(dataGridView.Columns[selectedColumn].Name.ToString());
            DataColumn frequencyDataColumn = new DataColumn("Frequency");
            DataColumn percentDataColumn = new DataColumn("Percent");
            DataColumn cumulativePercentDataColumn = new DataColumn("Cumulative Percent");
            oneWayFreqDataTable.Columns.Add(columnDataColumn);
            oneWayFreqDataTable.Columns.Add(frequencyDataColumn);
            oneWayFreqDataTable.Columns.Add(percentDataColumn);
            oneWayFreqDataTable.Columns.Add(cumulativePercentDataColumn);

            double cumulativePercent = 0;
            foreach (String value in listOfUniqueValues)
            {
                DataRow dataRow = oneWayFreqDataTable.NewRow();
                double count = 0;
                for (int i = 0; i< dataGridView.Rows.Count; i++)
                {
                    if (dataGridView.Rows[i].Cells[selectedColumn].Value.ToString().Equals(value))
                    {
                        count++;
                    }
                }
                dataRow[dataGridView.Columns[selectedColumn].Name.ToString()] = value;
                dataRow["Frequency"] = count;
                dataRow["Percent"] = Math.Round(count / numberOfValues * 100,2);
                cumulativePercent += count / numberOfValues * 100;
                dataRow["Cumulative Percent"] = Math.Round(cumulativePercent,2);
                oneWayFreqDataTable.Rows.Add(dataRow);
            }

            dataGridViewStatistics.DataSource = null;
            dataGridViewStatistics.DataSource = oneWayFreqDataTable;
        }

        public DataTable OutputDescriptiveStatistics()
        {
            NumberStringChecker nsc = new NumberStringChecker();
            DataTable descriptiveStatisticsDataTable = new DataTable("Descriptive Statistics");

            DataColumn nameDataColumn = new DataColumn("Name");
            DataColumn sizeDataColumn = new DataColumn("Size");
            DataColumn maximumDataColumn = new DataColumn("Maximum");
            DataColumn minimumDataColumn = new DataColumn("Minimum");
            DataColumn meanDataColumn = new DataColumn("Mean");
            DataColumn medianDataColumn = new DataColumn("Median");
            DataColumn varianceDataColumn = new DataColumn("Variance");
            DataColumn standardDeviationDataColumn = new DataColumn("StandardDeviation");
            DataColumn kurtosisDataColumn = new DataColumn("Kurtosis");
            DataColumn skewnessDataColumn = new DataColumn("Skewness");

            descriptiveStatisticsDataTable.Columns.Add(nameDataColumn);
            descriptiveStatisticsDataTable.Columns.Add(sizeDataColumn);
            descriptiveStatisticsDataTable.Columns.Add(maximumDataColumn);
            descriptiveStatisticsDataTable.Columns.Add(minimumDataColumn);
            descriptiveStatisticsDataTable.Columns.Add(meanDataColumn);
            descriptiveStatisticsDataTable.Columns.Add(medianDataColumn);
            descriptiveStatisticsDataTable.Columns.Add(varianceDataColumn);
            descriptiveStatisticsDataTable.Columns.Add(standardDeviationDataColumn);
            descriptiveStatisticsDataTable.Columns.Add(kurtosisDataColumn);
            descriptiveStatisticsDataTable.Columns.Add(skewnessDataColumn);

            for (int j = 0; j < dataTable.Columns.Count; j++)
            {
                List<double> list = new List<double>();
                //verifica daca elem initial al coloanei e numeric
                if (!nsc.IsString(dataTable.Rows[0].ItemArray[j].ToString()))
                {
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        String s = dataTable.Rows[i].ItemArray[j].ToString();
                        Double d = 0;
                        //adauga in lista doar daca celula poate fi convertita la double
                        if (Double.TryParse(s, out d))
                        {
                            list.Add(d);
                        }
                    }

                    DataRow dataRow = descriptiveStatisticsDataTable.NewRow();

                    dataRow["Name"] = dataTable.Columns[j].ColumnName.ToString();
                    dataRow["Size"] = list.Count();

                    double maximum = Statistics.Maximum(list);
                    double minimum = Statistics.Minimum(list);
                    double mean = Statistics.Mean(list);
                    double median = Statistics.Median(list);
                    double variance = Statistics.Variance(list);
                    double standardDeviation = Statistics.StandardDeviation(list);
                    double kurtosis = Statistics.Kurtosis(list);
                    double skewness = Statistics.Skewness(list);

                    dataRow["Maximum"] = maximum;
                    dataRow["Minimum"] = minimum;
                    dataRow["Mean"] = mean;
                    dataRow["Median"] = median;
                    dataRow["Variance"] = variance;
                    dataRow["StandardDeviation"] = standardDeviation;
                    dataRow["Kurtosis"] = kurtosis;
                    dataRow["Skewness"] = skewness;
                    descriptiveStatisticsDataTable.Rows.Add(dataRow);
                    list.Clear();
                }
            }
            return descriptiveStatisticsDataTable;
        }

        public DataTable OutputDescriptiveStatisticsPopulation()
        {
            NumberStringChecker nsc = new NumberStringChecker();
            DataTable descriptiveStatisticsDataTable = new DataTable("Descriptive Statistics");

            DataColumn nameDataColumn = new DataColumn("Name");
            DataColumn sizeDataColumn = new DataColumn("Size");
            DataColumn maximumDataColumn = new DataColumn("Maximum");
            DataColumn minimumDataColumn = new DataColumn("Minimum");
            DataColumn meanDataColumn = new DataColumn("Mean");
            DataColumn medianDataColumn = new DataColumn("Median");
            DataColumn varianceDataColumn = new DataColumn("Variance");
            DataColumn standardDeviationDataColumn = new DataColumn("StandardDeviation");
            DataColumn kurtosisDataColumn = new DataColumn("Kurtosis");
            DataColumn skewnessDataColumn = new DataColumn("Skewness");

            descriptiveStatisticsDataTable.Columns.Add(nameDataColumn);
            descriptiveStatisticsDataTable.Columns.Add(sizeDataColumn);
            descriptiveStatisticsDataTable.Columns.Add(maximumDataColumn);
            descriptiveStatisticsDataTable.Columns.Add(minimumDataColumn);
            descriptiveStatisticsDataTable.Columns.Add(meanDataColumn);
            descriptiveStatisticsDataTable.Columns.Add(medianDataColumn);
            descriptiveStatisticsDataTable.Columns.Add(varianceDataColumn);
            descriptiveStatisticsDataTable.Columns.Add(standardDeviationDataColumn);
            descriptiveStatisticsDataTable.Columns.Add(kurtosisDataColumn);
            descriptiveStatisticsDataTable.Columns.Add(skewnessDataColumn);

            for (int j = 0; j < dataTable.Columns.Count; j++)
            {
                List<double> list = new List<double>();
                //verifica daca elem initial al coloanei e numeric
                if (!nsc.IsString(dataTable.Rows[0].ItemArray[j].ToString()))
                {
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        String s = dataTable.Rows[i].ItemArray[j].ToString();
                        Double d = 0;
                        //adauga in lista doar daca celula poate fi convertita la double
                        if (Double.TryParse(s, out d))
                        {
                            list.Add(d);
                        }
                    }

                    DataRow dataRow = descriptiveStatisticsDataTable.NewRow();

                    dataRow["Name"] = dataTable.Columns[j].ColumnName.ToString();
                    dataRow["Size"] = list.Count();

                    double maximum = Statistics.Maximum(list);
                    double minimum = Statistics.Minimum(list);
                    double mean = Statistics.Mean(list);
                    double median = Statistics.Median(list);
                    double variance = Statistics.PopulationVariance(list);
                    double standardDeviation = Statistics.PopulationStandardDeviation(list);
                    double kurtosis = Statistics.PopulationKurtosis(list);
                    double skewness = Statistics.PopulationSkewness(list);

                    dataRow["Maximum"] = maximum;
                    dataRow["Minimum"] = minimum;
                    dataRow["Mean"] = mean;
                    dataRow["Median"] = median;
                    dataRow["Variance"] = variance;
                    dataRow["StandardDeviation"] = standardDeviation;
                    dataRow["Kurtosis"] = kurtosis;
                    dataRow["Skewness"] = skewness;
                    descriptiveStatisticsDataTable.Rows.Add(dataRow);
                    list.Clear();
                }
            }
            return descriptiveStatisticsDataTable;
        }

        public DataTable OutputCorrelation()
        {
            NumberStringChecker nsc = new NumberStringChecker();
            List<List<double>> listOfLists = new List<List<double>>();

            DataTable correlationDataTable = new DataTable("Correlation");

            for (int j = 0; j < dataTable.Columns.Count; j++)
            {
                List<double> list = new List<double>();
                //verifica daca elem initial al coloanei e numeric
                if (!nsc.IsString(dataTable.Rows[0].ItemArray[j].ToString()))
                {
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        String s = dataTable.Rows[i].ItemArray[j].ToString();
                        Double d = 0;
                        //adauga in lista doar daca celula poate fi convertita la double
                        if (Double.TryParse(s, out d))
                        {
                            list.Add(d);
                        }
                    }
                    listOfLists.Add(list);
                    DataColumn nameDataColumn = new DataColumn(dataTable.Columns[j].ColumnName.ToString());
                    correlationDataTable.Columns.Add(nameDataColumn);
                }
            }

            double[][] matrix = new double[listOfLists.Count][];

            for (int increment = 0; increment < listOfLists.Count; increment++)
            {
                matrix[increment] = listOfLists[increment].ToArray();
            }
            listOfLists.Clear();

            //verific daca matricea e simetrica
            Boolean isSymmetricMatrix = true;
            int numberElementsFirstRow = matrix[0].ToArray().Length;
            for (int increment = 0; increment < matrix.Length && isSymmetricMatrix == true; increment++)
            {
                if (matrix[increment].Length != numberElementsFirstRow)
                {
                    isSymmetricMatrix = false;
                }
            }

            if (isSymmetricMatrix)
            {
                var corr = MathNet.Numerics.Statistics.Correlation.SpearmanMatrix(matrix);

                for (int increment = 0; increment < corr.ColumnCount; increment++)
                {
                    DataRow dataRow = correlationDataTable.NewRow();
                    for (int increment2 = 0; increment2 < corr.RowCount; increment2++)
                    {
                        dataRow[increment2] = corr[increment2, increment];
                    }
                    correlationDataTable.Rows.Add(dataRow);
                }
                return correlationDataTable;
            }
            else
            {
                MessageBox.Show("Correlation data is invalid.");
                return null;
            }
        }

    }
}
