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
        Day day = new Day();
        //constructor
        //member functions
        public void RunGame()
        {
            day.CreateRecipe();
            foreach (KeyValuePair<int, string> item in day.recipe)
            {
                Console.WriteLine(item.Key + ":" + item.Value);

               

            }
        }
    }
}
