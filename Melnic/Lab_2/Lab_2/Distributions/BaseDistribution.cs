using System;
using System.Collections.Generic;
using System.Linq;
using Lab_2.Model;

namespace Lab_2.Distributions
{
    public abstract class BaseDistribution
    {
        public abstract List<double> GetValues();

        public AnalysisModel GetMathAttributes(List<double> listOfValue)
        {
            var mathExp = listOfValue.Sum() / listOfValue.Count;
            return new AnalysisModel
            {
                MathExpectation = mathExp,
                Dispersion = listOfValue.Sum(x => Math.Pow(x - mathExp, 2)) / listOfValue.Count
            };
        }
    }
}
