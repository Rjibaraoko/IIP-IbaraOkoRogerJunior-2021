using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakingClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an object of my class
            //an instance of Human
            Human david = new Human("David", "Carlson", 21, "blue");

            //access public var from outside, and even change it
                    //david.firstName = "David";
                    //david.lastName = "Carlson";
            //call methods of other class
            david.IntroduceMyself();

            Human james = new Human("James", "Carlson", 25, "green");
            james.IntroduceMyself();

            Human william = new Human("William", "Gregory", 23, "red");
            william.IntroduceMyself();

            Human michael = new Human("Michael", "Jackson", 32 , "brown" );
                    //michael.firstName = "Michael";
                    //michael.lastName = "Jackson";
            michael.IntroduceMyself();

            Console.ReadLine();
        }

        
    }
}
