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
            
            ////De path naar de folder van de muzieken
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic); //verandert MyDocuments naar MyMusic
            string startfolder = System.IO.Path.Combine(folderPath, Pathtxt.Text);
            

            
            DirectoryInfo dInfo = new DirectoryInfo(startfolder);
            //FileInfo[] Files = dInfo.GetFiles();
            


        }
        
        //Dit zal het muziek spelen
        private void PLAY_Click(object sender, RoutedEventArgs e)
        {

            player.controls.play();

        }

        //Dit zal het muziek pauzeren
        private void PAUSE_Click(object sender, RoutedEventArgs e)
        {
            player.controls.pause();
        }

        //Dit zal het muziek helemaal stoppen
        private void STOP_Click(object sender, RoutedEventArgs e)
        {
            player.controls.stop();
        }


        //Geen tijd genoeg om functionaliteit toe te voegen
        private void Medialist_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


        }

        //Dit zal de namen extracteren van de path en in in de listbox ordenen
        private void Pathtxt_Text(object sender, TextChangedEventArgs e)
        {
            DirectoryInfo dInfo = new DirectoryInfo(Pathtxt.Text);
            FileInfo[] Files = dInfo.GetFiles();
            foreach (FileInfo file in Files)
            {
                Medialist.Items.Add(file.Name);
            }

        }

        //Deze methode wordt gebruikt zodat als een user double klikt op een liedje het onmiddelijk wordt gespeeld
        private void Medialist_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            string selectedSong = Convert.ToString(Medialist.SelectedItem);
            

            //Het make gebruiken van de music player
            

            //De path naar de folder van de muzieken
            string musicFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);

            //De exacte path naar het liedje met de naam                         
            
            player.URL = System.IO.Path.Combine(musicFolder, selectedSong);

            player.controls.play();

            //Medialist.SelectedItem = true;

            lblCurrentSong.Content = "Current Song playing: " + Medialist.SelectedItem;
        }

        //Dit is normaal gezien om het volgende liedje te spelen in de lijst maar geen tijd genoeg om dit te inmplementeren
        private void NEXT_TRACK_Click(object sender, RoutedEventArgs e)
        {
            string selectedSong = Convert.ToString(Medialist.SelectedItem);


            //Het make gebruiken van de music player


            //De path naar de folder van de muzieken
            string musicFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);

            //De exacte path naar het liedje met de naam                         

            player.URL = System.IO.Path.Combine(musicFolder, selectedSong);

            Medialist.SelectedItem = true;

            lblCurrentSong.Content = "Current Song playing: " + selectedSong;
            //player.controls.next();
            Medialist.SelectedIndex += 1;
            //player.controls.play();
        }

        //Dit is normaal gezien om het vorige liedje te spelen in de lijst maar geen tijd genoeg om dit te inmplementeren
        private void PREVIOUS_TRACK_Click(object sender, RoutedEventArgs e)
        {
            string selectedSong = Convert.ToString(Medialist.SelectedItem);


            //Het make gebruiken van de music player


            //De path naar de folder van de muzieken
            string musicFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);

            //De exacte path naar het liedje met de naam                         

            player.URL = System.IO.Path.Combine(musicFolder, selectedSong);

            //Medialist.SelectedItem = true;

            lblCurrentSong.Content = "Current Song playing: " + selectedSong;
            //player.controls.previous();
            Medialist.SelectedIndex -= 1;
            //player.controls.play();

            if (Medialist.SelectedIndex == 0)
            {

            }

        }


















        //Om volume te veranderen maar geen tijd om bugs te verbeteren
        private void VolumeSlide_Value(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double huidigVolume = player.settings.volume;
            huidigVolume = VolumeSlide.Value;
            Volume_.Content = huidigVolume;
        }

        //om het geluid van het liedje te muten
        private void MUTE_Click(object sender, RoutedEventArgs e)
        {
            player.settings.mute = true;
        }

        //om het geluid van het liedje terug aan te zetten
        private void UNMUTE_Click(object sender, RoutedEventArgs e)
        {
            player.settings.mute = false;
        }

        //een andere functionaliteit waarbij we een nieuw liedje zouden kunnen toevoegen maar geeen tijd om dit te implementeren

        /* private void ADD_SONG_Click(object sender, RoutedEventArgs e)
         {
            

         }*/
    }
}
