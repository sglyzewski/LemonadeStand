using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        //member variables
        public List<string> weatherOptions;
        public List<int> temperatureOptions;
        public string forecast;
        public int weatherFactorNumber;
        public int highTemperatureForecast;
        public Random random;
    //constructor
    public Weather()
    {
            weatherOptions = new List<string>() { "sunny", "overcast", "rain", "cloudy", "hazy" };
            temperatureOptions = new List<int>() {75, 53, 85, 92, 67};
            random = new Random();
     
        }
    //member methods

       public string DetermineWeatherForecast()
        {
            int forecastIndexValue;
           
            forecastIndexValue = random.Next(0, weatherOptions.Count);
            return weatherOptions[forecastIndexValue];
    
        }

        public int DetermineTemperatureForecast()
        {
            int forecastIndexValue;
           
            forecastIndexValue = random.Next(0, temperatureOptions.Count);
            return temperatureOptions[forecastIndexValue];
        }

        public void DetermineForecast()
        {
            forecast = DetermineWeatherForecast();
            highTemperatureForecast = DetermineTemperatureForecast();
        }

        public int GetWeatherFactorNumber()
        {

            if (highTemperatureForecast == 92 && forecast != "rain")
            {
              weatherFactorNumber = 2;
                return weatherFactorNumber;
            }
            else if ((highTemperatureForecast == 85 || highTemperatureForecast == 75) && forecast != "rain")
            {
                 weatherFactorNumber = 3;
                return weatherFactorNumber;
            }
            else if ((highTemperatureForecast == 67 || highTemperatureForecast == 53) && forecast != "rain")
            {
                weatherFactorNumber = 4;
                return weatherFactorNumber;
            }
           else  if ((highTemperatureForecast == 92 || highTemperatureForecast == 85))
            {
                weatherFactorNumber = 5;
                return weatherFactorNumber;
            }
            else
            {
                weatherFactorNumber = 6;
                return weatherFactorNumber;
            }

        }


    }
}
