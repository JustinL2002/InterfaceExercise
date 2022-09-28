using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        public bool HasWheels { get; set; }
        public bool HasDoors { get; set; }
        public int NumberOfWheels { get; set; }   
        public string Make { get; set; }
    }
}
