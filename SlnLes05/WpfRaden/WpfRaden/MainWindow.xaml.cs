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

namespace WpfRaden
{
    public partial class MainWindow : Window
    {
        int getal;
        int pogingenOver = 3;
        public MainWindow()
        {
            InitializeComponent();
            Random rnd = new Random();
            getal = rnd.Next(1, 10);
            lblPogingen.Content = " Er is geen nog bod geplaats momenteel.";
        }
        private void btncntrl_Click(object sender, RoutedEventArgs e)
        {
            pogingenOver--;
            int gok = Convert.ToInt32(txtbox.Text);
            if (gok == getal)
            {
                lblPogingen.Content = "Gewonnen!";
                btncntrl.IsEnabled = false;
            }

          else if (gok > getal )
            {
                lblPogingen.Content = $" Te Hoog, Je hebt nog {pogingenOver} pogingen over";
                if (pogingenOver == 0)
                {
                    btncntrl.IsEnabled = false;
                }
                
            }
            else if ( gok < getal)
            {
                lblPogingen.Content = $" Te Laag, Je hebt nog {pogingenOver} pogingen over";
                if (pogingenOver == 0)
                {
                    btncntrl.IsEnabled = false;
                }

            }
        }

        private void BtnRestart_Click(object sender, RoutedEventArgs e)
        {
            btncntrl.IsEnabled = true;
            pogingenOver = 3;
        }
    }
}
    