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
    }
}
