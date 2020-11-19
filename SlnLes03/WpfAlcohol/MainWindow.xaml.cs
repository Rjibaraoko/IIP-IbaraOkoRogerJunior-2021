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

namespace WpfAlcohol
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

        private void SliderG_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            glazenlbl.Content = "glazen " + sliderG.Value;
            AlcoholPr.Value = sliderG.Value;
        }

        private void sliderG2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            glazenlbl2.Content = "glazen " + sliderG2.Value;
        }

        private void sliderG3_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            glazenlbl3.Content = "glazen " + sliderG3.Value;
        }

        private void ProgressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            AlcoholPr.Minimum = 0;
            AlcoholPr.Maximum = 5;
            AlcoholPr.Value = 1;
            

            
        }
    }
}
