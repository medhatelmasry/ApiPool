using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace ApiPool.Models.Restaurants
{
    [DataContract]
    public class Restaurant
    {
        [DataMember]
        public int RestaurantId { get; set; }

        [Required]
        [DataMember]
        public string? RestaurantName { get; set; }

        [Required]
        [DataMember]
        public string? Street { get; set; }

        [Required]
        public string? City { get; set; }

        [Required]
        public string? Province { get; set; }

        [Required]
        [DataMember]
        public string? PostalCode { get; set; }

        [Required]
        [DataMember]
        public string? Country { get; set; }

        [Required]
        [DataMember]
        public string? FoodType { get; set; }

        [Required]
        [DataMember]
        public string? Phone { get; set; }

        [Required]
        [DataMember]
        public string? LogoUrl { get; set; }

        [DataMember]
        public double Latitude { get; set; }

        [DataMember]
        public double Longitude { get; set; }

        public List<Menu>? MenuItems { get; set; }
    }
}
