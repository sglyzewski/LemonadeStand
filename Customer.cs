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
        bool purchase;
        
        //constructor
        public Customer()
        {
            random = new Random();
            weather = new Weather();
        }

        //member methods
        public void GetOdds()
        {
            oddsOfPurchasing = random.Next(1, weatherFactorNumber);
        }

        public void GetWeatherFactorNumber()
        {
        
            if (weather.highTemperatureForecast == 92 && weather.forecast != "rain")
            {
                weatherFactorNumber = 2;
            }
            if ((weather.highTemperatureForecast == 85 || weather.highTemperatureForecast ==75) && weather.forecast != "rain")
            {
                weatherFactorNumber = 3;
            }
            if((weather.highTemperatureForecast == 67 || weather.highTemperatureForecast ==53) && weather.forecast != "rain")
            {
                weatherFactorNumber = 4;
            }
            if((weather.highTemperatureForecast == 92 || weather.highTemperatureForecast == 85))
            {
                weatherFactorNumber = 5;
            }
            else
            {
               weatherFactorNumber = 6;
            }
             
        }

        public void Purchase(int cupsSold)
        {
            GetWeatherFactorNumber();
            GetOdds();
            if (oddsOfPurchasing == 1)
            {
                purchase = true;
            }

            if (purchase == true)
            {
                cupsSold++;
            }
        }
    }
}
