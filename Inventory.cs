using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Inventory
    {
        //Member variable (what it has:)//

        public string name;
        public List<List<Inventory>> supplies;
        public double profit;
        public double money;
        public Wallet wallet;
        List<Inventory> lemon;
        List<Inventory> sugarCube;
        List<Inventory> iceCube;
        List<Inventory> cup;
        List<Inventory> pitcher;
        //constructor (SPAWNER)//
        public Inventory()
        {
            wallet = new Wallet();
            supplies = new List<List<Inventory>>();
            lemon = new List<Inventory>();
            sugarCube = new List<Inventory>();
            iceCube = new List<Inventory>();
            cup = new List<Inventory>();
            pitcher = new List<Inventory>();
            supplies.Add(lemon);
            supplies.Add(sugarCube);
            supplies.Add(iceCube);
            supplies.Add(cup);
            supplies.Add(pitcher);
        }

        // member methods (CAN DO)

        public void AddLemon(Lemon lemon)
        {
            supplies[0].Add(lemon);
        }
        public void AddSugar(SugarCube sugarCube)
        {
            supplies[1].Add(sugarCube);
        }
        public void AddIce(IceCube iceCube)
        {
            supplies[2].Add(iceCube);
        }
        public void AddCup(Cup cup)
        {
            supplies[3].Add(cup);
        }
        public void AddPitcher(Pitcher pitcher)
        {
            supplies[4].Add(pitcher);
        }
        public void DisplayInventory()
        {
            Console.WriteLine($"Your current inventory:\n\n Money: ${money}\n Lemons: {supplies[0].Count}\n SugarCubes: {supplies[1].Count}\n IceCubes: {supplies[2].Count}\n Empty Cups: {supplies[3].Count}\n Cups of Lemonade: {supplies[4].Count}\n");
            Console.ReadKey();
        }
        //public List<Lemon> lemons;
        //public List<SugarCube> sugarCubes;
        //public List<IceCube> iceCubes;
        //public List<Cup> cups;

        ////Constructor (spawner)//
        //public Inventory()
        //{
        //    lemons = new List<Lemon>();
        //    sugarCubes = new List<SugarCube>();
        //    iceCubes = new List<IceCube>();
        //    cups = new List<Cup>();
        //}

        ////Member methods (what it does)//
        //public void AddLemonsToInventory(int numberOfLemons)
        //{
        //    for(int i = 0; i < numberOfLemons; i++)
        //    {
        //        Lemon lemon = new Lemon();
        //        lemons.Add(lemon);
        //    }
        //}

        //public void AddSugarCubesToInventory(int numberOfSugarCubes)
        //{
        //    for(int i = 0; i < numberOfSugarCubes; i++)
        //    {
        //        SugarCube sugarCube = new SugarCube();
        //        sugarCubes.Add(sugarCube);
        //    }
        //}

        //public void AddIceCubesToInventory(int numberOfIceCubes)
        //{
        //    for(int i = 0; i < numberOfIceCubes; i++)
        //    {
        //        IceCube iceCube = new IceCube();
        //        iceCubes.Add(iceCube);
        //    }
        //}

        //public void AddCupsToInventory(int numberOfCups)
        //{
        //    for(int i = 0; i < numberOfCups; i++)
        //    {
        //        Cup cup = new Cup();
        //        cups.Add(cup);
        //    }
        //}

    }
}
