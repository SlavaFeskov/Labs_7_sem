using System;
using System.Windows.Forms;

namespace Lab_1_1
{
    public partial class AnalyzeResultForm : Form
    {
        public AnalyzeResultForm(AnalizationResultModel analizationResultModel)
        {
            InitializeComponent();
            mathematicalExpectationLabel.Text += analizationResultModel.M;
            dispersionLabel.Text += analizationResultModel.D;
            meanSquareDeviationLabel.Text += analizationResultModel.Sigma;
            circumstantialAttributeLabel.Text += analizationResultModel.CircumstantialAttribute;
            piDivideFourLabel.Text += (Math.PI / 4);
            periodLabel.Text += analizationResultModel.Period;
            aperiodLabel.Text += analizationResultModel.APeriod;
        }
    }
}
