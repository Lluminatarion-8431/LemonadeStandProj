using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Day
    {
        //Member variable (what it has:)//
        
        public Weather weather;
        public List<Customer> customers;
        public int day;
        public double earnings;
        public double profit;

        //Constructor (spawner)//
        public Day ()
        {
            day = 1;
            weather = new Weather();
            customers = new List<Customer>();
        }

        //Member methods (what it does)//
        public void GetWeather(Random rnd)
        {
            weather.GetTemp(rnd);
            weather.GetOvercast(rnd);
            weather.DisplayCurrentWeather();
        }
        public void GetForecast(Random rnd)
        {
            weather.GetTemp(rnd);
            weather.GetOvercast(rnd);
            weather.DisplayForecast();
        }
        public void DisplayDay()
        {
            Console.WriteLine($"Today is Day {day}\n\n");
        }

        //will generate a random amount of customers according weather and temp.
        public void GetTotalCustomers(Random rnd, Recipe recipe)
        {
            Demand demand = new Demand(recipe, weather);
            if (weather.temperature == "Hot" && weather.condition == "and sunny")
            {
                int customerNumber = rnd.Next(35, 40);
                for (int i = 0; i < customerNumber; i++)
                {
                    customers.Add(new Customer(demand));
                }
            }
            else if (weather.temperature == "Hot" && weather.condition == "and cloudy")
            {
                int customerNumber = rnd.Next(30, 34);
                for (int i = 0; i < customerNumber; i++)
                {
                    customers.Add(new Customer(demand));
                }
            }
            else if (weather.temperature == "Hot" && weather.condition == "with thunderstorms")
            {
                int customerNumber = rnd.Next(20, 29);
                for (int i = 0; i < customerNumber; i++)
                {
                    customers.Add(new Customer(demand));
                }
            }
            else if (weather.temperature == "Warm" && weather.condition == "and sunny")
            {
                int customerNumber = rnd.Next(25, 31);
                for (int i = 0; i < customerNumber; i++)
                {
                    customers.Add(new Customer(demand));
                }
            }
            else if (weather.temperature == "Warm" && weather.condition == "and cloudy")
            {
                int customerNumber = rnd.Next(20, 24);
                for (int i = 0; i < customerNumber; i++)
                {
                    customers.Add(new Customer(demand));
                }
            }
            else if (weather.temperature == "Warm" && weather.condition == "with thunderstorms")
            {
                int customerNumber = rnd.Next(15, 19);
                for (int i = 0; i < customerNumber; i++)
                {
                    customers.Add(new Customer(demand));
                }
            }
            else if (weather.temperature == "Cold" && weather.condition == "and sunny")
            {
                int customerNumber = rnd.Next(5, 11);
                for (int i = 0; i < customerNumber; i++)
                {
                    customers.Add(new Customer(demand));
                }
            }
            else if (weather.temperature == "Cold" && weather.condition == "and cloudy")
            {
                int customerNumber = rnd.Next(0, 10);
                for (int i = 0; i < customerNumber; i++)
                {
                    customers.Add(new Customer(demand));
                }
            }
            else if (weather.temperature == "Cold" && weather.condition == "with thunderstorms")
            {
                int customerNumber = rnd.Next(0, 4);
                for (int i = 0; i < customerNumber; i++)
                {
                    customers.Add(new Customer(demand));
                }
            }
        }

        public double CalculateDaysEarnings(Player player, Recipe recipe)
        {
            earnings = recipe.pricePerCup * player.soldInventory;
            return earnings;
        }
        public double CalculateDayProfit(Store store)
        {
            profit = earnings - store.totalExpense;
            return profit;
        }
        public void DisplayDayProfit()
        {
            if (profit <= 0)
            {
                Console.WriteLine($"You lost money today! You lost ${profit}.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"You made ${profit} today!");
                Console.ReadKey();
            }

        }
    


        //Make a method that will add some customers to the customer list
        //Use some if/else if to add more customers if it's sunny and less customers if it's bad weather

    }
}
