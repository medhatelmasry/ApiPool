using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiPool.Models.Athletics
{
    public class Athlete
    {
        public int AthleteId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string Country { get; set; }

        public int CompetitionId { get; set; }

        [ForeignKey("CompetitionId")] 
        public Competition Competition { get; set; }
    }
}