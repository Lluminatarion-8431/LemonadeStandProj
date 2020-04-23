using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Customer
    {
        //member variable (HAS A:)
        private List<string> names;
        public string name;

        //Constructor (SPAWNER)


        //Member methods (WHAT IT DOES)
        public double buyProbability;

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
