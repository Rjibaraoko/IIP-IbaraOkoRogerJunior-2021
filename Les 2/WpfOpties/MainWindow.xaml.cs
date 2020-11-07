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

namespace WpfOpties
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

        private void chkbox_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            
            bool checking = Convert.ToBoolean(checkBox.IsChecked);
            int checking3 = Convert.ToInt32(checkBox.Tag);

            if (checking)
            {
                imgV.Visibility = Visibility.Visible;
            }
            else
            {
                imgV.Visibility = Visibility.Hidden;
            }


        }
    }
}
