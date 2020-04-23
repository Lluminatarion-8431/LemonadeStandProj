using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Game
    {
        //member variable (HAS A:)
        public Player player;
        //public UserInterface UI;
        public Day runDay;
        public Store store;
        public Recipe recipe;
        public Random rnd;
        public Weather weather;



        //Constructor (SPAWNER)
        public Game()
        {
            player = new Player();
            //UI = new UserInterface();
            runDay = new Day();
            store = new Store();
            recipe = new Recipe();
            rnd = new Random();
            weather = new Weather();
        }

        //Member methods (WHAT IT DOES)
        public void RunGame() //master method 
        {
            runDay.DisplayDay();
            player.item.DisplayInventory();
            store.StoreStart(player);
            Console.Clear();
            runDay.GetWeather(rnd);
            runDay.GetForecast(rnd);
            recipe.RecipeStart(player);
            Console.Clear();
            player.item.DisplayInventory();
            runDay.GetTotalCustomers(rnd, recipe);
            player.SellLemonade(runDay.customer);
            player.item.DisplayInventory();
            double dayEarning = runDay.CalculateDaysEarnings(player, recipe);
            double dayProfit = runDay.CalculateDayProfit(store);
            double runningProfit = CalculateDayOneProfit(dayProfit);
            //double totalProfit = CalculateTotalProfit(dayProfit,runningProfit)
            runDay.DisplayDayProfit();
            DisplayTotalProfit(runningProfit);
            AddProfit(runningProfit);
            player.CheckSpoilInventory();
            Console.Clear();
            EndOfDay();
            NewDay();
        }
        public double CalculateDayOneProfit(double dayProfit)
        {
            double dayOneProfit = dayProfit + 0;

            return dayOneProfit;
        }
        public double CalculateTotalProfit(double dayProfit, double runningProfit)
        {
            double totalProfit = dayProfit + runningProfit;

            return totalProfit;
        }
        public void DisplayTotalProfit(double totalProfit)
        {
            Console.WriteLine($"Your total profit is: ${totalProfit}!");
            Console.ReadKey();
        }
        public void AddProfit(double totalProfit)
        {
            player.item.money = totalProfit + player.item.money;
        }
        public void EndOfDay()
        {
            if (player.item.money <= 0)
            {
                Console.WriteLine("You have no more money!");
                Console.WriteLine("GAME OVER");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else
            {
                runDay.day++;
            }
        }
        public void NewDay()
        {
            for (int i = 0; i < 8; i++)
            {
                if (runDay.day <= 7)
                {
                    runDay.DisplayDay();
                    store.StoreStart(player);
                    Console.Clear();
                    runDay.Weather(rnd);
                    runDay.Forecast(rnd);
                    recipe.RecipeStart(player);
                    Console.Clear();
                    player.item.DisplayInventory();
                    runDay.GetTotalCustomers(rnd, recipe);
                    player.SellLemonade(runDay.customer);
                    player.item.DisplayInventory();
                    double dayEarning = runDay.CalculateDaysEarnings(player, recipe);
                    double dayProfit = runDay.CalculateDayProfit(store);
                    double runningProfit = CalculateDayOneProfit(dayProfit);
                    double totalProfit = CalculateTotalProfit(dayProfit, runningProfit);
                    runDay.DisplayDayProfit();
                    DisplayTotalProfit(runningProfit);
                    AddProfit(runningProfit);
                    player.CheckSpoilInventory();
                    Console.Clear();
                    EndOfDay();
                    NewDay();
                }
                else
                {
                    Console.WriteLine("Congrats on pulling through this week!\n\n Game Over :D");
                    Console.ReadKey();
                    player.item.DisplayInventory();
                    return;
                }
            }
        }


    }
}
