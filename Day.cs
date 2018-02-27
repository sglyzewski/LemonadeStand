using System;
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
        int pitcherLooper;
        Random random;
        Weather weather;
        //IceCubes iceCubes;
        //Lemons lemons;
        //Sugar sugar;
        //Cups cups;
        //Store store;
    
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
            //lemons = new Lemons();
            //sugar = new Sugar();
            //iceCubes = new IceCubes();
            //cups = new Cups();
            weather = new Weather();
            //store = new Store();
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

        public void DecreaseInventory(int cupsCurrentStock, int iceCubesCurrentStock, int lemonsCurrentStock, int sugarCurrentStock)
        {

            for (int i = 1; i <= cupsSold || (CheckForSoldOut(cupsCurrentStock, iceCubesCurrentStock, lemonsCurrentStock, sugarCurrentStock) == true); i++)
            {
                cupsCurrentStock --;
                iceCubesCurrentStock = iceCubesCurrentStock - iceCubesPerGlass;
                if (i % pitcherLooper ==0)
                {
                    lemonsCurrentStock = lemonsCurrentStock - lemonsPerPitcher;
                    sugarCurrentStock = sugarCurrentStock - cupsSugarPerPitcher;
                }
            }


        }

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
                Customer customer = new Customer();
                customer.Purchase(cupsSold, weather);
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

        public void PurchaseFromStore(Store store, double money, Lemons lemons, IceCubes iceCubes, Sugar sugar, Cups cups)
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

                        PurchaseLemons(store, money, lemons, amountToPurchase, amountToPurchaseInt);
                        break;

                    case "ice":
                        PurchaseIce(store, money, iceCubes, amountToPurchase, amountToPurchaseInt);
                        break;
                    case "sugar":

                        PurchaseSugar(store, money, sugar, amountToPurchase, amountToPurchaseInt);
                        break;
                    case "cups":
                        PurchaseCups(store, money, cups, amountToPurchase, amountToPurchaseInt);
                        break;

                    default:
                        break;

                }




            }




        }

        public int PurchaseLemons(Store store, double money, Lemons lemons, string amountToPurchase, int amountToPurchaseInt)
        {
            amountToPurchase = userInterface.DisplayStoreItem(store.lemons, store.lemonPrices, store.lemonAmount);
            amountToPurchaseInt = Int32.Parse(amountToPurchase);
            money = money - store.lemonPrices[amountToPurchaseInt - 1];
            lemons.currentStock += store.lemonAmount[amountToPurchaseInt - 1];
            return lemons.currentStock;
        }

        public int PurchaseIce(Store store, double money, IceCubes iceCubes, string amountToPurchase, int amountToPurchaseInt)
        {
            amountToPurchase = userInterface.DisplayStoreItem(store.iceCubes, store.iceCubesPrices, store.iceCubesAmount);
            amountToPurchaseInt = Int32.Parse(amountToPurchase);
            money = money - store.iceCubesPrices[amountToPurchaseInt - 1];
            iceCubes.currentStock += store.iceCubesAmount[amountToPurchaseInt - 1];
            return iceCubes.currentStock;
        }

        public int PurchaseSugar(Store store, double money, Sugar sugar, string amountToPurchase, int amountToPurchaseInt)
        {
            amountToPurchase = userInterface.DisplayStoreItem(store.cupsSugar, store.cupsSugarPrices, store.cupsSugarAmount);
            amountToPurchaseInt = Int32.Parse(amountToPurchase);
            money = money - store.cupsSugarPrices[amountToPurchaseInt - 1];
            sugar.currentStock += store.cupsSugarAmount[amountToPurchaseInt - 1];
            return sugar.currentStock;
        }

        public int PurchaseCups(Store store, double money, Cups cups, string amountToPurchase, int amountToPurchaseInt)
        {
            amountToPurchase = userInterface.DisplayStoreItem(store.paperCups, store.paperCupsPrices, store.paperCupsAmount);
            amountToPurchaseInt = Int32.Parse(amountToPurchase);
            money = money - store.paperCupsPrices[amountToPurchaseInt - 1];
            cups.currentStock += store.paperCupsAmount[amountToPurchaseInt - 1];
            return cups.currentStock;
        }



        public void RunDay(Store store, Player player, int dayNumber, Lemons lemons, IceCubes iceCubes, Sugar sugar, Cups cups)
        {
            weather.DetermineForecast();
            userInterface.DisplayBeginningOfDayInfo(weather.forecast, weather.highTemperatureForecast, dayNumber, player.money);
            userInterface.ShowRecipe(lemonsPerPitcher, cupsSugarPerPitcher, iceCubesPerGlass, pricePerCup);
            ChangeRecipe(); 
            userInterface.ShowRecipe(lemonsPerPitcher, cupsSugarPerPitcher, iceCubesPerGlass, pricePerCup);
            PurchaseFromStore(store, player.money, lemons, iceCubes, sugar, cups);
            userInterface.DisplayInventory(cups.currentStock, lemons.currentStock, sugar.currentStock, iceCubes.currentStock);
            DeterminePotentialCustomers();
            DetermineGlassesPerPitcher();
            DecreaseInventory(lemons.currentStock, iceCubes.currentStock, sugar.currentStock, cups.currentStock);
            GetPopularity();
            userInterface.DisplayEndOfDayInfo(CheckForSoldOut(iceCubes.currentStock, lemons.currentStock, sugar.currentStock, cups.currentStock), weather.forecast, weather.highTemperatureForecast, dayNumber, player.money, cupsSold, popularity);



        }
    }

}
