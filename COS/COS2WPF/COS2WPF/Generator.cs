using System.Collections.Generic;

namespace Lab_2
{
    public static class Generator
    {
        public static List<List<double>> GenerateAllSequences(int K, int N, double fi)
        {
            var result = new List<List<double>>();
            for (int M = K; M <= 2 * N; M++)
            {
                result.Add(HarmonicFunction.GetValues(M, N, fi));
            }

            return result;
        }
    }
}
