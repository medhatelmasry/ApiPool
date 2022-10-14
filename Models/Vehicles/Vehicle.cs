using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiPool.Models.Vehicles
{
    public class Vehicle
    {
        [Key]
        public string Model { get; set; }

        [Required]
        public string Fuel { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public string VehicleManufacturerName { get; set; }

        [ForeignKey("VehicleManufacturerName")] 
        public VehicleManufacturer VehicleManufacturer { get; set; }
    }
}