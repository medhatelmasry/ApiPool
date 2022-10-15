using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiPool.Data.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Competitions",
                columns: table => new
                {
                    CompetitionId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EventName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competitions", x => x.CompetitionId);
                });

            migrationBuilder.CreateTable(
                name: "Continents",
                columns: table => new
                {
                    ContinentName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Continents", x => x.ContinentName);
                });

            migrationBuilder.CreateTable(
                name: "FoodCategories",
                columns: table => new
                {
                    FoodCategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodCategories", x => x.FoodCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Hospitals",
                columns: table => new
                {
                    HospitalId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Street = table.Column<string>(type: "TEXT", nullable: false),
                    City = table.Column<string>(type: "TEXT", nullable: false),
                    Province = table.Column<string>(type: "TEXT", nullable: false),
                    PostalCode = table.Column<string>(type: "TEXT", nullable: false),
                    Country = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Phone = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospitals", x => x.HospitalId);
                });

            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    InstructorId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.InstructorId);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    DirectorFirstName = table.Column<string>(type: "TEXT", nullable: false),
                    DirectorLastName = table.Column<string>(type: "TEXT", nullable: false),
                    Year = table.Column<int>(type: "INTEGER", nullable: false),
                    Rating = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieId);
                });

            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    RestaurantId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RestaurantName = table.Column<string>(type: "TEXT", nullable: false),
                    Street = table.Column<string>(type: "TEXT", nullable: false),
                    City = table.Column<string>(type: "TEXT", nullable: false),
                    Province = table.Column<string>(type: "TEXT", nullable: false),
                    PostalCode = table.Column<string>(type: "TEXT", nullable: false),
                    Country = table.Column<string>(type: "TEXT", nullable: false),
                    FoodType = table.Column<string>(type: "TEXT", nullable: false),
                    Phone = table.Column<string>(type: "TEXT", nullable: false),
                    PictureUrl = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.RestaurantId);
                });

            migrationBuilder.CreateTable(
                name: "Species",
                columns: table => new
                {
                    SpecieName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Species", x => x.SpecieName);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    School = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    TeamName = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    City = table.Column<string>(type: "TEXT", nullable: true),
                    Province = table.Column<string>(type: "TEXT", nullable: true),
                    Country = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.TeamName);
                });

            migrationBuilder.CreateTable(
                name: "Toons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    Occupation = table.Column<string>(type: "TEXT", nullable: false),
                    Gender = table.Column<string>(type: "TEXT", nullable: false),
                    PictureUrl = table.Column<string>(type: "TEXT", nullable: false),
                    Votes = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Toons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehicleManufacturers",
                columns: table => new
                {
                    VehicleManufacturerName = table.Column<string>(type: "TEXT", nullable: false),
                    Country = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleManufacturers", x => x.VehicleManufacturerName);
                });

            migrationBuilder.CreateTable(
                name: "Athletes",
                columns: table => new
                {
                    AthleteId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Country = table.Column<string>(type: "TEXT", nullable: false),
                    CompetitionId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Athletes", x => x.AthleteId);
                    table.ForeignKey(
                        name: "FK_Athletes_Competitions_CompetitionId",
                        column: x => x.CompetitionId,
                        principalTable: "Competitions",
                        principalColumn: "CompetitionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryName = table.Column<string>(type: "TEXT", nullable: false),
                    CapitalCity = table.Column<string>(type: "TEXT", nullable: false),
                    AreaSqKm = table.Column<int>(type: "INTEGER", nullable: false),
                    ContinentName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryName);
                    table.ForeignKey(
                        name: "FK_Countries_Continents_ContinentName",
                        column: x => x.ContinentName,
                        principalTable: "Continents",
                        principalColumn: "ContinentName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    FoodId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Unit = table.Column<string>(type: "TEXT", nullable: false),
                    UnitPrice = table.Column<float>(type: "REAL", nullable: false),
                    FoodCategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.FoodId);
                    table.ForeignKey(
                        name: "FK_Foods_FoodCategories_FoodCategoryId",
                        column: x => x.FoodCategoryId,
                        principalTable: "FoodCategories",
                        principalColumn: "FoodCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    PatientId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Gender = table.Column<char>(type: "TEXT", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Street = table.Column<string>(type: "TEXT", nullable: false),
                    City = table.Column<string>(type: "TEXT", nullable: false),
                    Province = table.Column<string>(type: "TEXT", nullable: false),
                    PostalCode = table.Column<string>(type: "TEXT", nullable: true),
                    Country = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Phone = table.Column<string>(type: "TEXT", nullable: true),
                    RoomNumber = table.Column<string>(type: "TEXT", nullable: false),
                    InDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    OutDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    HospitalId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.PatientId);
                    table.ForeignKey(
                        name: "FK_Patients_Hospitals_HospitalId",
                        column: x => x.HospitalId,
                        principalTable: "Hospitals",
                        principalColumn: "HospitalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseId = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    InstructorId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                    table.ForeignKey(
                        name: "FK_Courses_Instructors_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Instructors",
                        principalColumn: "InstructorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    ActorId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    MovieId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.ActorId);
                    table.ForeignKey(
                        name: "FK_Actors_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MenuItems",
                columns: table => new
                {
                    MenuId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    PictureUrl = table.Column<string>(type: "TEXT", nullable: false),
                    RestaurantId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItems", x => x.MenuId);
                    table.ForeignKey(
                        name: "FK_MenuItems_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "RestaurantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Organisms",
                columns: table => new
                {
                    OrganismId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    SpecieName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organisms", x => x.OrganismId);
                    table.ForeignKey(
                        name: "FK_Organisms_Species_SpecieName",
                        column: x => x.SpecieName,
                        principalTable: "Species",
                        principalColumn: "SpecieName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    PlayerId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Position = table.Column<string>(type: "TEXT", nullable: false),
                    TeamName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.PlayerId);
                    table.ForeignKey(
                        name: "FK_Players_Teams_TeamName",
                        column: x => x.TeamName,
                        principalTable: "Teams",
                        principalColumn: "TeamName");
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Model = table.Column<string>(type: "TEXT", nullable: false),
                    Fuel = table.Column<string>(type: "TEXT", nullable: false),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    VehicleManufacturerName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Model);
                    table.ForeignKey(
                        name: "FK_Vehicles_VehicleManufacturers_VehicleManufacturerName",
                        column: x => x.VehicleManufacturerName,
                        principalTable: "VehicleManufacturers",
                        principalColumn: "VehicleManufacturerName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Provinces",
                columns: table => new
                {
                    ProvinceId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    CapitalCity = table.Column<string>(type: "TEXT", nullable: false),
                    CountryName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinces", x => x.ProvinceId);
                    table.ForeignKey(
                        name: "FK_Provinces_Countries_CountryName",
                        column: x => x.CountryName,
                        principalTable: "Countries",
                        principalColumn: "CountryName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sicknesses",
                columns: table => new
                {
                    SicknessId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SicknessName = table.Column<string>(type: "TEXT", nullable: false),
                    PatientId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sicknesses", x => x.SicknessId);
                    table.ForeignKey(
                        name: "FK_Sicknesses_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "PatientId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityName = table.Column<string>(type: "TEXT", nullable: false),
                    ProvinceId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityName);
                    table.ForeignKey(
                        name: "FK_Cities_Provinces_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Provinces",
                        principalColumn: "ProvinceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Medicines",
                columns: table => new
                {
                    MedicineId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    DosageUnit = table.Column<string>(type: "TEXT", nullable: false),
                    Dosage = table.Column<int>(type: "INTEGER", nullable: false),
                    FrequencyInHours = table.Column<int>(type: "INTEGER", nullable: false),
                    SicknessId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicines", x => x.MedicineId);
                    table.ForeignKey(
                        name: "FK_Medicines_Sicknesses_SicknessId",
                        column: x => x.SicknessId,
                        principalTable: "Sicknesses",
                        principalColumn: "SicknessId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Competitions",
                columns: new[] { "CompetitionId", "EventName" },
                values: new object[] { 1, "Men's 100m" });

            migrationBuilder.InsertData(
                table: "Competitions",
                columns: new[] { "CompetitionId", "EventName" },
                values: new object[] { 2, "Men's Pole Vault" });

            migrationBuilder.InsertData(
                table: "Competitions",
                columns: new[] { "CompetitionId", "EventName" },
                values: new object[] { 3, "Men's 50km Race Walking" });

            migrationBuilder.InsertData(
                table: "Competitions",
                columns: new[] { "CompetitionId", "EventName" },
                values: new object[] { 4, "Women's 100m" });

            migrationBuilder.InsertData(
                table: "Competitions",
                columns: new[] { "CompetitionId", "EventName" },
                values: new object[] { 5, "Women's 100m" });

            migrationBuilder.InsertData(
                table: "Competitions",
                columns: new[] { "CompetitionId", "EventName" },
                values: new object[] { 6, "Women's Marathon" });

            migrationBuilder.InsertData(
                table: "Competitions",
                columns: new[] { "CompetitionId", "EventName" },
                values: new object[] { 7, "Men's Marathon" });

            migrationBuilder.InsertData(
                table: "Continents",
                column: "ContinentName",
                value: "Africa");

            migrationBuilder.InsertData(
                table: "Continents",
                column: "ContinentName",
                value: "Asia");

            migrationBuilder.InsertData(
                table: "Continents",
                column: "ContinentName",
                value: "Australia");

            migrationBuilder.InsertData(
                table: "Continents",
                column: "ContinentName",
                value: "Europe");

            migrationBuilder.InsertData(
                table: "Continents",
                column: "ContinentName",
                value: "North America");

            migrationBuilder.InsertData(
                table: "Continents",
                column: "ContinentName",
                value: "South America");

            migrationBuilder.InsertData(
                table: "FoodCategories",
                columns: new[] { "FoodCategoryId", "Description", "Name" },
                values: new object[] { 1, "Bakery products, which include bread, rolls, \n                cookies, pies, pastries, and muffins, are usually prepared from flour \n                or meal derived from some form of grain. Bread, already a common \n                staple in prehistoric times, provides many nutrients in the human diet.", "Bakery" });

            migrationBuilder.InsertData(
                table: "FoodCategories",
                columns: new[] { "FoodCategoryId", "Description", "Name" },
                values: new object[] { 2, "The sweet \n                and fleshy product of a tree or other plant that contains seed \n                and can be eaten as food.", "Fruit" });

            migrationBuilder.InsertData(
                table: "FoodCategories",
                columns: new[] { "FoodCategoryId", "Description", "Name" },
                values: new object[] { 3, "A plant \n                or part of a plant used as food, typically as accompaniment to meat \n                or fish, such as a cabbage, potato, carrot, or bean.", "Vegetables" });

            migrationBuilder.InsertData(
                table: "Hospitals",
                columns: new[] { "HospitalId", "City", "Country", "Email", "Name", "Phone", "PostalCode", "Province", "Street" },
                values: new object[] { 1, "Vancouver", "Canada", null, "St. Paul's Hospital", "604-682-2344", "V6Z 1Y6", "British Columbia", "1081 Burrard Street" });

            migrationBuilder.InsertData(
                table: "Hospitals",
                columns: new[] { "HospitalId", "City", "Country", "Email", "Name", "Phone", "PostalCode", "Province", "Street" },
                values: new object[] { 2, "Port Moody", "Canada", null, "Eagle Ridge Hospital", "604-461-2022", "V3H 3W9", "British Columbia", "475 Guildford Way" });

            migrationBuilder.InsertData(
                table: "Hospitals",
                columns: new[] { "HospitalId", "City", "Country", "Email", "Name", "Phone", "PostalCode", "Province", "Street" },
                values: new object[] { 3, "Vancouver", "Canada", null, "Vancouver General Hospital (VGH)", "604-875-4111", "V5Z 1M9", "British Columbia", "899 West 12th Avenue" });

            migrationBuilder.InsertData(
                table: "Hospitals",
                columns: new[] { "HospitalId", "City", "Country", "Email", "Name", "Phone", "PostalCode", "Province", "Street" },
                values: new object[] { 4, "Surrey", "Canada", null, "Surrey Memorial Hospital", "604-581-2211", "V3V 1Z2", "British Columbia", "13750 96th Avenue" });

            migrationBuilder.InsertData(
                table: "Hospitals",
                columns: new[] { "HospitalId", "City", "Country", "Email", "Name", "Phone", "PostalCode", "Province", "Street" },
                values: new object[] { 5, "New Westminster", "Canada", null, "Royal Columbian Hospital", "604-520-4253", "V3L 3W7", "British Columbia", "330 East Columbia Street" });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "InstructorId", "Email", "FirstName", "LastName" },
                values: new object[] { 1, "zhang.liu@qq.com", "Zhang", "Liu" });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "InstructorId", "Email", "FirstName", "LastName" },
                values: new object[] { 2, "jin.ling@123.com", "Jin", "Ling" });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "InstructorId", "Email", "FirstName", "LastName" },
                values: new object[] { 3, "sam.sun@gmail.com", "Sam", "Sun" });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "InstructorId", "Email", "FirstName", "LastName" },
                values: new object[] { 4, "ann.fox@outlook.com", "Ann", "Fox" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "DirectorFirstName", "DirectorLastName", "Name", "Rating", "Year" },
                values: new object[] { 1, "Richard", "Attenborough", "Gandhi", "PG", 1982 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "DirectorFirstName", "DirectorLastName", "Name", "Rating", "Year" },
                values: new object[] { 2, "Robert", "Wise", "The Sound of Music", "G", 196 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "DirectorFirstName", "DirectorLastName", "Name", "Rating", "Year" },
                values: new object[] { 3, "George", "Cukor", "My Fair Lady", "PG", 1964 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "DirectorFirstName", "DirectorLastName", "Name", "Rating", "Year" },
                values: new object[] { 4, "Walter", "Lang", "The King and I", "G", 1956 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "DirectorFirstName", "DirectorLastName", "Name", "Rating", "Year" },
                values: new object[] { 5, "Hugh", "Hudson", "Chariots of Fire", "PG", 1981 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "DirectorFirstName", "DirectorLastName", "Name", "Rating", "Year" },
                values: new object[] { 6, "Stanley", "Kubrick", "Spartacus", "PG", 1960 });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "RestaurantId", "City", "Country", "FoodType", "Phone", "PictureUrl", "PostalCode", "Province", "RestaurantName", "Street" },
                values: new object[] { 1, "Coquitlam", "Canada", "Western Food", "(604) 705-0704", "images/restaurant/white-spot.png", "V5G 1U8", "British Columbia", "White Spot", "1096 Lougheed Highway" });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "RestaurantId", "City", "Country", "FoodType", "Phone", "PictureUrl", "PostalCode", "Province", "RestaurantName", "Street" },
                values: new object[] { 2, "Coquitlam", "Canada", "Chinese Food", "(778) 298-0591", "images/restaurant/hons.png", "V6A 1C5", "British Columbia", "Hons", "310-3025 Lougheed Highway" });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "RestaurantId", "City", "Country", "FoodType", "Phone", "PictureUrl", "PostalCode", "Province", "RestaurantName", "Street" },
                values: new object[] { 3, "Port Coquitlam", "Canada", "Western Food", "(604) 394-9339", "images/restaurant/boston-pizza.png", "V3B 8A4", "British Columbia", "Boston Pizza", "300 - 2325 Ottawa Street" });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "RestaurantId", "City", "Country", "FoodType", "Phone", "PictureUrl", "PostalCode", "Province", "RestaurantName", "Street" },
                values: new object[] { 4, "Maple Ridge", "Canada", "Indian Food", "(604) 764-5639", "images/restaurant/maple-leaf-indian-cuisine.png", "V2X 1X6", "British Columbia", "Maple Leaf Indian Cuisine", "11956 207 Street" });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "RestaurantId", "City", "Country", "FoodType", "Phone", "PictureUrl", "PostalCode", "Province", "RestaurantName", "Street" },
                values: new object[] { 5, "Maple Ridge", "Canada", "Greek Food", "(604) 554-6639", "images/restaurant/socrates-grill.jpeg", "V2X 2P9", "British Columbia", "Socrates Grill", "20691 Lougheed Hwy #19" });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "RestaurantId", "City", "Country", "FoodType", "Phone", "PictureUrl", "PostalCode", "Province", "RestaurantName", "Street" },
                values: new object[] { 6, "Burnaby", "Canada", "Western", "(604) 564-5639", "images/restaurant/joeys-bar-and-grill.png", "V5C 6R5", "BC", "JOEY's Bar & Grill", "109 - 1899 Rosser Ave" });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "RestaurantId", "City", "Country", "FoodType", "Phone", "PictureUrl", "PostalCode", "Province", "RestaurantName", "Street" },
                values: new object[] { 7, "Burnaby", "Canada", "Italian", "(604) 424-8779", "images/restaurant/andos-restaurant-and-grill.png", "V5H 2A9", "BC", "Ando's Restaurant & Grill", "102 - 4501 Kingsway" });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "RestaurantId", "City", "Country", "FoodType", "Phone", "PictureUrl", "PostalCode", "Province", "RestaurantName", "Street" },
                values: new object[] { 8, "Burnaby", "Canada", "Western", "(604) 291-6606", "images/restaurant/cactus-club-cafe.png", "V6C 0A8", "BC", "Cactus Club Cafe", "4219 B Lougheed Hwy" });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "RestaurantId", "City", "Country", "FoodType", "Phone", "PictureUrl", "PostalCode", "Province", "RestaurantName", "Street" },
                values: new object[] { 9, "Burnaby", "Canada", "Pub", "(604) 453-0811", "images/restaurant/personas-patio-restaurant-and-lounge.png", "V5G 1C7", "BC", "Personas Patio Restaurant And Lounge", "4331 Dominion St" });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "RestaurantId", "City", "Country", "FoodType", "Phone", "PictureUrl", "PostalCode", "Province", "RestaurantName", "Street" },
                values: new object[] { 10, "Burnaby", "Canada", "NW plates", "(604) 298-4278", "images/restaurant/hart-house-restaurant.jpeg", "V5E 4H3", "BC", "Hart House Restaurant", "6664 Deer Lake Ave" });

            migrationBuilder.InsertData(
                table: "Species",
                column: "SpecieName",
                value: "Amphibians");

            migrationBuilder.InsertData(
                table: "Species",
                column: "SpecieName",
                value: "Bird");

            migrationBuilder.InsertData(
                table: "Species",
                column: "SpecieName",
                value: "Fish");

            migrationBuilder.InsertData(
                table: "Species",
                column: "SpecieName",
                value: "Insect");

            migrationBuilder.InsertData(
                table: "Species",
                column: "SpecieName",
                value: "Mammal");

            migrationBuilder.InsertData(
                table: "Species",
                column: "SpecieName",
                value: "Reptile");

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[] { 1, "Tom", "Max", "Nursing" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[] { 2, "Ann", "Fay", "Mining" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[] { 3, "Joe", "Sun", "Nursing" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[] { 4, "Sue", "Fox", "Computing" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[] { 5, "Ben", "Ray", "Mining" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[] { 6, "Zoe", "Cox", "Business" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[] { 7, "Sam", "Ray", "Mining" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[] { 8, "Dan", "Ash", "Medicine" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[] { 9, "Pat", "Lee", "Computing" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[] { 10, "Kim", "Day", "Nursing" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[] { 11, "Tim", "Rex", "Computing" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[] { 12, "Rob", "Ram", "Business" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[] { 13, "Jan", "Fry", "Mining" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[] { 14, "Jim", "Tex", "Nursing" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[] { 15, "Ben", "Kid", "Business" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[] { 16, "Mia", "Chu", "Medicine" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[] { 17, "Ted", "Tao", "Computing" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[] { 18, "Amy", "Day", "Business" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[] { 19, "Ian", "Roy", "Nursing" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[] { 20, "Liz", "Kit", "Nursing" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[] { 21, "Mat", "Tan", "Medicine" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[] { 22, "Deb", "Roy", "Medicine" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[] { 23, "Ana", "Ray", "Mining" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[] { 24, "Lyn", "Poe", "Computing" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[] { 25, "Amy", "Raj", "Nursing" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[] { 26, "Kim", "Ash", "Mining" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[] { 27, "Bec", "Kid", "Nursing" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[] { 28, "Eva", "Fry", "Computing" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[] { 29, "Eli", "Lap", "Business" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[] { 30, "Sam", "Yim", "Nursing" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[] { 31, "Joe", "Hui", "Mining" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[] { 32, "Liz", "Jin", "Nursing" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[] { 33, "Ric", "Kuo", "Business" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[] { 34, "Pam", "Mak", "Computing" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[] { 35, "Cat", "Yao", "Medicine" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[] { 36, "Lou", "Zhu", "Mining" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[] { 37, "Tom", "Dag", "Business" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[] { 38, "Stu", "Day", "Business" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[] { 39, "Tom", "Gad", "Mining" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[] { 40, "Bob", "Bee", "Business" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[] { 41, "Jim", "Ots", "Business" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[] { 42, "Tom", "Mag", "Business" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[] { 43, "Hal", "Doe", "Mining" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[] { 44, "Roy", "Kim", "Mining" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[] { 45, "Vis", "Cox", "Nursing" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[] { 46, "Kay", "Aga", "Nursing" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[] { 47, "Reo", "Hui", "Nursing" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[] { 48, "Bob", "Roe", "Mining" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[] { 49, "Jay", "Eff", "Computing" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[] { 50, "Eva", "Chu", "Business" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[] { 51, "Lex", "Rae", "Nursing" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[] { 52, "Lin", "Dex", "Mining" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[] { 53, "Tom", "Dag", "Business" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[] { 54, "Ben", "Shy", "Computing" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[] { 55, "Rob", "Bos", "Nursing" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[] { 56, "Ali", "Mac", "Business" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamName", "City", "Country", "Province" },
                values: new object[] { "Blackhawks", "Chicago", "USA", "IL" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamName", "City", "Country", "Province" },
                values: new object[] { "Canucks", "Vancouver", "Canada", "BC" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamName", "City", "Country", "Province" },
                values: new object[] { "Ducks", "Anaheim", "USA", "CA" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamName", "City", "Country", "Province" },
                values: new object[] { "Flames", "Calgary", "Canada", "AB" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamName", "City", "Country", "Province" },
                values: new object[] { "Lightening", "Tampa Bay", "USA", "FL" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamName", "City", "Country", "Province" },
                values: new object[] { "Oilers", "Edmonton", "Canada", "AB" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamName", "City", "Country", "Province" },
                values: new object[] { "Sharks", "San Jose", "USA", "CA" });

            migrationBuilder.InsertData(
                table: "Toons",
                columns: new[] { "Id", "FirstName", "Gender", "LastName", "Occupation", "PictureUrl", "Votes" },
                values: new object[] { 1, "Fred", "M", "Flintstone", "Mining Manager", "images/flintstone/fred.png", 0 });

            migrationBuilder.InsertData(
                table: "Toons",
                columns: new[] { "Id", "FirstName", "Gender", "LastName", "Occupation", "PictureUrl", "Votes" },
                values: new object[] { 2, "Barney", "M", "Rubble", "Mining Assistant", "images/flintstone/barney.png", 0 });

            migrationBuilder.InsertData(
                table: "Toons",
                columns: new[] { "Id", "FirstName", "Gender", "LastName", "Occupation", "PictureUrl", "Votes" },
                values: new object[] { 3, "Betty", "F", "Rubble", "Nurse", "images/flintstone/betty.png", 0 });

            migrationBuilder.InsertData(
                table: "Toons",
                columns: new[] { "Id", "FirstName", "Gender", "LastName", "Occupation", "PictureUrl", "Votes" },
                values: new object[] { 4, "Wilma", "F", "Flintstone", "Teacher", "images/flintstone/wilma.png", 0 });

            migrationBuilder.InsertData(
                table: "Toons",
                columns: new[] { "Id", "FirstName", "Gender", "LastName", "Occupation", "PictureUrl", "Votes" },
                values: new object[] { 5, "Bambam", "M", "Rubble", "Baby", "images/flintstone/bambam.png", 0 });

            migrationBuilder.InsertData(
                table: "Toons",
                columns: new[] { "Id", "FirstName", "Gender", "LastName", "Occupation", "PictureUrl", "Votes" },
                values: new object[] { 6, "Pebbles", "M", "Flintstone", "Baby", "images/flintstone/pebbles.png", 0 });

            migrationBuilder.InsertData(
                table: "Toons",
                columns: new[] { "Id", "FirstName", "Gender", "LastName", "Occupation", "PictureUrl", "Votes" },
                values: new object[] { 7, "Dino", "F", "Flintstone", "Pet", "images/flintstone/dino.png", 0 });

            migrationBuilder.InsertData(
                table: "Toons",
                columns: new[] { "Id", "FirstName", "Gender", "LastName", "Occupation", "PictureUrl", "Votes" },
                values: new object[] { 8, "Micky", "M", "Mouse", "Hunter", "images/disney/MickyMouse.png", 0 });

            migrationBuilder.InsertData(
                table: "Toons",
                columns: new[] { "Id", "FirstName", "Gender", "LastName", "Occupation", "PictureUrl", "Votes" },
                values: new object[] { 9, "Donald", "M", "Duck", "Sailor", "images/disney/DonaldDuck.png", 0 });

            migrationBuilder.InsertData(
                table: "VehicleManufacturers",
                columns: new[] { "VehicleManufacturerName", "Country" },
                values: new object[] { "Kia", "South Korea" });

            migrationBuilder.InsertData(
                table: "VehicleManufacturers",
                columns: new[] { "VehicleManufacturerName", "Country" },
                values: new object[] { "Mercedes", "Germany" });

            migrationBuilder.InsertData(
                table: "VehicleManufacturers",
                columns: new[] { "VehicleManufacturerName", "Country" },
                values: new object[] { "Renault", "France" });

            migrationBuilder.InsertData(
                table: "VehicleManufacturers",
                columns: new[] { "VehicleManufacturerName", "Country" },
                values: new object[] { "Tesla", "USA" });

            migrationBuilder.InsertData(
                table: "VehicleManufacturers",
                columns: new[] { "VehicleManufacturerName", "Country" },
                values: new object[] { "Toyota", "Japan" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "ActorId", "FirstName", "LastName", "MovieId" },
                values: new object[] { 1, "Ben", "Kingsley", 1 });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "ActorId", "FirstName", "LastName", "MovieId" },
                values: new object[] { 2, "John", "Gielgud", 1 });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "ActorId", "FirstName", "LastName", "MovieId" },
                values: new object[] { 3, "Rohini", "Hattangadi", 1 });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "ActorId", "FirstName", "LastName", "MovieId" },
                values: new object[] { 4, "Julie", "Andrews", 2 });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "ActorId", "FirstName", "LastName", "MovieId" },
                values: new object[] { 5, "Christopher", "Plummer", 2 });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "ActorId", "FirstName", "LastName", "MovieId" },
                values: new object[] { 6, "Audrey", "Hepburn", 3 });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "ActorId", "FirstName", "LastName", "MovieId" },
                values: new object[] { 7, "Rex", "Harrison", 3 });

            migrationBuilder.InsertData(
                table: "Athletes",
                columns: new[] { "AthleteId", "CompetitionId", "Country", "DateOfBirth", "FirstName", "LastName" },
                values: new object[] { 1, 1, "USA", new DateTime(1996, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Christian", "Coleman" });

            migrationBuilder.InsertData(
                table: "Athletes",
                columns: new[] { "AthleteId", "CompetitionId", "Country", "DateOfBirth", "FirstName", "LastName" },
                values: new object[] { 2, 1, "GBR", new DateTime(1995, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zharnel", "Hughes" });

            migrationBuilder.InsertData(
                table: "Athletes",
                columns: new[] { "AthleteId", "CompetitionId", "Country", "DateOfBirth", "FirstName", "LastName" },
                values: new object[] { 3, 6, "KEN", new DateTime(1994, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brigid", "Kosgei" });

            migrationBuilder.InsertData(
                table: "Athletes",
                columns: new[] { "AthleteId", "CompetitionId", "Country", "DateOfBirth", "FirstName", "LastName" },
                values: new object[] { 4, 6, "ETH", new DateTime(1990, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Worknesh", "Degefa" });

            migrationBuilder.InsertData(
                table: "Athletes",
                columns: new[] { "AthleteId", "CompetitionId", "Country", "DateOfBirth", "FirstName", "LastName" },
                values: new object[] { 5, 7, "ETH", new DateTime(1994, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Birhanu", "Legese" });

            migrationBuilder.InsertData(
                table: "Athletes",
                columns: new[] { "AthleteId", "CompetitionId", "Country", "DateOfBirth", "FirstName", "LastName" },
                values: new object[] { 6, 7, "KEN", new DateTime(1988, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lawrence", "Cherono" });

            migrationBuilder.InsertData(
                table: "Athletes",
                columns: new[] { "AthleteId", "CompetitionId", "Country", "DateOfBirth", "FirstName", "LastName" },
                values: new object[] { 7, 2, "SWE", new DateTime(1999, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Armand", "Duplantis" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryName", "AreaSqKm", "CapitalCity", "ContinentName" },
                values: new object[] { "Brazil", 8511965, "Brasilia", "South America" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryName", "AreaSqKm", "CapitalCity", "ContinentName" },
                values: new object[] { "Canada", 9976140, "Ottawa", "North America" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryName", "AreaSqKm", "CapitalCity", "ContinentName" },
                values: new object[] { "China", 9596960, "Beijing", "Asia" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryName", "AreaSqKm", "CapitalCity", "ContinentName" },
                values: new object[] { "India", 3287590, "New Delhi", "Asia" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryName", "AreaSqKm", "CapitalCity", "ContinentName" },
                values: new object[] { "USA", 9629091, "Washington DC", "North America" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "InstructorId", "Name" },
                values: new object[] { "COMP1536", 4, "HTML & CSS" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "InstructorId", "Name" },
                values: new object[] { "COMP2910", 1, "Project Management" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "InstructorId", "Name" },
                values: new object[] { "COMP3717", 3, "Android" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "InstructorId", "Name" },
                values: new object[] { "COMP3973", 2, "ASP.NET" });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "FoodCategoryId", "Name", "Unit", "UnitPrice" },
                values: new object[] { 1, 1, "Croissant", "dozen", 9.98f });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "FoodCategoryId", "Name", "Unit", "UnitPrice" },
                values: new object[] { 2, 3, "Carrots", "lbs", 0.98f });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "FoodCategoryId", "Name", "Unit", "UnitPrice" },
                values: new object[] { 3, 2, "Apples", "lbs", 0.65f });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "MenuId", "Name", "PictureUrl", "Price", "RestaurantId" },
                values: new object[] { 1, "Oven Baked Lasagna", "images/menu/oven-baked-lasagna.jpeg", 17.989999999999998, 1 });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "MenuId", "Name", "PictureUrl", "Price", "RestaurantId" },
                values: new object[] { 2, "Spaghetti & Meatballs", "images/menu/spaghetti-and-meatballs.jpeg", 17.989999999999998, 1 });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "MenuId", "Name", "PictureUrl", "Price", "RestaurantId" },
                values: new object[] { 3, "Seafood Fettuccine", "images/menu/seafood-fettuccine.jpeg", 19.989999999999998, 1 });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "MenuId", "Name", "PictureUrl", "Price", "RestaurantId" },
                values: new object[] { 4, "Barbecued Duck", "images/menu/barbecued-duck.jpeg", 25.5, 2 });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "MenuId", "Name", "PictureUrl", "Price", "RestaurantId" },
                values: new object[] { 5, "Roasted Pork", "images/menu/roasted-pork.jpeg", 9.75, 2 });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "MenuId", "Name", "PictureUrl", "Price", "RestaurantId" },
                values: new object[] { 6, "The Ultimate Hamburger", "images/menu/hamburger.jpeg", 18.989999999999998, 3 });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "MenuId", "Name", "PictureUrl", "Price", "RestaurantId" },
                values: new object[] { 7, "Maki Sushi", "images/menu/maki-sushi.jpeg", 27.989999999999998, 3 });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "MenuId", "Name", "PictureUrl", "Price", "RestaurantId" },
                values: new object[] { 8, "Chicken Tikka Masala", "images/menu/chicken-tikka-masala.jpeg", 4.9900000000000002, 4 });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "MenuId", "Name", "PictureUrl", "Price", "RestaurantId" },
                values: new object[] { 9, "Butter Chicken", "images/menu/butter-chicken.jpeg", 12.99, 4 });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "MenuId", "Name", "PictureUrl", "Price", "RestaurantId" },
                values: new object[] { 10, "Lamb Souvlaki", "images/menu/lamb-souvlaki.jpeg", 19.0, 5 });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "MenuId", "Name", "PictureUrl", "Price", "RestaurantId" },
                values: new object[] { 11, "Chili Chicken", "images/menu/chilli-chicken.jpeg", 15.75, 6 });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "MenuId", "Name", "PictureUrl", "Price", "RestaurantId" },
                values: new object[] { 12, "Yam Fries", "images/menu/yam-fries.jpeg", 12.0, 6 });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "MenuId", "Name", "PictureUrl", "Price", "RestaurantId" },
                values: new object[] { 13, "Sushi Cone", "images/menu/sushi-cone.jpeg", 6.25, 6 });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "MenuId", "Name", "PictureUrl", "Price", "RestaurantId" },
                values: new object[] { 14, "Casar Salad", "images/menu/casar-salad.jpeg", 13.0, 7 });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "MenuId", "Name", "PictureUrl", "Price", "RestaurantId" },
                values: new object[] { 15, "Linguine Carbonara", "images/menu/linguine-carbonara.jpeg", 22.0, 7 });

            migrationBuilder.InsertData(
                table: "Organisms",
                columns: new[] { "OrganismId", "Name", "SpecieName" },
                values: new object[] { 1, "Australian brush turkey", "Bird" });

            migrationBuilder.InsertData(
                table: "Organisms",
                columns: new[] { "OrganismId", "Name", "SpecieName" },
                values: new object[] { 2, "Egyptian plover", "Bird" });

            migrationBuilder.InsertData(
                table: "Organisms",
                columns: new[] { "OrganismId", "Name", "SpecieName" },
                values: new object[] { 3, "White stork", "Bird" });

            migrationBuilder.InsertData(
                table: "Organisms",
                columns: new[] { "OrganismId", "Name", "SpecieName" },
                values: new object[] { 4, "Kingfisher", "Bird" });

            migrationBuilder.InsertData(
                table: "Organisms",
                columns: new[] { "OrganismId", "Name", "SpecieName" },
                values: new object[] { 5, "Atlantic salmon", "Fish" });

            migrationBuilder.InsertData(
                table: "Organisms",
                columns: new[] { "OrganismId", "Name", "SpecieName" },
                values: new object[] { 6, "Great white shark", "Fish" });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "PatientId", "City", "Country", "DateOfBirth", "Email", "FirstName", "Gender", "HospitalId", "InDate", "LastName", "OutDate", "Phone", "PostalCode", "Province", "RoomNumber", "Street" },
                values: new object[] { 1, "Delta", "Canada", new DateTime(1987, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "sam@fox.ca", "Sam", 'M', 1, new DateTime(2020, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fox", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "604-682-2344", "V6Z 1Y6", "British Columbia", "204a", "1081 River Street" });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "PatientId", "City", "Country", "DateOfBirth", "Email", "FirstName", "Gender", "HospitalId", "InDate", "LastName", "OutDate", "Phone", "PostalCode", "Province", "RoomNumber", "Street" },
                values: new object[] { 2, "Surrey", "Canada", new DateTime(1980, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "meg@roy.ca", "Meg", 'F', 1, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roy", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "604-286-4432", "V3Z 1P6", "British Columbia", "114b", "181 Alma Road" });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "PatientId", "City", "Country", "DateOfBirth", "Email", "FirstName", "Gender", "HospitalId", "InDate", "LastName", "OutDate", "Phone", "PostalCode", "Province", "RoomNumber", "Street" },
                values: new object[] { 3, "Port Coquitlam", "Canada", new DateTime(1977, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "joe@day.ca", "Joe", 'M', 2, new DateTime(2020, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Day", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "604-943-0807", "V3P 2C4", "British Columbia", "304", "870 Pitt River Road" });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "PatientId", "City", "Country", "DateOfBirth", "Email", "FirstName", "Gender", "HospitalId", "InDate", "LastName", "OutDate", "Phone", "PostalCode", "Province", "RoomNumber", "Street" },
                values: new object[] { 4, "Coquitlam", "Canada", new DateTime(2005, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "ann@lee.ca", "Ann", 'F', 2, new DateTime(2020, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lee", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "604-942-9856", "V6Y 2Y9", "British Columbia", "194", "1870 Ottawa Avenue" });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "PatientId", "City", "Country", "DateOfBirth", "Email", "FirstName", "Gender", "HospitalId", "InDate", "LastName", "OutDate", "Phone", "PostalCode", "Province", "RoomNumber", "Street" },
                values: new object[] { 5, "New Wesminster", "Canada", new DateTime(2015, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "bob@ray.ca", "Bob", 'M', 3, new DateTime(2020, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ray", new DateTime(2020, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "604-870-4031", "V7W 2Y9", "British Columbia", "619a", "7045 Main Street" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "PlayerId", "FirstName", "LastName", "Position", "TeamName" },
                values: new object[] { 1, "Bob", "Fox", "Forward", "Canucks" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "PlayerId", "FirstName", "LastName", "Position", "TeamName" },
                values: new object[] { 2, "Sam", "Dix", "Left Wing", "Canucks" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "PlayerId", "FirstName", "LastName", "Position", "TeamName" },
                values: new object[] { 3, "John", "Rooster", "Right Wing", "Flames" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "PlayerId", "FirstName", "LastName", "Position", "TeamName" },
                values: new object[] { 4, "Pat", "Plumber", "Defense", "Oilers" });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Model", "Fuel", "Type", "VehicleManufacturerName" },
                values: new object[] { "Corolla", "Gas", "Sedan", "Toyota" });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Model", "Fuel", "Type", "VehicleManufacturerName" },
                values: new object[] { "Model S", "Electric", "Sedan", "Tesla" });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Model", "Fuel", "Type", "VehicleManufacturerName" },
                values: new object[] { "Rav4", "Gas", "SUV", "Toyota" });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Model", "Fuel", "Type", "VehicleManufacturerName" },
                values: new object[] { "Soul", "Electric", "SUV", "Kia" });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "ProvinceId", "CapitalCity", "CountryName", "Name" },
                values: new object[] { 1, "Montgomery", "USA", "Aalabama" });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "ProvinceId", "CapitalCity", "CountryName", "Name" },
                values: new object[] { 2, "Sacramento", "USA", "California" });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "ProvinceId", "CapitalCity", "CountryName", "Name" },
                values: new object[] { 3, "Honolulu", "USA", "Hawaii" });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "ProvinceId", "CapitalCity", "CountryName", "Name" },
                values: new object[] { 4, "Fuzhou", "China", "Fujian" });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "ProvinceId", "CapitalCity", "CountryName", "Name" },
                values: new object[] { 5, "Wuhan", "China", "Hubei" });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "ProvinceId", "CapitalCity", "CountryName", "Name" },
                values: new object[] { 6, "Toronto", "Canada", "Ontario" });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "ProvinceId", "CapitalCity", "CountryName", "Name" },
                values: new object[] { 7, "Edmopnton", "Canada", "Alberta" });

            migrationBuilder.InsertData(
                table: "Sicknesses",
                columns: new[] { "SicknessId", "PatientId", "SicknessName" },
                values: new object[] { 1, 4, "Diabetes" });

            migrationBuilder.InsertData(
                table: "Sicknesses",
                columns: new[] { "SicknessId", "PatientId", "SicknessName" },
                values: new object[] { 2, 4, "PTSD" });

            migrationBuilder.InsertData(
                table: "Sicknesses",
                columns: new[] { "SicknessId", "PatientId", "SicknessName" },
                values: new object[] { 3, 2, "High Blood Pressure" });

            migrationBuilder.InsertData(
                table: "Sicknesses",
                columns: new[] { "SicknessId", "PatientId", "SicknessName" },
                values: new object[] { 4, 3, "COVID-19" });

            migrationBuilder.InsertData(
                table: "Sicknesses",
                columns: new[] { "SicknessId", "PatientId", "SicknessName" },
                values: new object[] { 5, 1, "Maternity" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityName", "ProvinceId" },
                values: new object[] { "Hamilton", 6 });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityName", "ProvinceId" },
                values: new object[] { "Kingston", 6 });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityName", "ProvinceId" },
                values: new object[] { "Los Angeles", 2 });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityName", "ProvinceId" },
                values: new object[] { "Mississauga", 6 });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityName", "ProvinceId" },
                values: new object[] { "Ottawa", 6 });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityName", "ProvinceId" },
                values: new object[] { "Quanzhou", 4 });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityName", "ProvinceId" },
                values: new object[] { "San Diego", 2 });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityName", "ProvinceId" },
                values: new object[] { "San Francisco", 2 });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityName", "ProvinceId" },
                values: new object[] { "Windsor", 6 });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityName", "ProvinceId" },
                values: new object[] { "Xiamen", 4 });

            migrationBuilder.InsertData(
                table: "Medicines",
                columns: new[] { "MedicineId", "Dosage", "DosageUnit", "FrequencyInHours", "Name", "SicknessId" },
                values: new object[] { 1, 50, "mg", 8, "Acarbose", 1 });

            migrationBuilder.InsertData(
                table: "Medicines",
                columns: new[] { "MedicineId", "Dosage", "DosageUnit", "FrequencyInHours", "Name", "SicknessId" },
                values: new object[] { 2, 850, "mg", 12, "Metformin", 1 });

            migrationBuilder.InsertData(
                table: "Medicines",
                columns: new[] { "MedicineId", "Dosage", "DosageUnit", "FrequencyInHours", "Name", "SicknessId" },
                values: new object[] { 3, 150, "mg", 6, "Prazosin", 2 });

            migrationBuilder.InsertData(
                table: "Medicines",
                columns: new[] { "MedicineId", "Dosage", "DosageUnit", "FrequencyInHours", "Name", "SicknessId" },
                values: new object[] { 4, 180, "mg", 8, "Zoloft", 2 });

            migrationBuilder.InsertData(
                table: "Medicines",
                columns: new[] { "MedicineId", "Dosage", "DosageUnit", "FrequencyInHours", "Name", "SicknessId" },
                values: new object[] { 5, 20, "mg", 24, "Benicar", 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Actors_MovieId",
                table: "Actors",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Athletes_CompetitionId",
                table: "Athletes",
                column: "CompetitionId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_ProvinceId",
                table: "Cities",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_ContinentName",
                table: "Countries",
                column: "ContinentName");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_InstructorId",
                table: "Courses",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_FoodCategoryId",
                table: "Foods",
                column: "FoodCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Medicines_SicknessId",
                table: "Medicines",
                column: "SicknessId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_RestaurantId",
                table: "MenuItems",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_Organisms_SpecieName",
                table: "Organisms",
                column: "SpecieName");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_HospitalId",
                table: "Patients",
                column: "HospitalId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_TeamName",
                table: "Players",
                column: "TeamName");

            migrationBuilder.CreateIndex(
                name: "IX_Provinces_CountryName",
                table: "Provinces",
                column: "CountryName");

            migrationBuilder.CreateIndex(
                name: "IX_Sicknesses_PatientId",
                table: "Sicknesses",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_VehicleManufacturerName",
                table: "Vehicles",
                column: "VehicleManufacturerName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "Athletes");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Medicines");

            migrationBuilder.DropTable(
                name: "MenuItems");

            migrationBuilder.DropTable(
                name: "Organisms");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Toons");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Competitions");

            migrationBuilder.DropTable(
                name: "Provinces");

            migrationBuilder.DropTable(
                name: "Instructors");

            migrationBuilder.DropTable(
                name: "FoodCategories");

            migrationBuilder.DropTable(
                name: "Sicknesses");

            migrationBuilder.DropTable(
                name: "Restaurants");

            migrationBuilder.DropTable(
                name: "Species");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "VehicleManufacturers");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Continents");

            migrationBuilder.DropTable(
                name: "Hospitals");
        }
    }
}
