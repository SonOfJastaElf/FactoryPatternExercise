using System;

namespace ConsoleApp2
{
    class FactoryPatternExercise
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of tires for the vehicle you want to create:");

            int wheelCount;
            bool input = false;

            do
            {
                input = int.TryParse(Console.ReadLine(), out wheelCount);
            } while (input == false);
            
            var vehicle = VehicleFactory.GetVehicle(wheelCount);
            vehicle.Drive();
        }
    }
}
