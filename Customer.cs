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

        //public void GetWeatherFactorNumber(Weather weather)
        //{
        
        //    if (weather.highTemperatureForecast == 92 && weather.forecast != "rain")
        //    {
        //        weatherFactorNumber = 2;
        //    }
        //    if ((weather.highTemperatureForecast == 85 || weather.highTemperatureForecast ==75) && weather.forecast != "rain")
        //    {
        //        weatherFactorNumber = 3;
        //    }
        //    if((weather.highTemperatureForecast == 67 || weather.highTemperatureForecast ==53) && weather.forecast != "rain")
        //    {
        //        weatherFactorNumber = 4;
        //    }
        //    if((weather.highTemperatureForecast == 92 || weather.highTemperatureForecast == 85))
        //    {
        //        weatherFactorNumber = 5;
        //    }
        //    else
        //    {
        //       weatherFactorNumber = 6;
        //    }
             
        //}

        public bool Purchase(int cupsSold, Weather weather)
        {
            weather.GetWeatherFactorNumber();
            GetOddsOfPurchasing(weather);
            if (oddsOfPurchasing == 1 || oddsOfPurchasing == 2)
            {
                
                cupsSold++;
                return true;
            }
            else
            {
                return false;
            }

            //if (purchase == true)
            //{
            //    cupsSold++;
            //}
        }
    }
}
