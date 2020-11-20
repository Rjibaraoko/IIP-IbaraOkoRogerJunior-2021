using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een cijfer:");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            // het werkt alleen maar als ik een var gebruik doordat het een array is. Ik weet niet precies waarom....
            var x = Fibonacci(input);

            foreach (int nummers in x)
            {
                Console.WriteLine(nummers);
                
            }
            
            Console.Read();
        }

        private static int[] Fibonacci(int nummer)
        {
            int[] y = new int[nummer];
            y[0] = 0;
            y[1] = 1;

            for (int i = 2; i < nummer; i++)
            {
                y[i] = y[i - 2] + y[i - 1];
            }

            return y;
        }
    }
    
}
