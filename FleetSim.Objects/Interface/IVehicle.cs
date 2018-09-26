using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetSim.Objects.interfaces
{
    interface IVehicle
    {
        void TuneUp(int mileage, int lastServicedMileage, DateTime lastServicedDate, string modelName);
        void RebuildEngine(string modelName);

    }
}

