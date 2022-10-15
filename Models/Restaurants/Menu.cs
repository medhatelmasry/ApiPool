using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiPool.Models.Restaurants
{
    public class Menu
    {
        public int MenuId { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public string? PictureUrl { get; set; }




        public int RestaurantId { get; set; }

        [ForeignKey("RestaurantId")]
        public Restaurant? Restaurant { get; set; }
    }
}
