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
        public string forecast;
        public string currentWeather;
        public Random random;
    //constructor
    public Weather()
    {
            weatherOptions = new List<string>() { "sunny", "overcast", "rain", "cloudy" };
            random = new Random();
     
        }
    //member methods

       public void DetermineForecast(List<string> weatherOptions)
        {
            int forecastIndexValue;
            this.random = random;
            forecastIndexValue = random.Next(0, weatherOptions.Count);
            forecast = weatherOptions[forecastIndexValue];
            Console.WriteLine(forecast);
        }
        
}
}
