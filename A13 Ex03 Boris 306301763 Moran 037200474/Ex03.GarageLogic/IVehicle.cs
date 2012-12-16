using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public interface IVehicle
    {
        public abstract string ModelName { get; }
        public abstract string LisenceNUmber { get; }
        public abstract float EnergyLevel { get; set; }
        public VehicleTires Wheels { get; } 
    }
}
