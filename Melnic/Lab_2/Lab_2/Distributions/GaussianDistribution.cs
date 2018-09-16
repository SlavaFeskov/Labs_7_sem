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
            var amountOfSequences = 6;
            var sequences = DataProvider.GetSequences(amountOfSequences);
            for (int i = 0; i < Configuration.GetAmount; i++)
            {
                var sumOfRRi = sequences.Sum(el => el[i]);
                result.Add(MathExp + Sigma * Math.Sqrt(12 / amountOfSequences) *
                           (sumOfRRi - amountOfSequences / 2));
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
