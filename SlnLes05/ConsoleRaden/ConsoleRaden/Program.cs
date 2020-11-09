using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRaden
{
    class Program
    {
        static void Main(string[] args)
        {
            int geheimGetal = 6; /// het getal te raden.

            Console.Write(" Raad een getal tussen 1 en 10 :");
            string antwoord = Console.ReadLine();
            int getal = Convert.ToInt32(antwoord);
            if ( getal > 6)
            {
                Console.WriteLine("gok is te hoog");
            }
            else if (getal < 6)
            {
                Console.WriteLine("gok is te laag");
            }
            else if (getal == 6) {
                Console.WriteLine();
            }

            if  (getal == geheimGetal) /// bij het fout gokken.
            {
                Console.WriteLine("Correct");
            }
            else  /// else als het correct geraden is anders voor andere nummers heeft die ; if (getal != geheimGetal)
            {
                Console.WriteLine("Fout geraden");
            }
        }
    }
}
