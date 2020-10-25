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

namespace WpfCalculator
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

        private void _1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void lbl1_Click(object sender, RoutedEventArgs e)
        {
            lblReken.Inlines.Add(lbl1.Content + "");
        }

        private void lbl2_Click(object sender, RoutedEventArgs e)
        {
            lblReken.Inlines.Add(lbl2.Content + "");
        }

        private void lbl3_Click(object sender, RoutedEventArgs e)
        {
            lblReken.Inlines.Add(lbl3.Content + "");
        }

        private void lbl4_Click(object sender, RoutedEventArgs e)
        {
            lblReken.Inlines.Add(lbl4.Content + "");
        }

        private void lbl5_Click(object sender, RoutedEventArgs e)
        {
            lblReken.Inlines.Add(lbl5.Content + "");
        }

        private void lbl6_Click(object sender, RoutedEventArgs e)
        {
            lblReken.Inlines.Add(lbl6.Content + "");
        }

        private void lbl7_Click(object sender, RoutedEventArgs e)
        {
            lblReken.Inlines.Add(lbl7.Content + "");
        }

        private void lbl8_Click(object sender, RoutedEventArgs e)
        {
            lblReken.Inlines.Add(lbl8.Content + "");
        }

        private void lbl9_Click(object sender, RoutedEventArgs e) /// bouton, 9
        {
            lblReken.Inlines.Add(lbl9.Content + "");
        }

        private void lbl0_Click(object sender, RoutedEventArgs e) /// bouton 10
        {
            lblReken.Inlines.Add(lbl0.Content + "");
        }

        private void lbl__Click(object sender, RoutedEventArgs e) /// bouton + 
        {
            double cijfer1 = Convert.ToDouble (lbluitkomst.Content);
            double cijfer2 = Convert.ToDouble (lblReken.Text);
            lbluitkomst.Content = cijfer1 + cijfer2;
            lblReken.Text = "";
        }

        private void lblMin_Click(object sender, RoutedEventArgs e) ///bouton -
        {
            double cijfer1 = Convert.ToDouble(lbluitkomst.Content);
            double cijfer2 = Convert.ToDouble(lblReken.Text);
            lbluitkomst.Content = cijfer1 - cijfer2;
            lblReken.Text = "";
        }

        private void lblMaal_Click(object sender, RoutedEventArgs e) /// bouton MAAL *
        {
            double cijfer1 = Convert.ToDouble(lbluitkomst.Content);
            double cijfer2 = Convert.ToDouble(lblReken.Text);
            lbluitkomst.Content = cijfer1 * cijfer2;
            lblReken.Text = "";
        }

        private void lblCe_Click(object sender, RoutedEventArgs e) ///bouten CE
        {
            lblReken.Text = ""; /// TextBlock normaal
            lbluitkomst.Content = "0.0"; 
        }

        private void lblPunt_Click(object sender, RoutedEventArgs e)
        {
            lblReken.Inlines.Add(lblPunt.Content + "");
        }

        private void lebelDelen_Click(object sender, RoutedEventArgs e)
        {
            double cijfer1 = Convert.ToDouble(lbluitkomst.Content);
            double cijfer2 = Convert.ToDouble(lblReken.Text);
            lbluitkomst.Content = cijfer1 / cijfer2;
            lblReken.Text = "";
        }
    }
}
