using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_1_1
{
    public class Analyzer
    {
        public List<double> Values { get; set; }

        public Analyzer(List<double> values)
        {
            this.Values = values;
        }

        public AnalizationResultModel PerformFullAnalysis(int amountOfIntervals)
        {
            var result = new AnalizationResultModel();
            result.M = MathematicalExpectation();
            result.D = Dispersion(result.M);
            result.Sigma = MeanSquareDeviation(result.D);
            result.BarChartValues = GetBarChartValues(amountOfIntervals);
            result.CircumstantialAttribute = CircumstantialAttributeValidation();
            result.Period = GetPeriod(Values);
            result.APeriod = GetAPeriod(Values, result.Period);
            return result;
        }

        public double MathematicalExpectation()
        {
            return Values.Sum() / Values.Count;
        }

        public double Dispersion(double mathExpectation)
        {
            return Values.Sum(x => Math.Pow(x - mathExpectation, 2)) / Values.Count;
        }

        public double MeanSquareDeviation(double dispersion)
        {
            return Math.Sqrt(dispersion);
        }

        public DataForBarChart GetBarChartValues(int amountOfIntervals)
        {
            var workingCopyOfValues = new List<double>();
            workingCopyOfValues.AddRange(Values);
            workingCopyOfValues.Sort();
            double minValue = workingCopyOfValues.First(), maxValue = workingCopyOfValues.Last();
            var step = (maxValue - minValue) / amountOfIntervals;
            var borderValuesForEachInterval = new List<Tuple<double, double>>();
            double startValue = minValue;
            for (int i = 0; i < amountOfIntervals; i++)
            {
                var endValue = startValue + step;
                borderValuesForEachInterval.Add(new Tuple<double, double>(startValue, endValue));
                startValue = endValue;
            }
            var yValues = borderValuesForEachInterval
                .Select(pairOfValues => Values.Count(x => x >= pairOfValues.Item1 && x <= pairOfValues.Item2)).ToList();
            var xValues = borderValuesForEachInterval.Select(pairOfValues =>
                $"{pairOfValues.Item1:F} - {pairOfValues.Item2:F}").ToList();
            var dataForBarChart = new DataForBarChart(yValues, xValues);
            return dataForBarChart;
        }

        public double CircumstantialAttributeValidation()
        {
            var pairsOfValues = new List<Tuple<double, double>>();
            for (int i = 0; i < Values.Count - 1; i = i + 2)
            {
                if (i >= Values.Count)
                {
                    break;
                }
                pairsOfValues.Add(new Tuple<double, double>(Values[i], Values[i + 1]));
            }
            var pairsWhereConditionIsFollowed = pairsOfValues.Where(pair => Math.Pow(pair.Item1, 2) + Math.Pow(pair.Item2, 2) < 1);
            return (double)pairsWhereConditionIsFollowed.Count() * 2 / Values.Count;
        }

        private static int GetPeriod(List<double> generatedList)
        {
            var v = generatedList.Count;
            var isRep = new int[2];
            var ir = 2;
            for (var i = 0; i < v; i++)
            {
                if (generatedList[i] == generatedList[v - 1])
                {
                    isRep[ir - 1] = i;
                    ir--;
                    if (ir <= 0)
                        break;
                }
            }
            var period = isRep[0] - isRep[1];
            if (period <= 0)
                throw new Exception("Can't find period");
            return period;
        }

        private static int GetAPeriod(List<double> generatedList, int period)
        {
            var v = generatedList.Count;
            var aperiod = -1;
            for (int i = 0; i < v; i++)
            {
                if (generatedList[i + period] == generatedList[i])
                {
                    aperiod = i;
                    break;
                }
            }
            if (aperiod == -1)
                throw new Exception("can't find repeat");
            return aperiod + period;
        }
    }
}
