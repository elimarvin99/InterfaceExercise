using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            var tesla = new Car() {AmountOfWheels = 4, color = "blue", CompanyName = "Tesla", Has4Doors = true, RunsOnGas = false, TrunkSize = 5};
            var HondaPilot = new SUV() {AmountOfWheels = 4, color = "silver", CargoSize = 7, RunsOnGas = true, CompanyName = "Honda", FourWheelDrive = false };
            var FordF150 = new Truck() { AmountOfWheels = 4, BedSize = 15, color = "red", CompanyName = "Ford", IsDiesel = true, RunsOnGas = true};

            Console.WriteLine($"My {tesla.CompanyName} is {tesla.color}. It's trunk is {tesla.TrunkSize} square feet.");
            Console.WriteLine($"The most bought car in 'Merica is the FordF150. I personally love when they are {FordF150.color}. It's {FordF150.RunsOnGas} that they consume alot of fuel, but they are a beast of a truck");
            Console.WriteLine($"A common car in Miami is the {HondaPilot.CompanyName} Pilot. Most of them are not four wheel drive.");
        }
    }
}
