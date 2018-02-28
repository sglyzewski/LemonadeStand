using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        //member variables
        double profit;
        //double expenses;
        //double income;
        //double liquidatedInventoryValue; //total worth of a company's physical assets when it goes out of business; determined by assets i.e. inventory
        double money;
        public string name;

        //member variables
        //constructor
        public Player()
        {
            money = 20.00;
            profit = 0;
            
        }
        public bool WithDrawMoney(double amount)
        {
            if(money - amount >= 0)
            {
                money -= amount;
                return true;
            }
            return false;
        }

        public void FindProfit(double moneyInWalletAtStart)
        {
            profit = money - moneyInWalletAtStart;
          
        }
        public void DepositMoney(double amount)
        {
           
                money += amount;
            
        }
        public double Money
        {
            get
            {
                return money;
            }
        }

        public double Profit
        {
            get
            {
                return profit;
            }
        }

        


        //member methods

        
    }
}
