using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Car : IVehicle
    {
        public Car()
        {
        }

        public void Drive()
        {
            Console.WriteLine("This car is now driving!");
        }


    }
}
