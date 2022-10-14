using System;
using System.Collections.Generic;
using ApiPool.Models.Toons;
using ApiPool.Models.Countries;

// https://www.worldathletics.org/world-rankings/overall-ranking/men
namespace ApiPool.Data.Seed
{
    public class ToonSeedData
    {
        public static List<Toon> GetToons()
        {
            List<Toon> items = new List<Toon>()
            {
                new Toon() { 
                    Id = 1, 
                    LastName = "Flintstone", 
                    FirstName ="Fred",
                    Occupation = "Mining Manager",
                    Gender = "M",
                    PictureUrl = "images/flintstone/fred.png",
                    Votes = 0
                },
                new Toon() { 
                    Id = 2, 
                    LastName = "Rubble", 
                    FirstName ="Barney",
                    Occupation = "Mining Assistant",
                    Gender = "M",
                    PictureUrl = "images/flintstone/barney.png",
                    Votes = 0
                },
                new Toon() { 
                    Id = 3, 
                    LastName = "Rubble", 
                    FirstName ="Betty",
                    Occupation = "Nurse",
                    Gender = "F",
                    PictureUrl = "images/flintstone/betty.png",
                    Votes = 0
                },

                new Toon() { 
                    Id = 4, 
                    LastName = "Flintstone", 
                    FirstName ="Wilma",
                    Occupation = "Teacher",
                    Gender = "F",
                    PictureUrl = "images/flintstone/wilma.png",
                    Votes = 0
                },

                new Toon() { 
                    Id = 5, 
                    LastName = "Rubble", 
                    FirstName ="Bambam",
                    Occupation = "Baby",
                    Gender = "M",
                    PictureUrl = "images/flintstone/bambam.png",
                    Votes = 0
                },

                new Toon() { 
                    Id =6, 
                    LastName = "Flintstone", 
                    FirstName ="Pebbles",
                    Occupation = "Baby",
                    Gender = "M",
                    PictureUrl = "images/flintstone/pebbles.png",
                    Votes = 0
                },

                new Toon() { 
                    Id = 7, 
                    LastName = "Flintstone", 
                    FirstName ="Dino",
                    Occupation = "Pet",
                    Gender = "F",
                    PictureUrl = "images/flintstone/dino.png",
                    Votes = 0
                },

                new Toon() { 
                    Id = 8, 
                    LastName = "Mouse", 
                    FirstName ="Micky",
                    Occupation = "Hunter",
                    Gender = "M",
                    PictureUrl = "images/disney/MickyMouse.png",
                    Votes = 0
                },

                new Toon() { 
                    Id = 9, 
                    LastName = "Duck", 
                    FirstName ="Donald",
                    Occupation = "Sailor",
                    Gender = "M",
                    PictureUrl = "images/disney/DonaldDuck.png",
                    Votes = 0
                },


            };

            return items;
        }

    }
}
