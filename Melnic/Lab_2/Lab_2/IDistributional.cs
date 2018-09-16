using System.Collections.Generic;
using System.Windows.Documents;

namespace Lab_2
{
    public interface IDistributional
    {
        List<double> GetValues(params object[] parameters);
        AnalysisModel GetMathAttributes(List<double> values);
    }
}
