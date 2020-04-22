﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Weather
    {
        //Member Variables// 
        public double temperature;
        public string forecast;
        public double demandLevel;
        protected double sunnyFactor = 1.5;
        protected double cloudyFactor = 1;
        protected double rainyFactor = .5;


        //Contstructor//

        //generates a random double int to simulate temperature for the day
        
        //generates a random number for the atmosphere
       

        //Member Methods//

        //will give value to Random(1, 3) to help generate the atomsphere of the day.
        public Weather()
        {
            Random temp = new Random();
            this.temperature = temp.Next(65, 110);
            Random rnd = new Random();
            int atmos = rnd.Next(1, 3);

            if (atmos == 1)
            {
                this.forecast = "Sunny";
            }
            else if (atmos == 2)
            {
                this.forecast = "Cloudy";
            }
            else
            {
                this.forecast = "Rainy";
            }
            //will calculate the demand level according to the weather
            if (this.forecast == "Sunny")
            {
                this.demandLevel = temperature * sunnyFactor;
            }
            else if (this.forecast == "Cloudy")
            {
                this.demandLevel = temperature * cloudyFactor;
            }
            else
            {
                this.demandLevel = temperature * rainyFactor;
            }
        }
            //will get member variable and return its value
        public double Temperature
        {
            get
            {
                return temperature;
            }
        }
        public string Forecast
        {
            get
            {
                return forecast;
            }
        }
        public double DemandLevel
        {
            get
            {
                return demandLevel;
            }
        }
        // weather conditon could affect how many customers come for the day 
        //according to temp. if they buy or not;



    }
}
