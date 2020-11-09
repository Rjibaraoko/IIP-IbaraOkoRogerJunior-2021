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

namespace Wpf.Boodschappenlijst
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LblResultaat.Content = " Er is nog geen selectie gemaakt. ";
            
        }

        private void lb_changed(object sender, SelectionChangedEventArgs e)
        {
            
           


        }

        private void lb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (IsLoaded)
            {
                string txt = " je selecteerde : ";
                foreach (ListBoxItem lbi in lb.SelectedItems)
                {
                    txt += lbi.Content + " ";
                }
                LblResultaat.Content = (txt) ;
                
            }

    }
}
}
