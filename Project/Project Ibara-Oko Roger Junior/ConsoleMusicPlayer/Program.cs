using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            Console.ReadKey();
            Console.WriteLine("Spacebar om te pauseren/play");
            Console.WriteLine("Uparrow om te muten");
            Console.WriteLine("Downarrow om te ontmuten");
            Console.WriteLine("Enter om liedje te stoppen");
            Console.WriteLine("Backspace om geluid te veranderen");
            
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

            string path = input;
            FileInfo filepath = new FileInfo(path);

            int druk = Convert.ToInt32(keypress.Key);
            druk = 0;

            
            while (keypress.Key == ConsoleKey.Spacebar)
            {
                
                player.controls.pause();
                druk++;


                if (keypress.Key == ConsoleKey.Spacebar && druk > 1)
                {
                    player.controls.play();
                    druk--;
                    
                }

            }

            while (keypress.Key == ConsoleKey.Enter)
            {
                player.controls.stop();
                break;
            }

            if (keypress.Key == ConsoleKey.Backspace)
            {
                int huidigVolume = player.settings.volume;
                Console.WriteLine($"Huidig volume: {huidigVolume}");

                Console.WriteLine("Naar hoeveel wil je het volume veranderen?");
                player.settings.volume = Convert.ToInt32(Console.ReadLine());

                //int Volumes = Convert.ToInt32(Console.ReadLine());
                /*if (Volumes > 100 )
                {
                    Console.WriteLine("Ongeldige waarde. Geef een waarde onder de 100");
                }

                if (Volumes < 0)
                {
                    Console.WriteLine("Ongeldige waarde. Geef een waarde boven de 0");
                }*/


                  }

            //als je op de up arrow drkt zal de app de volume helemaal muten
            if (keypress.Key == ConsoleKey.UpArrow)
            {
                player.settings.mute = true;
            }
            //als je op de up arrow drukt zal de applicatie de volume terug herstellen
            if (keypress.Key == ConsoleKey.DownArrow)
            {
                player.settings.mute = false;
            }

            


            Console.Read();


            
        }
    }
}
