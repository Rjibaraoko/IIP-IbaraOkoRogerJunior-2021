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

namespace WpfSliderKleur
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int sldvalue = Convert.ToInt32(sldr1.Value);
            LblCijfer.Content = sldvalue;

            double volume  = sldr1.Value;
            LblWaarde.Content = " Geselecteerde waarde : ";
           
            
            if ( sldvalue > 20 && sldvalue < 20 )
            {
                LblCijfer.Foreground = new SolidColorBrush(Colors.AliceBlue);
            } else if ( sldvalue > 20 && sldvalue < 35 )
            {
                LblCijfer.Foreground = new SolidColorBrush(Colors.BlueViolet);
            } else if ( sldvalue > 35 && sldvalue < 50 )
            {
                LblCijfer.Foreground = new SolidColorBrush(Colors.PaleVioletRed);
            } else if (sldvalue > 50 && sldvalue < 75)
            {
                LblCijfer.Foreground = new SolidColorBrush(Colors.Yellow);
            } else if (sldvalue > 75 && sldvalue < 90 )
            {
                LblCijfer.Foreground = new SolidColorBrush(Colors.Green);
            }
            else if (sldvalue > 75 && sldvalue < 90)
            {
                LblCijfer.Foreground = new SolidColorBrush(Colors.Gold);
            }



        }
    }
}
;