using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiPool.Models.Vehicles
{
    public class VehicleManufacturer
    {
        [Key]
        public string VehicleManufacturerName { get; set; }

        [Required]
        public string Country { get; set; }

        public List<Vehicle> Vehicles { get; set; }
    }
}