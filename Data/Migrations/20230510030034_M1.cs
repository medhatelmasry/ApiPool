using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApiPool.Data.Migrations
{
    /// <inheritdoc />
    public partial class M1 : Migration
    {
        /// <inheritdoc />
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
                name: "QuizResult",
                columns: table => new
                {
                    QuizResultId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    WebAppId = table.Column<string>(type: "TEXT", nullable: true),
                    Category = table.Column<string>(type: "TEXT", nullable: true),
                    DateOfQuiz = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    TimeOfQuiz = table.Column<TimeOnly>(type: "TEXT", nullable: false),
                    NumberOfQuestionsInQuiz = table.Column<int>(type: "INTEGER", nullable: false),
                    Score = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuizResult", x => x.QuizResultId);
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
                    LogoUrl = table.Column<string>(type: "TEXT", nullable: false),
                    Latitude = table.Column<double>(type: "REAL", nullable: false),
                    Longitude = table.Column<double>(type: "REAL", nullable: false)
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
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    InstructorId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
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
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    PictureUrl = table.Column<string>(type: "TEXT", nullable: false),
                    RestaurantId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItems", x => x.Id);
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
                values: new object[,]
                {
                    { 1, "Men's 100m" },
                    { 2, "Men's Pole Vault" },
                    { 3, "Men's 50km Race Walking" },
                    { 4, "Women's 100m" },
                    { 5, "Women's 100m" },
                    { 6, "Women's Marathon" },
                    { 7, "Men's Marathon" }
                });

            migrationBuilder.InsertData(
                table: "Continents",
                column: "ContinentName",
                values: new object[]
                {
                    "Africa",
                    "Asia",
                    "Australia",
                    "Europe",
                    "North America",
                    "South America"
                });

            migrationBuilder.InsertData(
                table: "FoodCategories",
                columns: new[] { "FoodCategoryId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Bakery products, which include bread, rolls, \n                cookies, pies, pastries, and muffins, are usually prepared from flour \n                or meal derived from some form of grain. Bread, already a common \n                staple in prehistoric times, provides many nutrients in the human diet.", "Bakery" },
                    { 2, "The sweet \n                and fleshy product of a tree or other plant that contains seed \n                and can be eaten as food.", "Fruit" },
                    { 3, "A plant \n                or part of a plant used as food, typically as accompaniment to meat \n                or fish, such as a cabbage, potato, carrot, or bean.", "Vegetables" }
                });

            migrationBuilder.InsertData(
                table: "Hospitals",
                columns: new[] { "HospitalId", "City", "Country", "Email", "Name", "Phone", "PostalCode", "Province", "Street" },
                values: new object[,]
                {
                    { 1, "Vancouver", "Canada", null, "St. Paul's Hospital", "604-682-2344", "V6Z 1Y6", "British Columbia", "1081 Burrard Street" },
                    { 2, "Port Moody", "Canada", null, "Eagle Ridge Hospital", "604-461-2022", "V3H 3W9", "British Columbia", "475 Guildford Way" },
                    { 3, "Vancouver", "Canada", null, "Vancouver General Hospital (VGH)", "604-875-4111", "V5Z 1M9", "British Columbia", "899 West 12th Avenue" },
                    { 4, "Surrey", "Canada", null, "Surrey Memorial Hospital", "604-581-2211", "V3V 1Z2", "British Columbia", "13750 96th Avenue" },
                    { 5, "New Westminster", "Canada", null, "Royal Columbian Hospital", "604-520-4253", "V3L 3W7", "British Columbia", "330 East Columbia Street" }
                });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "InstructorId", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "zhang.liu@qq.com", "Zhang", "Liu" },
                    { 2, "jin.ling@123.com", "Jin", "Ling" },
                    { 3, "sam.sun@gmail.com", "Sam", "Sun" },
                    { 4, "ann.fox@outlook.com", "Ann", "Fox" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "DirectorFirstName", "DirectorLastName", "Name", "Rating", "Year" },
                values: new object[,]
                {
                    { 1, "Richard", "Attenborough", "Gandhi", "PG", 1982 },
                    { 2, "Robert", "Wise", "The Sound of Music", "G", 196 },
                    { 3, "George", "Cukor", "My Fair Lady", "PG", 1964 },
                    { 4, "Walter", "Lang", "The King and I", "G", 1956 },
                    { 5, "Hugh", "Hudson", "Chariots of Fire", "PG", 1981 },
                    { 6, "Stanley", "Kubrick", "Spartacus", "PG", 1960 }
                });

            migrationBuilder.InsertData(
                table: "QuizResult",
                columns: new[] { "QuizResultId", "Category", "DateOfQuiz", "Name", "NumberOfQuestionsInQuiz", "Score", "TimeOfQuiz", "WebAppId" },
                values: new object[,]
                {
                    { 1, "General Knowledge", new DateOnly(2023, 5, 9), "Tom Max", 10, 8, new TimeOnly(20, 0, 34, 814).Add(TimeSpan.FromTicks(1150)), "d74c4d21-e60b-4c6b-80b8-4505896c39bd" },
                    { 2, "Entertainment: Books", new DateOnly(2023, 5, 9), "Ann Fay", 10, 5, new TimeOnly(20, 0, 34, 814).Add(TimeSpan.FromTicks(1160)), "4d836559-4e5e-4cc9-acef-646fd8021516" },
                    { 3, "General Knowledge", new DateOnly(2023, 5, 9), "Ken Sim", 10, 6, new TimeOnly(20, 0, 34, 814).Add(TimeSpan.FromTicks(1160)), "124e9daf-a8eb-4a37-84ff-5d7665b123ee" },
                    { 4, "Entertainment: Film", new DateOnly(2023, 5, 9), "Joe Sun", 10, 9, new TimeOnly(20, 0, 34, 814).Add(TimeSpan.FromTicks(1160)), "ac5e5228-194c-4720-97e2-444894ce236c" },
                    { 5, "Entertainment: Books", new DateOnly(2023, 5, 9), "Sue Fox", 10, 4, new TimeOnly(20, 0, 34, 814).Add(TimeSpan.FromTicks(1170)), "c68d3cc6-03b3-4e36-a04d-a59963193331" },
                    { 6, "Entertainment: Music", new DateOnly(2023, 5, 9), "Ben Ray", 10, 7, new TimeOnly(20, 0, 34, 814).Add(TimeSpan.FromTicks(1170)), "4946a047-34d7-468a-af10-320d75236f06" },
                    { 7, "Entertainment: Books", new DateOnly(2023, 5, 9), "Zoe Cox", 10, 4, new TimeOnly(20, 0, 34, 814).Add(TimeSpan.FromTicks(1180)), "a5764069-19e4-47ff-802b-bf16bab84ff5" },
                    { 8, "Entertainment: Film", new DateOnly(2023, 5, 9), "Sam Ray", 10, 10, new TimeOnly(20, 0, 34, 814).Add(TimeSpan.FromTicks(1180)), "0912c6cf-337c-45ba-a36f-0d8755c4b1d0" },
                    { 9, "General Knowledge", new DateOnly(2023, 5, 9), "Dan Ash", 10, 8, new TimeOnly(20, 0, 34, 814).Add(TimeSpan.FromTicks(1190)), "efbc601f-cfc6-4071-8884-0c9f5778cc30" },
                    { 10, "General Knowledge", new DateOnly(2023, 5, 9), "Pat Day", 10, 6, new TimeOnly(20, 0, 34, 814).Add(TimeSpan.FromTicks(1190)), "6dff6a08-b48d-4d45-8d82-cf88c3a8f2cc" }
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "RestaurantId", "City", "Country", "FoodType", "Latitude", "LogoUrl", "Longitude", "Phone", "PostalCode", "Province", "RestaurantName", "Street" },
                values: new object[,]
                {
                    { 1, "Coquitlam", "Canada", "Western Food", 49.234569999999998, "images/restaurant/white-spot.png", -122.86264, "(604) 705-0704", "V5G 1U8", "British Columbia", "White Spot", "1096 Lougheed Highway" },
                    { 2, "Coquitlam", "Canada", "Chinese Food", 49.274659999999997, "images/restaurant/hons.png", -122.79255999999999, "(778) 298-0591", "V6A 1C5", "British Columbia", "Hons", "310-3025 Lougheed Highway" },
                    { 3, "Port Coquitlam", "Canada", "Western Food", 49.25667, "images/restaurant/boston-pizza.png", -122.74825, "(604) 394-9339", "V3B 8A4", "British Columbia", "Boston Pizza", "300 - 2325 Ottawa Street" },
                    { 4, "Maple Ridge", "Canada", "Indian Food", 49.219900000000003, "images/restaurant/maple-leaf-indian-cuisine.png", -122.64779, "(604) 764-5639", "V2X 1X6", "British Columbia", "Maple Leaf Indian Cuisine", "11956 207 Street" },
                    { 5, "Maple Ridge", "Canada", "Greek Food", 49.218380000000003, "images/restaurant/socrates-grill.png", -122.64904, "(604) 554-6639", "V2X 2P9", "British Columbia", "Socrates Grill", "20691 Lougheed Hwy #19" },
                    { 6, "Burnaby", "Canada", "Western Food", 49.283563000000001, "images/restaurant/joeys-bar-and-grill.png", -123.00581200000001, "(604) 564-5639", "V5C 6R5", "BC", "JOEY's Bar & Grill", "109 - 1899 Rosser Ave" },
                    { 7, "Burnaby", "Canada", "Italian Food", 49.230289999999997, "images/restaurant/andos-restaurant-and-grill.png", -123.00471, "(604) 424-8779", "V5H 2A9", "BC", "Ando's Restaurant & Grill", "102 - 4501 Kingsway" },
                    { 8, "Burnaby", "Canada", "Western Food", 49.238914000000001, "images/restaurant/cactus-club-cafe.png", -122.95826700000001, "(604) 291-6606", "V6C 0A8", "BC", "Cactus Club Cafe", "4219 B Lougheed Hwy" },
                    { 9, "Burnaby", "Canada", "Pub Food", 49.256329999999998, "images/restaurant/personas-patio-restaurant-and-lounge.png", -123.00727000000001, "(604) 453-0811", "V5G 1C7", "BC", "Personas Patio Restaurant And Lounge", "4331 Dominion St" },
                    { 10, "Burnaby", "Canada", "NW plates", 49.23856, "images/restaurant/hart-house-restaurant.png", -122.96683, "(604) 298-4278", "V5E 4H3", "BC", "Hart House Restaurant", "6664 Deer Lake Ave" },
                    { 11, "Port Coquitlam", "Canada", "Western Food", 49.265569999999997, "images/restaurant/earls-kitchen-bar.png", -122.7784, "(604) 941-1733", "V5E 4V3", "BC", "Earls Kitchen + Bar", "5100 - 2850 Shaughnessy" }
                });

            migrationBuilder.InsertData(
                table: "Species",
                column: "SpecieName",
                values: new object[]
                {
                    "Amphibians",
                    "Bird",
                    "Fish",
                    "Insect",
                    "Mammal",
                    "Reptile"
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[,]
                {
                    { 1, "Tom", "Max", "Nursing" },
                    { 2, "Ann", "Fay", "Mining" },
                    { 3, "Joe", "Sun", "Nursing" },
                    { 4, "Sue", "Fox", "Computing" },
                    { 5, "Ben", "Ray", "Mining" },
                    { 6, "Zoe", "Cox", "Business" },
                    { 7, "Sam", "Ray", "Mining" },
                    { 8, "Dan", "Ash", "Medicine" },
                    { 9, "Pat", "Lee", "Computing" },
                    { 10, "Kim", "Day", "Nursing" },
                    { 11, "Tim", "Rex", "Computing" },
                    { 12, "Rob", "Ram", "Business" },
                    { 13, "Jan", "Fry", "Mining" },
                    { 14, "Jim", "Tex", "Nursing" },
                    { 15, "Ben", "Kid", "Business" },
                    { 16, "Mia", "Chu", "Medicine" },
                    { 17, "Ted", "Tao", "Computing" },
                    { 18, "Amy", "Day", "Business" },
                    { 19, "Ian", "Roy", "Nursing" },
                    { 20, "Liz", "Kit", "Nursing" },
                    { 21, "Mat", "Tan", "Medicine" },
                    { 22, "Deb", "Roy", "Medicine" },
                    { 23, "Ana", "Ray", "Mining" },
                    { 24, "Lyn", "Poe", "Computing" },
                    { 25, "Amy", "Raj", "Nursing" },
                    { 26, "Kim", "Ash", "Mining" },
                    { 27, "Bec", "Kid", "Nursing" },
                    { 28, "Eva", "Fry", "Computing" },
                    { 29, "Eli", "Lap", "Business" },
                    { 30, "Sam", "Yim", "Nursing" },
                    { 31, "Joe", "Hui", "Mining" },
                    { 32, "Liz", "Jin", "Nursing" },
                    { 33, "Ric", "Kuo", "Business" },
                    { 34, "Pam", "Mak", "Computing" },
                    { 35, "Cat", "Yao", "Medicine" },
                    { 36, "Lou", "Zhu", "Mining" },
                    { 37, "Tom", "Dag", "Business" },
                    { 38, "Stu", "Day", "Business" },
                    { 39, "Tom", "Gad", "Mining" },
                    { 40, "Bob", "Bee", "Business" },
                    { 41, "Jim", "Ots", "Business" },
                    { 42, "Tom", "Mag", "Business" },
                    { 43, "Hal", "Doe", "Mining" },
                    { 44, "Roy", "Kim", "Mining" },
                    { 45, "Vis", "Cox", "Nursing" },
                    { 46, "Kay", "Aga", "Nursing" },
                    { 47, "Reo", "Hui", "Nursing" },
                    { 48, "Bob", "Roe", "Mining" },
                    { 49, "Jay", "Eff", "Computing" },
                    { 50, "Eva", "Chu", "Business" },
                    { 51, "Lex", "Rae", "Nursing" },
                    { 52, "Lin", "Dex", "Mining" },
                    { 53, "Tom", "Dag", "Business" },
                    { 54, "Ben", "Shy", "Computing" },
                    { 55, "Rob", "Bos", "Nursing" },
                    { 56, "Ali", "Mac", "Business" },
                    { 57, "Ken", "Sim", "Medicine" }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamName", "City", "Country", "Province" },
                values: new object[,]
                {
                    { "Blackhawks", "Chicago", "USA", "IL" },
                    { "Canucks", "Vancouver", "Canada", "BC" },
                    { "Ducks", "Anaheim", "USA", "CA" },
                    { "Flames", "Calgary", "Canada", "AB" },
                    { "Lightening", "Tampa Bay", "USA", "FL" },
                    { "Oilers", "Edmonton", "Canada", "AB" },
                    { "Sharks", "San Jose", "USA", "CA" }
                });

            migrationBuilder.InsertData(
                table: "Toons",
                columns: new[] { "Id", "FirstName", "Gender", "LastName", "Occupation", "PictureUrl", "Votes" },
                values: new object[,]
                {
                    { 1, "Fred", "M", "Flintstone", "Mining Manager", "images/flintstone/fred.png", 0 },
                    { 2, "Barney", "M", "Rubble", "Mining Assistant", "images/flintstone/barney.png", 0 },
                    { 3, "Betty", "F", "Rubble", "Nurse", "images/flintstone/betty.png", 0 },
                    { 4, "Wilma", "F", "Flintstone", "Teacher", "images/flintstone/wilma.png", 0 },
                    { 5, "Bambam", "M", "Rubble", "Baby", "images/flintstone/bambam.png", 0 },
                    { 6, "Pebbles", "M", "Flintstone", "Baby", "images/flintstone/pebbles.png", 0 },
                    { 7, "Dino", "F", "Flintstone", "Pet", "images/flintstone/dino.png", 0 },
                    { 8, "Micky", "M", "Mouse", "Hunter", "images/disney/MickyMouse.png", 0 },
                    { 9, "Donald", "M", "Duck", "Sailor", "images/disney/DonaldDuck.png", 0 }
                });

            migrationBuilder.InsertData(
                table: "VehicleManufacturers",
                columns: new[] { "VehicleManufacturerName", "Country" },
                values: new object[,]
                {
                    { "Kia", "South Korea" },
                    { "Mercedes", "Germany" },
                    { "Renault", "France" },
                    { "Tesla", "USA" },
                    { "Toyota", "Japan" }
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "ActorId", "FirstName", "LastName", "MovieId" },
                values: new object[,]
                {
                    { 1, "Ben", "Kingsley", 1 },
                    { 2, "John", "Gielgud", 1 },
                    { 3, "Rohini", "Hattangadi", 1 },
                    { 4, "Julie", "Andrews", 2 },
                    { 5, "Christopher", "Plummer", 2 },
                    { 6, "Audrey", "Hepburn", 3 },
                    { 7, "Rex", "Harrison", 3 }
                });

            migrationBuilder.InsertData(
                table: "Athletes",
                columns: new[] { "AthleteId", "CompetitionId", "Country", "DateOfBirth", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, 1, "USA", new DateTime(1996, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Christian", "Coleman" },
                    { 2, 1, "GBR", new DateTime(1995, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zharnel", "Hughes" },
                    { 3, 6, "KEN", new DateTime(1994, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brigid", "Kosgei" },
                    { 4, 6, "ETH", new DateTime(1990, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Worknesh", "Degefa" },
                    { 5, 7, "ETH", new DateTime(1994, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Birhanu", "Legese" },
                    { 6, 7, "KEN", new DateTime(1988, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lawrence", "Cherono" },
                    { 7, 2, "SWE", new DateTime(1999, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Armand", "Duplantis" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryName", "AreaSqKm", "CapitalCity", "ContinentName" },
                values: new object[,]
                {
                    { "Brazil", 8511965, "Brasilia", "South America" },
                    { "Canada", 9976140, "Ottawa", "North America" },
                    { "China", 9596960, "Beijing", "Asia" },
                    { "India", 3287590, "New Delhi", "Asia" },
                    { "USA", 9629091, "Washington DC", "North America" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "InstructorId", "Name" },
                values: new object[,]
                {
                    { "COMP1536", 4, "HTML & CSS" },
                    { "COMP2910", 1, "Project Management" },
                    { "COMP3717", 3, "Android" },
                    { "COMP3973", 2, "ASP.NET" }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "FoodCategoryId", "Name", "Unit", "UnitPrice" },
                values: new object[,]
                {
                    { 1, 1, "Croissant", "dozen", 9.98f },
                    { 2, 3, "Carrots", "lbs", 0.98f },
                    { 3, 2, "Apples", "lbs", 0.65f }
                });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Name", "PictureUrl", "Price", "RestaurantId" },
                values: new object[,]
                {
                    { 1, "Baked Lasagna", "images/menu/oven-baked-lasagna.jpeg", 17.989999999999998, 1 },
                    { 2, "Spaghetti & Meatballs", "images/menu/spaghetti-and-meatballs.jpeg", 17.989999999999998, 1 },
                    { 3, "Seafood Fettuccine", "images/menu/seafood-fettuccine.jpeg", 19.989999999999998, 1 },
                    { 4, "Barbecued Duck", "images/menu/barbecued-duck.jpeg", 25.5, 2 },
                    { 5, "Roasted Pork", "images/menu/roasted-pork.jpeg", 9.75, 2 },
                    { 6, "Superburger", "images/menu/hamburger.jpeg", 18.989999999999998, 3 },
                    { 7, "Maki Sushi", "images/menu/maki-sushi.jpeg", 27.989999999999998, 3 },
                    { 8, "Chicken Tikka", "images/menu/chicken-tikka-masala.jpeg", 4.9900000000000002, 4 },
                    { 9, "Butter Chicken", "images/menu/butter-chicken.jpeg", 12.99, 4 },
                    { 10, "Lamb Souvlaki", "images/menu/lamb-souvlaki.jpeg", 19.0, 5 },
                    { 11, "Chili Chicken", "images/menu/chilli-chicken.jpeg", 15.75, 6 },
                    { 12, "Yam Fries", "images/menu/yam-fries.jpeg", 12.0, 6 },
                    { 13, "Sushi Cone", "images/menu/sushi-cone.jpeg", 6.25, 6 },
                    { 14, "Casar Salad", "images/menu/casar-salad.jpeg", 13.0, 7 },
                    { 15, "Linguine Carbonara", "images/menu/linguine-carbonara.jpeg", 22.0, 7 },
                    { 16, "Eggs Benedict", "images/menu/eggs-benedict.jpeg", 19.0, 10 },
                    { 17, "Lamb Shank", "images/menu/braised-lamb-shank.jpg", 42.0, 10 },
                    { 18, "Cioppino", "images/menu/cioppino.jpeg", 32.0, 10 },
                    { 19, "Seafood Platter", "images/menu/seafood-platter.jpeg", 74.0, 11 },
                    { 20, "Chicken Salad", "images/menu/santa-fe-salad.jpeg", 24.75, 11 },
                    { 21, "Corn & Avocado Dip", "images/menu/streetcorn-avocado-dip.jpeg", 13.5, 11 },
                    { 22, "Korean Fried Chicken", "images/menu/korean-fried-chicken.jpg", 14.0, 9 },
                    { 23, "Sticky Ribs", "images/menu/sticky-ribs.jpeg", 15.0, 9 },
                    { 24, "Hawaiian Chicken", "images/menu/hawaiian-chicken.jpg", 17.5, 9 },
                    { 25, "Rigatoni Bolongese", "images/menu/rigatoni-bolongese.jpeg", 24.25, 8 },
                    { 26, "Peppercorn Steak", "images/menu/peppercorn-steak.jpeg", 37.25, 8 },
                    { 27, "Thai Prawn Curry", "images/menu/thai-prawn-curry.jpeg", 26.25, 8 }
                });

            migrationBuilder.InsertData(
                table: "Organisms",
                columns: new[] { "OrganismId", "Name", "SpecieName" },
                values: new object[,]
                {
                    { 1, "Australian brush turkey", "Bird" },
                    { 2, "Egyptian plover", "Bird" },
                    { 3, "White stork", "Bird" },
                    { 4, "Kingfisher", "Bird" },
                    { 5, "Atlantic salmon", "Fish" },
                    { 6, "Great white shark", "Fish" }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "PatientId", "City", "Country", "DateOfBirth", "Email", "FirstName", "Gender", "HospitalId", "InDate", "LastName", "OutDate", "Phone", "PostalCode", "Province", "RoomNumber", "Street" },
                values: new object[,]
                {
                    { 1, "Delta", "Canada", new DateTime(1987, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "sam@fox.ca", "Sam", 'M', 1, new DateTime(2020, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fox", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "604-682-2344", "V6Z 1Y6", "British Columbia", "204a", "1081 River Street" },
                    { 2, "Surrey", "Canada", new DateTime(1980, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "meg@roy.ca", "Meg", 'F', 1, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roy", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "604-286-4432", "V3Z 1P6", "British Columbia", "114b", "181 Alma Road" },
                    { 3, "Port Coquitlam", "Canada", new DateTime(1977, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "joe@day.ca", "Joe", 'M', 2, new DateTime(2020, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Day", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "604-943-0807", "V3P 2C4", "British Columbia", "304", "870 Pitt River Road" },
                    { 4, "Coquitlam", "Canada", new DateTime(2005, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "ann@lee.ca", "Ann", 'F', 2, new DateTime(2020, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lee", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "604-942-9856", "V6Y 2Y9", "British Columbia", "194", "1870 Ottawa Avenue" },
                    { 5, "New Wesminster", "Canada", new DateTime(2015, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "bob@ray.ca", "Bob", 'M', 3, new DateTime(2020, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ray", new DateTime(2020, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "604-870-4031", "V7W 2Y9", "British Columbia", "619a", "7045 Main Street" }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "PlayerId", "FirstName", "LastName", "Position", "TeamName" },
                values: new object[,]
                {
                    { 1, "Bob", "Fox", "Forward", "Canucks" },
                    { 2, "Sam", "Dix", "Left Wing", "Canucks" },
                    { 3, "John", "Rooster", "Right Wing", "Flames" },
                    { 4, "Pat", "Plumber", "Defense", "Oilers" }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Model", "Fuel", "Type", "VehicleManufacturerName" },
                values: new object[,]
                {
                    { "Corolla", "Gas", "Sedan", "Toyota" },
                    { "Model S", "Electric", "Sedan", "Tesla" },
                    { "Rav4", "Gas", "SUV", "Toyota" },
                    { "Soul", "Electric", "SUV", "Kia" }
                });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "ProvinceId", "CapitalCity", "CountryName", "Name" },
                values: new object[,]
                {
                    { 1, "Montgomery", "USA", "Aalabama" },
                    { 2, "Sacramento", "USA", "California" },
                    { 3, "Honolulu", "USA", "Hawaii" },
                    { 4, "Fuzhou", "China", "Fujian" },
                    { 5, "Wuhan", "China", "Hubei" },
                    { 6, "Toronto", "Canada", "Ontario" },
                    { 7, "Edmopnton", "Canada", "Alberta" }
                });

            migrationBuilder.InsertData(
                table: "Sicknesses",
                columns: new[] { "SicknessId", "PatientId", "SicknessName" },
                values: new object[,]
                {
                    { 1, 4, "Diabetes" },
                    { 2, 4, "PTSD" },
                    { 3, 2, "High Blood Pressure" },
                    { 4, 3, "COVID-19" },
                    { 5, 1, "Maternity" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityName", "ProvinceId" },
                values: new object[,]
                {
                    { "Hamilton", 6 },
                    { "Kingston", 6 },
                    { "Los Angeles", 2 },
                    { "Mississauga", 6 },
                    { "Ottawa", 6 },
                    { "Quanzhou", 4 },
                    { "San Diego", 2 },
                    { "San Francisco", 2 },
                    { "Windsor", 6 },
                    { "Xiamen", 4 }
                });

            migrationBuilder.InsertData(
                table: "Medicines",
                columns: new[] { "MedicineId", "Dosage", "DosageUnit", "FrequencyInHours", "Name", "SicknessId" },
                values: new object[,]
                {
                    { 1, 50, "mg", 8, "Acarbose", 1 },
                    { 2, 850, "mg", 12, "Metformin", 1 },
                    { 3, 150, "mg", 6, "Prazosin", 2 },
                    { 4, 180, "mg", 8, "Zoloft", 2 },
                    { 5, 20, "mg", 24, "Benicar", 3 }
                });

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

        /// <inheritdoc />
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
                name: "QuizResult");

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
