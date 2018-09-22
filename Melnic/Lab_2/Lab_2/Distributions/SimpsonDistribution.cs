using System;
using System.Collections.Generic;
using System.Linq;
using Lab_2.Model;

namespace Lab_2.Distributions
{
    public class SimpsonDistribution : BaseDistribution
    {
        public double A { get; set; }
        public double B { get; set; }

        public SimpsonDistribution(double a, double b)
        {
            A = a;
            B = b;
        }

        public override List<double> GetValues()
        {
            var result = new List<double>();
            var realSequence = DataProvider.GetRrSequence(Configuration.GetAmount * 2).Where(el => el >= A / 2 && el <= B / 2).ToList();
            for (int i = 1; i < realSequence.Count; i++)
            {
                result.Add(realSequence[i - 1] + realSequence[i]);
            }

            return result;
        }

        //public override AnalysisModel GetMathAttributes(List<double> values)
        //{
        //    return new AnalysisModel
        //    {
        //        MathExpectation = 2 / (3 * Math.Pow(B - A, 2)) * (Math.Pow(A, 3) + Math.Pow(B, 3) - (A + B) / 4),
        //        Dispersion = Math.Pow(B - A, 2) / 24
        //    };
        //}
    }
}
