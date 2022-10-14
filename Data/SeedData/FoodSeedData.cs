using System.Collections.Generic;
using ApiPool.Models.Foods;

namespace ApiPool.Data.Seed
{
    public class FoodSeedData
    {
        public static List<FoodCategory> GetFoodCategories()
        {
            List<FoodCategory> items = new List<FoodCategory>()
            {
                new FoodCategory() { FoodCategoryId = 1, Name = "Bakery", Description = @"Bakery products, which include bread, rolls, 
                cookies, pies, pastries, and muffins, are usually prepared from flour 
                or meal derived from some form of grain. Bread, already a common 
                staple in prehistoric times, provides many nutrients in the human diet."
                },
                new FoodCategory() { FoodCategoryId = 2, Name = "Fruit", Description = @"The sweet 
                and fleshy product of a tree or other plant that contains seed 
                and can be eaten as food." },

                new FoodCategory() { FoodCategoryId = 3, Name = "Vegetables", Description = @"A plant 
                or part of a plant used as food, typically as accompaniment to meat 
                or fish, such as a cabbage, potato, carrot, or bean." }
            };

            return items;
        }

        public static List<Food> GetFoods()
        {
            List<Food> items = new List<Food>()
            {
                new Food() { FoodId = 1, Name = "Croissant", Unit = "dozen", UnitPrice = 9.98f, FoodCategoryId = 1 },
                new Food() { FoodId = 2, Name = "Carrots", Unit = "lbs", UnitPrice = 0.98f, FoodCategoryId = 3 },
                new Food() { FoodId = 3, Name = "Apples", Unit = "lbs", UnitPrice = 0.65f, FoodCategoryId = 2 }
            };

            return items;
        }

    }
}
