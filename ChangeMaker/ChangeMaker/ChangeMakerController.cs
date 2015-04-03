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
                                                           
        public string MakeChange(decimal amount)
        {
            Change change = new Change(amount);
            decimal remainder = amount;

            change.Hundreds = FindOccurencesOfAmount(remainder, HUNDRED);
            
            change.Fifties = FindOccurencesOfAmount(remainder -= (change.Hundreds * HUNDRED), FIFTY);            
          
            change.Twenties = FindOccurencesOfAmount(remainder -= (change.Fifties * FIFTY), TWENTY);
            
            change.Tens = FindOccurencesOfAmount(remainder -= (change.Twenties * TWENTY), TEN);

            change.Fives = FindOccurencesOfAmount(remainder -= (change.Tens * TEN), FIVE);           

            change.Ones = FindOccurencesOfAmount(remainder -= (change.Fives * FIVE), ONE);
            
            change.Quarters = FindOccurencesOfAmount(remainder -= (change.Ones * ONE), QUARTER);
            
            change.Dimes = FindOccurencesOfAmount(remainder -= (change.Quarters * QUARTER), DIME);

            change.Nickels = FindOccurencesOfAmount(remainder -= (change.Dimes * DIME), NICKEL);           

            change.Pennies = FindOccurencesOfAmount(remainder -= (change.Nickels * NICKEL), PENNY);

            return change.ToString();
        }
        private int FindOccurencesOfAmount(decimal currentAmount, int amountThatOccurs)
        {
            int occurences = 0;
            if(currentAmount >= amountThatOccurs)
            {
                occurences = ((int)currentAmount) / amountThatOccurs;
            }
            return occurences;
        }

        private int FindOccurencesOfAmount(decimal currentAmount, decimal amountThatOccurs)
        {
            int occurences = 0;
            if (currentAmount >= amountThatOccurs)
            {
                occurences = (int)(currentAmount / amountThatOccurs);
            }
            return occurences;
        }
        public static void Main(string[] args)
        {

        }
    }
}
