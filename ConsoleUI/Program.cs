using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles



            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */
            var car1 = new Car()
            {
                HasHood = true,
                HasSunRoof = false,
                HasTrunk = true,
            };
            var motorcycle1 = new Motorcycle()
            {
                HasHandleBars = true,
                HasSideCar = false,
                RequireHelmet = true,
            };
            Vehicle vehicle1= new Car()
            { Make = "Benz",
            Model = "AMG",
            Year = "2022"};
            Vehicle vehicle2 = new Motorcycle()
            {
                Make = "Yamaha",
                Model = "YZF-R6",
                Year = "1996",
            };
            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            vehicles.Add(car1);
            vehicles.Add(motorcycle1);
            vehicles.Add(vehicle1);
            vehicles.Add(vehicle2);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Year : {vehicle.Make}");
                Console.WriteLine($"Model : {vehicle.Model}");
                Console.WriteLine($"Make: {vehicle.Make}");
                Console.WriteLine();
                vehicle.DriveAbstract();
                vehicle.DriveVirtual();
                Console.WriteLine();
            }
            // Call each of the drive methods for one car and one motorcycle

                #endregion
            Console.ReadLine();
        }
    }
}
