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
    public ApiPoolContext() { }

    public ApiPoolContext(DbContextOptions<ApiPoolContext> options)
        : base(options)
    {
    }

    //public DbSet<Toon> Toons { get; set; }
    public DbSet<Toon> Toons => Set<Toon>();

    //public DbSet<Student> Students { get; set; }
    public DbSet<Student> Students => Set<Student>();

    //public DbSet<FoodCategory> FoodCategories { get; set; }
    public DbSet<FoodCategory> FoodCategories => Set<FoodCategory>();
    //public DbSet<Food> Foods { get; set; }
    public DbSet<Food> Foods => Set<Food>();


    //public DbSet<VehicleManufacturer> VehicleManufacturers { get; set; }
    public DbSet<VehicleManufacturer> VehicleManufacturers => Set<VehicleManufacturer>();
    //public DbSet<Vehicle> Vehicles { get; set; }
    public DbSet<Vehicle> Vehicles => Set<Vehicle>();

    //public DbSet<Instructor> Instructors { get; set; }
    public DbSet<Instructor> Instructors => Set<Instructor>();
    //public DbSet<Course> Courses { get; set; }
    public DbSet<Course> Courses => Set<Course>();

    //public DbSet<Continent> Continents { get; set; }
    public DbSet<Continent> Continents => Set<Continent>();
    //public DbSet<City> Cities { get; set; }
    public DbSet<City> Cities => Set<City>();
    //public DbSet<Country> Countries { get; set; }
    public DbSet<Country> Countries => Set<Country>();
    //public DbSet<Province> Provinces { get; set; }
    public DbSet<Province> Provinces => Set<Province>();

    //public DbSet<Actor> Actors { get; set; }
    public DbSet<Actor> Actors => Set<Actor>();
    //public DbSet<Movie> Movies { get; set; }
    public DbSet<Movie> Movies => Set<Movie>();

    //public DbSet<Organism> Organisms { get; set; }
    public DbSet<Organism> Organisms => Set<Organism>();
    //public DbSet<Specie> Species { get; set; }
    public DbSet<Specie> Species => Set<Specie>();

    //public DbSet<Competition> Competitions { get; set; }
    public DbSet<Competition> Competitions => Set<Competition>();
    //public DbSet<Athlete> Athletes { get; set; }
    public DbSet<Athlete> Athletes => Set<Athlete>();

    //public DbSet<Team> Teams { get; set; }
    public DbSet<Team> Teams => Set<Team>();
    //public DbSet<Player> Players { get; set; }
    public DbSet<Player> Players => Set<Player>();

    //public DbSet<Restaurant> Restaurants { get; set; }
    public DbSet<Restaurant> Restaurants => Set<Restaurant>();
    // public DbSet<Menu> MenuItems { get; set; }
    public DbSet<Menu> MenuItems => Set<Menu>();

    //public DbSet<Hospital> Hospitals { get; set; }
    public DbSet<Hospital> Hospitals => Set<Hospital>();
    //public DbSet<Patient> Patients { get; set; }
    public DbSet<Patient> Patients => Set<Patient>();
    //public DbSet<Sickness> Sicknesses { get; set; }
    public DbSet<Sickness> Sicknesses => Set<Sickness>();
    //public DbSet<Medicine> Medicines { get; set; }
    public DbSet<Medicine> Medicines => Set<Medicine>();


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