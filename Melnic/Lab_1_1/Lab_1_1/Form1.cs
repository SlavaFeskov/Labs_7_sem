using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab_1_1
{
    public partial class Form1 : Form
    {
        public Int64 X0 { get; set; }
        public Int64 A { get; set; }
        public Int64 M { get; set; }
        public Int64 AmountOfValues { get; set; }
        private string errorMessage;
        public List<double> Values { get; set; }
        private AnalizationResultModel analyzationResult;

        public Form1()
        {
            InitializeComponent();            
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            if (ValidateAndSetValues())
            {
                Values = Generator.GenerateValues(X0, AmountOfValues, A, M);
                analyzeButton.Enabled = true;
                amountOfIntervalsTextBox.Enabled = true;
            }
            else
            {
                MessageBox.Show(errorMessage);
            }            
        }

        private bool ValidateAndSetValues()
        {
            if (Int64.TryParse(x0TextBox.Text, out var x0))
            {
                this.X0 = x0;
            }
            else
            {
                errorMessage = "X0 text box contains not numeric value";
                return false;
            }
            if (Int64.TryParse(aTextBox.Text, out var a))
            {
                this.A = a;
            }
            else
            {
                errorMessage = "A text box contains not numeric value";
                return false;
            }
            if (Int64.TryParse(mTextBox.Text, out var m))
            {
                if (m <= 0)
                {
                    errorMessage = "M must be above 0";
                    return false;
                }
                this.M = m;
            }
            else
            {
                errorMessage = "M text box contains not numeric value";
                return false;
            }
            if (Int64.TryParse(amountOfValuesTextBox.Text, out var amount))
            {
                if (amount <= 0)
                {
                    errorMessage = "Amount of values must be above 0 value";
                    return false;
                }
                this.AmountOfValues = amount;
            }
            else
            {
                errorMessage = "Amount of values must be a numeric";
                return false;
            }
            return true;
        }

        private void analyzeButton_Click(object sender, EventArgs e)
        {
            Int32.TryParse(amountOfIntervalsTextBox.Text, out var amountOfIntervals);
            var analyzer = new Analyzer(Values);
            analyzationResult = analyzer.PerformFullAnalysis(amountOfIntervals);
            analyzationResultsButton.Enabled = true;
            mainChart.Series[0].MarkerStep = 20;
            mainChart.Series[0].Points.DataBindXY(analyzationResult.BarChartValues.X, analyzationResult.BarChartValues.Y);
        }

        private void analyzationResultsButton_Click(object sender, EventArgs e)
        {
            new AnalyzeResultForm(analyzationResult).ShowDialog();
        }
    }
}
