using System.Collections.Generic;

namespace Lab_1_1
{
    public class DataForBarChart
    {
        public List<int> Y { get; set; }
        public List<string> X { get; set; }

        public DataForBarChart()
        {            
        }

        public DataForBarChart(List<int> y, List<string> x)
        {
            Y = y;
            X = x;
        }
    }
}
