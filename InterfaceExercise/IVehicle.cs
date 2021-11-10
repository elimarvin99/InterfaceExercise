using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    //In your IVehicle

    /* Create 4 members that Car, Truck, & SUV all have in common.
     * Example: All vehicles have a number of wheels... for now..
     */
    public interface IVehicle
    {
        public int AmountOfWheels { get; set; }
        public bool RunsOnGas { get; set; }
        public string Make { get; set; }
        public string color { get; set; }
    }
}
