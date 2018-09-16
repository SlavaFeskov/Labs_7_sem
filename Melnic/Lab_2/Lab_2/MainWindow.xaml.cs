using System;
using System.Collections.Generic;
using System.Windows;
using Lab_2.Distributions;

namespace Lab_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public enum Distribution
    {
        EvenDistribution,
        ExponentialDistribution,
        GammaDistribution,
        GaussianDistribution,
        SimpsonDistribution,
        TriangleDistribution
    }

    public delegate void StringSetter(string value);
    public delegate void VisibiltySetter(Visibility value);
    public partial class MainWindow : Window
    {
        public Distribution CurentDistribution { get; private set; }
        public List<StringSetter> edtNames { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            edtNames = new List<StringSetter> {
                value => Edit0.ShowingName = value,
                value => Edit1.ShowingName = value,
                value => Edit2.ShowingName = value,
            };
            edtContent = new List<StringSetter> {
                value => Edit0.ContentText = value,
                value => Edit1.ContentText = value,
                value => Edit2.ContentText = value,

            };
            edtVisibilitys = new List<VisibiltySetter> {
                value => Edit0.Visibility = value,
                value => Edit1.Visibility = value,
                value => Edit2.Visibility = value,

            };
            RadioEvent.IsChecked = true;
        }
        public List<VisibiltySetter> edtVisibilitys { get; set; }

        public List<StringSetter> edtContent { get; set; }

        private void HideAllEdit()
        {
            edtVisibilitys.ForEach(setter => setter.Invoke(Visibility.Collapsed));
        }

        private void ShowEdits(int count)
        {
            for (int i = 0; i < count; i++)
            {
                edtVisibilitys[i].Invoke(Visibility.Visible);
            }
        }

        public void SetString(List<StringSetter> setters, List<string> values)
        {
            for (int i = 0; i < values.Count; i++)
            {
                setters[i].Invoke(values[i]);
            }
        }

        private void ResetAllEdit()
        {
            edtContent.ForEach(setter => setter.Invoke("0"));
        }
        private void ButtonGenrate_OnClick(object sender, RoutedEventArgs e)
        {
            BaseDistribution distribution;
            switch (CurentDistribution)
            {
                case Distribution.EvenDistribution:
                    distribution = new EvenDistribution(Edit0.GetContent<double>(), Edit1.GetContent<double>());
                    break;
                case Distribution.ExponentialDistribution:
                    distribution = new ExponentialDistribution(Edit0.GetContent<double>());
                    break;
                case Distribution.GammaDistribution:
                    distribution = new GammaDistribution(Edit0.GetContent<long>(), Edit1.GetContent<double>());
                    break;
                case Distribution.GaussianDistribution:
                    distribution = new GaussianDistribution(Edit0.GetContent<double>(), Edit1.GetContent<double>());
                    break;
                case Distribution.SimpsonDistribution:
                    distribution = new SimpsonDistribution(Edit0.GetContent<double>(), Edit1.GetContent<double>());
                    break;
                case Distribution.TriangleDistribution:
                    distribution = new TriangleDistribution(Edit0.GetContent<double>(), Edit1.GetContent<double>(),Edit2.GetContent<bool>());
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            Charte.SetValues(distribution.GetValues());
            var analiysis = distribution.GetMathAttributes();
            lbDispersion.Content = $"Dispersion = {analiysis.Dispersion}";
            lbSigma.Content = $"Sigma = {analiysis.Sigma}";
            lbMathExpectation.Content = $"MathExpectation = {analiysis.MathExpectation}";
        }

        private void Reset()
        {
            HideAllEdit();
            ResetAllEdit();
        }

        private void EventSelect(object sender, RoutedEventArgs e)
        {
            CurentDistribution = Distribution.EvenDistribution;
            Reset();
            ShowEdits(2);
            SetString(edtNames,new List<string>{"a","b"});
        }

        private void TriangleSelect(object sender, RoutedEventArgs e)
        {
            CurentDistribution = Distribution.TriangleDistribution;
            Reset();
            ShowEdits(3);
            SetString(edtNames, new List<string> { "a", "b" , "density" });
        }

        private void GaussianSelect(object sender, RoutedEventArgs e)
        {
            CurentDistribution = Distribution.GaussianDistribution;
            Reset();
            ShowEdits(2);
            SetString(edtNames, new List<string> { "mathExp",  "sigma" });
        }

        private void SimpsonSelect(object sender, RoutedEventArgs e)
        {
            CurentDistribution = Distribution.SimpsonDistribution;
            Reset();
            ShowEdits(2);
            SetString(edtNames, new List<string> { "a", "b" });
        }

        private void ExponentialSelect(object sender, RoutedEventArgs e)
        {
            CurentDistribution = Distribution.ExponentialDistribution;
            Reset();
            ShowEdits(1);
            SetString(edtNames, new List<string> { "lambda" });
        }

        private void GammaSelect(object sender, RoutedEventArgs e)
        {
            CurentDistribution = Distribution.GammaDistribution;
            Reset();
            ShowEdits(2);
            SetString(edtNames, new List<string> {"n", "lambda" });
        }
    }
}
