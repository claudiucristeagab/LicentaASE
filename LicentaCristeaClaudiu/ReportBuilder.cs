using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LicentaCristeaClaudiu
{
    class ReportBuilder
    {
        String reportName;
        List<ReportItem> listReportItems;
        StringBuilder reportOutput;

        public ReportBuilder()
        {
            this.reportName = String.Empty;
            this.listReportItems = new List<ReportItem>();
            this.reportOutput = new StringBuilder();
        }

        public string ReportName
        {
            get
            {
                return reportName;
            }

            set
            {
                reportName = value;
            }
        }

        internal List<ReportItem> ListReportItems
        {
            get
            {
                return listReportItems;
            }

            set
            {
                listReportItems = value;
            }
        }

        public StringBuilder ReportOutput
        {
            get
            {
                return reportOutput;
            }

            set
            {
                reportOutput = value;
            }
        }

        public String GenerateReport()
        {
            this.reportOutput.Clear();

            reportOutput.AppendLine("<!DOCTYPE html>");
            reportOutput.AppendLine("<html>");
            reportOutput.AppendLine("<body>");
            reportOutput.AppendLine("<h1>" + this.reportName + "</h1>");
            reportOutput.AppendLine("Report Date: " + System.DateTime.Now.ToString());
            foreach(ReportItem reportItem in listReportItems)
            {
                reportOutput.AppendLine(reportItem.GenerateItemReport());
            }
            reportOutput.AppendLine("</body>");
            reportOutput.AppendLine("</html>");
            return reportOutput.ToString();
        }

    }
}
