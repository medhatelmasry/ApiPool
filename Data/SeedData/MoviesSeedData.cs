using System.Collections.Generic;
using ApiPool.Models.Movies;

namespace ApiPool.Data.Seed
{
    public class MoviesSeedData
    {
        public static List<Movie> GetMovies()
        {
            List<Movie> items = new List<Movie>()
            {
                new Movie() { MovieId = 1, Name = "Gandhi", DirectorFirstName="Richard", DirectorLastName="Attenborough", Year=1982, Rating="PG" },
                new Movie() { MovieId = 2, Name = "The Sound of Music", DirectorFirstName="Robert", DirectorLastName="Wise",Year=196, Rating="G" },
                new Movie() { MovieId = 3, Name = "My Fair Lady", DirectorFirstName="George", DirectorLastName="Cukor",Year=1964, Rating="PG" },
                new Movie() { MovieId = 4, Name = "The King and I", DirectorFirstName="Walter", DirectorLastName="Lang",Year=1956, Rating="G" },
                new Movie() { MovieId = 5, Name = "Chariots of Fire", DirectorFirstName="Hugh", DirectorLastName="Hudson",Year=1981, Rating="PG" },
                new Movie() { MovieId = 6, Name = "Spartacus", DirectorFirstName="Stanley", DirectorLastName="Kubrick",Year=1960, Rating="PG" }
            };

            return items;
        }

        public static List<Actor> GetActors()
        {
            List<Actor> items = new List<Actor>()
            {
                new Actor() { ActorId = 1, FirstName = "Ben", LastName="Kingsley", MovieId=1 },
                new Actor() { ActorId = 2, FirstName = "John", LastName="Gielgud", MovieId=1 },
                new Actor() { ActorId = 3, FirstName = "Rohini", LastName="Hattangadi", MovieId=1 },
                new Actor() { ActorId = 4, FirstName = "Julie", LastName="Andrews", MovieId=2 },
                new Actor() { ActorId = 5, FirstName = "Christopher", LastName="Plummer", MovieId=2 },
                new Actor() { ActorId = 6, FirstName = "Audrey", LastName="Hepburn", MovieId=3 },
                new Actor() { ActorId = 7, FirstName = "Rex", LastName="Harrison", MovieId=3 }
            };

            return items;
        }
    }
}
