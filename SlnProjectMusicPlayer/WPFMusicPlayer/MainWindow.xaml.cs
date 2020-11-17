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
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public MainWindow()
        {
            InitializeComponent();
            //WindowsMediaPlayer player = new WindowsMediaPlayer();
            
            //De path naar de folder van de muzieken
            ////De path naar de folder van de muzieken
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic); //verandert MyDocuments naar MyMusic
            string startfolder = System.IO.Path.Combine(folderPath, Pathtxt.Text);
            // open stream and start reading
            //string path = Pathtxt.Text;
            //string[] array = Directory.GetFiles(startfolder); //Pathtxt.Text zal niet werken dus placeholder

            //List<String> files = array.ToList();
            DirectoryInfo dInfo = new DirectoryInfo(startfolder);
            FileInfo[] Files = dInfo.GetFiles();
            //player.controls.stop();
            //player.controls.pause();


        }
        
        private void PLAY_Click(object sender, RoutedEventArgs e)
        {

            /*bool textValue = Convert.ToBoolean(Pathtxt.Text);
            if (textValue == true)
            {
                //Medialist.Items
            }*/

            player.controls.play();

        }

        private void PAUSE_Click(object sender, RoutedEventArgs e)
        {
            player.controls.pause();
        }

        private void STOP_Click(object sender, RoutedEventArgs e)
        {
            player.controls.stop();
        }



        private void Medialist_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            /*string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic); //verandert MyDocuments naar MyMusic
            string startfolder = System.IO.Path.Combine(folderPath, Pathtxt.Text);
            // open stream and start reading
            string path = Pathtxt.Text;
            string[] array = Directory.GetFiles(startfolder); //Pathtxt.Text zal niet werken dus placeholder

            List<String> files = array.ToList();
            for (int i = 0; i < files.Count; i++)
            {
                Console.WriteLine($"{i}--" + System.IO.Path.GetFileName(files[i]));

            }*/
            
        }

        private void Pathtxt_Text(object sender, TextChangedEventArgs e)
        {
            DirectoryInfo dInfo = new DirectoryInfo(Pathtxt.Text);
            FileInfo[] Files = dInfo.GetFiles();
            foreach (FileInfo file in Files)
            {
                Medialist.Items.Add(file.Name);
            }

        }

        private void Medialist_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            string selectedSong = Convert.ToString(Medialist.SelectedItem);
            //What zal het zoeken van de file in het systeem zorgen
            //System.Diagnostics.Process.Start(selectedSong);

            //Het make gebruiken van de music player
            

            //De path naar de folder van de muzieken
            string musicFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);

            //De exacte path naar het liedje met de naam                         
            
            player.URL = System.IO.Path.Combine(musicFolder, selectedSong);

            player.controls.play();

            //Medialist.SelectedItem = true;

            lblCurrentSong.Content = "Current Song playing: " + Medialist.SelectedItem;
        }

        private void NEXT_TRACK_Click(object sender, RoutedEventArgs e)
        {
            player.controls.next();
        }

        private void PREVIOUS_TRACK_Click(object sender, RoutedEventArgs e)
        {
            player.controls.previous();
        }

        private void VolumeSlide_Value(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VolumeSlide.Value = player.settings.volume;
        }
    }
}
