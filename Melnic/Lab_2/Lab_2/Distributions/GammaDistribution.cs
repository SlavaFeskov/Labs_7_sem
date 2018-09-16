using System;
using System.Collections.Generic;
using Lab_2.Model;

namespace Lab_2.Distributions
{
    public class GammaDistribution : BaseDistribution
    {
        public long N { get; set; }
        public double Lambda { get; set; }

        public GammaDistribution(long n, double lambda)
        {
            N = n;
            Lambda = lambda;
        }

        public override List<double> GetValues()
        {
            var result = new List<double>();
            var sequences = DataProvider.GetSequences(N);
            for (int i = 0; i < Configuration.GetAmount; i++)
            {
                double currentR = 1;
                foreach (var sequence in sequences)
                {
                    currentR *= sequence[i];
                }
                result.Add(-1 / Lambda * Math.Log(currentR, Math.E));
            }

            return result;
        }

        public override AnalysisModel GetMathAttributes()
        {
            return new AnalysisModel
            {
                MathExpectation = N / Lambda,
                Dispersion = N / Math.Pow(Lambda, 2)
            };
        }
    }
}
