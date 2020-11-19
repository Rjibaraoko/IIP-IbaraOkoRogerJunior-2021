using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBestelling
{
    class Program
    {
        static void Main(string[] args)
        {

            string pizza = "";
            string grootte = "";
            string extra = "";
            double prijs = 0;
            bool thuisbezorgen = true;


            Console.WriteLine(" Pizaa Bestelling ");
            Console.WriteLine(" =============== ");
            Console.WriteLine();



            Console.WriteLine(@" kies je pizza
 a) Margherita 8 Euro
 b) Funghi 10 Euro  
 c) Diabolo 11 Euro 
 d) Hawai 12 Euro ");
            Console.Write(">>>>> wat is je keuze ? : ");




            switch (Console.ReadLine()) /// keuze Pizza
            {
                case "a": pizza = "Margherita "; prijs = 8; break;
                case "b": pizza = "Funghi"; prijs = 10; break;
                case "c": pizza = "Diabolo"; prijs = 11; break;
                case "d": pizza = "Hawai"; prijs = 12; break;
                    
                default:
                    Console.WriteLine("Kies je Pizza"); break;
            }

            Console.WriteLine();

            //grootte Pizza
            Console.WriteLine(@" kies de grootte
 a) 15 CM (Klein; - 20%) 
 b) 20 CM (normaal)  
 c) 25 CM (groot + 20% ) 
 d) 60 CM (family size + 30%) ");
            Console.Write(">>>>> wat is je keuze ? : ");


            switch (Console.ReadLine())
            {
               case "a":  grootte = "Klein"; prijs -= prijs * Convert.ToDouble(-2); break;
                case "b": grootte = "normaal"; break;
                case "c": grootte = "groot"; prijs += prijs * Convert.ToDouble(0.20); break;
                case "d": grootte = "family size"; prijs += prijs * Convert.ToDouble(0.3); break;    
                default:
                    Console.WriteLine(" Kies de grootte "); break;

            }

            Console.WriteLine(""); 

            //Extra op de Pizza
            Console.WriteLine(@" extra
a) extra saus 0,50 euro 
b) extra kaas + 0,50 euro 
c) geen extra ");
            Console.Write(">>>>>>>>> wat is je keuze ? : ");

            switch (Console.ReadLine()) 
            {
                case "a": extra = " met  extra "; prijs += 0.50; break;
                case "b": extra = " met extra kaas"; prijs += 0.50 ; break;
                case "c": extra = ""; prijs += 0; break;
                default: Console.WriteLine("Kies een etra"); break;
            }

            //levering
            Console.WriteLine("");
            Console.Write(" thuis bezorgen (3 euro extra) ja /nee ");
            string keuze3e = Console.ReadLine();
            if (keuze3e == "ja")
            {
                prijs += 3;
                thuisbezorgen = true;
            } else if (keuze3e == "nee"){
                prijs += 0;
                thuisbezorgen = false;

            }
            string bezorgenTekst = thuisbezorgen ? "thuis bezorgd" : "afhalen";



            Console.WriteLine(" ");

            Console.WriteLine($"\nJouw bestelling: een "+ pizza + grootte+" voor "+ prijs + "euro " + bezorgenTekst  );
            Console.ReadKey();
        }
    }
}
