using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGGD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BEREKEN GROOTST GEMENE DELER");
            Console.WriteLine("============================");

            Console.WriteLine("Getal 1:");
            int Getal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Getal 2:");
            int Getal2 = Convert.ToInt32(Console.ReadLine());

            int result;
            
            while (Getal1 != Getal2)
            {
                if (Getal1 > Getal2)
                {
                   result  = Getal1 - Getal2;
                }
                else
                {
                    result = Getal2 - Getal1;
                }
                Console.WriteLine($"De grootst gemene deler is: {result}");
                break;
            }
            Console.Read();
        }
    }
}
