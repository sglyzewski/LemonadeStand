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
        //constructor
        public Game (){
            store = new Store();
            userInterface = new UserInterface();
            weather = new Weather();
         }
        //member functions

        public void DetermineDayScore()
        {

        }


        public void RunGame()
        {
            //string input;
            //input = userInterface.DisplayStoreItem(store.lemons, store.lemonPrices, store.lemonAmount);
            weather.DetermineForecast(weather.weatherOptions);
        }
    }
}
