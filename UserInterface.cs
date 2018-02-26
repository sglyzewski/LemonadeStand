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

        
    }
}
