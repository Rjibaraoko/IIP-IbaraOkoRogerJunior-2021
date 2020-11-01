﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace ConsoleMusicPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Het make gebruiken van de music player
            WindowsMediaPlayer player = new WindowsMediaPlayer();

            //De path naar de folder van de muzieken
            string musicFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);

            //De exacte path naar het liedje met de naam                                
            player.URL = System.IO.Path.Combine(musicFolder, "the-final-coundown.mp3");

            //Overwrite the song als je skipt
            /*                                                                    
            player.URL = System.IO.Path.Combine(musicFolder, "god-is-a-dj.mp3");

            //Controls

            
            player.controls.pause();
            player.controls.play();
            player.controls.stop();

            int huidigVolume = player.settings.volume;
            Console.WriteLine($"Huidig volume: {huidigVolume}");

            player.settings.volume = 50;

            player.settings.mute = true;

            player.settings.mute = false;


            Console.Read();*/
        }
    }
}
