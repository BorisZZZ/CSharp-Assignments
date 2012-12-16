using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public abstract class VehicleTires
    {
            abstract public byte WheelsCount { get; }

            abstract public Tire this[int i_Index] { get; set; }
    }
}
