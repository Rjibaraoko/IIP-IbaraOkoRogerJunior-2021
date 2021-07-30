using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakingClasses
{
    // this class is a blueprint for a datatype
    class Human
    {
        //member variable
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;
        // constructor
        public Human(string MyFirstName, string lastName, int age, string eyeColor)
        {
            //manière 1
            firstName = MyFirstName;
            //manière 2
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        //member method
        public void IntroduceMyself()
        {
            Console.WriteLine("Hi, my name is {0} {1}", firstName, lastName);
            Console.WriteLine("I'm {0} {1} {2} {3}", age, " years old and with", eyeColor, "eyes");
            
        }

    }
}
