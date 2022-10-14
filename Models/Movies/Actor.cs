using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace ApiPool.Models.Movies
{
    public class Actor
    {
        public int ActorId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public int MovieId { get; set; }

        [ForeignKey("MovieId")] 
        public Movie Movie { get; set; }
    }
}