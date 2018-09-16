using System;

namespace Lab_2.Model
{
    public class AnalysisModel
    {
        private double _dispersion;
        public double MathExpectation { get; set; }

        public double Dispersion
        {
            get => _dispersion;
            set
            {
                _dispersion = value;
                Sigma = Math.Sqrt(_dispersion);
            }
        }

        public double Sigma { get; set; }

        public AnalysisModel()
        {             
        }

        public AnalysisModel(double mathExpectation, double dispersion, double sigma)
        {
            MathExpectation = mathExpectation;
            Dispersion = dispersion;
            Sigma = sigma;
        }
    }
}
