using System;
using System.Collections.Generic;
using System.IO;
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
            //de tekst dat zal opkomen bij het starten van het programma
            Console.WriteLine("MEDIAPLAYER");
            Console.WriteLine("===========");
            Console.WriteLine("Bestand afspelen:");
            //Wat de user zal inzetten als path
            var input = Console.ReadLine();

            //What zal het zoeken van de file in het systeem zorgen
            //System.Diagnostics.Process.Start(input);

            //Het make gebruiken van de music player
            WindowsMediaPlayer player = new WindowsMediaPlayer();

            //De path naar de folder van de muzieken
            string musicFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);



            //De exacte path naar het liedje met de naam                         

            player.URL = System.IO.Path.Combine(musicFolder, input);

            ConsoleKeyInfo keypress;
            keypress = Console.ReadKey();

            if (File.Exists(input))
            {
                if (keypress.Key == ConsoleKey.Escape)
                {
                    player.controls.pause();
                }
                else if (keypress.Key == ConsoleKey.Enter)
                {
                    player.controls.play();
                }
                else if (keypress.Key == ConsoleKey.Enter)
                {
                    player.controls.stop();
                }
                else
                {
                    player.controls.play();
                }

            }

            

            //player.settings.volume = 50;

            //player.settings.mute = true;

            //player.settings.mute = false;

            Console.Read();



            //Overwrite the song als je skipt
            /*                                                                    
            player.URL = System.IO.Path.Combine(musicFolder, "god-is-a-dj.mp3");

            //Controls

            
            player.controls.pause();
            player.controls.play();
            player.controls.stop();

            int huidigVolume = player.settings.volume;
            Console.WriteLine($"Huidig volume: {huidigVolume}");

           


            Console.Read();*/
        }
    }
}
