using System;
namespace Factory_Method_Pattern.Models
{
    public class Motorcycle : IVehicle
    {
        public void DisplayInfo()
        {
            Console.WriteLine("Motorcycle produced");
        }
    }
}

