using System.Collections.Generic;

namespace Lab_1_1
{
    public class AnalizationResultModel
    {
        public double M { get; set; }
        public double D { get; set; }
        public double Sigma { get; set; }
        public double CircumstantialAttribute { get; set; }
        public DataForBarChart BarChartValues { get; set; }
        public int Period { get; set; }
        public int APeriod { get; set; }

        public AnalizationResultModel()
        {       
        }

        public AnalizationResultModel(double m, double d, double sigma, double circumstantialAttribute, DataForBarChart barChartValues)
        {
            M = m;
            D = d;
            Sigma = sigma;
            CircumstantialAttribute = circumstantialAttribute;
            BarChartValues = barChartValues;
        }
    }
}
