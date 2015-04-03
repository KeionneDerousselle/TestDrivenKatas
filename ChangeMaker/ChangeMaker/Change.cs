using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeMaker
{
    public class Change
    {
        public decimal Total { get; private set; }
        public int Hundreds { get; set; }
        public int Fifties { get; set; }
        public int Twenties { get; set; }
        public int Tens { get; set; }
        public int Fives { get; set; }
        public int Ones { get; set; }
        public int Quarters { get; set; }
        public int Dimes { get; set; }
        public int Nickels { get; set; }
        public int Pennies { get; set; }

        public Change(decimal totalAmount)
        {
            Total = totalAmount;
        }

        public override string ToString()
        {
            return "100's: " + Hundreds + ", 50's: "
                + Fifties + ", 20's: " + Twenties +
                ", 10's: " + Tens + ", 5's: " + Fives
                + ", 1's: " + Ones + ", .25's: " +
                Quarters + ", .10's: " + Dimes +
                ", .05's: " + Nickels + ", .01's: "
                + Pennies + ", ";
        }

    }
}
