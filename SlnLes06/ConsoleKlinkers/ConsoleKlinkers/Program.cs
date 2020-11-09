

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleKlinkers
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write(" geef een tekst : ");
            string str = Console.ReadLine();
            int aantalklinkers = 0;
            foreach (char c in str)
            {
                if (c == 'e') aantalklinkers++;
                else
                if (c == 'a') aantalklinkers++;
                else
                if (c == 'i') aantalklinkers++;
                else
                if (c == 'u') aantalklinkers++;
                else
                if (c == 'o') aantalklinkers++;
                else if (aantalklinkers != c) ;

            }


            Console.WriteLine($"deze tekst bevat {aantalklinkers++} klinkers");
            Console.WriteLine($"in geheimeschrift : ");
            Console.ReadKey();




        }
    }
}
