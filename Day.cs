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
        

        public int lemonsPerPitcher;
        public int cupsSugarPerPitcher;
        public int iceCubesPerGlass;
        public double pricePerCup;
        public int cupsSold;
        public int potentialCustomers;
        public double popularity;
        int pitcherLooper;
        Random random;
        Weather weather;
        IceCubes iceCubes;
        Lemons lemons;
        Sugar sugar;
        Cups cups;

        //constructor
        public Day()
        {
            lemonsPerPitcher = 4;
            cupsSugarPerPitcher = 4;
            iceCubesPerGlass = 4;
            pricePerCup = 0.25;
            cupsSold = 0;
            random = new Random();
            lemons = new Lemons();
            sugar = new Sugar();
            iceCubes = new IceCubes();
            cups = new Cups();
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

        public void DetermineGlassesPerPitcher ()
        {
            if(iceCubesPerGlass <=2)
            {
                pitcherLooper = 12;
            }
            if(iceCubesPerGlass >= 3)
            {
                pitcherLooper = random.Next(20, 25);
            }
        }

        public void DecreaseInventory()
        {
            for (int i = 1; i <= cupsSold; i++)
            {
                cups.currentStock --;
                iceCubes.currentStock = iceCubes.currentStock - iceCubesPerGlass;  
            }


        }


        public void DeterminePotentialCustomers()
        {
            if (weather.highTemperatureForecast >= 60 && pricePerCup <= .25)
            {
                potentialCustomers = 80;
            }
            else
            {
                potentialCustomers = 60;
            }
        }

        public void RunDay()
        {
            weather.DetermineForecast();
            DeterminePotentialCustomers();
            DetermineGlassesPerPitcher();
            DecreaseInventory();


        }
    }

}
