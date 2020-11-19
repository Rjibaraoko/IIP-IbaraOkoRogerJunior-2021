using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEindCijfer
{
    class Program
    {
        static void Main(string[] args)
        {
            double dagelijks, project, cijfer, eindcijfer;

            Console.WriteLine("Berekening eindcijfer");
            Console.WriteLine("======================");
            Console.WriteLine("");

            Console.Write("Geef het cijfer dagelijks werk (op 20) : ");
            dagelijks = double.Parse(Console.ReadLine());
            Console.Write("Geef het Cijfer op het Project (op 20) : ");
            project = double.Parse(Console.ReadLine());
            Console.Write("Geef het cijfer op het examen(op 20) :");
            cijfer = double.Parse(Console.ReadLine());

            eindcijfer = (dagelijks * 0.30 + project * 0.20 + cijfer * 0.50) / 20 * 100;

            if (eindcijfer < 50)

            {
                Console.WriteLine(" onvoldoende ");

            }
            else if (eindcijfer >= 60 )
            {
                Console.WriteLine(" Grote onderschijding  ");

            }
            else if (eindcijfer >= 80) {
                Console.WriteLine("grootste onderschijding");
            }
            


            Console.WriteLine($"je eindcijfer is :{eindcijfer}%");
            Console.Read();




        }
    }
}
