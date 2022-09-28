using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany
    {
        public Car()
        {

        }
        public bool HasWheels { get; set; }
        public bool HasDoors { get; set; }
        public int NumberOfWheels { get; set; }
        public string Make { get; set; }

        public string Logo { get; set; }
        public string Name { get; set; }

        public string TrunkSize { get; set; }
        public bool IsHighOffGround { get; set; }
    }
}
