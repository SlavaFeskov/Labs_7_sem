using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;

namespace ME1
{
    /// <summary>
    /// Interaction logic for Charte.xaml
    /// </summary>
    public partial class Charte : UserControl
    {
        public Charte()
        {
            InitializeComponent();

            SeriesCollection = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Distribution density ",
                    Values = new ChartValues<ObservablePoint>()
                    {
                        new ObservablePoint(0.025 + 0.05 * 0, 0.5 ),
                        new ObservablePoint(0.025 + 0.05 * 1, 0.5 ),
                        new ObservablePoint(0.025 + 0.05 * 2, 0.5 ),
                        new ObservablePoint(0.025 + 0.05 * 3, 0.5 ),
                        new ObservablePoint(0.025 + 0.05 * 4, 0.5 ),
                        new ObservablePoint(0.025 + 0.05 * 5, 0.5 ),
                        new ObservablePoint(0.025 + 0.05 * 6, 0.5 ),
                        new ObservablePoint(0.025 + 0.05 * 7, 0.5 ),
                        new ObservablePoint(0.025 + 0.05 * 8, 0.5 ),
                        new ObservablePoint(0.025 + 0.05 * 9, 0.5 ),
                        new ObservablePoint(0.025 + 0.05 * 10, 0.5 ),
                        new ObservablePoint(0.025 + 0.05 * 11, 0.5 ),
                        new ObservablePoint(0.025 + 0.05 * 12, 0.5 ),
                        new ObservablePoint(0.025 + 0.05 * 13, 0.5 ),
                        new ObservablePoint(0.025 + 0.05 * 14, 0.5 ),
                        new ObservablePoint(0.025 + 0.05 * 15, 0.5 ),
                        new ObservablePoint(0.025 + 0.05 * 16, 0.5 ),
                        new ObservablePoint(0.025 + 0.05 * 17, 0.5 ),
                        new ObservablePoint(0.025 + 0.05 * 18, 0.5 ),
                        new ObservablePoint(0.025 + 0.05 * 19, 0.5 ),
                    }
               }            
            };
            
            DataContext = this;
        }

        public void SetValues(List<double> values)
        {
            
            SeriesCollection[0].Values.Clear();
            var v = new List<Tuple<double, double>>();
            var min = double.MaxValue;
            values.ForEach(d =>
            {
                if (d < min) min = d;
            });
            var max = double.MinValue;
            values.ForEach(d =>
            {
                if (d > max) max = d;
            });
            var step = ((double)(max - min) / 20);
            for (int i = 0; i < 20; i++)
            {
                double upValue = min + (i + 1) * step;
                double downValue = min + i * step;
                float sum = 0;
                values.ForEach(
                    d =>
                    {
                        if (d >= downValue && d < upValue)
                            sum++;
                    });
                v.Add(new Tuple<double, double>(i, sum / values.Count));
            }
            SeriesCollection[0].Values.AddRange(v.Select(vector2 => new ObservablePoint(vector2.Item1,vector2.Item2)));
        }

        public double Step { get; set; }
        public SeriesCollection SeriesCollection { get; set; }

    }
}
