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
            Console.WriteLine("\n");
            //Wat de user zal inzetten als path
            var input = Console.ReadLine();

            Console.WriteLine("Spacebar om te pauseren/play");
            Console.WriteLine("Uparrow om te muten");
            Console.WriteLine("Downarrow om te ontmuten");
            Console.WriteLine("Enter om liedje te stoppen");
            Console.WriteLine("Backspace om geluid te veranderen");
            Console.WriteLine("schrijf 'quit' om uit de applicatie te komen");
            Console.ReadKey();

      
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

            //state = 0 is pause 
            //state = 1 is play
            //state = 2 volume weizigen terwijl pause
            //state = 3 volume weizigen terwijl play

            int state = Convert.ToInt32(keypress.Key);
            state = 1;
            
            //een loop zodat als je op spacebar drukt hij niet onmiddelijk de rest van de functionaliteiten dropt
            while (keypress.Key != ConsoleKey.Escape)
            {
                
                    Console.WriteLine("Spacebar om te pauseren/play");
                    Console.WriteLine("Uparrow om te muten");
                    Console.WriteLine("Downarrow om te ontmuten");
                    Console.WriteLine("Enter om liedje te stoppen");
                    Console.WriteLine("Backspace om geluid te veranderen");
                    Console.WriteLine("schrijf 'quit' om uit de applicatie te komen");
                    Console.ReadKey();
                
                //als het muziek op start of pause is dan kan je steeds de volume veranderen
                if (state == 3 || state == 4)
                {
                    
                    if (keypress.Key == ConsoleKey.Enter)
                    {
                        //c'est a cet endroit la qu'il doit lire l'input de l'utilisateur
                        int volume = Convert.ToInt32(Console.ReadLine());
                        player.settings.volume = volume;
                        if (state == 3)
                        {
                            state = 0;
                        }
                        else if (state == 4)
                        {
                            state = 1;
                        }
                    }
                    
                }
                else
                {
                    if (keypress.Key == ConsoleKey.Spacebar && state == 1)
                    {
                        player.controls.pause();
                        state = 0;
                        Console.WriteLine(state);
                    }

                    else if (keypress.Key == ConsoleKey.Spacebar && state == 0)
                    {
                        player.controls.play();
                        state = 1;
                        Console.WriteLine(state);

                    }
                    else if (keypress.Key == ConsoleKey.Tab)
                    {
                        player.controls.stop();
                    }
                    else if (keypress.Key == ConsoleKey.UpArrow)
                    {

                        int huidigVolume = player.settings.volume;
                        Console.WriteLine($"Huidig volume: {huidigVolume}");
                        Console.WriteLine("Tot welk volume wilt u komen");

                        if (state == 0)
                        {
                            state = 3;

                        }
                        else if (state == 1)
                        {
                            state = 4;
                        }
                    }

                }


                keypress = Console.ReadKey();
                
            }

            //ajouter une fonction pause pour que le loop sois moins lourd pour le pc
            
           

            
        }
    }
}
