using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Lab_2;
namespace COS2WPF
{
    public class AnalyzatorResult
    {
        public int Start;
        public List<double> MSVErrors;
        public List<double> MSVAs;
    }

    public static class Analyzator
    {
        private static double GetMSV(List<double> values)
        {
            double sum = 0;
            values.ForEach(d => sum+= d*d);
            var MSV = Math.Sqrt(sum / (values.Count + 1));
            if (Math.Abs(MSV) < 0.0001)
            {
                double sumSqr = 0;
                sum = 0;
                values.ForEach(d =>
                    {
                        sumSqr += d * d;
                        sum += d;

                    });
                MSV = Math.Sqrt(sum / values.Count - Math.Pow(sumSqr/values.Count,2));
            }

            return MSV;
        }

        private static AnalyzatorResult Analyze(double fi)
        {
            var ret = new AnalyzatorResult();
            var allSequences = Generator.GenerateAllSequences(DataTable.K, DataTable.N, fi);
            var MSVs = allSequences.Select(GetMSV);            
            var MSVErrors = MSVs.Select(d => 0.707 - d);
            var Asub = allSequences.Select(sequence => sequence.Select(Math.Abs).Max()).ToList();
            var MSVAs = Asub.Select(complex => 1 - complex);    
            ret.MSVAs = MSVAs.ToList();
            ret.MSVErrors = MSVErrors.ToList();
            ret.Start = DataTable.K;
            return ret;
        }

        public static AnalyzatorResult Analyze()
        {
            return Analyze(0);
        }
        public static AnalyzatorResult AlalyzeWithFi()
        {
            return Analyze(DataTable.Fi);
        }
    }
}
