using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Player
    {
        // member variables (HAS A)
        public Item item;
        public Inventory inventory;
        public Wallet wallet;
        public Recipe recipe;
        public Pitcher pitcher;
        public int soldInventory;

        // constructor (SPAWNER)
        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet();
        }

        // member methods (CAN DO)
        public int SellLemonade(List<Customer> customer)
        {
            soldInventory = 0;
            for (int i = 0; i < customer.Count; i++)
            {
                if (item.supplies[4].Count == 0)
                {
                    Console.WriteLine("You sold out and have no more cups of lemonade!");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }
                else
                {
                    if (customer[i].buyProbability >= 75)
                    {
                        soldInventory++;
                        item.supplies[4].RemoveAt(0);
                    }
                    else if ((customer[i].buyProbability <= 74) && (customer[i].buyProbability >= 50))
                    {
                        soldInventory++;
                        item.supplies[4].RemoveAt(0);
                    }
                    else if ((customer[i].buyProbability <= 49) && (customer[i].buyProbability >= 25))
                    {
                        soldInventory++;
                        item.supplies[4].RemoveAt(0);
                    }
                    else if (customer[i].buyProbability <= 24)
                    {
                        //no sale
                    }
                }
            }
            return soldInventory;
        }
        public void CheckSpoilInventory()
        {
            while (item.supplies[4].Count > 0)
            {
                item.supplies[4].RemoveAt(0);
            }
        }
        
        

    }
}
