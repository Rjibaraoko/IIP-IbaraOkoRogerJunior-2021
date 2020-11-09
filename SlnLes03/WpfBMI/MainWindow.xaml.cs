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

namespace WpfBMI
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //De input van de user onthouden
            var Lengte = Convert.ToDouble(Lengtetxt.Text) / 100;
            var Gewicht = Convert.ToDouble(Gewichttxt.Text);

            //formule voor het maken van de berekening van de BMI
            var BMI = Gewicht / (Lengte * Lengte);

            //het resultaat afgerond
            LblBmi.Content = "BMI: " + Math.Round(BMI, 1);
            
            //Math.Ceiling(BMI));
        }
    }
}
