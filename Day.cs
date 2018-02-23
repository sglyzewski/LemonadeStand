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
        Customer customer;
        public List<KeyValuePair<int, string>> recipe;
        int LemonsPerPitcher;
        int cupsSugarPerPitcher;
        int iceCubesPerGlass;
        int pricePerCup;
        //constrListuctor
        public void CreateRecipe()
        {
            recipe = new List<KeyValuePair<int, string>>();
            {
                new KeyValuePair<string, int>("Price Per Cup", pricePerCup);
                new KeyValuePair<string, int>("Number of Lemons Per Pitcher", LemonsPerPitcher);
                new KeyValuePair<string, int>("Cups of Sugar Per Pitcher", cupsSugarPerPitcher);
                new KeyValuePair<string, int>("Ice Cubes per Glass", iceCubesPerGlass);
            }

        }



        //member methods
    }

}
