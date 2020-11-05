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


            /*while (File.Exists(input))
            {
                if (keypress.Key == ConsoleKey.UpArrow)
                {
                    player.controls.pause();
                }
                else if (keypress.Key == ConsoleKey.Spacebar)
                {
                    player.controls.play();
                }
            }*/

            bool rap = Convert.ToBoolean(keypress.Key);

            while (rap)
            {
                switch (keypress.Key)
                {
                    case ConsoleKey.Spacebar:
                        {
                            player.controls.pause();
                            break;
                        }
                    case ConsoleKey.Escape:
                        {
                            player.controls.play();
                            break;
                        }
                    case ConsoleKey.Enter:
                        {
                            player.controls.stop();
                            break;
                        }
                    default: break;
                }
            }

            

            Console.ReadKey();
            
        }
    }
}
