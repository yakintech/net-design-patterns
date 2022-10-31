using Factory_Method_Pattern.Models;

var vehicleFactory = new VehicleFactory();

IVehicle vehicleCar = vehicleFactory.ProduceVehicle(VehicleType.Car);
vehicleCar.DisplayInfo();

IVehicle vehicleMotorcycle = vehicleFactory.ProduceVehicle(VehicleType.Motorcycle);
vehicleMotorcycle.DisplayInfo();

Console.Read();
