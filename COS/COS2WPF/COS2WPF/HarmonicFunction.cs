using System;
using System.Collections.Generic;

namespace Lab_2
{
    public static class HarmonicFunction
    {
        public static List<double> GetValues(int M, int N, double fi)
        {
            var result = new List<double>();
            for (int n = 0; n < M; n++)
            {
                result.Add(Math.Sin(2 * Math.PI * n / N + fi));
            }
            return result;
        }
    }
}
