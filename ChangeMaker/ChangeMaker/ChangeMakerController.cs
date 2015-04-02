using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeMaker
{
    public class ChangeMakerController
    {
        private const int 
            HUNDRED = 100,
            FIFTY = 50,
            TWENTY = 20,
            TEN = 10,
            FIVE = 5,
            ONE = 1;

        private readonly decimal
            QUARTER = new decimal(.25),
            DIME = new decimal(.10),
            NICKEL = new decimal(.05),
            PENNY = new decimal(.01);
                                                           
                          
        static void Main(string[] args)
        {
        }
        //427.27
        public string MakeChange(decimal amount)
        {
            int hundreds = 0, fifties = 0, twenties = 0, tens = 0, fives = 0, ones = 0;
            decimal quarters = 0, dimes = 0, nickels = 0, pennies = 0;
            if(amount >= HUNDRED)
            {
                hundreds = ((int)amount) / HUNDRED;
            }
            decimal remainder = amount - (hundreds * HUNDRED);

            if(remainder >= FIFTY)
            {
                fifties = ((int)remainder) / FIFTY;
            }
            remainder = remainder - (fifties * FIFTY);

            if(remainder >= TWENTY)
            {
                twenties = ((int)remainder) / TWENTY;
            }
            remainder = remainder - (twenties * TWENTY);
            if(remainder >= TEN)
            {
                tens = ((int)remainder) / TEN;
            }
            remainder = remainder - (tens * TEN);
            if (remainder >= FIVE)
            {
                fives = ((int)remainder) / FIVE;
            }
            remainder = remainder - (fives * FIVE);
            if (remainder >= ONE)
            {
                ones = ((int)remainder) / ONE;
            }
            remainder = remainder - (ones * ONE);
            if (remainder >= QUARTER)
            {
                quarters = (int)(remainder / QUARTER);
            }
            remainder = remainder - (quarters * QUARTER);
            if (remainder >= TEN)
            {
                dimes = (int)(remainder / TEN);
            }
            remainder = remainder - (dimes * TEN);
            if (remainder >= NICKEL)
            {
                nickels = (int)(remainder / NICKEL);
            }
            remainder = remainder - (nickels * NICKEL);
            if (remainder >= PENNY)
            {
                pennies = (int)(remainder / PENNY);
            }
            remainder = remainder - (pennies * PENNY);
            return "100's: " + hundreds + ", 50's: " 
                + fifties + ", 20's: " + twenties +
                ", 10's: "+ tens+ ", 5's: " + fives
                + ", 1's: "+ ones+ ", .25's: " + 
                quarters + ", .10's: " + dimes +
                ", .05's: "+ nickels + ", .01's: "
                + pennies +", ";
        }
    }
}
