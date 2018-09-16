using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_2
{
    public static class ExponentialDistribution
    {
        public static List<double> GetValues(double lambda)
        {
            return Data.GetRrSequence().Select(el => -1 / lambda * Math.Log(el, Math.E)).ToList();
        }
    }
}
