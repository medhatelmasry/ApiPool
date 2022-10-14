using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApiPool.Models.Health
{
    public class Hospital
    {
        public int HospitalId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Street { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Province { get; set; }

        [Required]
        public string PostalCode { get; set; }

        [Required]
        public string Country { get; set; }

        public string Email { get; set; }
        public string Phone { get; set; }

        public List<Patient> Patients { get; set; }
    }
}