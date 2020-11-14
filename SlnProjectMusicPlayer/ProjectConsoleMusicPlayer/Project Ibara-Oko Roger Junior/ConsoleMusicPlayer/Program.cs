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

            var input = Console.ReadLine();
            Console.WriteLine("SPACEBAR om te pauseren/play");
            Console.WriteLine("UPARROW om geluid te veranderen");
            Console.WriteLine("RIGHTARROW om te muten");
            Console.WriteLine("LEFTARROW om te ontmuten"); 
            Console.WriteLine("BACKSPACE om liedje te stoppen en van liedje te veranderen");
            Console.WriteLine("\n");
            Console.WriteLine("ESCAPE om uit de applicatie te komen");
            Console.WriteLine("\n");




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
            //state = 4 is 

            int state = Convert.ToInt32(keypress.Key);
            state = 1;
            
            //een loop zodat als je op spacebar drukt hij niet onmiddelijk de rest van de functionaliteiten dropt
            while (keypress.Key != ConsoleKey.Escape)
            {
                    Console.WriteLine("MEDIAPLAYER");
                    Console.WriteLine("===========");
                    Console.WriteLine("\n");
                    Console.WriteLine("SPACEBAR om te pauseren/play");
                    Console.WriteLine("UPARROW om geluid te veranderen");
                    Console.WriteLine("RIGHTARROW om te muten");
                    Console.WriteLine("LEFTARROW om te ontmuten");
                    Console.WriteLine("BACKSPACE om liedje te stoppen en van liedje te veranderen");
                    Console.WriteLine("\n");
                    Console.WriteLine("ESCAPE om uit de applicatie te komen");
                    Console.WriteLine("\n");


                //als het muziek op start of pause is dan kan je steeds de volume veranderen
                
                    
                if (keypress.Key == ConsoleKey.Backspace)
                {
                        //na het stoppen van het liedje zal de user een nieuw liedje kunnen inputten
                        player.controls.stop();
                        Console.WriteLine("STOPPED");
                        Console.WriteLine("===========");
                        Console.WriteLine("Een ander bestand afspelen:");
                        Console.WriteLine("\n");
                        //Wat de user zal inzetten als path
                        var reinput = Console.ReadLine();
                        player.URL = System.IO.Path.Combine(musicFolder, reinput);
                    
                }
                    else
                    {   //zodat de user kan pauzeren
                        if (keypress.Key == ConsoleKey.Spacebar && state == 1)
                        {
                        player.controls.pause();
                        state = 0;
                        //Console.WriteLine(state);
                        Console.WriteLine("PAUSED");
                        }
                        //zodat de user terug het liedje op play kan zetten
                        else if (keypress.Key == ConsoleKey.Spacebar && state == 0)
                        {
                        player.controls.play();
                        state = 1;
                        //Console.WriteLine(state);
                        Console.WriteLine("PLAYING");

                        }
                        //het volume veranderen door op uparrow en een waarde te geven
                        else if (keypress.Key == ConsoleKey.UpArrow)
                        {

                        int huidigVolume = player.settings.volume;
                        Console.WriteLine($"Huidig volume: {huidigVolume}");
                        Console.WriteLine("Geef een waarde voor het volume die u wilt berijken (0-100)");
                        player.settings.volume = Convert.ToInt32(Console.ReadLine());
                        //state = 1;

                        }
                        //op right arrow drukken zodat het geluid gemute wordt links om het te ontmuten
                        else if (keypress.Key == ConsoleKey.RightArrow)
                        {
                        player.settings.mute = true;
                        Console.WriteLine("MUTED");
                        }
                        else if (keypress.Key == ConsoleKey.LeftArrow)
                        {
                        player.settings.mute = false;
                        Console.WriteLine("UNMUTED");
                        }

                        

                    }
                        /*if (player.settings.volume > 100 || player.settings.volume < 0)
                        {
                        Console.WriteLine("Gelieve een geldige waarde te geven voor het volume");
                        }*/


                keypress = Console.ReadKey();
                //om de console meer proper en user friendly te houden
                Console.Clear();

            }
            

            //ajouter une fonction pause pour que le loop sois moins lourd pour le pc
            
        }
    }
}
