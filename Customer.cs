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
        
        
        
        //constructor
        public Customer()
        {
            
           
        }

        //member methods
        public void GetOddsOfPurchasing(Weather weather)
        {
            random = new Random();
            oddsOfPurchasing = random.Next(1, weather.weatherFactorNumber);
        }

       

        public int Purchase( Weather weather)
        {
            int cupsSold = 0;
            weather.GetWeatherFactorNumber();
            GetOddsOfPurchasing(weather);
            if (oddsOfPurchasing == 1 || oddsOfPurchasing == 2)
            {

                cupsSold = 1;
                return cupsSold;
            }
            else
            {
                return cupsSold;
            }

            //if (purchase == true)
            //{
            //    cupsSold++;
            //}
        }
    }
}
