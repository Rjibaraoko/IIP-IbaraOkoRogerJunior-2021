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

namespace WpfFormChecking
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

        private void BtnRegis_Click(object sender, RoutedEventArgs e)
        {
            int foutmelding = 0;
            
            LblerrorNaam.Content = "";
            if ( txtNaam.Text == "" )
            {
                
                LblerrorNaam.Content = (" naam moet ingevuld zijn  ");
                foutmelding++;
            } else
            {
                LblerrorNaam.Content = "";
            }
            LblerrorEmail.Content = "";
            if ( txtMail.Text == "")
            {
                
                LblerrorEmail.Content = " Email is verplicht. ";
                foutmelding++;
            }
            LblerrorPasw.Content = "";
            if ( txtCode.Text=="")
            {

                LblerrorPasw.Content = " Wachtwoord is verplicht. ";
                foutmelding++;
            }
            LblErrorGeslacht.Content = "";
            if ( RdMan.IsChecked == false && rdVrouw.IsChecked == false )
            {
                
                LblErrorGeslacht.Content = " Kies een geslacht. ";
                foutmelding++;
            }
            LblerrorIntersses.Content = "";
            if ( CheckProgrm.IsChecked == false && CheckNtwrk.IsChecked == false && CheckBusins.IsChecked == false)
            { 
                LblerrorIntersses.Content = " Verplicht! ";
                foutmelding++;
            }
            LblerrorGbrtdtm.Content = "";
            if ( DatePicker.SelectedDate.HasValue == false)
            {
                
                LblerrorGbrtdtm.Content = " Datum is verplicht ";
                foutmelding++;
            } 

            if ( foutmelding == 0)
            {

                Lblfouten.Content = " bedankt voor de registratie ! ";
            }
            else
            {
                Lblfouten.Content = ($" dit formulier bevat {foutmelding} fouten");
            }

        }

        private void BtnWissen_Click(object sender, RoutedEventArgs e)
        {
            txtCode.Text = "";
            txtMail.Text = "";
            txtNaam.Text = "";
            rdVrouw.IsChecked = false;
            RdMan.IsChecked = false;
            CheckBusins.IsChecked = false;
            CheckNtwrk.IsChecked = false;
            CheckProgrm.IsChecked = false;
            DatePicker.SelectedDate = null;
   
        }
    }
}
