using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBMI
{
    class Program
    {
        static void Main(string[] args)
        {
            //De tekst genereren
            Console.WriteLine("BMI CALCULATOR");
            Console.WriteLine("==============");
            Console.WriteLine("Lengte (in cm):");
            //De input van de user onthouden
            var Lengte = Convert.ToDouble(Console.ReadLine()) / 100;
            Console.WriteLine("Gewicht (in kg):");
            var Gewicht = Convert.ToDouble(Console.ReadLine());
            //formule voor het maken van de berekening van de BMI
            var BMI = Gewicht / (Lengte * Lengte);
            //het resultaat afgerond
            Console.WriteLine("Je BMI bedraagt:" + Math.Round(BMI, 1));

            Console.ReadKey();
            
        }
    }
}
