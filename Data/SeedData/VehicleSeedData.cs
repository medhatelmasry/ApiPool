using System.Collections.Generic;
using ApiPool.Models.Vehicles;

namespace ApiPool.Data.Seed
{
    public class VehicleSeedData
    {
        public static List<VehicleManufacturer> GetVehicleManufacturers()
        {
            List<VehicleManufacturer> items = new List<VehicleManufacturer>()
            {
                new VehicleManufacturer() { VehicleManufacturerName = "Toyota", Country = "Japan" },
                new VehicleManufacturer() { VehicleManufacturerName = "Kia", Country = "South Korea" },
                new VehicleManufacturer() { VehicleManufacturerName = "Renault", Country = "France" },
                new VehicleManufacturer() { VehicleManufacturerName = "Mercedes", Country = "Germany" },
                new VehicleManufacturer() { VehicleManufacturerName = "Tesla", Country = "USA" }
            };

            return items;
        }

        public static List<Vehicle> GetVehicles()
        {
            List<Vehicle> items = new List<Vehicle>()
            {
                new Vehicle() { Model = "Corolla", Type = "Sedan", Fuel = "Gas", VehicleManufacturerName = "Toyota" },
                new Vehicle() { Model = "Rav4", Type = "SUV", Fuel = "Gas", VehicleManufacturerName = "Toyota" },
                new Vehicle() { Model = "Soul", Type = "SUV", Fuel = "Electric", VehicleManufacturerName = "Kia" },
                new Vehicle() { Model = "Model S", Type = "Sedan", Fuel = "Electric", VehicleManufacturerName = "Tesla" }
            };

            return items;
        }

    }
}
