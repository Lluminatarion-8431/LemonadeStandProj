using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Player
    {
        //Member variable (what it has:)//
        public Inventory inventory;
        //public Wallet wallet;
        public int soldInventory;

        //Constructor (spawner)//
        public Player()
        {
            inventory = new Inventory();
            //wallet = new Wallet();
        }

        //Member methods (what it does)//
        public int SellLemonade(List<Customer> customer)
        {
            soldInventory = 0;
            for (int i = 0; i < customer.Count; i++)
            {
                if (inventory.supplies[4].Count == 0)
                {
                    Console.WriteLine("You sold out of cups of lemonade!");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }
                else
                {
                    if (customer[i].buyProbability >= 75)
                    {
                        soldInventory++;
                        inventory.supplies[4].RemoveAt(0);
                    }
                    else if ((customer[i].buyProbability <= 74) && (customer[i].buyProbability >= 50))
                    {
                        soldInventory++;
                        inventory.supplies[4].RemoveAt(0);
                    }
                    else if ((customer[i].buyProbability <= 49) && (customer[i].buyProbability >= 25))
                    {
                        soldInventory++;
                        inventory.supplies[4].RemoveAt(0);
                    }
                    else if(customer[i].buyProbability <= 24)
                    {
                        //no sale
                    }
                }
            }
            return soldInventory;
        }
        public void CheckSpoilInventory()
        {
            while (inventory.supplies[4].Count > 0)
            {
                inventory.supplies[4].RemoveAt(0);
            }
        }
        

    }
}
