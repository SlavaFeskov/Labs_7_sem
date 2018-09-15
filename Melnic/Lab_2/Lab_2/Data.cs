using System.Collections.Generic;
using System.Windows.Documents;

namespace Lab_2
{
    public static class Data
    {
        private static List<double> rRSequence;
        private static List<List<double>> sequences;

        public static List<double> GetRrSequence()
        {
            return rRSequence ?? (rRSequence = Generator.GenerateValues(Configuration.GetA, Configuration.GetAmount, Configuration.GetA, Configuration.GetM));
        }

        public static List<List<double>> GetSequences()
        {
            if (sequences != null) return sequences;
            var result = new List<List<double>>();
            for (int i = 0; i < Configuration.GetAmountOfSequences; i++)
            {
                result[i] = Generator.GenerateValues(Configuration.GetA, Configuration.GetAmount,
                    Configuration.GetA, Configuration.GetM);
            }               
            return result;
        }
    }
}
