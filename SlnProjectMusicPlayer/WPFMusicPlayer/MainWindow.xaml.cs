using Microsoft.Win32;
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
            string musicFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            player.URL = System.IO.Path.Combine(musicFolder, input);
            
            player.controls.stop();
            player.controls.pause();

        }
        string path;
        private void PLAY_Click(object sender, RoutedEventArgs e)
        {

            player.controls.play();
        }

        private void GET_PATH_Click(object sender, RoutedEventArgs e)
        {
            
            
        }
    }
}
