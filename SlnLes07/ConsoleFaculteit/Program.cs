using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFaculteit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FACULTEIT BEREKENEN");
            Console.WriteLine("Geef een geheel getal:");
            int getal = Convert.ToInt32(Console.ReadLine());
            Faculteit(getal);
            Console.ReadKey();
        }

        private static int Faculteit(int n)
        {
            int i, facu = 1;
            for (i = 1; i <= n; i++)
            {
                facu = facu * i;
                Console.WriteLine($"de faculteit is {facu}");
             
            }
            return n;

        }
    }
}
