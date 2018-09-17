using System.Collections.Generic;

namespace Lab_2
{
    public class Generator
    {
        public List<List<double>> GenerateAllSequences(int K, int N)
        {
            var harmonicFunc = new HarmonicFunction();
            var result = new List<List<double>>();
            for (int M = K; M <= 2 * N; M++)
            {
                result.Add(harmonicFunc.GetValues(M, N, 0));
            }

            return result;
        }
    }
}
