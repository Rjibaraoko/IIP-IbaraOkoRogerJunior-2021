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
            var x = Fibonacci(input);

            foreach (int nummers in x)
            {
                Console.WriteLine(nummers);
            }
            
            Console.Read();
        }

        private static int[] Fibonacci(int nummer)
        {
            
            int[] a = new int[nummer];
            a[0] = 0;
            a[1] = 1;
            for (int i = 2; i < nummer; i++)
            {
                a[i] = a[i - 2] + a[i - 1];
            }
            return a;
        }
    }
    
}
