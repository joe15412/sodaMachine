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
        public static displayWelcome()
        {
            Console.WriteLine("Welcome to the vending machine!");
            Console.WriteLine("What type of soda do you want?");
            Console.WriteLine("G: Grape");
            Console.WriteLine("L: Lemon");
            Console.WriteLine("O: Orange");

           string value = Console.ReadLine();
            switch (value)
            {
             case G:
                    Console.WriteLine("There are" + Inventory.grapeSoda + "cans left.")
 


              case L;
                    Console.WriteLine("There are" + Inventory.lemonSoda + "cans left")
 


              case O;
                    Console.WriteLine("There are" + Inventory.orangeSoda + "cans left")
 



               default: "invalid entry";
            }




            }
        }
                
                
               
                )





                

        }

    }
}
