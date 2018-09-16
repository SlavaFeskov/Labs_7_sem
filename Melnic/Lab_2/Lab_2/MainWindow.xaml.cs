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
            throw new NotImplementedException();
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
            CurentDistribution = Distribution.SimpsonDistribution;
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
            CurentDistribution = Distribution.ExponentialDistribution;
            Reset();
            ShowEdits(2);
            SetString(edtNames, new List<string> {"n", "lambda" });
        }
    }
}
