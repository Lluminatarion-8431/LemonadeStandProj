using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Wallet
    {
        private double money;
         
        public double Money
        {
            get
            {
                return Money;
            }
        }

        public Wallet()
        {
            money = 20.00;
        }

    //    public void PayMoneyForItems(double totalExpense)
    //    {
    //        money -= totalExpense;
    //    }
    }
}
