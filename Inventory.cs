using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    abstract class Inventory
    {
        //member variables
       public int currentStock;
       public int spoilNumber;



        //constructor
        //member methods
        public abstract bool Spoiler(int spoilNumber);
        

    }
}
