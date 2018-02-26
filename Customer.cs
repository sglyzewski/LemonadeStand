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
        Weather weather;
        int weatherFactorNumber;
        
        //constructor
        public Customer()
        {
            random = new Random();
            weather = new Weather();
        }

        //member methods
        public void GetOdds()
        {

            oddsOfPurchasing = random.Next(0, weatherFactorNumber);
        }

        public void GetWeatherFactorNumber()
        {

        }
    }
}
