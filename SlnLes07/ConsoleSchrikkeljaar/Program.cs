using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSchrikkeljaar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SCHRIKKELJAAR");
            Console.WriteLine("=============");
            Console.WriteLine("Geef een jaartal:");
            int input = Convert.ToInt32(Console.ReadLine());
            Schrikkle(input);
            
        }

        private static void Schrikkle(int jaar)
        {
            while (jaar > 0)
            {
                Console.WriteLine("Geef een jaartal:");
                jaar = Convert.ToInt32(Console.ReadLine());

                if (jaar % 400 == 0 || (jaar % 4 == 0 && jaar % 100 != 0))
                {
                    Console.WriteLine($"{jaar} is een schrikkeljaar");
                }
                else
                {
                    Console.WriteLine($"{jaar} is geen schrikkeljaar");
                }

                if (jaar <= 0)
                {
                    Environment.Exit(0);
                }
                Console.ReadKey();

            }
            
        }

    }
}
