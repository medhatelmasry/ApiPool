using System;
using System.Collections.Generic;
using ApiPool.Models.Athletics;
using ApiPool.Models.Countries;

// https://www.worldathletics.org/world-rankings/overall-ranking/men
namespace ApiPool.Data.Seed
{
    public class AthleticsSeedData
    {
        public static List<Competition> GetCompetitions()
        {
            List<Competition> items = new List<Competition>()
            {
                new Competition() { CompetitionId = 1, EventName = "Men's 100m" },
                new Competition() { CompetitionId = 2, EventName = "Men's Pole Vault" },
                new Competition() { CompetitionId = 3, EventName = "Men's 50km Race Walking" },
                new Competition() { CompetitionId = 4, EventName = "Women's 100m" },
                new Competition() { CompetitionId = 5, EventName = "Women's 100m" },
                new Competition() { CompetitionId = 6, EventName = "Women's Marathon" },
                new Competition() { CompetitionId = 7, EventName = "Men's Marathon" }
            };

            return items;
        }

        public static List<Athlete> GetAthletes()
        {
            List<Athlete> items = new List<Athlete>()
            {
                new Athlete() { AthleteId = 1, FirstName = "Christian", LastName="Coleman",
                    DateOfBirth=new DateTime(1996,3,6), Country="USA", CompetitionId=1
                },
                new Athlete() { AthleteId = 2, FirstName = "Zharnel", LastName="Hughes",
                    DateOfBirth=new DateTime(1995,7,13), Country="GBR", CompetitionId=1
                },
                new Athlete() { AthleteId = 3, FirstName = "Brigid", LastName="Kosgei",
                    DateOfBirth=new DateTime(1994,2,20), Country="KEN", CompetitionId=6
                },
                new Athlete() { AthleteId = 4, FirstName = "Worknesh", LastName="Degefa",
                    DateOfBirth=new DateTime(1990,10,28), Country="ETH", CompetitionId=6
                },
                new Athlete() { AthleteId = 5, FirstName = "Birhanu", LastName="Legese",
                    DateOfBirth=new DateTime(1994,9,11), Country="ETH", CompetitionId=7
                },
                new Athlete() { AthleteId = 6, FirstName = "Lawrence", LastName="Cherono",
                    DateOfBirth=new DateTime(1988,8,7), Country="KEN", CompetitionId=7
                },
                new Athlete() { AthleteId = 7, FirstName = "Armand", LastName="Duplantis",
                    DateOfBirth=new DateTime(1999,11,10), Country="SWE", CompetitionId=2
                }
            };

            return items;
        }
    }
}
