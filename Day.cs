using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        //member variables
        

        //recipe
        public int lemonsPerPitcher;
        public int cupsSugarPerPitcher;
        public int iceCubesPerGlass;
        public double pricePerCup;
        public int cupsSold;
        public int potentialCustomers;
        public double popularity;
        Weather weather;

        //constructor
        public Day()
        {
            lemonsPerPitcher = 4;
            cupsSugarPerPitcher = 4;
            iceCubesPerGlass = 4;
            pricePerCup = 0.25;
            weather = new Weather();

        }

        //member methods
        


        public void DetermineForecast()
        {
            weather.DetermineForecast();
        }

        public void GetPopularity()
        {
            popularity = (cupsSold / potentialCustomers);
        }

        public void MorningDayReport()
        {

        }

        public void RunDay()
        {
            weather.DetermineForecast();


        }
    }

}
