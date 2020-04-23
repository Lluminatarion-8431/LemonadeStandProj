using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Weather
    {
        //Member variable (what it has:)// 
        public string temperature;
        public string condition;

        //Constructor (spawner)//
        public Weather()
        {

        }

        //Member methods (what it does)//
        public int GetTemp(Random rnd) //will display a random temperature
        {
            int temperature = rnd.Next(1, 4);

            switch (temperature)
            {
                case 1:
                    this.temperature = "Hot";
                    break;
                case 2:
                    this.temperature = "Warm";
                    break;
                case 3:
                    this.temperature = "Cold";
                    break;
                default:
                    Console.WriteLine("There was an error getting the report");
                    break;
            }
            return temperature;
        }
        public int GetOvercast(Random rnd)//will randomly display percipitation
        {
            int condition = rnd.Next(1, 4);

            switch (condition)
            {
                case 1:
                    this.condition = "sunny";
                    break;
                case 2:
                    this.condition = "cloudy";
                    break;
                case 3:
                    this.condition = "rainy";
                    break;
                default:
                    Console.WriteLine("There was an error getting the report");
                    break;
            }
            return condition;
        }
        public void DisplayCurrentWeather()
        {
            Console.WriteLine($"Today's forcast is: {temperature} {condition}\n");
        }
        public void DisplayForecast()
        {
            Console.WriteLine($"The weather for tomorrow is: {temperature} {condition}\n");
        }



    }
}
