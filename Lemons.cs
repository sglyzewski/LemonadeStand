using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Lemons : Inventory
    {

        //member variables
        //constructor
        public Lemons()
        {
            currentStock = 0;
        }
        //member methods
        public override bool Spoiler(int spoilNumber)
        {
            return true;


        }

        public void DecreaseInventory(int cupsSold, int pitcherLooper, int lemonsPerPitcher)
        {
            for (int i = 1; i <= cupsSold; i++)
            {
                if (i % pitcherLooper == 0)
                {
                    currentStock = currentStock - lemonsPerPitcher;
                }
            }

        }
    }
}
