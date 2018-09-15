using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_2
{
    public static class GaussianDistribution
    {
        public static List<double> GenerateValues(double mathExp, double sigma)
        {
            var result = new List<double>();
            for (int i = 0; i < Configuration.GetAmountOfSequences; i++)
            {
                var sumOfRRi = Data.GetSequences().Sum(el => el[i]);
                result.Add(mathExp + sigma * Math.Sqrt(Configuration.GetAmountOfSequences / 2) *
                           (sumOfRRi - Configuration.GetAmountOfSequences / 2));
            }

            return result;
        }
    }
}
