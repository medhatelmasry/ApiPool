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
                     PictureUrl = "images/restaurant/white-spot.png"
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
                     PictureUrl = "images/restaurant/hons.png"
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
                     PictureUrl = "images/restaurant/boston-pizza.png"
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
                     PictureUrl = "images/restaurant/maple-leaf-indian-cuisine.png"
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
                     PictureUrl = "images/restaurant/socrates-grill.jpeg"
                 },
                new Restaurant() {
                    RestaurantId=6,
                    RestaurantName="JOEY's Bar & Grill",
                    Street="109 - 1899 Rosser Ave",
                    City="Burnaby",
                    Province="BC",
                    PostalCode="V5C 6R5",
                    Country="Canada",
                    FoodType="Western",
                    Phone="(604) 564-5639",
                     PictureUrl = "images/restaurant/joeys-bar-and-grill.png"
                },
                new Restaurant() {
                    RestaurantId=7,
                    RestaurantName="Ando's Restaurant & Grill",
                    Street="102 - 4501 Kingsway",
                    City="Burnaby",
                    Province="BC",
                    PostalCode="V5H 2A9",
                    Country="Canada",
                    FoodType="Italian",
                    Phone="(604) 424-8779",
                     PictureUrl = "images/restaurant/andos-restaurant-and-grill.png"
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
                     PictureUrl = "images/restaurant/cactus-club-cafe.png"
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
                    Phone="(604) 453-0811",
                     PictureUrl = "images/restaurant/personas-patio-restaurant-and-lounge.png"
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
                    PictureUrl = "images/restaurant/hart-house-restaurant.jpeg"
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
                    RestaurantId = 1,
                    PictureUrl = "images/menu/oven-baked-lasagna.jpeg"
                 },
                 new Menu()
                 {
                    MenuId = 2,
                    Name = "Spaghetti & Meatballs",
                    Price = 17.99,
                    RestaurantId = 1,
                    PictureUrl = "images/menu/spaghetti-and-meatballs.jpeg"
                 },
                 new Menu()
                 {
                    MenuId = 3,
                    Name = "Seafood Fettuccine",
                    Price = 19.99,
                    RestaurantId = 1,
                    PictureUrl = "images/menu/seafood-fettuccine.jpeg"
                 },
                 new Menu()
                 {
                    MenuId = 4,
                    Name = "Barbecued Duck",
                    Price = 25.50,
                    RestaurantId = 2,
                    PictureUrl = "images/menu/barbecued-duck.jpeg"
                 },
                 new Menu()
                 {
                    MenuId = 5,
                    Name = "Roasted Pork",
                    Price = 9.75,
                    RestaurantId = 2,
                    PictureUrl = "images/menu/roasted-pork.jpeg"
                 },
                 new Menu()
                 {
                    MenuId = 6,
                    Name = "The Ultimate Hamburger",
                    Price = 18.99,
                    RestaurantId = 3,
                    PictureUrl = "images/menu/hamburger.jpeg"
                 },

                 new Menu()
                 {
                    MenuId = 7,
                    Name = "Maki Sushi",
                    Price = 27.99,
                    RestaurantId = 3,
                    PictureUrl = "images/menu/maki-sushi.jpeg"
                 },
                 new Menu()
                 {
                    MenuId = 8,
                    Name = "Chicken Tikka Masala",
                    Price = 4.99,
                    RestaurantId = 4,
                    PictureUrl = "images/menu/chicken-tikka-masala.jpeg"
                 },
                 new Menu()
                 {
                    MenuId = 9,
                    Name = "Butter Chicken",
                    Price = 12.99,
                    RestaurantId = 4,
                    PictureUrl = "images/menu/butter-chicken.jpeg"
                 },
                 new Menu()
                 {
                    MenuId = 10,
                    Name = "Lamb Souvlaki",
                    Price = 19.00,
                    RestaurantId = 5,
                    PictureUrl = "images/menu/lamb-souvlaki.jpeg"
                 },
                                 new Menu() {
                    MenuId = 11,
                    Name = "Chili Chicken",
                    Price = 15.75,
                    RestaurantId = 6,
                    PictureUrl = "images/menu/chilli-chicken.jpeg"
                },
                new Menu() {
                    MenuId = 12,
                    Name = "Yam Fries",
                    Price = 12.00,
                    RestaurantId = 6,
                    PictureUrl = "images/menu/yam-fries.jpeg"
                },
                new Menu() {
                    MenuId = 13,
                    Name = "Sushi Cone",
                    Price = 6.25,
                    RestaurantId = 6,
                    PictureUrl = "images/menu/sushi-cone.jpeg"
                },
                new Menu() {
                    MenuId = 14,
                    Name = "Casar Salad",
                    Price = 13,
                    RestaurantId = 7,
                    PictureUrl = "images/menu/casar-salad.jpeg"
                },
                new Menu() {
                    MenuId = 15,
                    Name = "Linguine Carbonara",
                    Price = 22,
                    RestaurantId = 7,
                    PictureUrl = "images/menu/linguine-carbonara.jpeg"
                },

            };

            return menuitems;
        }
    }
}
