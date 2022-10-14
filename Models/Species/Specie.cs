using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApiPool.Models.Species
{
    public class Specie
    {
        [Key]
        public string SpecieName { get; set; }

        public List<Organism> Organisms { get; set; }
    }
}