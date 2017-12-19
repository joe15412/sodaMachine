using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sodaMachine
{
    public class UserInterface
    //let them select soda type
    //tell them how much it cost
    //show user money available
    //do they have exact change
    //do they need change back
    // do they want to make another purchase
    //if no change in machine, cancel order

    {
        private static int sodaType;

        public static string grapeSodaQty { get; set; }
        public static string LemonSodaQty { get; set; }
        public static string orangeSodaQty { get; set; }

        public static void displayWelcome()
        {
            Console.WriteLine("Welcome to the vending machine!");
            Console.WriteLine("What type of soda do you want?");
            Console.WriteLine("[1}: Grape");
            Console.WriteLine("[2]: Lemon");
            Console.WriteLine("[3]: Orange");

            string value = Console.ReadLine();
            switch (value)
            {
                case 1:
                    Console.WriteLine("There are" + grapeSodaQty + "cans left.");
                    Console.WriteLine("Grape costs 60 cents.");
                    return;
                case 2:
                    Console.WriteLine("There are" + LemonSodaQty + "cans left.");
                    Console.WriteLine("Lemon costs 6 cents.");
                    return;
                case 3:
                    Console.WriteLine("There are" + orangeSodaQty + "cans left.");
                    Console.WriteLine("Orange costs 35 cents.");
                    return;
            }


            default: "Invalid entry;";

            // types available - quanitity wanted
            //if more then 5 of type then error message

            Console.WriteLine("What type do you want?");
            string type = Console.ReadLine();


            Console.WriteLine("How Many do you want?");
            int qty = Console.Read();

            //how do you want to pay for it
            //show listofcoins available
            //add getters and setters

            Console.WriteLine("How would you like to pay?");



        }
    }











}