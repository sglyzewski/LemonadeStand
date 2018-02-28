using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Sugar : Inventory
    {

        //member variables
        //constructor
        public Sugar()
        {
            currentStock = 0;
        }
        //member methods
        public override bool Spoiler(int spoilNumber)
        {
            return true;


        }

        public void DecreaseInventory(int cupsSold, int pitcherLooper, int cupsSugarPerPitcher)
        {
            for (int i = 1; i <= cupsSold; i++)
            {
                if (i % pitcherLooper == 0)
                {
                    currentStock = currentStock - cupsSugarPerPitcher;
                }
            }

        }
    }
}
