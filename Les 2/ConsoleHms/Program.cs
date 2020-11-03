using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHms
{
    class Program
    {
        static void Main(string[] args)
        {
            //Eerste zin d
            Console.WriteLine("Geef het aantal seconden:");
            var input = Convert.ToInt32(Console.ReadLine());


            TimeSpan t = TimeSpan.FromSeconds(input);
            //D2, D3 zijn het aantal digits in de conversie van seconden naar een echt uur
            string answer = string.Format("{0:D2}h:{1:D2}m:{2:D2}s",
                            t.Hours,
                            t.Minutes,
                            t.Seconds);
            Console.WriteLine("Omgezet in hms formaat:" + answer);
            Console.Read();
        }
    }
}
