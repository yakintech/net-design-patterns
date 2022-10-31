using System;
namespace Factory_Method_Pattern.Models
{
    public interface IVehicleFactory
    {
        IVehicle ProduceVehicle(VehicleType type);
    }
}

