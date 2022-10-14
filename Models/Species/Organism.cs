using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiPool.Models.Species
{
    public class Organism
    {
        public int OrganismId { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? SpecieName { get; set; }

        [ForeignKey("SpecieName")] 
        public Specie? Specie { get; set; }
    }
}