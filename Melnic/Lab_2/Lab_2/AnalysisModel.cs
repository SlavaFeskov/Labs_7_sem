namespace Lab_2
{
    public class AnalysisModel
    {
        public double MathExpectation { get; set; }
        public double Dispersion { get; set; }
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
