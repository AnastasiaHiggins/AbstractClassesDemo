using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal abstract class Vehicle
    {

        public string Year { get; set; } = "Default";
        public string Make { get; set; } = "Default";
        public string Model { get; set; } = "Default";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine("Default Virtual Drive Method");
        }

        /*
 * Create an abstract class called Vehicle
 * The vehicle class shall have three string properties Year, Make, and Model
 * Set the defaults to something generic in the Vehicle class
 * Vehicle shall have an abstract method called DriveAbstract with no implementation
 * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
 */

        /* 
         * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
         * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
         * Provide the implementations for the abstract methods
         * Only in the Motorcycle class will you override the virtual drive method
        */

    }
}
