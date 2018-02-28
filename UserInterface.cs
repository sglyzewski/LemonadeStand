using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class UserInterface
    {
        //member variables
      

        
       
        //constructor

        public UserInterface()
        {
        
           
            
        }
        //member methods

        public void GiveMessage(string message)
        {
            Console.WriteLine(message);
            
        }

        public void DisplayInventory(int cupsCurrentStock, int lemonsCurrentStock, int sugarCurrentStock, int iceCubesCurrentStock )
        {
            GiveMessage("\n\n\nInventory/Purchasing:");
            GiveMessage("You currently have...");
            GiveMessage(cupsCurrentStock + " cups");
            GiveMessage(lemonsCurrentStock + " lemons");
            GiveMessage(sugarCurrentStock + " cups of sugar");
            GiveMessage(iceCubesCurrentStock + " ice cubes\n\n\n");
        }

        public string GetStringInput(string message)
        {
            string input;
            Console.WriteLine(message);
            input = Console.ReadLine();
            return input;
        }

        public void DisplayRules()
        {

        }

        public string DisplayStoreItem(string item, List<double> price, List<int> amount)
        {
            GiveMessage(item + " for purchase:");
            for (int i = 0; i < price.Count; i++)
            {

                GiveMessage("OPTION " + (i + 1) + ": " + amount[i] + " for $" + price[i]);
            }

            string input = GetStringInput("Type '1' for Option 1, '2' for Option 2, '3' for Option 3 or '0' to buy none.");
            
            return input;
        }

        public string GetPlayerName()
        {
            string name;
            name = GetStringInput("Welcome to lemonade stand! What is your name?");
            return name;
        }

        public int GetDays(string name)
        {
            string input = GetStringInput("How many days would you like to play for?");
            int output;
            output = Int32.Parse(input);
            
            GiveMessage(name + ", you will play for " + output + " days.");
            return output;

        }

        public void ShowRecipe(int lemonsPerPitcherDay, int cupsSugarPerPitcherDay, int iceCubesPerGlassDay, double pricePerCupDay )
        {
            GiveMessage("Your current lemonade recipe is: \nLemons Per Pitcher: " + lemonsPerPitcherDay + "\nCups of Sugar Per Pitcher: " + cupsSugarPerPitcherDay + "\nIce Cubes Per Glass: " + iceCubesPerGlassDay + "\nPrice Per Cup: $" + pricePerCupDay);
        }

        

        public void ChangeRecipe (int lemonsPerPitcherDay, int cupsSugarPerPitcherDay, int iceCubesPerGlassDay, double pricePerCupDay )
        {
            GiveMessage("\n\n\nPrice/Quality Control: ");
            string input = GetStringInput("Would you like to adjust your recipe? Type 'yes' if so.");
            
            if (input.ToLower() == "yes")

            {
                ChangeLemonsPerPitcher( lemonsPerPitcherDay);
                ChangeCupsSugarPerPitcher( cupsSugarPerPitcherDay);
                ChangeIceCubesPerCup(  iceCubesPerGlassDay);
                ChangePricePerCup( pricePerCupDay);

            }
        }

        public int ChangeLemonsPerPitcher( int lemonsPerPitcherDay)
        {
            string userInput = "";
            userInput = GetStringInput("Would you like to you like to change the lemons per Pitcher? Type 'yes'");
            
            if (userInput.ToLower() == "yes")
            {
                string lemonsPerPitcher = GetStringInput("What amount of lemons per pitcher would you like in the recipe?");
                lemonsPerPitcherDay = Int32.Parse(lemonsPerPitcher);
                userInput = "";
                

            }
            return lemonsPerPitcherDay;
        }

        public int ChangeCupsSugarPerPitcher( int cupsSugarPerPitcherDay)
        {
            string userInput = "";
            userInput = GetStringInput("Would you like to you like to change the cups of Sugar per Pitcher? Type 'yes'");

            if (userInput.ToLower() == "yes")
            {
                string cupsSugarPerPitcher = GetStringInput("What amount of cups of sugar per pitcher would you like in the recipe?");
                cupsSugarPerPitcherDay = Int32.Parse(cupsSugarPerPitcher);
                userInput = "";
            }
            return cupsSugarPerPitcherDay;
        }


        public int ChangeIceCubesPerCup( int iceCubesPerGlassDay)
        {
            string userInput = "";
            userInput = GetStringInput("Would you like to you like to change the ice cubes per cup? Type 'yes'");
            if (userInput.ToLower() == "yes")
            {
                string iceCubesPerGlass = GetStringInput("What amount of ice cubes per cup would you like in the recipe?");
                iceCubesPerGlassDay = Int32.Parse(iceCubesPerGlass);
                userInput = "";
            }
            return iceCubesPerGlassDay;
        }


        public double ChangePricePerCup(double pricePerCupDay)
        {
            string userInput = "";
            userInput = GetStringInput("Would you like to you like to change the price per cup? Type 'yes'");
            if (userInput.ToLower() == "yes")
            {
                string pricePerCup = GetStringInput("What would you like the price per cup to be today?");
                pricePerCupDay = Convert.ToDouble(pricePerCup);
                userInput = "";
            }
            return pricePerCupDay;

        }

        public void DisplayBeginningOfDayInfo(string forecast, int temperatureForecast, int dayNumber, double money)
        {
            GiveMessage("Day " + dayNumber + " info:");
            GiveMessage("Forecast: " + forecast);
            GiveMessage("High Temp: " + temperatureForecast);
            GiveMessage("Day: " + dayNumber);
            GiveMessage("Money: $" + money + "\n\n\n");
        }

        public void DisplayEndOfDayInfo(bool soldOut, string forecast, int temperatureForecast, int dayNumber, double money, int cupsSold, double popularity)
        {
            double percentageMaker = 100;
            if (soldOut == true)
            {
                GiveMessage("You sold out today :( Plan better next time");
            }
            {
                
                GiveMessage("End of Day " + dayNumber + " Report:");
                GiveMessage("Weather: " + forecast);
                GiveMessage("High Temp: " + temperatureForecast);

                GiveMessage("Money: $" + money );
                GiveMessage("Popularity " + (popularity * percentageMaker));
                GiveMessage("Cups Sold: " + cupsSold + "\n\n\n");
            }

        }
        
    }
}
