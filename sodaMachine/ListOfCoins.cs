using sodaMachine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sodaMachine
{
    //list coins value
    public abstract class ListOfCoins
    {
        int Quarters = 20;
        int Dimes = 10;
        int Nickels = 20;
        int Pennies = 50;

        public abstract Quarters {get; Set;}

        public abstract dimes {get, Set }

        public abstract nickels {get, set}
        
        public abstract  Pennies {get, Set}
    }
}
