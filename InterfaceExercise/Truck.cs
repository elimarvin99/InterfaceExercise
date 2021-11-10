using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise  
{
    public class Truck : IVehicle, ICompany
    {
        public Truck()
        {
                
        }
        public int BedSize { get; set; }
        public bool IsDiesel { get; set; }

        public int AmountOfWheels { get; set; }
        public bool RunsOnGas { get; set; }
        public string Make { get; set; }
        public string color { get; set; }

        public string Logo { get; set; }
        public string CompanyName { get; set; }
    }
}
