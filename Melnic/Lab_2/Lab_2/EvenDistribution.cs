using System.Collections.Generic;
using System.Linq;

namespace Lab_2
{
    public static class EvenDistribution
    {
        public static List<double> GenerateValues(double a, double b, int amount)
        {            
            var config = new Configuration();            
            var rrValues = Generator.GenerateValues(config.GetR0, amount, config.GetA, config.GetM);
            return rrValues.Select(el => a + (b - a) * el).ToList();
        }
    }
}
