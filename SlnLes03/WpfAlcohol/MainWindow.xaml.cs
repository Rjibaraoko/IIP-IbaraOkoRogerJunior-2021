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

            //AlcoholPr.Value = AlcoholPr.Value + 1;
            AlcoholPr.Value = sliderG.Value + sliderG2.Value + sliderG3.Value;
        }

        private void sliderG2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            glazenlbl2.Content = "glazen " + sliderG2.Value;
            AlcoholPr.Value = sliderG2.Value + sliderG.Value + sliderG3.Value;
        }

        private void sliderG3_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            glazenlbl3.Content = "glazen " + sliderG3.Value;
            AlcoholPr.Value = sliderG3.Value + sliderG.Value + sliderG2.Value;
        }

        private void ProgressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            AlcoholPr.Minimum = 0;
            AlcoholPr.Maximum = 10;
            
            if (AlcoholPr.Value > 6)
            {
               
                Color.FromRgb(255, 0, 0);
            }
            else
            {
                Color.FromRgb(0, 255, 0);
            }


            
        }
    }
}
