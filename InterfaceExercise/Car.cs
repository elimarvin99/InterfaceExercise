using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car()
        {

        }
        public int TrunkSize { get; set; }
        public bool Has4Doors { get; set; }

        public int AmountOfWheels { get; set; }
        public bool RunsOnGas { get; set; }
        public string Make { get; set; }
        public string color { get; set; }

        public string Logo { get; set; }
        public string CompanyName { get; set; }
    }
}
