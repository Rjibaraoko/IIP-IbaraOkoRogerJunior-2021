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

namespace WpfPizza
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

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            pizzalbl.Content = "Tomatensaus, mozzarella & oregano";
            PizzaImg.Source = new BitmapImage(new Uri("Images/large_c6a07aff-9ba9-4e50-bf65-7d259bff1e19.jpg", UriKind.Relative));
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            pizzalbl.Content = "Tomatensaus, mozzarella, rode ui, kip, paprika, pepperoni & spaanse pepers";
            PizzaImg.Source = new BitmapImage(new Uri("Images/g_pizza-eck_hawaii_resch_frisch_600x600_1.png", UriKind.Relative));
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            pizzalbl.Content = "Tomatensaus, mozzarella, pepperoni, gegrilde ham, champignons, rode ui, paprika, gehakt & olijven";
            PizzaImg.Source = new BitmapImage(new Uri("Images/spicy-pizza-slice-isolated-white-background-clipping-path-50605273.jpg", UriKind.Relative));
        }
    }
}
