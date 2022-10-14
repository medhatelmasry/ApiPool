using System;
using System.Collections.Generic;
using ApiPool.Models.Health;

namespace ApiPool.Data.Seed
{
    public class HealthSeedData
    {
        public static List<Hospital> GetHospitals()
        {
            List<Hospital> items = new List<Hospital>()
            {
                new Hospital() { HospitalId=1, Name="St. Paul's Hospital",
                        Street = "1081 Burrard Street", City = "Vancouver",
                        Province = "British Columbia", PostalCode = "V6Z 1Y6",
                        Country = "Canada", Phone="604-682-2344"
                },
                new Hospital() { HospitalId=2, Name="Eagle Ridge Hospital",
                        Street = "475 Guildford Way", City = "Port Moody",
                        Province = "British Columbia", PostalCode = "V3H 3W9",
                        Country = "Canada", Phone="604-461-2022"
                },
                new Hospital() { HospitalId=3, Name="Vancouver General Hospital (VGH)",
                        Street = "899 West 12th Avenue", City = "Vancouver",
                        Province = "British Columbia", PostalCode = "V5Z 1M9",
                        Country = "Canada", Phone="604-875-4111"
                },
                new Hospital() { HospitalId=4, Name="Surrey Memorial Hospital",
                        Street = "13750 96th Avenue", City = "Surrey",
                        Province = "British Columbia", PostalCode = "V3V 1Z2",
                        Country = "Canada", Phone="604-581-2211"
                },
                new Hospital() { HospitalId=5, Name="Royal Columbian Hospital",
                        Street = "330 East Columbia Street", City = "New Westminster",
                        Province = "British Columbia", PostalCode = "V3L 3W7",
                        Country = "Canada", Phone="604-520-4253"
                },
            };

            return items;
        }

        public static List<Patient> GetPatients()
        {
            List<Patient> items = new List<Patient>()
            {
                new Patient() { PatientId=1, FirstName="Sam", LastName="Fox", Gender='M',
                        DateOfBirth = new DateTime(1987, 4, 7), 
                        Street = "1081 River Street", City = "Delta",
                        Province = "British Columbia", PostalCode = "V6Z 1Y6",
                        Country = "Canada", Phone="604-682-2344", Email="sam@fox.ca",
                        RoomNumber = "204a", InDate = new DateTime(2020, 4, 17), HospitalId = 1
                },
                 new Patient() { PatientId=2, FirstName="Meg", LastName="Roy", Gender='F',
                        DateOfBirth = new DateTime(1980, 2, 10),
                        Street = "181 Alma Road", City = "Surrey",
                        Province = "British Columbia", PostalCode = "V3Z 1P6",
                        Country = "Canada", Phone="604-286-4432", Email="meg@roy.ca",
                        RoomNumber = "114b", InDate = new DateTime(2020, 5, 1), HospitalId = 1
                },
                 new Patient() { PatientId=3, FirstName="Joe", LastName="Day", Gender='M',
                        DateOfBirth = new DateTime(1977, 10, 5),
                        Street = "870 Pitt River Road", City = "Port Coquitlam",
                        Province = "British Columbia", PostalCode = "V3P 2C4",
                        Country = "Canada", Phone="604-943-0807", Email="joe@day.ca",
                        RoomNumber = "304", InDate = new DateTime(2020, 4, 28), HospitalId = 2
                },
                 new Patient() { PatientId=4, FirstName="Ann", LastName="Lee", Gender='F',
                        DateOfBirth = new DateTime(2005, 3, 15),
                        Street = "1870 Ottawa Avenue", City = "Coquitlam",
                        Province = "British Columbia", PostalCode = "V6Y 2Y9",
                        Country = "Canada", Phone="604-942-9856", Email="ann@lee.ca",
                        RoomNumber = "194", InDate = new DateTime(2020, 4, 21), HospitalId = 2
                },
                 new Patient() { PatientId=5, FirstName="Bob", LastName="Ray", Gender='M',
                        DateOfBirth = new DateTime(2015, 6, 12),
                        Street = "7045 Main Street", City = "New Wesminster",
                        Province = "British Columbia", PostalCode = "V7W 2Y9",
                        Country = "Canada", Phone="604-870-4031", Email="bob@ray.ca",
                        RoomNumber = "619a", InDate = new DateTime(2020, 3, 11), HospitalId = 3, OutDate = new DateTime(2020, 3, 18)
                },
            };

            return items;
        }

        public static List<Sickness> GetSicknesses()
        {
            List<Sickness> items = new List<Sickness>()
            {
                new Sickness() { SicknessId=1, PatientId=4, SicknessName="Diabetes" },
                new Sickness() { SicknessId=2, PatientId=4, SicknessName="PTSD" },
                new Sickness() { SicknessId=3, PatientId=2, SicknessName="High Blood Pressure" },
                new Sickness() { SicknessId=4, PatientId=3, SicknessName="COVID-19" },
                new Sickness() { SicknessId=5, PatientId=1, SicknessName="Maternity" },
            };

            return items;
        }

        public static List<Medicine> GetMedicines()
        {
            List<Medicine> items = new List<Medicine>()
            {
                new Medicine() { MedicineId=1, SicknessId=1, Name="Acarbose", DosageUnit="mg" , Dosage=50, FrequencyInHours=8},
                new Medicine() { MedicineId=2, SicknessId=1, Name="Metformin", DosageUnit="mg" , Dosage=850, FrequencyInHours=12},
                new Medicine() { MedicineId=3, SicknessId=2, Name="Prazosin", DosageUnit="mg" , Dosage=150, FrequencyInHours=6},
                new Medicine() { MedicineId=4, SicknessId=2, Name="Zoloft", DosageUnit="mg" , Dosage=180, FrequencyInHours=8},
                new Medicine() { MedicineId=5, SicknessId=3, Name="Benicar", DosageUnit="mg" , Dosage=20, FrequencyInHours=24},
            };

            return items;
        }

    }
}
