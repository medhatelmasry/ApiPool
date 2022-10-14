using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApiPool.Models.Movies
{
    public class Movie
    {
        public int MovieId { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? DirectorFirstName { get; set; }    

        [Required]
        public string? DirectorLastName { get; set; }   

        [Required]
        public int Year { get; set; }

        [Required]
        public string? Rating { get; set; }

        public List<Actor>? Actors { get; set; }
    }
}