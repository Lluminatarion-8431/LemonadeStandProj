using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Customer
    {
        //Member variable (what it has:)//
        public double buyProbability;

        //Constructor (spawner)//

        //Member methods (what it does)//
        public Customer(Demand demand)
        {
            CustomerBuyProbability(demand);
        }
        public double CustomerBuyProbability(Demand demand)
        {
            Random rnd = new Random();
            buyProbability = rnd.Next(50, 90) / demand.priceDemand / demand.weatherDemand;
            return buyProbability;
        }
    }
}
