using System.Collections.Generic;

namespace Lab_2
{
    public static class DataProvider
    {
        private static List<double> rRSequence;
        private static List<List<double>> sequences;

        public static List<double> GetRrSequence(long? amount = null)
        {
            return rRSequence ?? (rRSequence = Generator.GenerateValues(Configuration.GetA, amount ?? Configuration.GetAmount, Configuration.GetA, Configuration.GetM));
        }

        public static List<List<double>> GetSequences(long amountOfSequences = 0)
        {
            var realAmountOfSequences = amountOfSequences != 0 ? amountOfSequences : Configuration.GetAmountOfSequences; 
            if (sequences != null)
            {
                if (sequences.Count >= realAmountOfSequences)
                {
                    return sequences;
                }

                var result = new List<List<double>>();
                for (int i = 0; i < realAmountOfSequences - sequences.Count; i++)
                {
                    result.Add(GetRrSequence());
                }

                sequences.AddRange(result);
                return sequences;
            }
            else
            {
                var result = new List<List<double>>();
                for (int i = 0; i < realAmountOfSequences; i++)
                {
                    result.Add(GetRrSequence(realAmountOfSequences));
                }

                return sequences = result;
            }          
        }
    }
}
