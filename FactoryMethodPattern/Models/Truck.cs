using System;
namespace Factory_Method_Pattern.Models
{
    public class Truck : IVehicle
    {
        public void DisplayInfo()
        {
            Console.WriteLine("Truck produced");
        }
    }
}

