﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        //member variables
        

        public int lemonsPerPitcher;
        public int cupsSugarPerPitcher;
        public int iceCubesPerGlass;
        public double pricePerCup;
        public int cupsSold;
        public int potentialCustomers;
        public double popularity;
        public double moneyInWalletAtStart;
        int pitcherLooper;
        Random random;
        Weather weather;
        
    
        UserInterface userInterface;

        //constructor
        public Day()
        {
            lemonsPerPitcher = 4;
            cupsSugarPerPitcher = 4;
            iceCubesPerGlass = 4;
            pricePerCup = 0.25;
            cupsSold = 0;
            random = new Random();
            

            weather = new Weather();
          
            userInterface = new UserInterface();
            

        }

        //member methods
        


        public void DetermineForecast()
        {
            weather.DetermineForecast();
        }

        public void GetPopularity()
        {
            popularity = (cupsSold / potentialCustomers);
        }

       

        public void DetermineGlassesPerPitcher ()
        {
            if(iceCubesPerGlass <=2)
            {
                pitcherLooper = 12;
            }
            if(iceCubesPerGlass >= 3)
            {
                pitcherLooper = random.Next(20, 25);
            }
        }

        //public void DecreaseInventory(int cupsCurrentStock, int iceCubesCurrentStock, int lemonsCurrentStock, int sugarCurrentStock)
        //{

        //    for (int i = 1; i <= cupsSold; i++)
        //    {
        //        cupsCurrentStock --;
        //        iceCubesCurrentStock = iceCubesCurrentStock - iceCubesPerGlass;
        //        if (i % pitcherLooper ==0)
        //        {
        //            lemonsCurrentStock = lemonsCurrentStock - lemonsPerPitcher;
        //            sugarCurrentStock = sugarCurrentStock - cupsSugarPerPitcher;
        //        }
        //    }


        //}

        
        public bool CheckForSoldOut(int iceCubesCurrentStock, int lemonsCurrentStock, int sugarCurrentStock, int cupsCurrentStock)
        {
            if ((iceCubesCurrentStock) < 1 || (lemonsCurrentStock < 1) || (sugarCurrentStock < 1) || (cupsCurrentStock < 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void DeterminePotentialCustomers()
        {
            if (weather.highTemperatureForecast >= 60 && pricePerCup <= .25)
            {
                potentialCustomers = 80;
            }
            else
            {
                potentialCustomers = 60;
            }
        }
        public void DetermineCupsSold()
        {
            for (int i = 0; i < potentialCustomers; i++)
            {
                Customer customer;
                customer = new Customer();
                cupsSold += customer.Purchase(weather);
            }
        }

            public int ChangeLemonsPerPitcher()
            {
                string userInput = "";
                userInput = userInterface.GetStringInput("Would you like to you like to change the lemons per Pitcher? Type 'yes'");

                if (userInput.ToLower() == "yes")
                {
                    string lemonsPerPitcherString = userInterface.GetStringInput("What amount of lemons per pitcher would you like in the recipe?");
                    lemonsPerPitcher = 0;
                    lemonsPerPitcher += Int32.Parse(lemonsPerPitcherString);
                    userInput = "";
               
                }
                return lemonsPerPitcher;
            }


        public void ChangeRecipe()
        {
            userInterface.GiveMessage("\n\n\nPrice/Quality Control: ");
            string input = userInterface.GetStringInput("Would you like to adjust your recipe? Type 'yes' if so.");

            if (input.ToLower() == "yes")

            {
                ChangeLemonsPerPitcher();
                ChangeCupsSugarPerPitcher();
                ChangeIceCubesPerCup();
                ChangePricePerCup();

            }
        }

        

        public int ChangeCupsSugarPerPitcher()
        {
            string userInput = "";
            userInput = userInterface.GetStringInput("Would you like to you like to change the cups of Sugar per Pitcher? Type 'yes'");

            if (userInput.ToLower() == "yes")
            {
                string cupsSugarPerPitcherString = userInterface.GetStringInput("What amount of cups of sugar per pitcher would you like in the recipe?");
                cupsSugarPerPitcher = Int32.Parse(cupsSugarPerPitcherString);
                userInput = "";
            }
            return cupsSugarPerPitcher;
        }


        public int ChangeIceCubesPerCup()
        {
            string userInput = "";
            userInput = userInterface.GetStringInput("Would you like to you like to change the ice cubes per cup? Type 'yes'");
            if (userInput.ToLower() == "yes")
            {
                string iceCubesPerGlassString = userInterface.GetStringInput("What amount of ice cubes per cup would you like in the recipe?");
                iceCubesPerGlass = Int32.Parse(iceCubesPerGlassString);
                userInput = "";
            }
            return iceCubesPerGlass;
        }


        public double ChangePricePerCup()
        {
            string userInput = "";
            userInput = userInterface.GetStringInput("Would you like to you like to change the price per cup? Type 'yes'");
            if (userInput.ToLower() == "yes")
            {
                string pricePerCupString = userInterface.GetStringInput("What would you like the price per cup to be today?");
                pricePerCup = Convert.ToDouble(pricePerCupString);
                userInput = "";
            }
            return pricePerCup;

        }

        public void PurchaseFromStore(Store store, Player player, Lemons lemons, IceCubes iceCubes, Sugar sugar, Cups cups)
        {
            string input = "";
            string amountToPurchase = "";
            int amountToPurchaseInt = 0;
            while (input.ToLower() != "exit")
            {
                input = userInterface.GetStringInput("Type 'lemons' to buy lemons, 'ice' to buy ice cubes, 'sugar' to purchase cups of sugar, or 'cups' to purchase cups. Type 'exit' to finish purchasing");
                switch (input.ToLower())
                {
                    case "lemons":
                        PurchaseLemons(store, player, lemons, amountToPurchase, amountToPurchaseInt);
                        break;

                    case "ice":
                        PurchaseIce(store, player, iceCubes, amountToPurchase, amountToPurchaseInt);
                        break;
                    case "sugar":

                        PurchaseSugar(store, player, sugar, amountToPurchase, amountToPurchaseInt);
                        break;
                    case "cups":
                        PurchaseCups(store, player, cups, amountToPurchase, amountToPurchaseInt);
                        break;

                    default:
                        break;

                }

            }

        }


        public void PurchaseLemons(Store store, Player player, Lemons lemons, string amountToPurchase, int amountToPurchaseInt)
        {

            amountToPurchase = userInterface.DisplayStoreItem(store.lemons, store.lemonPrices, store.lemonAmount);
            if (amountToPurchase != "0")
            {
                amountToPurchaseInt = Int32.Parse(amountToPurchase);
                player.WithDrawMoney(store.lemonPrices[amountToPurchaseInt - 1]);
                AdjustLemonAmount(store, lemons, amountToPurchaseInt, store.lemonAmount[amountToPurchaseInt - 1]);
                
            }
           
        }

        public int AdjustLemonAmount(Store store, Lemons lemons, int amountToPurchaseInt, int itemsToAdd)
        {
            lemons.currentStock += itemsToAdd;
            return lemons.currentStock;
        }

        public int AdjustIceCubesAmount(Store store, IceCubes iceCubes, int amountToPurchaseInt, int itemsToAdd)
        {
            iceCubes.currentStock += itemsToAdd;
            return iceCubes.currentStock;
        }


        public void PurchaseIce(Store store, Player player, IceCubes iceCubes, string amountToPurchase, int amountToPurchaseInt)
        {

            amountToPurchase = userInterface.DisplayStoreItem(store.iceCubes, store.iceCubesPrices, store.iceCubesAmount);
            if (amountToPurchase != "0")
            {
                amountToPurchaseInt = Int32.Parse(amountToPurchase);
                player.WithDrawMoney(store.iceCubesPrices[amountToPurchaseInt - 1]);
                AdjustIceCubesAmount(store, iceCubes, amountToPurchaseInt, store.iceCubesAmount[amountToPurchaseInt - 1]);
            }
              
            
        }




        public int AdjustSugarAmount(Store store,Sugar sugar, int amountToPurchaseInt, int itemsToAdd)
        {
            sugar.currentStock += itemsToAdd;
            return sugar.currentStock;
        }

        public void PurchaseSugar(Store store, Player player, Sugar sugar, string amountToPurchase, int amountToPurchaseInt)
        {
                amountToPurchase = userInterface.DisplayStoreItem(store.cupsSugar, store.cupsSugarPrices, store.cupsSugarAmount);
            if (amountToPurchase != "0")
            { 
                amountToPurchaseInt = Int32.Parse(amountToPurchase);
                player.WithDrawMoney(store.cupsSugarPrices[amountToPurchaseInt - 1]);          
                AdjustSugarAmount(store, sugar, amountToPurchaseInt, store.cupsSugarAmount[amountToPurchaseInt - 1]);
            }
        }




        public int AdjustCupsAmount(Store store, Cups cups, int amountToPurchaseInt, int itemsToAdd)
        {
            cups.currentStock += itemsToAdd;
            return cups.currentStock;
        }


        public void PurchaseCups(Store store, Player player, Cups cups, string amountToPurchase, int amountToPurchaseInt)
        {
            amountToPurchase = userInterface.DisplayStoreItem(store.paperCups, store.paperCupsPrices, store.paperCupsAmount);
            if (amountToPurchase != "0")
            {
                amountToPurchaseInt = Int32.Parse(amountToPurchase);
                player.WithDrawMoney(store.paperCupsPrices[amountToPurchaseInt - 1]);
                AdjustCupsAmount(store, cups, amountToPurchaseInt, store.paperCupsAmount[amountToPurchaseInt - 1]);
              
              
            }
            
        }

        public void AddProfit(Player player)
        {
            player.DepositMoney(cupsSold * pricePerCup);
        }

        public void RunDay(Store store, Player player, int dayNumber, Lemons lemons, IceCubes iceCubes, Sugar sugar, Cups cups)
        {
            moneyInWalletAtStart = player.Money;

            weather.DetermineForecast();
            userInterface.DisplayBeginningOfDayInfo(weather.forecast, weather.highTemperatureForecast, dayNumber, player.Money);
            userInterface.ShowRecipe(lemonsPerPitcher, cupsSugarPerPitcher, iceCubesPerGlass, pricePerCup);
            ChangeRecipe(); 
            userInterface.ShowRecipe(lemonsPerPitcher, cupsSugarPerPitcher, iceCubesPerGlass, pricePerCup);
            PurchaseFromStore(store, player, lemons, iceCubes, sugar, cups);
            userInterface.DisplayInventory(cups.currentStock, lemons.currentStock, sugar.currentStock, iceCubes.currentStock);
            DetermineGlassesPerPitcher();
            DeterminePotentialCustomers();
            DetermineCupsSold();
            AddProfit(player);
            player.FindProfit(moneyInWalletAtStart);
            lemons.DecreaseInventory(cupsSold, pitcherLooper, lemonsPerPitcher);
            sugar.DecreaseInventory(cupsSold, pitcherLooper, cupsSugarPerPitcher);
            cups.DecreaseInventory(cupsSold);
            iceCubes.DecreaseInventory(cupsSold, iceCubesPerGlass);
            
            GetPopularity();
            userInterface.DisplayEndOfDayInfo(CheckForSoldOut(iceCubes.currentStock, lemons.currentStock, sugar.currentStock, cups.currentStock), weather.forecast, weather.highTemperatureForecast, dayNumber, player.Money, player.Profit, cupsSold, popularity);



        }
    }

}
