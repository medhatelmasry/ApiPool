using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiPool.Models.Health
{
    public class Medicine
    {
        public int MedicineId { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? DosageUnit { get; set; }

        [Required]
        public int Dosage { get; set; }

        [Required]
        public int FrequencyInHours { get; set; }

        [Required]
        public int SicknessId { get; set; }

        [ForeignKey("SicknessId")]
        public Sickness? Sickness { get; set; }
    }
}
