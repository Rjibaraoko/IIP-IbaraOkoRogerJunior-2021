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

namespace WpfInterest
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void jaarslider_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            jaarlbl.Content = "jaar " + Math.Round(jaarslider.Value, 0);
        }

        private void buttoncalc_Click(object sender, RoutedEventArgs e)
        {
            var sliderV = Convert.ToDouble(Math.Round(jaarslider.Value, 0));
            var euro = Convert.ToDouble(eurotxt.Text);
            var interest = Convert.ToDouble(percenttxt.Text) / 100;
            var result = euro * (1 + interest ) + Math.Pow(interest, sliderV);

            resultlbl.Content = "De waarde na " + sliderV + " jaar bedraagt $" + result;
        }
    }
}
