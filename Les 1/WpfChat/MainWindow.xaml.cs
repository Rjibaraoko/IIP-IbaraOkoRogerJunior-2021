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

namespace WpfChat
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
             
            Chatlbl.Content = Naam1.Text + Environment.NewLine + Berichttxt.Text;
            Berichttxt.Text = "";
            Naam1.Text = "";

            /*String i = "pussy";
            String ii = "fuck";
            String iii = "ass";

            i = i.Replace("Pussy", "*****");
            ii = ii.Replace("Fuck", "*****");
            iii = iii.Replace("ass", "*****");*/


        }

    }
}
