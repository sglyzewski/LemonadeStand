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
        //public Weather weather;
        public Player player;
        public Lemons lemons;
        public Sugar sugar;
        public IceCubes iceCubes;
        public Cups cups;

        int dayNumber;
        int amountOfDaysInGame;
        //constructor
        public Game()
        {
            store = new Store();
            userInterface = new UserInterface();
           // weather = new Weather();
            player = new Player();
            amountOfDaysInGame = 0;
            dayNumber = 1;
            lemons = new Lemons();
            sugar = new Sugar();
            iceCubes = new IceCubes();
            cups = new Cups();

        }
        //member functions

        public void DetermineScore()
        {
            userInterface.GiveMessage("End of Season Report:");
            userInterface.GiveMessage("Money: " + player.Money);
        }


        public void RunGame()
        {
            player.name = userInterface.GetPlayerName();
            amountOfDaysInGame = userInterface.GetDays(player.name);

            while (amountOfDaysInGame > 0)
            {
                Day day = new Day();
               
                userInterface.DisplayInventory(cups.currentStock, lemons.currentStock, sugar.currentStock, iceCubes.currentStock);
                day.RunDay(store, player, dayNumber, lemons, iceCubes, sugar, cups);
                
                dayNumber++;
                amountOfDaysInGame--;

      

            }
            DetermineScore();
        }
    }
}
