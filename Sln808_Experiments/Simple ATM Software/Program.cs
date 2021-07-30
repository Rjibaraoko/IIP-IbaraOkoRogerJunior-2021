using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_ATM_Software
{
    class SimpleATM
    {
        static void Main(string[] args)
        {
            //Message for first interaction with the ATM
            Console.WriteLine("Hello welcome to Fortis");
            Console.WriteLine("Please enter your debit card:");

            //OR IT IS THAT PART THAT IS GIVING ME SOME SHIT OR......

            //Input to read the number of the debit card
            
            int debitCardInp = Convert.ToInt32(Console.ReadLine());
            int kaart = 1;            
            

            //statement if the number is correct/wrong

            

            if (debitCardInp != kaart)
            {
                Console.WriteLine("Wrong card number you will be disconnected");
                Console.Read();
                System.Environment.Exit(0);

            }

            else if (debitCardInp == kaart)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("\n");
                Console.WriteLine("Give us your PIN code...");
                int pinCode = Convert.ToInt32(Console.ReadLine());
                int Code = 1;

                if (pinCode == Code)
                {
                    Menu();
                }
                else
                {
                    Console.WriteLine("Wrong PIN code you will be " +
                        "disconnected and your card will be returned");
                    Console.Read();
                    
                    System.Environment.Exit(0);
                    
                }

                
            }

        }


        private static void Menu()
        {
            int state = 1;

            while (state == 1)
            {
                int balance = 5000;
                Console.WriteLine("Which option are you choosing? ");
                Console.WriteLine("1. Get cash");
                Console.WriteLine("2. Your previous transactions");
                Console.WriteLine("3. Show your balance");
                Console.WriteLine("4. Stop transaction and get your card back");
                Console.WriteLine("\n");

                string option = Console.ReadLine();
                Console.Clear();

                //switch case is not looping (after one role he consideres the job done and stops
                //with activating the cases

                switch (option)
                {
                    case "1":
                        
                       Console.WriteLine("Current balance: " + balance + "£");
                       Console.WriteLine("How much cash do you want?");
                       int removal = Convert.ToInt32(Console.ReadLine());
                       int totalBalance = balance - removal;
                        //wihtdrawl error doesn't work
                       int maxWithdrawl = 1000;
                       if (removal >= maxWithdrawl)
                       {
                            Console.WriteLine("Invalid amount, you can withdrawl only 1000 £ or less");
                            Console.Clear();
                            break;
                       }
                       Console.Clear();
                       Console.WriteLine("Your total balance will be {0}", totalBalance);
                       Console.WriteLine("Confirm?");
                       string confirmation = Console.ReadLine();
                       if (confirmation == "yes")
                       {
                            Console.WriteLine("You have removed {0}", removal + " of your bank account");
                       }
                        Console.WriteLine("\n");
                        //state = 0;     
                        
                        continue;
                    case "2":
                        Console.WriteLine("Here are your 5 previous transactions");
                        Console.WriteLine("-500");
                        Console.WriteLine("-5");
                        Console.WriteLine("-600");
                        Console.WriteLine("+1200");
                        Console.WriteLine("+40");
                        Console.WriteLine("\n");
                        //state = 0;
                        continue;

                    case "3":
                        Console.WriteLine("Here is your balance:");
                        Console.WriteLine(balance + "£");
                        Console.WriteLine("\n");
                        //state = 0;
                        continue;
                    case "4":
                        state = 0;
                        Console.WriteLine("Your card will be returned to you immediatly");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Invalid input please choose one of these options");
                        Console.WriteLine("\n");
                        continue;
                }                
            }            
            Console.Read();
            

        }

    }
}
