using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FleetSim.Objects;
using FleetSim.Objects.interfaces;
using FleetSim.Objects.Enum;

namespace FleetSim.Objects
{
    public class Car : Vehicle, ICar
    {
        public int _year;
        public string _model;
        public string _make;

        public Car() { }

        public Car(int year, string model, string make)
        {
            this._model = model;
            this._make = make;
            this._year = year;
        }
        public Car(int year, string model, string make, ColorsTypes carColors)
        {
            this._model = model;
            this._make = make;
            this._year = year;
            this.vehColors = carColors;
        }

        public int year { get; set; }
        public string model { get; set; }
        public string make { get; set; }
    }
}


