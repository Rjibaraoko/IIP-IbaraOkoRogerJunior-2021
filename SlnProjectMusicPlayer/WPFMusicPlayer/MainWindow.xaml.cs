using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
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
using WMPLib;

namespace WPFMusicPlayer
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowsMediaPlayer player = new WindowsMediaPlayer();

            //De path naar de folder van de muzieken
            ////De path naar de folder van de muzieken
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic); //verandert MyDocuments naar MyMusic
            string startfolder = System.IO.Path.Combine(folderPath, Pathtxt.Text);
            // open stream and start reading
            string path = Pathtxt.Text;
            string[] array = Directory.GetFiles(startfolder); //Pathtxt.Text zal niet werken dus placeholder

            List<String> files = array.ToList();
            
            //player.controls.stop();
            //player.controls.pause();

        }
        
        private void PLAY_Click(object sender, RoutedEventArgs e)
        {
            WindowsMediaPlayer player = new WindowsMediaPlayer();
            /*bool textValue = Convert.ToBoolean(Pathtxt.Text);
            if (textValue == true)
            {
                //Medialist.Items
            }*/
            player.controls.play();
        }

        private void GET_PATH_Click(object sender, RoutedEventArgs e)
        {
            
            
        }

        private void Medialist_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
