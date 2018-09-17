using System;
using System.ComponentModel;
using System.Windows.Controls;
using LiveCharts;
using LiveCharts.Defaults;

namespace COS2WPF
{

    public partial class AnalogChart : UserControl
    {
        public Func<double, string> XAxisLableormatter { get; set; }
        public Func<double, string> YAxisLableormatter { get; set; }
        public int start = 0;
        public AnalogChart()
        {
            XAxisLableormatter = d => $"{d + start:0.##}";
            YAxisLableormatter = d => $"{d :0.##}";
            InitializeComponent();
            NameLable = "lol";
            DataContext = this;
            Values = new ChartValues<ObservableValue>
            {
                new ObservableValue(3),
                new ObservableValue(4),
                new ObservableValue(6),
                new ObservableValue(3),
                new ObservableValue(2),
                new ObservableValue(6)
            };

        }
        [Bindable(true)]
        public string NameLable { get; set; }

        [Bindable(true)]
        public ChartValues<ObservableValue> Values { get; set; }

        public int Step { get; set; }


    }
}