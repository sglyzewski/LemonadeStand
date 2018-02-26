using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        //member variables
        int oddsOfPurchasing;
        Random random;
        int weatherFactorNumber;
        
        //constructor
        public Customer(Random random)
        {
            this.random = random;
        }

        //member methods
        public void GetOdds()
        {

            oddsOfPurchasing = random.Next(0, weatherFactorNumber);
        }
    }
}
