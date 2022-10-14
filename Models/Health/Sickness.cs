using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiPool.Models.Health
{
    public class Sickness
    {
        public int SicknessId { get; set; }

        [Required]
        public string? SicknessName { get; set; }

        [Required]
        public int PatientId { get; set; }

        [ForeignKey("PatientId")]
        public Patient? Patient { get; set; }

        public List<Medicine>? Medicines { get; set; }
    }
}
