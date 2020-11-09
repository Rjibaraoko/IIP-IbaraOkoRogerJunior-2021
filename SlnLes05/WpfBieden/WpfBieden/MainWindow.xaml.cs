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

namespace WpfBieden
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int Hoogstebod = 0;
        string Hoogstebieder;
        

        public MainWindow()
        {
            InitializeComponent();
            Lblbiending.Content = " Er is nog geen bod geplaats momenteel.";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            int getal = Convert.ToInt32( TxtBod.Text);
            if (getal > Hoogstebod)
            {

                Hoogstebod = getal;
                Hoogstebieder = TxtNaam.Text;
                Lblbiending.Content = ($" { Hoogstebieder } heeft met {getal}€ nu het hoogste bod ");
            } else  
            {
                
                Lblbiending.Content = ($" { Hoogstebieder} heeft momenteel het hoogste bod ."); 

            }

        }
    }
}
