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

namespace WpfEllipsen
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // maak de ellips
            Ellipse newEllipse = new Ellipse();
            newEllipse.Width = 150;
            newEllipse.Height = 60;
            newEllipse.Fill = new SolidColorBrush(Color.FromRgb(122, 78, 200));
            double xPos = 50;
            double yPos = 85;
            newEllipse.SetValue(Canvas.LeftProperty, xPos);
            newEllipse.SetValue(Canvas.TopProperty, yPos);
            //voeg ellips toe aan het canvas
            canvas1.Children.Add(newEllipse);
        }

        private void btnTekenen_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            Byte[] b = new Byte[255];
            rnd.NextBytes(b);
            double rand = rnd.NextDouble();
            int n = 255;

            for (int i = 0; i < n; i++)
            {
            Ellipse newEllipse = new Ellipse();
            newEllipse.Width = rand;
            newEllipse.Height = rand;
            newEllipse.Fill = new SolidColorBrush(Color.FromRgb(b[i], b[i], b[i]));
            double xPos = rand;
            double yPos = rand;
            newEllipse.SetValue(Canvas.LeftProperty, xPos);
            newEllipse.SetValue(Canvas.TopProperty, yPos);
            canvas1.Children.Add(newEllipse);
            }

            
        }
    }
}
