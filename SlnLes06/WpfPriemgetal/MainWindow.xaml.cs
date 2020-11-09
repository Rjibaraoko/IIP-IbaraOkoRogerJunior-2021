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

namespace WpfPriemgetal
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

        private void contrbtn_Click_1(object sender, RoutedEventArgs e)
        {
            int number = Convert.ToInt32(numbertxt.Text);
            bool Prim = true;

            for (int i = 2; i < number/2; i++)
            {
                if (number % i == 0)
                {
                    Prim = false;
                    break;
                }
            }

            if (Prim)
            {
                priemlbl.Content = "Het is een priem getal";
                
            }
            else
            {
                priemlbl.Content = "Het is geen priem getal";
            }

        }
    }
}
