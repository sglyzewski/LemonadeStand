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
    }
}
