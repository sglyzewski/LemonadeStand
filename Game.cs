using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LemonadeStand
{
    class Game
    {
        //member variables
        public Store store;
        public UserInterface userInterface;
        public Weather weather;
        public Player player;


        int dayNumber;
        int amountOfDaysInGame;
        //constructor
        public Game()
        {
            store = new Store();
            userInterface = new UserInterface();
            weather = new Weather();
            player = new Player();
            amountOfDaysInGame = 0;
            dayNumber = 1;

        }
        //member functions

        public void DetermineDayScore()
        {

        }


        public void RunGame()
        {
            userInterface.GetPlayerName();
            amountOfDaysInGame = userInterface.GetDays(player.name);

            while (amountOfDaysInGame > 0)
            {
                Day day = new Day();
                userInterface.DisplayBeginningOfDayInfo(weather.forecast, weather.highTemperatureForecast, dayNumber, player.money);
                userInterface.ShowRecipe();
                userInterface.ChangeRecipe();
                userInterface.DisplayInventory();
                day.RunDay();
                userInterface.DisplayEndOfDayInfo(day.CheckForSoldOut(), weather.forecast, weather.highTemperatureForecast, dayNumber, player.money, day.cupsSold, day.popularity);
                dayNumber++;
                amountOfDaysInGame--;

                //}
                //string input;
                //input = userInterface.DisplayStoreItem(store.lemons, store.lemonPrices, store.lemonAmount);
                // weather.DetermineForecast(weather.weatherOptions);


            }
        }
    }
}
