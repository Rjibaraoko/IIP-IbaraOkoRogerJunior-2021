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

namespace WpfIngredienten
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int personen = Convert.ToInt32(persontxt.Text);

            //dont forget to use string interpolation
            int hoeveel = Convert.ToInt32(hoevtxt.Text);
            int hoeveel2 = Convert.ToInt32(hoevtxt2.Text);
            int hoeveel3 = Convert.ToInt32(hoevtxt3.Text);
            int hoeveel4 = Convert.ToInt32(hoevtxt4.Text);

            boodschlbl.Content = "-" +  hoeveel *  personen + " " +  eenheidtxt.Text + " " +  ingtxt.Text + " " + Environment.NewLine + 
                "-" + hoeveel2 * personen + " " + eenheidtxt2.Text + " " + ingtxt2.Text + " " + Environment.NewLine 
                + "-" + hoeveel3 * personen + " " + eenheidtxt3.Text + " " + ingtxt3.Text + " " + Environment.NewLine + 
                "-" + hoeveel4 * personen + " " + eenheidtxt4.Text + " " + ingtxt4.Text + " " + Environment.NewLine;

        }
    }
}
