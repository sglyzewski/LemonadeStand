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
        Day day;
        //constructor

        public UserInterface()
        {
            day = new Day();
        }
        //member methods

        public void GiveMessage(string message)
        {
            Console.WriteLine(message);
            
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

                GiveMessage(amount[i] + " for $" + price[i]);
            }

            string input = GetStringInput("How many " + item + " would you like to purchase?");
            
            return input;
        }

        public int GetDays()
        {
            string input = GetStringInput("How many days would you like to play for?");
            int output;
            output = Int32.Parse(input);
            
            GiveMessage("You will play for" + output + " days.");
            return output;

        }

        public void ShowRecipe()
        {
            GiveMessage("Your current lemonade recipe is: \nLemons Per Pitcher: " + day.lemonsPerPitcher + "\nCups of Sugar Per Pitcher: " + day.cupsSugarPerPitcher + "\nIce Cubes Per Glass: " + day.iceCubesPerGlass + "\nPrice Per Cup: $" + day.pricePerCup);
        }
        public void ChangeRecipe ()
        {
            
            string userInput = GetStringInput("Would you like to you like to change the lemons per Pitcher? Type 'yes'");
            if (userInput.ToLower() == "yes") {
                string lemonsPerPitcher = GetStringInput("What amount of lemons per pitcher would you like in the recipe?");
                day.lemonsPerPitcher = Int32.Parse(lemonsPerPitcher);
                userInput = "";
            }
            userInput = GetStringInput("Would you like to you like to change the cups of Sugar per Pitcher? Type 'yes'");
            if (userInput.ToLower() == "yes")
            {
                string cupsSugarPerPitcher = GetStringInput("What amount of cups of sugar per pitcher would you like in the recipe?");
                day.cupsSugarPerPitcher = Int32.Parse(cupsSugarPerPitcher);
                userInput = "";
            }
            userInput = GetStringInput("Would you like to you like to change the ice cubes per cup? Type 'yes'");
            if (userInput.ToLower() == "yes")
            {
                string iceCubesPerGlass = GetStringInput("What amount of ice cubes per cup would you like in the recipe?");
                day.iceCubesPerGlass = Int32.Parse(iceCubesPerGlass);
                userInput = "";
            }

            userInput = GetStringInput("Would you like to you like to change the price per cup? Type 'yes'");
            if (userInput.ToLower() == "yes")
            {
                string pricePerCup = GetStringInput("What would you like the price per cup to be today?");
                day.pricePerCup = Convert.ToDouble(pricePerCup);
                userInput = "";
            }

            ShowRecipe();

            

        }
        
    }
}
