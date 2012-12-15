using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public abstract class Vehicle
    {
        public abstract string ModelName { get; }
        public abstract string LisenceNUmber { get; }
        public abstract float FuelLevel { get; set; }
        public Wheels CarWheels { get; }

        public abstract class Wheels
        {
            abstract public byte WHeelsCount { get; }

            abstract public Wheel this[byte i_Index] { get; set; }
        }
    }
}
