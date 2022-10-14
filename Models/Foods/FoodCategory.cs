using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiPool.Models.Foods
{
    public class FoodCategory
    {
        [Key]
        public int FoodCategoryId { get; set; }
        
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public List<Food> Foods { get; set; }
    }
}