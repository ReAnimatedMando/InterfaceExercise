using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle:
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: public int NumberOfWheels { get; set; }
                 */
            

            //In ICompany: 
            
                /* Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 * Example: public string Logo { get; set; }
                 */

            //In each of your Car, Truck, and SUV classes

                /* Create 2 members that are specific to each class
                 * Example for Car: public bool HasTrunk { get; set; }
                 * Example for SUV: public int NumberOfSeats { get; set; }
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 */

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values

            var carOne = new Car();
            carOne.Make = "Subaru";
            carOne.Model = "Crosstrek";
            carOne.Year = 2015;
            carOne.IsConvertible = true;
            carOne.HasTrunk = true;
            carOne.NumberOfWheels = "4";
            carOne.NumberOfSeats = "6";
            carOne.NumberOfDoors = "2";
            carOne.IsAutomatic = true;
            carOne.Logo = "Swoosh";
            carOne.Location = "Denver";

            var truckOne = new Truck();
            truckOne.Make = "Jeep";
            truckOne.Model = "Gladiator";
            truckOne.Year = 2024;
            truckOne.HasBedCover = false;
            truckOne.HasTowHitch = true;
            truckOne.NumberOfWheels = "6";
            truckOne.NumberOfSeats = "4";
            truckOne.NumberOfDoors = "2";
            truckOne.IsAutomatic = false;
            truckOne.Logo = "Penguin";
            truckOne.Location = "New York";

            var suvOne = new SUV();
            suvOne.Make = "Nissan";
            suvOne.Model = "Pathfinder";
            suvOne.Year = 2019;
            suvOne.HasFoldableCargoSpace = true;
            suvOne.SeatRows = 3;
            suvOne.NumberOfWheels = "4";
            suvOne.NumberOfSeats = "8";
            suvOne.NumberOfDoors = "4";
            suvOne.IsAutomatic = true;
            suvOne.Logo = "Popsicle";
            suvOne.Location = "Los Angeles";

            var parkingLot = new List<IVehicle>() { carOne, truckOne, suvOne };

            foreach (var ride in parkingLot)
            {
                Console.WriteLine($"This is a {ride.Make} {ride.Model}, made in the year {ride.Year}.\n");
            }

            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.

        }
    }
}
