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
            Console.WriteLine("Folder listen:");
            Console.WriteLine("\n");

            var input = Console.ReadLine();
            Console.WriteLine("HOME BUTTON om liedjes uit de lijst de kunnen selecteren");
            Console.WriteLine("SPACEBAR om te pauseren/play");
            Console.WriteLine("UPARROW om geluid te veranderen");
            Console.WriteLine("RIGHTARROW om te muten");
            Console.WriteLine("LEFTARROW om te ontmuten");
            Console.WriteLine("BACKSPACE om liedje te stoppen en van liedje te veranderen");
            Console.WriteLine("PAGE UP om een liedje toe te voegen aan de lijst");
            Console.WriteLine("PAGE DOWN om een liedje te verwijderen van de lijst");
            Console.WriteLine("\n");
            Console.WriteLine("ESCAPE om uit de applicatie te komen");
            Console.WriteLine("\n");
            Console.WriteLine("Lijst van de gegeven lietjes");
            Console.WriteLine("\n");

            WindowsMediaPlayer player = new WindowsMediaPlayer();

            //De path naar de folder van de muzieken
            ////De path naar de folder van de muzieken
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string startfolder = System.IO.Path.Combine(folderPath, input);
            // open stream and start reading
            string[] array = Directory.GetFiles(input);

            List<String> files = array.ToList();

            ConsoleKeyInfo keypress;
            keypress = Console.ReadKey();

            //string path = input;
            //FileInfo filepath = new FileInfo(path);

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
                Console.WriteLine("HOME BUTTON om liedjes uit de lijst de kunnen selecteren");
                Console.WriteLine("SPACEBAR om te pauseren/play");
                Console.WriteLine("UPARROW om geluid te veranderen");
                Console.WriteLine("RIGHTARROW om te muten");
                Console.WriteLine("LEFTARROW om te ontmuten");
                Console.WriteLine("BACKSPACE om liedje te stoppen en van liedje te veranderen");
                Console.WriteLine("PAGE UP om een liedje toe te voegen aan de lijst");
                Console.WriteLine("PAGE DOWN om een liedje te verwijderen van de lijst");
                Console.WriteLine("\n");
                Console.WriteLine("ESCAPE om uit de applicatie te komen");
                Console.WriteLine("\n");
                Console.WriteLine("Lijst van de gegeven lietjes");
                Console.WriteLine("\n");
                for (int i = 0; i < files.Count; i++)
                {
                    Console.WriteLine($"{i}--" + Path.GetFileName(files[i]));

                }

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
                    int liedje = Convert.ToInt32(Console.ReadLine());
                    player.URL = System.IO.Path.Combine(folderPath, files[liedje]);
                    Console.WriteLine($"Current song: {Path.GetFileName(files[liedje])}");

                }
                else
                {
                    //dit is om een keuze te kunnen maken in de lijst van liedjes die gegeven zijn
                    if (keypress.Key == ConsoleKey.Home)
                    {
                        Console.WriteLine("\n");
                        int liedje = Convert.ToInt32(Console.ReadLine());
                        player.URL = System.IO.Path.Combine(folderPath, files[liedje]);
                        Console.WriteLine($"Current song: {Path.GetFileName(files[liedje])}");

                        Console.WriteLine("\n");
                        /*if (state == 2)
                        {
                            Console.WriteLine("Wilt u een liedje toevoegen?");
                            String toevoeging = Console.ReadLine();
                            files.Add(toevoeging);
                        }*/

                    }

                    //zodat de user kan pauzeren
                    else if (keypress.Key == ConsoleKey.Spacebar && state == 1)
                    {
                        player.controls.pause();
                        state = 0;
                        //Console.WriteLine(state);
                        Console.WriteLine("\n");
                        Console.WriteLine("PAUSED");
                    }
                    //zodat de user terug het liedje op play kan zetten
                    else if (keypress.Key == ConsoleKey.Spacebar && state == 0)
                    {
                        player.controls.play();
                        state = 1;
                        //Console.WriteLine(state);
                        Console.WriteLine("\n");
                        Console.WriteLine("PLAYING");

                    }
                    //het volume veranderen door op uparrow en een waarde te geven
                    else if (keypress.Key == ConsoleKey.UpArrow)
                    {
                        Console.WriteLine("\n");
                        int huidigVolume = player.settings.volume;
                        Console.WriteLine($"Huidig volume: {huidigVolume}");
                        Console.WriteLine("Geef een waarde voor het volume die u wilt berijken (0-100)");
                        player.settings.volume = Convert.ToInt32(Console.ReadLine());
                        //state = 1;

                    }
                    //op right arrow drukken zodat het geluid gemute wordt links om het te ontmuten
                    else if (keypress.Key == ConsoleKey.RightArrow)
                    {
                        Console.WriteLine("\n");
                        player.settings.mute = true;
                        Console.WriteLine("MUTED");
                    }
                    else if (keypress.Key == ConsoleKey.LeftArrow)
                    {
                        Console.WriteLine("\n");
                        player.settings.mute = false;
                        Console.WriteLine("UNMUTED");
                    }
                    else if (keypress.Key == ConsoleKey.PageUp)
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("Welk liedje wilt u toevoegen in de lijst?");
                        Console.WriteLine("\n");
                        String toevoeging = Console.ReadLine();
                        files.Add(toevoeging);
                    }
                    else if (keypress.Key == ConsoleKey.PageDown)
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("Wilt u een liedje verwijderen van de lijst?");
                        Console.WriteLine("\n");
                        int liedje = Convert.ToInt32(Console.ReadLine());

                        files.Remove(files[liedje]);
                    }
                    /*else if (keypress.Key == ConsoleKey.End)
                    {
                        Console.WriteLine("\n");
                        int liedje = Convert.ToInt32(Console.ReadLine());
                        liedje =+ 1;
                        player.URL = System.IO.Path.Combine(folderPath, files[liedje]);
                        Console.WriteLine($"Next song: {Path.GetFileName(files[liedje])}");
                    }*/



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
