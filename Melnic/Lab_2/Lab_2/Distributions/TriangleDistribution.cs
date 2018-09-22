using System;
using System.Collections.Generic;
using Lab_2.Model;

namespace Lab_2.Distributions
{
    public class TriangleDistribution : BaseDistribution
    {
        public double A { get; set; }
        public double B { get; set; }
        public bool Density { get; set; }

        public TriangleDistribution(double a, double b, bool density)
        {
            A = a;
            B = b;
            Density = density;
        }

        public override List<double> GetValues()
        {
            var amountOfRrValues = Configuration.GetAmount + 1;

            var result = new List<double>();
            var rRSequence = DataProvider.GetRrSequence(amountOfRrValues);
            if (Density)
            {
                for (int i = 1; i < amountOfRrValues; i++)
                {
                    result.Add(A + (B - A) * Math.Max(rRSequence[i - 1], rRSequence[i]));
                }
            }
            else
            {
                for (int i = 1; i < amountOfRrValues; i++)
                {
                    result.Add(A + (B - A) * Math.Min(rRSequence[i - 1], rRSequence[i]));
                }
            }

            return result;
        }

        //public override AnalysisModel GetMathAttributes(List<double> values)
        //{
        //    return new SimpsonDistribution(A, B).GetMathAttributes(values);
        //}
    }
}
