using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleExperiment01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dit is een spel waarbij je het nummer moet raden");
            Console.WriteLine("Guess wat het nummer is:");
            Random rightNum = new Random();
            int genNum = rightNum.Next(1, 10);
            int anwser = Convert.ToInt32(Console.ReadLine());
            
            int trigger = 1;
            while (anwser != genNum)
            {
                Console.WriteLine("Fout antwoord, herproberen?");
                int antwoord = Convert.ToInt32(Console.ReadLine());
                trigger++;
                if (antwoord == genNum && trigger < 4)
                {
                    Console.WriteLine("Gefeliciteerd het antwoord was: " + genNum);
                    break;
                }
                else if (trigger > 4)
                {
                    Console.WriteLine("Spijtig genoeg heeft u all uw kansen gebruikt");
                    break;
                }
                
            }

            
            Console.Read();
        }
    }
}
