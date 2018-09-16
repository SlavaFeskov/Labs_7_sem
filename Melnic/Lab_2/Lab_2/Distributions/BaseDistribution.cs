using System.Collections.Generic;
using Lab_2.Model;

namespace Lab_2.Distributions
{
    public abstract class BaseDistribution
    {
        public abstract List<double> GetValues();
        public abstract AnalysisModel GetMathAttributes();
    }
}
