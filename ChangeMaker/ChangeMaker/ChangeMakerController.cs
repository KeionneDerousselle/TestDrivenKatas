using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeMaker
{
    public class ChangeMakerController
    {
        static void Main(string[] args)
        {
        }
        //427.27
        public string MakeChange(decimal amount)
        {
            int hundreds = 0, fifties = 0, twenties = 0, tens = 0, fives = 0, ones = 0;
            decimal quarters = 0, dimes = 0, nickels = 0, pennies = 0;
            if(amount >= 100)
            {
                hundreds = ((int)amount) / 100;
            }
            decimal remainder = amount - (hundreds * 100);

            if(remainder >= 50)
            {
                fifties = ((int)remainder) / 50;
            }
            remainder = remainder - (fifties * 50);

            if(remainder >= 20)
            {
                twenties = ((int)remainder) / 20;
            }
            remainder = remainder - (twenties * 20);
            if(remainder >= 10)
            {
                tens = ((int)remainder) / 10;
            }
            remainder = remainder - (tens * 10);
            if (remainder >= 5)
            {
                fives = ((int)remainder) / 5;
            }
            remainder = remainder - (fives * 5);
            if (remainder >= 1)
            {
                ones = ((int)remainder) / 1;
            }
            remainder = remainder - (ones * 1);
            if (remainder >= ((decimal).25))
            {
                quarters = (int)(remainder / ((decimal).25));
            }
            remainder = remainder - (quarters * ((decimal).25));
            if (remainder >= ((decimal).10))
            {
                dimes = (int)(remainder / ((decimal).10));
            }
            remainder = remainder - (dimes * ((decimal).10));
            if (remainder >= ((decimal).05))
            {
                nickels = (int)(remainder / ((decimal).05));
            }
            remainder = remainder - (nickels * ((decimal).05));
            if (remainder >= ((decimal).01))
            {
                pennies = (int)(remainder / ((decimal).01));
            }
            remainder = remainder - (pennies * ((decimal).01));
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
