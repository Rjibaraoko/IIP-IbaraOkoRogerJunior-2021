using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLancering
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("HOEVEEL SECONDE :");

            for (int i = 12; i >= 1; i--)
            {
                Console.WriteLine($"" +
                    $"in {i}.....");
                Console.ReadKey();

            }

            Console.WriteLine("GO............. ");
            Console.ReadKey();
        }
    }
}
