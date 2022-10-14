using System.Collections.Generic;
using ApiPool.Models.Restaurants;

namespace ApiPool.Data.Seed
{
    public class RestaurantSeedData
    {
        public static List<Restaurant> GetRestaurants()
        {
            List<Restaurant> restaurants = new List<Restaurant>()
            {
                 new Restaurant()
                 {
                     RestaurantId = 1,
                     RestaurantName = "White Spot",
                     Street = "1096 Lougheed Highway",
                     City = "Coquitlam",
                     Province = "British Columbia",
                     PostalCode = "V5G 1U8",
                     Country = "Canada",
                     FoodType = "Western Food",
                     Phone="(604) 705-0704"
                 },
                 new Restaurant()
                 {
                     RestaurantId = 2,
                     RestaurantName = "Hons",
                     Street = "310-3025 Lougheed Highway",
                     City = "Coquitlam",
                     Province = "British Columbia",
                     PostalCode = "V6A 1C5",
                     Country = "Canada",
                     FoodType = "Chinese Food",
                     Phone="(778) 298-0591"
                 },
                 new Restaurant()
                 {
                     RestaurantId = 3,
                     RestaurantName = "Boston Pizza",
                     Street = "300 - 2325 Ottawa Street",
                     City = "Port Coquitlam",
                     Province = "British Columbia",
                     PostalCode = "V3B 8A4",
                     Country = "Canada",
                     FoodType = "Western Food",
                     Phone="(604) 394-9339"
                 },
                 new Restaurant()
                 {
                     RestaurantId = 4,
                     RestaurantName = "Maple Leaf Indian Cuisine",
                     Street = "11956 207 Street",
                     City = "Maple Ridge",
                     Province = "British Columbia",
                     PostalCode = "V2X 1X6",
                     Country = "Canada",
                     FoodType = "Indian Food",
                     Phone="(604) 764-5639"
                 },
                 new Restaurant()
                 {
                     RestaurantId = 5,
                     RestaurantName = "Socrates Grill",
                     Street = "20691 Lougheed Hwy #19",
                     City = "Maple Ridge",
                     Province = "British Columbia",
                     PostalCode = "V2X 2P9",
                     Country = "Canada",
                     FoodType = "Greek Food",
                     Phone="(604) 554-6639"
                 },
                                 new Restaurant() {
                    RestaurantId=6,
                    RestaurantName="JOEY Burnaby",
                    Street="109 - 1899 Rosser Ave",
                    City="Burnaby",
                    Province="BC",
                    PostalCode="V5C 6R5",
                    Country="Canada",
                    FoodType="Western",
                    Phone="(604) 564-5639"
                },
                new Restaurant() {
                    RestaurantId=7,
                    RestaurantName="Trattoria",
                    Street="102 - 4501 Kingsway",
                    City="Burnaby",
                    Province="BC",
                    PostalCode="V5H 2A9",
                    Country="Canada",
                    FoodType="Italian",
                    Phone="(604) 424-8779"
                },
                new Restaurant() {
                    RestaurantId=8,
                    RestaurantName="Cactus Club Cafe",
                    Street="4219 B Lougheed Hwy",
                    City="Burnaby",
                    Province="BC",
                    PostalCode="V6C 0A8",
                    Country="Canada",
                    FoodType="Western",
                    Phone="(604) 291-6606",
                },
                new Restaurant() {
                    RestaurantId=9,
                    RestaurantName="Personas Patio Restaurant And Lounge",
                    Street="4331 Dominion St",
                    City="Burnaby",
                    Province="BC",
                    PostalCode="V5G 1C7",
                    Country="Canada",
                    FoodType="Pub",
                    Phone="(604) 453-0811"
                },
                new Restaurant() {
                    RestaurantId=10,
                    RestaurantName="Hart House Restaurant",
                    Street="6664 Deer Lake Ave",
                    City="Burnaby",
                    Province="BC",
                    PostalCode="V5E 4H3",
                    Country="Canada",
                    FoodType="NW plates",
                    Phone="(604) 298-4278"
                },                                                            

            };

            return restaurants;
        }

        public static List<Menu> GetMenuItems()
        {
            List<Menu> menuitems = new List<Menu>()
            {
                 new Menu()
                 {
                    MenuId = 1,
                    Name = "Oven Baked Lasagna",
                    Price = 17.99,
                    RestaurantId = 1
                 },
                 new Menu()
                 {
                    MenuId = 2,
                    Name = "Spaghetti & Meatballs",
                    Price = 17.99,
                    RestaurantId = 1
                 },
                 new Menu()
                 {
                    MenuId = 3,
                    Name = "Seafood Fettuccine",
                    Price = 19.99,
                    RestaurantId = 1
                 },
                 new Menu()
                 {
                    MenuId = 4,
                    Name = "Barbecued Duck",
                    Price = 25.50,
                    RestaurantId = 2
                 },
                 new Menu()
                 {
                    MenuId = 5,
                    Name = "Roasted Pork",
                    Price = 9.75,
                    RestaurantId = 2
                 },
                 new Menu()
                 {
                    MenuId = 6,
                    Name = "Royal Hawaiian",
                    Price = 18.99,
                    RestaurantId = 3
                 },

                 new Menu()
                 {
                    MenuId = 7,
                    Name = "Royal Hawaiian",
                    Price = 27.99,
                    RestaurantId = 3
                 },
                 new Menu()
                 {
                    MenuId = 8,
                    Name = "Chicken Tikka",
                    Price = 4.99,
                    RestaurantId = 4
                 },
                 new Menu()
                 {
                    MenuId = 9,
                    Name = "Butter Chicken",
                    Price = 12.99,
                    RestaurantId = 4
                 },
                 new Menu()
                 {
                    MenuId = 10,
                    Name = "Lamb Souvlaki",
                    Price = 19.00,
                    RestaurantId = 5
                 },
                                 new Menu() {
                    MenuId = 11,
                    Name = "Chili Chicken",
                    Price = 15.75,
                    RestaurantId = 6
                },
                new Menu() {
                    MenuId = 12,
                    Name = "Yam Fries",
                    Price = 12.00,
                    RestaurantId = 6
                },    
                new Menu() {
                    MenuId = 13,
                    Name = "Sushi Cone",
                    Price = 6.25,
                    RestaurantId = 6
                },
                new Menu() {
                    MenuId = 14,
                    Name = "Casar Salad",
                    Price = 13,
                    RestaurantId = 7
                },  
                new Menu() {
                    MenuId = 15,
                    Name = "Linguine Carbonara",
                    Price = 22,
                    RestaurantId = 7
                },                

            };

            return menuitems;
        }
    }
}
