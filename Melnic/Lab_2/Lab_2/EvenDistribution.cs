using System.Collections.Generic;
using System.Linq;

namespace Lab_2
{
    public static class EvenDistribution
    {
        public static List<double> GenerateValues(double a, double b)
        {                    
            return Data.GetRrSequence().Select(el => a + (b - a) * el).ToList();
        }
    }
}
