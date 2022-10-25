﻿using System;
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

        [Required]
        public string? LogoUrl { get; set; }

        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public List<Menu>? MenuItems { get; set; }
    }
}
