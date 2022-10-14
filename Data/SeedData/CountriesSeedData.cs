using System.Collections.Generic;
using ApiPool.Models.Countries;

namespace ApiPool.Data.Seed
{
    public class CountriesSeedData
    {
        public static List<Continent> GetContinents()
        {
            List<Continent> items = new List<Continent>()
            {
                new Continent() { ContinentName = "Africa" },
                new Continent() { ContinentName = "Asia" },
                new Continent() { ContinentName = "Europe" },
                new Continent() { ContinentName = "South America" },
                new Continent() { ContinentName = "Australia" },
                new Continent() { ContinentName = "North America" }
            };

            return items;
        }

        // https://data.mongabay.com/igapo/world_statistics_by_area.htm
        public static List<Country> GetCountries()
        {
            List<Country> items = new List<Country>()
            {
                new Country() { CountryName = "Canada", CapitalCity = "Ottawa", AreaSqKm =    9976140, ContinentName="North America" },
                new Country() { CountryName = "USA", CapitalCity = "Washington DC", AreaSqKm = 9629091, ContinentName="North America" },
                new Country() { CountryName = "Brazil", CapitalCity = "Brasilia", AreaSqKm = 8511965, ContinentName="South America" },
                new Country() { CountryName = "India", CapitalCity = "New Delhi", AreaSqKm = 3287590, ContinentName="Asia" },
                new Country() { CountryName = "China", CapitalCity = "Beijing", AreaSqKm = 9596960, ContinentName="Asia" }
            };

            return items;
        }

        public static List<Province> GetProvinces()
        {
            List<Province> items = new List<Province>()
            {
                new Province() { ProvinceId=1, Name = "Aalabama", CapitalCity = "Montgomery", CountryName="USA" },
                new Province() { ProvinceId=2, Name = "California", CapitalCity = "Sacramento", CountryName="USA" },
                new Province() { ProvinceId=3, Name = "Hawaii", CapitalCity = "Honolulu", CountryName="USA" },

                new Province() { ProvinceId=4, Name = "Fujian", CapitalCity = "Fuzhou", CountryName="China" },
                new Province() { ProvinceId=5, Name = "Hubei", CapitalCity = "Wuhan", CountryName="China" },

                new Province() { ProvinceId=6, Name = "Ontario", CapitalCity = "Toronto", CountryName="Canada" },
                new Province() { ProvinceId=7, Name = "Alberta", CapitalCity = "Edmopnton", CountryName="Canada" }
            };

            return items;
        }

        public static List<City> GetCities()
        {
            List<City> items = new List<City>()
            {
                new City() { CityName = "Los Angeles", ProvinceId=2 },
                new City() { CityName = "San Francisco", ProvinceId=2 },
                new City() { CityName = "San Diego", ProvinceId=2 },

                new City() { CityName = "Xiamen", ProvinceId=4 },
                new City() { CityName = "Quanzhou", ProvinceId=4 },

                new City() { CityName = "Ottawa", ProvinceId=6 },
                new City() { CityName = "Windsor", ProvinceId=6 },
                new City() { CityName = "Kingston", ProvinceId=6 },
                new City() { CityName = "Mississauga", ProvinceId=6 },
                new City() { CityName = "Hamilton", ProvinceId=6 }
            };

            return items;
        }

    }
}
