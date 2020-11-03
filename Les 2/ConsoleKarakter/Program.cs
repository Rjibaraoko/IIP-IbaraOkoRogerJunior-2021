using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleKarakter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een kleine letter:");
            var input = Console.ReadLine();
            string[] alphabet = { "a", "b", "c", "d", "e", "f", "g", "h", 
            "i", "j", "k", "l", "m","n", "o", "p", "q", "r", "s", "t", "u", 
            "v", "w", "x", "y","z"};

            if (input == "")
            {
                alphabet[]
            }

            Console.WriteLine("De hoofdletter is:" + input.ToUpper());
            Console.WriteLine("De vorige letter is:" + input.());
            Console.WriteLine("De volgende letter is:" + input.ToUpper());
            Console.Read();

        }
    }
}
