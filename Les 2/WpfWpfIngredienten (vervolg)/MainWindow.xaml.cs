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

namespace WpfWpfIngredienten__vervolg_
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
            int personen = Convert.ToInt32(personcombo.SelectedIndex);

            //dont forget to use string interpolation
            int hoeveel = Convert.ToInt32(hoevtxt.Text);
            int hoeveel2 = Convert.ToInt32(hoevtxt2.Text);
            int hoeveel3 = Convert.ToInt32(hoevtxt3.Text);
            int hoeveel4 = Convert.ToInt32(hoevtxt4.Text);

            ComboBoxItem selectedItem = (ComboBoxItem)eenheidcombo.SelectedItem;
            ComboBoxItem selectedItem2 = (ComboBoxItem)eenheidcombo2.SelectedItem;
            ComboBoxItem selectedItem3 = (ComboBoxItem)eenheidcombo3.SelectedItem;
            ComboBoxItem selectedItem4 = (ComboBoxItem)eenheidcombo4.SelectedItem;

            boodschlbl.Content = "-" + hoeveel * personen + " " + selectedItem.Content + " " + ingtxt.Text + " " + Environment.NewLine +
                "-" + hoeveel2 * personen + " " + selectedItem2.Content + " " + ingtxt2.Text + " " + Environment.NewLine
                + "-" + hoeveel3 * personen + " " + selectedItem3.Content + " " + ingtxt3.Text + " " + Environment.NewLine +
                "-" + hoeveel4 * personen + " " + selectedItem4.Content + " " + ingtxt4.Text + " " + Environment.NewLine;

        }
    }

}
