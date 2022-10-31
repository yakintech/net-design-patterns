using System;
namespace Factory_Method_Pattern.Models
{
    public class VehicleFactory : IVehicleFactory
    {
        public IVehicle ProduceVehicle(VehicleType type)
        {
            IVehicle vehicle = null;
            switch (type)
            {
                case VehicleType.Car:
                    vehicle = new Car();
                    break;
                case VehicleType.Truck:
                    vehicle = new Truck();
                    break;
                case VehicleType.Motorcycle:
                    vehicle = new Motorcycle();
                    break;
            }
            return vehicle;
        }
    }

