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
                     Phone="(604) 705-0704",
                     LogoUrl = "images/restaurant/white-spot.png",
                     Latitude = 49.234570,
                     Longitude = -122.862640,
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
                     Phone="(778) 298-0591",
                     LogoUrl = "images/restaurant/hons.png",
                     Latitude = 49.274660,
                     Longitude = -122.792560,
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
                     Phone="(604) 394-9339",
                     LogoUrl = "images/restaurant/boston-pizza.png",
                     Latitude = 49.256670,
                     Longitude = -122.748250,
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
                     Phone="(604) 764-5639",
                     LogoUrl = "images/restaurant/maple-leaf-indian-cuisine.png",
                     Latitude = 49.219900,
                     Longitude = -122.647790,
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
                     Phone="(604) 554-6639",
                     LogoUrl = "images/restaurant/socrates-grill.png",
                     Latitude = 49.21838,
                     Longitude = -122.64904,
                 },
                new Restaurant() {
                    RestaurantId=6,
                    RestaurantName="JOEY's Bar & Grill",
                    Street="109 - 1899 Rosser Ave",
                    City="Burnaby",
                    Province="BC",
                    PostalCode="V5C 6R5",
                    Country="Canada",
                    FoodType="Western Food",
                    Phone="(604) 564-5639",
                     LogoUrl = "images/restaurant/joeys-bar-and-grill.png",
                     Latitude = 49.283563,
                     Longitude = -123.005812,
                },
                new Restaurant() {
                    RestaurantId=7,
                    RestaurantName="Ando's Restaurant & Grill",
                    Street="102 - 4501 Kingsway",
                    City="Burnaby",
                    Province="BC",
                    PostalCode="V5H 2A9",
                    Country="Canada",
                    FoodType="Italian Food",
                    Phone="(604) 424-8779",
                     LogoUrl = "images/restaurant/andos-restaurant-and-grill.png",
                     Latitude = 49.230290,
                     Longitude = -123.004710,
                },
                new Restaurant() {
                    RestaurantId=8,
                    RestaurantName="Cactus Club Cafe",
                    Street="4219 B Lougheed Hwy",
                    City="Burnaby",
                    Province="BC",
                    PostalCode="V6C 0A8",
                    Country="Canada",
                    FoodType="Western Food",
                    Phone="(604) 291-6606",
                     LogoUrl = "images/restaurant/cactus-club-cafe.png",
                     Latitude = 49.238914,
                     Longitude = -122.958267,
                },
                new Restaurant() {
                    RestaurantId=9,
                    RestaurantName="Personas Patio Restaurant And Lounge",
                    Street="4331 Dominion St",
                    City="Burnaby",
                    Province="BC",
                    PostalCode="V5G 1C7",
                    Country="Canada",
                    FoodType="Pub Food",
                    Phone="(604) 453-0811",
                     LogoUrl = "images/restaurant/personas-patio-restaurant-and-lounge.png",
                     Latitude = 49.25633,
                     Longitude = -123.00727,
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
                    Phone="(604) 298-4278",
                    LogoUrl = "images/restaurant/hart-house-restaurant.png",
                     Latitude = 49.23856,
                     Longitude = -122.96683,
                },
                new Restaurant() {
                    RestaurantId=11,
                    RestaurantName="Earls Kitchen + Bar",
                    Street="5100 - 2850 Shaughnessy",
                    City="Port Coquitlam",
                    Province="BC",
                    PostalCode="V5E 4V3",
                    Country="Canada",
                    FoodType="Western Food",
                    Phone="(604) 941-1733",
                    LogoUrl = "images/restaurant/earls-kitchen-bar.png",
                     Latitude = 49.26557,
                     Longitude = -122.7784,
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
                    Id = 1,
                    Name = "Oven Baked Lasagna",
                    Price = 17.99,
                    RestaurantId = 1,
                    PictureUrl = "images/menu/oven-baked-lasagna.jpeg"
                 },
                 new Menu()
                 {
                    Id = 2,
                    Name = "Spaghetti & Meatballs",
                    Price = 17.99,
                    RestaurantId = 1,
                    PictureUrl = "images/menu/spaghetti-and-meatballs.jpeg"
                 },
                 new Menu()
                 {
                    Id = 3,
                    Name = "Seafood Fettuccine",
                    Price = 19.99,
                    RestaurantId = 1,
                    PictureUrl = "images/menu/seafood-fettuccine.jpeg"
                 },
                 new Menu()
                 {
                    Id = 4,
                    Name = "Barbecued Duck",
                    Price = 25.50,
                    RestaurantId = 2,
                    PictureUrl = "images/menu/barbecued-duck.jpeg"
                 },
                 new Menu()
                 {
                    Id = 5,
                    Name = "Roasted Pork",
                    Price = 9.75,
                    RestaurantId = 2,
                    PictureUrl = "images/menu/roasted-pork.jpeg"
                 },
                 new Menu()
                 {
                    Id = 6,
                    Name = "The Ultimate Hamburger",
                    Price = 18.99,
                    RestaurantId = 3,
                    PictureUrl = "images/menu/hamburger.jpeg"
                 },

                 new Menu()
                 {
                    Id = 7,
                    Name = "Maki Sushi",
                    Price = 27.99,
                    RestaurantId = 3,
                    PictureUrl = "images/menu/maki-sushi.jpeg"
                 },
                 new Menu()
                 {
                    Id = 8,
                    Name = "Chicken Tikka Masala",
                    Price = 4.99,
                    RestaurantId = 4,
                    PictureUrl = "images/menu/chicken-tikka-masala.jpeg"
                 },
                 new Menu()
                 {
                    Id = 9,
                    Name = "Butter Chicken",
                    Price = 12.99,
                    RestaurantId = 4,
                    PictureUrl = "images/menu/butter-chicken.jpeg"
                 },
                 new Menu()
                 {
                    Id = 10,
                    Name = "Lamb Souvlaki",
                    Price = 19.00,
                    RestaurantId = 5,
                    PictureUrl = "images/menu/lamb-souvlaki.jpeg"
                 },
                                 new Menu() {
                    Id = 11,
                    Name = "Chili Chicken",
                    Price = 15.75,
                    RestaurantId = 6,
                    PictureUrl = "images/menu/chilli-chicken.jpeg"
                },
                new Menu() {
                    Id = 12,
                    Name = "Yam Fries",
                    Price = 12.00,
                    RestaurantId = 6,
                    PictureUrl = "images/menu/yam-fries.jpeg"
                },
                new Menu() {
                    Id = 13,
                    Name = "Sushi Cone",
                    Price = 6.25,
                    RestaurantId = 6,
                    PictureUrl = "images/menu/sushi-cone.jpeg"
                },
                new Menu() {
                    Id = 14,
                    Name = "Casar Salad",
                    Price = 13,
                    RestaurantId = 7,
                    PictureUrl = "images/menu/casar-salad.jpeg"
                },
                new Menu() {
                    Id = 15,
                    Name = "Linguine Carbonara",
                    Price = 22,
                    RestaurantId = 7,
                    PictureUrl = "images/menu/linguine-carbonara.jpeg"
                },
                new Menu() {
                    Id = 16,
                    Name = "Eggs Benedict",
                    Price = 19,
                    RestaurantId = 10,
                    PictureUrl = "images/menu/eggs-benedict.jpeg"
                },
                new Menu() {
                    Id = 17,
                    Name = "Braised Lamb Shank",
                    Price = 42,
                    RestaurantId = 10,
                    PictureUrl = "images/menu/braised-lamb-shank.jpg"
                },                new Menu() {
                    Id = 18,
                    Name = "Cioppino",
                    Price = 32,
                    RestaurantId = 10,
                    PictureUrl = "images/menu/cioppino.jpeg"
                },                new Menu() {
                    Id = 19,
                    Name = "Seafood Platter",
                    Price = 74,
                    RestaurantId = 11,
                    PictureUrl = "images/menu/seafood-platter.jpeg"
                },                new Menu() {
                    Id = 20,
                    Name = "Santa Fe Chicken Salad",
                    Price = 24.75,
                    RestaurantId = 11,
                    PictureUrl = "images/menu/santa-fe-salad.jpeg"
                },                new Menu() {
                    Id = 21,
                    Name = "Street Corn + Avocado Dip",
                    Price = 13.50,
                    RestaurantId = 11,
                    PictureUrl = "images/menu/streetcorn-avocado-dip.jpeg"
                },                new Menu() {
                    Id = 22,
                    Name = "Korean Fried Chicken",
                    Price = 14,
                    RestaurantId = 9,
                    PictureUrl = "images/menu/korean-fried-chicken.jpg"
                },                new Menu() {
                    Id = 23,
                    Name = "Sticky Ribs",
                    Price = 15,
                    RestaurantId = 9,
                    PictureUrl = "images/menu/sticky-ribs.jpeg"
                },                new Menu() {
                    Id = 24,
                    Name = "Hawaiian CChicken",
                    Price = 17.50,
                    RestaurantId = 9,
                    PictureUrl = "images/menu/hawaiian-chicken.jpg"
                },
            };

            return menuitems;
        }
    }
}
