using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class IceCubes : Inventory
    {

        //member variables
        //constructor
        public IceCubes()
        {
            currentStock = 0;

        }
        //member methods
        public override bool Spoiler(int spoilNumber)
        {

            return true;
        }

        public string SpoilAlert()
        {
            if (Spoiler(spoilNumber) == true)
            {
                return ("Your remaining " + currentStock + " ice cubes have melted.");
            }
            else
                return ("");
        }

        public void DecreaseInventory(int cupsSold, int iceCubesPerGlass)
        {
            for (int i = 1; i <= cupsSold; i++)
            {
                currentStock = currentStock - iceCubesPerGlass;
            }

        }
    }
}

