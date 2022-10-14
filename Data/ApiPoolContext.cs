using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using ApiPool.Data.Seed;
using ApiPool.Models.Athletics;
using ApiPool.Models.Countries;
using ApiPool.Models.Courses;
using ApiPool.Models.Foods;
using ApiPool.Models.Health;
using ApiPool.Models.Movies;
using ApiPool.Models.Restaurants;
using ApiPool.Models.Species;
using ApiPool.Models.Sports;
using ApiPool.Models.Students;
using ApiPool.Models.Toons;
using ApiPool.Models.Vehicles;
using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.EntityFrameworkCore;

namespace ApiPool.Data;

public partial class ApiPoolContext : DbContext
    {
        public ApiPoolContext()
        {
        }

        public ApiPoolContext(DbContextOptions<ApiPoolContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Toon> Toons { get; set; }

        public virtual DbSet<Student> Students { get; set; }

        public virtual DbSet<FoodCategory> FoodCategories { get; set; }
        public virtual DbSet<Food> Foods { get; set; }

        public virtual DbSet<VehicleManufacturer> VehicleManufacturers { get; set; }
        public virtual DbSet<Vehicle> Vehicles { get; set; }

        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<Course> Courses { get; set; }

        public virtual DbSet<Continent> Continents { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Province> Provinces { get; set; }

        public virtual DbSet<Actor> Actors { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }

        public virtual DbSet<Organism> Organisms { get; set; }
        public virtual DbSet<Specie> Species { get; set; }

        public virtual DbSet<Competition> Competitions { get; set; }
        public virtual DbSet<Athlete> Athletes { get; set; }

        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<Player> Players { get; set; }

        public virtual DbSet<Restaurant> Restaurants { get; set; }
        public virtual DbSet<Menu> MenuItems { get; set; }

        public virtual DbSet<Hospital> Hospitals { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Sickness> Sicknesses { get; set; }
        public virtual DbSet<Medicine> Medicines { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region "Seed Food Category Data"
            modelBuilder.Entity<FoodCategory>().HasData(FoodSeedData.GetFoodCategories());
            #endregion

            #region "Seed Food Data"
            modelBuilder.Entity<Food>().HasData(FoodSeedData.GetFoods());
            #endregion

            #region "Seed Vehicle Manufacturer Data"
            modelBuilder.Entity<VehicleManufacturer>().HasData(VehicleSeedData.GetVehicleManufacturers());
            #endregion

            #region "Seed Vehicle Data"
            modelBuilder.Entity<Vehicle>().HasData(VehicleSeedData.GetVehicles());
            #endregion

            #region "Seed Instructor Data"
            modelBuilder.Entity<Instructor>().HasData(CoursesSeedData.GetInstructors());
            #endregion

            #region "Seed Course Data"
            modelBuilder.Entity<Course>().HasData(CoursesSeedData.GetCourses());
            #endregion

            #region "Seed Continent Data"
            modelBuilder.Entity<Continent>().HasData(CountriesSeedData.GetContinents());
            #endregion

            #region "Seed Country Data"
            modelBuilder.Entity<Country>().HasData(CountriesSeedData.GetCountries());
            #endregion

            #region "Seed Province Data"
            modelBuilder.Entity<Province>().HasData(CountriesSeedData.GetProvinces());
            #endregion

            #region "Seed City Data"
            modelBuilder.Entity<City>().HasData(CountriesSeedData.GetCities());
            #endregion

            #region "Seed Specie Data"
            modelBuilder.Entity<Specie>().HasData(SpeciesSeedData.GetSpecies());
            #endregion

            #region "Seed Organism Data"
            modelBuilder.Entity<Organism>().HasData(SpeciesSeedData.GetOrganisms());
            #endregion

            #region "Seed Movie Data"
            modelBuilder.Entity<Movie>().HasData(MoviesSeedData.GetMovies());
            #endregion

            #region "Seed Actor Data"
            modelBuilder.Entity<Actor>().HasData(MoviesSeedData.GetActors());
            #endregion

            #region "Seed Competition Data"
            modelBuilder.Entity<Competition>().HasData(AthleticsSeedData.GetCompetitions());
            #endregion

            #region "Seed Athlete Data"
            modelBuilder.Entity<Athlete>().HasData(AthleticsSeedData.GetAthletes());
            #endregion

            #region "Seed Team Data"
            modelBuilder.Entity<Team>().HasData(SportsSeedData.GetTeams());
            #endregion

            #region "Seed Player Data"
            modelBuilder.Entity<Player>().HasData(SportsSeedData.GetPlayers());
            #endregion

            #region "Seed Restaurant Data"
            modelBuilder.Entity<Restaurant>().HasData(RestaurantSeedData.GetRestaurants());
            #endregion

            #region "Seed Menu Data"
            modelBuilder.Entity<Menu>().HasData(RestaurantSeedData.GetMenuItems());
            #endregion

            #region "Seed Hospital Data"
            modelBuilder.Entity<Hospital>().HasData(HealthSeedData.GetHospitals());
            #endregion

            #region "Seed Patient Data"
            modelBuilder.Entity<Patient>().HasData(HealthSeedData.GetPatients());
            #endregion

            #region "Seed Sickness Data"
            modelBuilder.Entity<Sickness>().HasData(HealthSeedData.GetSicknesses());
            #endregion

            #region "Seed Medicine Data"
            modelBuilder.Entity<Medicine>().HasData(HealthSeedData.GetMedicines());
            #endregion

            #region "Seed Toon Data"
            modelBuilder.Entity<Toon>().HasData(ToonSeedData.GetToons());
            #endregion

            #region "Seed Students"
            modelBuilder.Entity<Student>().HasData(GetStudents());
            #endregion
        }

        private static IEnumerable<Student> GetStudents()
    {
        string[] p = { Directory.GetCurrentDirectory(), "wwwroot", "students.csv" };
        var csvFilePath = Path.Combine(p);

        var config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            PrepareHeaderForMatch = args => args.Header.ToLower(),
        };

        var data = new List<Student>().AsEnumerable();
        using (var reader = new StreamReader(csvFilePath))
        {
            using (var csvReader = new CsvReader(reader, config))
            {
                data = (csvReader.GetRecords<Student>()).ToList();
            }
        }

        return data;
    }

    }