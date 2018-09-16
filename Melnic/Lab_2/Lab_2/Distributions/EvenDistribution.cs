using System;
using System.Collections.Generic;
using System.Linq;
using Lab_2.Model;

namespace Lab_2.Distributions
{
    public class EvenDistribution : BaseDistribution
    {
        public double A { get; set; }
        public double B { get; set; }

        public EvenDistribution(double a, double b)
        {
            A = a;
            B = b;
        }

        public override List<double> GetValues()
        {
            return DataProvider.GetRrSequence().Select(el => A + (B - A) * el).ToList();
        }

        public override AnalysisModel GetMathAttributes()
        {
            return new AnalysisModel
            {
                MathExpectation = (A + B) / 2,
                Dispersion = Math.Pow(B - A, 2) / 12
            };
        }
    }
}
