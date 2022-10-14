using System.Collections.Generic;
using ApiPool.Models.Sports;

namespace ApiPool.Data.Seed
{
    public class SportsSeedData
    {
        public static List<Team> GetTeams()
        {
            List<Team> items = new List<Team>()
            {
                new Team() {
                    TeamName="Canucks",
                    City="Vancouver",
                    Province="BC",
                    Country="Canada"
                },
                new Team() {
                    TeamName="Sharks",
                    City="San Jose",
                    Province="CA",
                    Country="USA"
                },
                new Team() {
                    TeamName="Oilers",
                    City="Edmonton",
                    Province="AB",
                    Country="Canada"
                },
                new Team() {
                    TeamName="Flames",
                    City="Calgary",
                    Province="AB",
                    Country="Canada"
                },
                new Team() {
                    TeamName="Ducks",
                    City="Anaheim",
                    Province="CA",
                    Country="USA"
                },
                new Team() {
                    TeamName="Lightening",
                    City="Tampa Bay",
                    Province="FL",
                    Country="USA"
                },
                new Team() {
                    TeamName="Blackhawks",
                    City="Chicago",
                    Province="IL",
                    Country="USA"
                }
            };

            return items;
        }

        public static List<Player> GetPlayers()
        {
            List<Player> items = new List<Player>()
            {
                new Player() {
                    PlayerId = 1,
                    FirstName = "Bob",
                    LastName = "Fox",
                    TeamName = "Canucks",
                    Position = "Forward"
                },
                new Player() {
                    PlayerId = 2,
                    FirstName = "Sam",
                    LastName = "Dix",
                    TeamName = "Canucks",
                    Position = "Left Wing"
                },
                new Player() {
                    PlayerId = 3,
                    FirstName = "John",
                    LastName = "Rooster",
                    TeamName = "Flames",
                    Position = "Right Wing"
                },
                new Player() {
                    PlayerId = 4,
                    FirstName = "Pat",
                    LastName = "Plumber",
                    TeamName = "Oilers",
                    Position = "Defense"
                }
            };

            return items;
        }
    }
}
