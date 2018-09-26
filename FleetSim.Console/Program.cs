using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FleetSim.Objects.Enum;
using FleetSim.Objects;
using FleetSim.Objects.interfaces;

namespace FleetSim.Console
{
    class Program
    {
        static void mileExamp()
        {
            List<Car> cars = new List<Car>()
            {
                new Car() {year = 1969, model = "cortina", make = "ford", vehColors= ColorsTypes.blue, mileage = 0, lastServicedMileage = 0 },
                new Car() {year = 1999, model = "prius", make = "toyota",  vehColors= ColorsTypes.red, mileage = 0, lastServicedMileage = 0 },
                new Car() {year = 2010, model = "accord", make = "honda",  vehColors= ColorsTypes.white, mileage = 0, lastServicedMileage = 0 },
                new Car() {year = 2012, model = "sorento", make = "kia",  vehColors= ColorsTypes.red, mileage = 0, lastServicedMileage = 0 },
                new Car() {year = 1990, model = "wrangler", make = "jeep", vehColors= ColorsTypes.white, mileage = 0, lastServicedMileage = 0 }
            };

            foreach (var prefCar in cars)
            {
                for (int counter = 0; counter < 10; counter++)
                {
                    Random rnd = new Random();
                    int newMileage = rnd.Next(5000, 15000);
                    prefCar.mileage = prefCar.mileage + newMileage;
                    prefCar.TuneUp(prefCar.mileage, prefCar.lastServicedMileage, prefCar.lastServicedDate, prefCar.model);
                };
            }
        }


        static void Main(string[] args)
        {
            try
            {
                mileExamp();
            }

            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }
    }
}

