using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class SUV : IVehicle, ICompany
    {
        public SUV()
        {

        }
        public bool HasWheels { get; set; }
        public bool HasDoors { get; set; }
        public int NumberOfWheels { get; set; }
        public string Make { get; set; }

        public string Logo { get; set; }
        public string Name { get; set; }

        public string CargoHoldSize { get; set; }
        public bool IsHighOffGround { get; set; }
    }
}
