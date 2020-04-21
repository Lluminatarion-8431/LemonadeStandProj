using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Weather
    {
        //Member Variables// 
        protected double temperature;
        protected string atmosphere;
        protected double demandLevel;
        protected double sunnyFactor = 1;
        protected double rainyFactor = .5;


        //Contstructor//

        //generates a random double int to simulate temperature for the day
        Random temp = new Random();
        this.temperature = temp.Next(65, 110);
        //generates a random number for the atmosphere
        Random rnd = new Random();
        int atmos = rnd.Next(1, 3);

        //Member Methods//

        //this will give value to Random(1, 3) to help generate the atomsphere of the day.
        public Weather()
        {
            if (atmos == 1)
            {
                this.atmosphere = "Sunny";
            }
            else if (atmos == 2)
            {
                this.atmosphere = "Cloudy";
            }
            else
            {
                this.atmosphere = "Rainy";
            }
        }

        // weather conditon could affect how many customers come for the day 
        //according to temp. if they buy or not; 



    }
}
