using System.Collections.Generic;
using ApiPool.Models.Species;

namespace ApiPool.Data.Seed
{
    public class SpeciesSeedData
    {
        public static List<Specie> GetSpecies()
        {
            List<Specie> items = new List<Specie>()
            {
                new Specie() { SpecieName = "Bird" },
                new Specie() { SpecieName = "Mammal" },
                new Specie() { SpecieName = "Insect" },
                new Specie() { SpecieName = "Reptile" },
                new Specie() { SpecieName = "Fish" },
                new Specie() { SpecieName = "Amphibians" }
            };

            return items;
        }

        public static List<Organism> GetOrganisms()
        {
            List<Organism> items = new List<Organism>()
            {
                new Organism() { OrganismId = 1, Name = "Australian brush turkey", SpecieName="Bird" },
                new Organism() { OrganismId = 2, Name = "Egyptian plover", SpecieName="Bird" },
                new Organism() { OrganismId = 3, Name = "White stork", SpecieName="Bird" },
                new Organism() { OrganismId = 4, Name = "Kingfisher", SpecieName="Bird" },
                new Organism() { OrganismId = 5, Name = "Atlantic salmon", SpecieName="Fish" },
                new Organism() { OrganismId = 6, Name = "Great white shark", SpecieName="Fish" }
            };

            return items;
        }
    }
}
