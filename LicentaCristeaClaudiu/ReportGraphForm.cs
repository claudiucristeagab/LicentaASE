using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LicentaCristeaClaudiu
{
    public partial class ReportGraphForm : Form
    {
        private IGraph parentForm;
        private String[] chartTypes = {"Area", "Bar", "Column", "Pie", "Point"};

        public ReportGraphForm()
        {
            InitializeComponent();
        }

        public ReportGraphForm(IGraph parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void buttonReportGraphOK_Click(object sender, EventArgs e)
        {
            try
            {
                GraphHelper graphHelper = new GraphHelper(
                    Int16.Parse(textBoxReportGraphWidth.Text), 
                    Int16.Parse(textBoxReportGraphHeight.Text), 
                    Int16.Parse(textBoxReportGraphX.Text), 
                    Int16.Parse(textBoxReportGraphY.Text));
                parentForm.SetGraph(graphHelper);
                this.Close();
            }
            catch(Exception ex)
            {

            }
        }
    }
}
