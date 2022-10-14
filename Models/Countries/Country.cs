using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiPool.Models.Countries
{
    public class Country
    {
        [Key]
        public string CountryName { get; set; }

        [Required]
        public string CapitalCity { get; set; }

        [Required]
        public int AreaSqKm { get; set; }

        [Required]
        public string ContinentName { get; set; }

        [ForeignKey("ContinentName")] 
        public Continent Continent { get; set; }

        public List<Province> Provinces { get; set; }
    }
}