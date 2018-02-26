using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
   public class Store
    {
        //member variables
        public List<string> items;

        public List<double> lemonPrices;
        public List<double> iceCubesPrices;
        public List<double> cupsSugarPrices;
        public List<double> paperCupsPrices;

        public List<int> lemonAmount;
        public List<int> iceCubesAmount;
        public List<int> cupsSugarAmount;
        public List<int> paperCupsAmount;

        public string lemons;
        public string iceCubes;
        public string cupsSugar;
        public string paperCups;

        //constructor
        public Store()
        {
            lemons = "Lemons";
            iceCubes = "Ice Cubes";
            cupsSugar = "Cups of Sugar";
            paperCups = "Paper Cups";
            items = new List<string>() { lemons, iceCubes, cupsSugar, paperCups };

            lemonPrices = new List<double> { 0.86, 2.24, 4.37 };
            iceCubesPrices = new List<double> { 0.84, 2.15, 3.94 };
            cupsSugarPrices = new List<double> { 0.64, 1.53, 3.42 };
            paperCupsPrices = new List<double> { 0.84, 2.15, 3.94 };

            lemonAmount = new List<int> { 10, 30, 75 };
            iceCubesAmount = new List<int> { 25, 50, 100 };
            cupsSugarAmount = new List<int> { 8, 20, 48 };
            paperCupsAmount = new List<int> { 25, 50, 100};

            
        }
        //member methods
    }
}
