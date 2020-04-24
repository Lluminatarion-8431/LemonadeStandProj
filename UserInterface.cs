using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    public class UserInterface
    {
        public UserInterface()
        {

        }
        public void WelcomePlayer()
        {

            Console.WriteLine("You have 7 days with the lemonade stand you have just opened. You have complete control over how you're business is run, including choosing, inventory and buying supplies. Buy your supplies, set your recipe, and start making money!\n\n You will start off the game with $20.00 and will have the ability to buy your supplies, lemons, sugar cubes, ice cubea, and cups. After buying your supplies you get to decide your recipe and start making money.\n\nGood luck!\n\nSupply Prices:\nLemons: $.15\nSugar: $.05\nIce: $.05\nCups: $.10\n\n Press enter to continue!");
            Console.ReadLine();
        }
    }
    
}
