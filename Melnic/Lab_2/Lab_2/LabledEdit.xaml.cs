using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
    /// Interaction logic for LabledEdit.xaml
    /// </summary>
    public partial class LabledEdit : UserControl
    {
        public string ShowingName
        {
            get => (string)GetValue(ShowingNameProperty);
            set => SetValue(ShowingNameProperty, value);
        }

        public static readonly DependencyProperty ShowingNameProperty =
            DependencyProperty.Register("ShowingName", typeof(string), typeof(LabledEdit));

        public string ContentText
        {
            get => (string)GetValue(ContentTextProperty);
            set => SetValue(ContentTextProperty, value);
        }

        public static readonly DependencyProperty ContentTextProperty =
            DependencyProperty.Register("ContentText", typeof(string), typeof(LabledEdit));

        public string GetValue()
        {
            return TextBox.Text;
        }

        public LabledEdit()
        {
            DataContext = this;
            SetValue(ShowingNameProperty, "sas");
            InitializeComponent();
        }
    }
}
