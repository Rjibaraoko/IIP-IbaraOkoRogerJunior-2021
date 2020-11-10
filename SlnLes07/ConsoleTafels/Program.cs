using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTafels
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een getal:");
            int get1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geef een lengte:");
            int get2 = Convert.ToInt32(Console.ReadLine());
            DrukTafel(get1, get2);
            Console.ReadKey();
        }

        private static void DrukTafel(int getal, int lengte)
        {
            for (int i = 1; i <= lengte; i++)
            {
                int resultaat = getal * i;
                Console.WriteLine($"{getal} X {i} = {resultaat}");
            }
            
        }
    }
}
