using System;
namespace Factory_Method_Pattern.Models
{
    public class Car : IVehicle
    {
        public void DisplayInfo()
        {
            Console.WriteLine("Car produced");
        }
    }
}

