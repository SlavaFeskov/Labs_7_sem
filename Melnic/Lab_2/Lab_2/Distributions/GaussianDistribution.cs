using System;
using System.Collections.Generic;
using System.Linq;
using Lab_2.Model;

namespace Lab_2.Distributions
{
    public class GaussianDistribution : BaseDistribution
    {
        public double MathExp { get; set; }
        public double Sigma { get; set; }

        public GaussianDistribution(double mathExp, double sigma)
        {
            MathExp = mathExp;
            Sigma = sigma;
        }

        public override List<double> GetValues()
        {
            var result = new List<double>();
            for (int i = 0; i < Configuration.GetAmountOfSequences; i++)
            {
                var sumOfRRi = DataProvider.GetSequences().Sum(el => el[i]);
                result.Add(MathExp + Sigma * Math.Sqrt(12 / Configuration.GetAmountOfSequences) *
                           (sumOfRRi - Configuration.GetAmountOfSequences / 2));
            }

            return result;
        }

        public override AnalysisModel GetMathAttributes()
        {
            return new AnalysisModel
            {
                MathExpectation = MathExp,
                Dispersion = Math.Pow(Sigma, 2)
            };
        }
    }
}
