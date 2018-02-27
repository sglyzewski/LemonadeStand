﻿using System;
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

        

        UserInterface userInterface;
        
        //constructor
        public Store()
        {
            lemons = "Lemons";
            iceCubes = "Ice Cubes";
            cupsSugar = "Cups of Sugar";
            paperCups = "Paper Cups";
            userInterface = new UserInterface();
            //player = new Player();
            items = new List<string>() { lemons, iceCubes, cupsSugar, paperCups };

            lemonPrices = new List<double> { 0.86, 2.24, 4.37 };
            iceCubesPrices = new List<double> { 0.84, 2.15, 3.94 };
            cupsSugarPrices = new List<double> { 0.64, 1.53, 3.42 };
            paperCupsPrices = new List<double> { 0.84, 2.15, 3.94 };

            lemonAmount = new List<int> { 10, 30, 75 };
            iceCubesAmount = new List<int> { 25, 50, 100 };
            cupsSugarAmount = new List<int> { 8, 20, 48 };
            paperCupsAmount = new List<int> { 25, 50, 100};
     
            //lemon - 0
            //iceCube - 1
            //cups sugar - 2
            // cups - 3
            
        }


        //member methods


        public void PurchaseFromStore(Store store, double money, int lemonsInventory, int iceCubesInventory, int sugarInventory, int cupsInventory)
        {
            string input = "";
           
            string amountToPurchase = "";
            int amountToPurchaseInt = 0;
            while (input.ToLower() != "exit")
            {
                input = userInterface.GetStringInput("Type 'lemons' to buy lemons, 'ice' to buy ice cubes, 'sugar' to purchase cups of sugar, or 'cups' to purchase cups. Type 'exit' to finish purchasing");
                switch(input.ToLower())
                {
                    case "lemons":
                 
                        PurchaseLemons(money, lemonsInventory, amountToPurchase, amountToPurchaseInt);
                        break;
                       
                    case "ice":
                        PurchaseIce(money, iceCubesInventory, amountToPurchase, amountToPurchaseInt);
                        break;
                    case "sugar":
                   
                        PurchaseSugar(money, sugarInventory, amountToPurchase, amountToPurchaseInt);
                        break;
                    case "cups":
                        PurchaseCups(money, cupsInventory, amountToPurchase, amountToPurchaseInt);
                        break;

                    default:
                        break;
                        
                }
               



            }

        

            
        }

        public int PurchaseLemons(double money, int lemonsInventory, string amountToPurchase, int amountToPurchaseInt)
        {
            amountToPurchase = userInterface.DisplayStoreItem(lemons, lemonPrices, lemonAmount);
            amountToPurchaseInt = Int32.Parse(amountToPurchase);
            money = money - lemonPrices[amountToPurchaseInt - 1];
            lemonsInventory = lemonsInventory + lemonAmount[amountToPurchaseInt - 1];
            return lemonsInventory;
        }

        public int PurchaseIce(double money, int iceCubesInventory, string amountToPurchase, int amountToPurchaseInt)
        {
            amountToPurchase = userInterface.DisplayStoreItem(iceCubes, iceCubesPrices, iceCubesAmount);
            amountToPurchaseInt = Int32.Parse(amountToPurchase);
            money = money - iceCubesPrices[amountToPurchaseInt - 1];
            iceCubesInventory = iceCubesInventory + iceCubesAmount[amountToPurchaseInt - 1];
            return iceCubesInventory;
        }

        public int PurchaseSugar(double money, int sugarInventory, string amountToPurchase, int amountToPurchaseInt)
        {
            amountToPurchase = userInterface.DisplayStoreItem(cupsSugar, cupsSugarPrices, cupsSugarAmount);
            amountToPurchaseInt = Int32.Parse(amountToPurchase);
            money = money - cupsSugarPrices[amountToPurchaseInt - 1];
            sugarInventory = sugarInventory + cupsSugarAmount[amountToPurchaseInt - 1];
            return sugarInventory;
        }

        public int PurchaseCups(double money, int cupsInventory, string amountToPurchase, int amountToPurchaseInt)
        {
            amountToPurchase = userInterface.DisplayStoreItem(paperCups, paperCupsPrices, paperCupsAmount);
            amountToPurchaseInt = Int32.Parse(amountToPurchase);
            money = money - paperCupsPrices[amountToPurchaseInt - 1];
            cupsInventory = cupsInventory + paperCupsAmount[amountToPurchaseInt - 1];
            return cupsInventory;
        }
    }
}
