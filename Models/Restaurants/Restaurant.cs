using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApiPool.Models.Restaurants
{
    public class Restaurant
    {
        public int RestaurantId { get; set; }

        [Required]
        public string? RestaurantName { get; set; }

        [Required]
        public string? Street { get; set; }

        [Required]
        public string? City { get; set; }

        [Required]
        public string? Province { get; set; }

        [Required]
        public string? PostalCode { get; set; }

        [Required]
        public string? Country { get; set; }

        [Required]
        public string? FoodType { get; set; }

        [Required]
        public string? Phone { get; set; }

        public List<Menu>? MenuItems { get; set; }
    }
}
