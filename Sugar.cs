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
    }
}
