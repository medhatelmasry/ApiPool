using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiPool.Models.Health
{
    public class Patient
    {
        public int PatientId { get; set; }

        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }

        [Required]
        public char Gender { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string? Street { get; set; }

        [Required]
        public string? City { get; set; }

        [Required]
        public string? Province { get; set; }

        public string? PostalCode { get; set; }

        [Required]
        public string? Country { get; set; }

        public string? Email { get; set; }
        public string? Phone { get; set; }

        [Required]
        public string? RoomNumber { get; set; }

        [Required]
        public DateTime InDate { get; set; }

        public DateTime OutDate { get; set; }

        [Required]
        public int HospitalId { get; set; }

        [ForeignKey("HospitalId")]
        public Hospital? Hospital { get; set; }

        public List<Sickness>? Sicknesses { get; set; }
    }
}
