using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using COS2WPF;
using LiveCharts;
using LiveCharts.Defaults;


namespace MSM1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int N = 2048;        
        public List<List<List<double>>> HarmonicValuse => new List<List<List<double>>>
        {
        };        

        public MainWindow()
        {
            InitializeComponent();
            ChartLeft.NameLable = "Погрешность 1";
            ChartRigth.NameLable = "Погрешность 2";

        }

        private void ShowAnalyzeResult(AnalyzatorResult result)
        {
            ChartLeft.start = result.Start;
            ReplaceChartValues(ChartLeft.Values, result.MSVErrors);
            var resul = Analyzator.Analyze();
            ChartRigth.start = resul.Start;
            ReplaceChartValues(ChartRigth.Values, resul.MSVAs);
        }

        private void ReplaceChartValues(ChartValues<ObservableValue> chartValues, List<double> values)
        {
            chartValues.Clear();
            chartValues.AddRange(ListToChartValues(values));
        }

        private ChartValues<ObservableValue> ListToChartValues(List<double> values)
        {
            var ret = new ChartValues<ObservableValue>();
            ret.AddRange(values.Select(d => new ObservableValue(d)));
            return ret;
        }


        private void NoFiChecked(object sender, RoutedEventArgs e)
        {
            ShowAnalyzeResult(Analyzator.Analyze());
        }

        private void WithFiChecked(object sender, RoutedEventArgs e)
        {
            ShowAnalyzeResult(Analyzator.AlalyzeWithFi());
        }
    }
}
