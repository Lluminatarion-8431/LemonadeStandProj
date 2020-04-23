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
        //member variable (HAS A:)
        public Weather weather;
        public List<Customer> customers;
        public int day;
        public double earnings;
        public double profit;

        //Constructor (SPAWNER)
        public Day ()
        {
            day = 1;
            weather = new Weather();
            customers = new List<Customer>();
        }
       
        //Member methods (WHAT IT DOES)
        public void Weather()
        {
            Console.WriteLine("Weather will be " + weather.temperature + " and " + weather.forecast);
        }
        public void DisplayDay()
        {
            Console.WriteLine($"Today is Day {day}\n\n");
        }
        public void GetTotalCustomers(Random rnd, Recipe recipe)//customers that come out based on weather conditions
        {
            Demand demand = new Demand(recipe, weather);
            if (weather.forecast == "Sunny")
            {
                int customerNumber = rnd.Next(20, 40);
                for (int i = 0; i < customerNumber; i++)
                {
                    customer.Add(new Customer(demand));
                }
            }
            //else if (weather.forecast == "cloudy")
            //{
            //    int customerNumber = rnd.Next(30, 34);
            //    for (int i = 0; i < customerNumber; i++)
            //    {
            //        customer.Add(new Customer(demand));
            //    }
            //}
            //else if (weather.temperature == "Hot" && weather.condition == "with thunderstorms")
            //{
            //    int customerNumber = rnd.Next(20, 29);
            //    for (int i = 0; i < customerNumber; i++)
            //    {
            //        customer.Add(new Customer(demand));
            //    }
            //}
            //else if (weather.temperature == "Warm" && weather.condition == "and sunny")
            //{
            //    int customerNumber = rnd.Next(25, 31);
            //    for (int i = 0; i < customerNumber; i++)
            //    {
            //        customer.Add(new Customer(demand));
            //    }
            //}
            //else if (weather.temperature == "Warm" && weather.condition == "and cloudy")
            //{
            //    int customerNumber = rnd.Next(20, 24);
            //    for (int i = 0; i < customerNumber; i++)
            //    {
            //        customer.Add(new Customer(demand));
            //    }
            //}
            else if (weather.forecast == "Cloudy")
            {
                int customerNumber = rnd.Next(15, 30);
                for (int i = 0; i < customerNumber; i++)
                {
                    customer.Add(new Customer(demand));
                }
            }
            //else if (weather.temperature == "Cold" && weather.condition == "and sunny")
            //{
            //    int customerNumber = rnd.Next(5, 11);
            //    for (int i = 0; i < customerNumber; i++)
            //    {
            //        customer.Add(new Customer(demand));
            //    }
            //}
            //else if (weather.temperature == "Cold" && weather.condition == "and cloudy")
            //{
            //    int customerNumber = rnd.Next(0, 10);
            //    for (int i = 0; i < customerNumber; i++)
            //    {
            //        customer.Add(new Customer(demand));
            //    }
            //}
            else if (weather.forecast == "rainy")
            {
                int customerNumber = rnd.Next(0, 15);
                for (int i = 0; i < customerNumber; i++)
                {
                    customer.Add(new Customer(demand));
                }
            }
        }

        public double CalculateDaysEarnings(Player player, Recipe recipe)
        {
            dayEarning = recipe.pricePerCup * player.soldInventory;
            return dayEarning;
        }
        public double CalculateDayProfit(Store store)
        {
            dayProfit = dayEarning - store.totalExpense;
            return dayProfit;
        }
        public void DisplayDayProfit()
        {
            if (dayProfit <= 0)
            {
                Console.WriteLine($"You lost money today! You lost ${dayProfit}.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"You made ${dayProfit} today!");
                Console.ReadKey();
            }
        }
    }


        //Make a method that will add some customers to the customer list
        //Use some if/else if to add more customers if it's sunny and less customers if it's bad weather

    }
}
