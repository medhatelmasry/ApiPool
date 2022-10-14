dotnet aspnet-codegenerator controller -name InstructorsController -async -api -m Instructor -dc ApiPoolContext -outDir Controllers
dotnet aspnet-codegenerator controller -name CoursesController -async -api -m Course -dc ApiPoolContext -outDir Controllers

dotnet aspnet-codegenerator controller -name FoodCategoriesController -async -api -m FoodCategory -dc ApiPoolContext -outDir Controllers
dotnet aspnet-codegenerator controller -name FoodsController -async -api -m Food -dc ApiPoolContext -outDir Controllers

dotnet aspnet-codegenerator controller -name VehicleManufacturersController -async -api -m VehicleManufacturer -dc ApiPoolContext -outDir Controllers
dotnet aspnet-codegenerator controller -name VehiclesController -async -api -m Vehicle -dc ApiPoolContext -outDir Controllers

dotnet aspnet-codegenerator controller -name ContinentsController -async -api -m Continent -dc ApiPoolContext -outDir Controllers
dotnet aspnet-codegenerator controller -name CitiesController -async -api -m City -dc ApiPoolContext -outDir Controllers
dotnet aspnet-codegenerator controller -name CountriesController -async -api -m Country -dc ApiPoolContext -outDir Controllers
dotnet aspnet-codegenerator controller -name ProvincessController -async -api -m Province -dc ApiPoolContext -outDir Controllers

dotnet aspnet-codegenerator controller -name ActorsController -async -api -m Actor -dc ApiPoolContext -outDir Controllers
dotnet aspnet-codegenerator controller -name MoviesController -async -api -m Movie -dc ApiPoolContext -outDir Controllers

dotnet aspnet-codegenerator controller -name OrganismsController -async -api -m Organism -dc ApiPoolContext -outDir Controllers
dotnet aspnet-codegenerator controller -name SpeciesController -async -api -m Specie -dc ApiPoolContext -outDir Controllers

dotnet aspnet-codegenerator controller -name CompetitionsController -async -api -m Competition -dc ApiPoolContext -outDir Controllers
dotnet aspnet-codegenerator controller -name AthletesController -async -api -m Athlete -dc ApiPoolContext -outDir Controllers

dotnet aspnet-codegenerator controller -name TeamsController -async -api -m Team -dc ApiPoolContext -outDir Controllers
dotnet aspnet-codegenerator controller -name PlayersController -async -api -m Player -dc ApiPoolContext -outDir Controllers