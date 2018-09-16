using System.Collections.Generic;
using Lab_2.Utils;

namespace Lab_2
{
    public static class DataProvider
    {
        private static List<double> rRSequence;
        private static List<List<double>> sequences;

        public static List<double> GetRrSequence(long? amount = null, long? r0 = null, long? a = null, long? m = null)
        {
            if (rRSequence != null) return rRSequence;
            if (r0.HasValue && a.HasValue && m.HasValue)
            {
                rRSequence = Generator.GenerateValues(r0.Value, amount ?? Configuration.GetAmount, a.Value, m.Value);
            }
            else
            {
                var randomAttributes = Randomizer.GetThreeRandomValuesFromList();
                rRSequence = Generator.GenerateValues(randomAttributes[0], amount ?? Configuration.GetAmount, randomAttributes[1], randomAttributes[2]);
            }            
            return rRSequence;
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
                    var randomAttributes = Randomizer.GetThreeRandomValuesFromList();
                    result.Add(GetRrSequence(r0: randomAttributes[0], a: randomAttributes[1], m: randomAttributes[2]));
                }

                sequences.AddRange(result);
                return sequences;
            }
            else
            {
                var result = new List<List<double>>();
                for (int i = 0; i < realAmountOfSequences; i++)
                {
                    var randomAttributes = Randomizer.GetThreeRandomValuesFromList();
                    result.Add(GetRrSequence(realAmountOfSequences, r0: randomAttributes[0], a: randomAttributes[1], m: randomAttributes[2]));
                }

                return sequences = result;
            }          
        }
    }
}
