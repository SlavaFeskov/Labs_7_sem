using System;
using System.Collections.Generic;
using System.Linq;
using Lab_2.Model;

namespace Lab_2.Distributions
{
    public class ExponentialDistribution : BaseDistribution
    {
        public double Lambda { get; set; }

        public ExponentialDistribution(double lambda)
        {
            Lambda = lambda;
        }

        public override List<double> GetValues()
        {
            return DataProvider.GetRrSequence().Select(el => -1 / Lambda * Math.Log(el, Math.E)).ToList();
        }

        //public override AnalysisModel GetMathAttributes(List<double> values)
        //{
        //    return new AnalysisModel
        //    {
        //        MathExpectation = 1 / Lambda,
        //        Dispersion = 1 / Math.Pow(Lambda, 2)
        //    };
        //}
    }
}
