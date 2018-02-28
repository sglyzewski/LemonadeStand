using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Cups : Inventory
    {

        //member variables
        //constructor
        public Cups () {
            currentStock = 0;
         }
        //member methods
        public override bool Spoiler(int spoilNumber)
        {
            return true;
        }

        public void DecreaseInventory(int cupsSold)
        {

            for (int i = 1; i <= cupsSold; i++)
            {
                currentStock--;
            }




        }
    }

}
