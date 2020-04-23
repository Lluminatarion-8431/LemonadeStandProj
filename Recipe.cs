using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Recipe
    {
        //Member variable (what it has:)//
        public int amountOfLemons;
        public int amountOfSugarCubes;
        public int amountOfIceCubes;
        public double pricePerCup;
        public int cup;


        //Constructor (spawner)//
        public Recipe ()
        {

        }

        //Member methods (what it does)//
        public void RecipeStart(Player player)
        {
            Console.WriteLine("What would you like to do: 'make' recipe, 'check' inventory, 'set' lemonade price, 'display' recipe, 'leave'?");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "make":
                    player.item.DisplayInventory();
                    amountOfLemons = PickLemons();
                    CheckLemonInventory(player, amountOfLemons);
                    amountOfSugarCubes = PickSugar();
                    CheckSugarInventory(player, amountOfSugarCubes);
                    amountOfIceCubes = PickIce();
                    CheckIceInventory(player, amountOfIceCubes);
                    cup = PickCup();
                    CheckCupInventory(player, cup);
                    int totalLemon = CalculateLemonUse(amountOfLemons, cup);
                    CheckLemonInventory(player, totalLemon);
                    int totalSugar = CalculateSugarUse(amountOfSugarCubes, cup);
                    CheckSugarInventory(player, totalLemon);
                    int totalIce = CalculateIceUse(amountOfIceCubes, cup);
                    CheckIceInventory(player, totalIce);
                    RemoveLemons(player, totalLemon);
                    RemoveSugar(player, totalSugar);
                    RemoveIce(player, totalIce);
                    RemoveCup(player, cup);
                    MakeLemonade(player, cup);
                    player.item.DisplayInventory();
                    Console.Clear();
                    RecipeStart(player);
                    break;

                case "check":
                    player.item.DisplayInventory();
                    Console.Clear();
                    RecipeStart(player);
                    break;
                case "set":
                    if (player.item.supplies[4].Count > 0)
                    {
                        DisplayRecipe(amountOfLemons, amountOfSugarCubes, amountOfIceCubes, cup);
                        PickLemonadePrice();
                        Console.Clear();
                        return;
                    }
                    else
                    {
                        Console.WriteLine("You have to make your lemonade");
                        Console.ReadKey();
                        Console.Clear();
                        RecipeStart(player);
                    }
                    break;
                case "display":
                    DisplayRecipe(amountOfLemons, amountOfSugarCubes, amountOfIceCubes, cup);
                    Console.Clear();
                    RecipeStart(player);
                    break;
                case "leave":
                    if (pricePerCup > 0)
                    {
                        return;
                    }
                    else
                    {
                        Console.WriteLine("You must enter a price for your lemonade.");
                        Console.ReadKey();
                        Console.Clear();
                        RecipeStart(player);
                    }
                    break;

                default:
                    Console.WriteLine("Please select one of the options.");
                    Console.ReadKey();
                    Console.Clear();
                    RecipeStart(player);
                    break;
            }
        }
        public int PickLemons()
        {
            Console.WriteLine("How many lemons would you like?");
            amountOfLemons = int.Parse(Console.ReadLine());
            return amountOfLemons;
        }
        public bool CheckLemonInventory(Player player, int amountOfLemons)// TODO
        {//program will catch the user the first time and no matter what number is entered the second time, will throw error. 
            if (player.item.supplies[0].Count < amountOfLemons)
            {
                Console.WriteLine("You do not have that many lemons!");
                PickLemons();
            }
            return true;
        }
        public int PickSugar()
        {
            Console.WriteLine("\nHow much sugar would you like?");
            amountOfSugarCubes = int.Parse(Console.ReadLine());
            return amountOfSugarCubes;
        }
        public bool CheckSugarInventory(Player player, int sugarCount)
        {//program will catch the user the first time and no matter what number is entered the second time, will throw error.
            if (player.item.supplies[1].Count < amountOfSugarCubes)
            {
                Console.WriteLine("You do not have that much sugar!");
                PickSugar();
            }
            return true;
        }
        public int PickIce()
        {
            Console.WriteLine("\nHow much ice would you like?");
            amountOfIceCubes = int.Parse(Console.ReadLine());
            return amountOfIceCubes;
        }
        public bool CheckIceInventory(Player player, int iceCount)
        {//program will catch the user the first time and no matter what number is entered the second time, will throw error.
            if (player.item.supplies[2].Count < iceCount)
            {
                Console.WriteLine("You do not have that much ice!");
                PickIce();
            }
            return true;
        }
        public int PickCup()
        {
            Console.WriteLine("\nHow many cups of lemonade would you like to make?");
            cup = int.Parse(Console.ReadLine());
            return cup;
        }
        public bool CheckCupInventory(Player player, int cupCount)
        {//program will catch the user the first time and no matter what number is entered the second time, will throw error.
            if (player.item.supplies[2].Count < cupCount)
            {
                Console.WriteLine("You do not have that many cups!");
                PickCup();
            }
            return true;
        }
        public int CalculateLemonUse(int lemon, int cup)
        {
            int totalLemons = lemon * cup;
            return totalLemons;
        }
        public int CalculateSugarUse(int sugar, int cup)
        {
            int totalSugar = sugar * cup;
            return totalSugar;
        }
        public int CalculateIceUse(int ice, int cup)
        {
            int totalIce = ice * cup;
            return totalIce;
        }
        public void RemoveLemons(Player player, int lemon)
        {
            for (int i = 0; i < lemon; i++)
            {
                player.item.supplies[0].RemoveAt(0);
            }
        }
        public void RemoveSugar(Player player, int sugar)
        {
            for (int i = 0; i < sugar; i++)
            {
                player.item.supplies[1].RemoveAt(0);
            }
        }
        public void RemoveIce(Player player, int ice)
        {
            for (int i = 0; i < ice; i++)
            {
                player.item.supplies[2].RemoveAt(0);
            }
        }
        public void RemoveCup(Player player, int cup)
        {
            for (int i = 0; i < cup; i++)
            {
                player.item.supplies[3].RemoveAt(0);
            }
        }
        public void MakeLemonade(Player player, int cup)
        {
            for (int i = 0; i < cup; i++)
            {
                player.item.AddPitcher(new Pitcher());
            }
        }
        public double PickLemonadePrice()
        {
            Console.WriteLine("How much would you like to sell each cup of your lemonade for?");
            pricePerCup = double.Parse(Console.ReadLine());
            return pricePerCup;
        }
        public void DisplayRecipe(int amountOfLemons, int amountOfSugarCubes, int amountOfIceCubes, int cup)
        {
            Console.WriteLine($"Your current recipe includes *(each number represents the amount of the item in each cup): \n Lemons: {amountOfLemons}  \n Sugar: {amountOfSugarCubes} \nIce: {amountOfIceCubes}\n Cups of Lemonade: {cup}\n");
            Console.ReadKey();
        }
    }
}
