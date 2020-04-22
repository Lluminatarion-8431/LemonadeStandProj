using System;
using System.Collections.Generic;
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

        //Make a method that will add some customers to the customer list
        //Use some if/else if to add more customers if it's sunny and less customers if it's bad weather

    }
}
