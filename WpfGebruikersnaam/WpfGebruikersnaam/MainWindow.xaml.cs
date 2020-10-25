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

namespace WpfGebruikersnaam
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
        int foutmelding;

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

            if ( TxtBox1.Text == "")
            {
                Background = Brushes.White;
                
            }
            else if (TxtBox1.Text.Contains(""))
            {
                TxtBox1.Background = Brushes.LawnGreen;
            }


            if (TxtBox1.Text.Contains(" "))
            {
                TxtBox1.Background = Brushes.DarkRed;
                Lblfout.Content = " mag geen spaties bevatten";
            }
            else if  ( TxtBox1.Text == "")
            {
                TxtBox1.Background = Brushes.White;
                Lblfout.Content = "";
            }
        }
    }
}
