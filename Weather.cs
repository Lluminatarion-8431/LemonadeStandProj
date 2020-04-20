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
        protected string percipitation;
        protected double demandLevel;



        //Contstructor//
        Random rnd = new Random();
        this.temperature = rnd.Next(65, 110);




        //Member Methods

        // weather conditon could affect how many customers come for the day 
        //according to temp. if they buy or not; 



    }
}
