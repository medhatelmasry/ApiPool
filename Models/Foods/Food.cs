using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiPool.Models.Foods
{
    public class Food
    {
        [Key]
        public int FoodId { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Unit { get; set; }
        
        [Required]
        public float UnitPrice { get; set; }

        public int FoodCategoryId { get; set; }

        [ForeignKey("FoodCategoryId")]
        public FoodCategory? FoodCategory { get; set; }

    }
}