using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApiPool.Models.Countries
{
    public class Continent
    {
        [Key]
        public string? ContinentName { get; set; }

        public List<Country>? Countries { get; set; }
    }
}