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
        //IceCubes iceCubes;
        //Lemons lemons;
        //Sugar sugar;
        //Cups cups;
        //Store store;
    
        UserInterface userInterface;

        //constructor
        public Day()
        {
            lemonsPerPitcher = 4;
            cupsSugarPerPitcher = 4;
            iceCubesPerGlass = 4;
            pricePerCup = 0.25;
            cupsSold = 0;
            random = new Random();
            //lemons = new Lemons();
            //sugar = new Sugar();
            //iceCubes = new IceCubes();
            //cups = new Cups();
            weather = new Weather();
            //store = new Store();
            userInterface = new UserInterface();
            

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

        public void DecreaseInventory(int cupsCurrentStock, int iceCubesCurrentStock, int lemonsCurrentStock, int sugarCurrentStock)
        {

            for (int i = 1; i <= cupsSold || (CheckForSoldOut(cupsCurrentStock, iceCubesCurrentStock, lemonsCurrentStock, sugarCurrentStock) == true); i++)
            {
                cupsCurrentStock --;
                iceCubesCurrentStock = iceCubesCurrentStock - iceCubesPerGlass;
                if (i % pitcherLooper ==0)
                {
                    lemonsCurrentStock = lemonsCurrentStock - lemonsPerPitcher;
                    sugarCurrentStock = sugarCurrentStock - cupsSugarPerPitcher;
                }
            }


        }

        public bool CheckForSoldOut(int iceCubesCurrentStock, int lemonsCurrentStock, int sugarCurrentStock, int cupsCurrentStock)
        {
            if ((iceCubesCurrentStock) < 1 || (lemonsCurrentStock < 1) || (sugarCurrentStock < 1) || (cupsCurrentStock < 0))
            {
                return true;
            }
            else
            {
                return false;
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
        public void DetermineCupsSold()
        {
            for(int i = 0; i<potentialCustomers; i++)
            {
                Customer customer = new Customer();
                customer.Purchase(cupsSold, weather);
            }
        }
        public void RunDay(Store store, Player player, int dayNumber, int lemonsCurrentStock, int iceCubesCurrentStock, int sugarCurrentStock, int cupsCurrentStock)
        {
            weather.DetermineForecast();
            userInterface.DisplayBeginningOfDayInfo(weather.forecast, weather.highTemperatureForecast, dayNumber, player.money);
            userInterface.ShowRecipe(lemonsPerPitcher, cupsSugarPerPitcher, iceCubesPerGlass, pricePerCup);
            userInterface.ChangeRecipe(lemonsPerPitcher, cupsSugarPerPitcher, iceCubesPerGlass, pricePerCup);
            userInterface.ShowRecipe(lemonsPerPitcher, cupsSugarPerPitcher, iceCubesPerGlass, pricePerCup);
            store.PurchaseFromStore(store, player.money, lemonsCurrentStock, iceCubesCurrentStock, sugarCurrentStock, cupsCurrentStock);
            DeterminePotentialCustomers();
            DetermineGlassesPerPitcher();
            DecreaseInventory(lemonsCurrentStock, iceCubesCurrentStock, sugarCurrentStock, cupsCurrentStock);
            GetPopularity();
            userInterface.DisplayEndOfDayInfo(CheckForSoldOut(iceCubesCurrentStock, lemonsCurrentStock, sugarCurrentStock, cupsCurrentStock), weather.forecast, weather.highTemperatureForecast, dayNumber, player.money, cupsSold, popularity);



        }
    }

}
