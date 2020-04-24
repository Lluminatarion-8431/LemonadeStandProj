using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    abstract class Item
    {
        public string name;
        public double price;

        public Item()
        {

        }
        //// member variables (HAS A)
        //public string name;
        //public List<List<Item>> supplies;
        //public double profit;
        //public double money;
        //List<Item> lemon;
        //List<Item> sugarCube;
        //List<Item> iceCube;
        //List<Item> cup;
        //List<Item> pitcher;
        //// constructor (SPAWNER)
        //public Item()
        //{
        //    supplies = new List<List<Item>>();
        //    lemon = new List<Item>();
        //    sugarCube = new List<Item>();
        //    iceCube = new List<Item>();
        //    cup = new List<Item>();
        //    pitcher = new List<Item>();
        //    supplies.Add(lemon);
        //    supplies.Add(sugarCube);
        //    supplies.Add(iceCube);
        //    supplies.Add(cup);
        //    supplies.Add(pitcher);
        //}

        //// member methods (CAN DO)

        //public void AddLemon(Lemon lemon)
        //{
        //    supplies[0].Add(lemon);
        //}
        //public void AddSugar(SugarCube sugarCube)
        //{
        //    supplies[1].Add(sugarCube);
        //}
        //public void AddIce(IceCube iceCube)
        //{
        //    supplies[2].Add(iceCube);
        //}
        //public void AddCup(Cup cup)
        //{
        //    supplies[3].Add(cup);
        //}
        //public void AddPitcher(Pitcher pitcher)
        //{
        //    supplies[4].Add(pitcher);
        //}
        //public void DisplayInventory()
        //{
        //    Console.WriteLine($"Your current inventory:\n\n Money: ${money}\n Lemons: {supplies[0].Count}\n SugarCubes: {supplies[1].Count}\n IceCubes: {supplies[2].Count}\n Empty Cups: {supplies[3].Count}\n Cups of Lemonade: {supplies[4].Count}\n");
        //    Console.ReadKey();
        //}
    }
}
