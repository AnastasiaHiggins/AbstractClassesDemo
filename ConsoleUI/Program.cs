using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Vehicles
            var vehicles = new List<Vehicle>();

            var car1 = new Car()
            { 
                    HasTrunk = true, 
                    Year = "2000",
                    Make = "Honda",
                    Model = "Accord"
            };
            var motorcycle1 = new Motorcycle()
            {
                    HasSidecar = true,
                    Year = "1993",
                    Make = "Harley",
                    Model = "Something"
            };
            Vehicle vehicle1 = new Car()
            {
                    Year = "2001",
                    Make = "Toyota",
                    Model = "Camry"
            };
            Vehicle vehicle2 = new Motorcycle()
            {
                    Year = "Dunno",
                    Make = "Bike",
                    Model = "Bike"
            };

            vehicles.Add(car1);
            vehicles.Add(motorcycle1);
            vehicles.Add(vehicle1);
            vehicles.Add(vehicle2);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Year: {vehicle.Year}");
                Console.WriteLine($"Year: {vehicle.Make}");
                Console.WriteLine($"Year: {vehicle.Model}");
                Console.WriteLine();
                vehicle.DriveVirtual();
                vehicle.DriveAbstract();
                Console.WriteLine();
            }

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
        }
    }
}
