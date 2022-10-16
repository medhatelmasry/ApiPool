using System.Collections.Generic;
using ApiPool.Models.Courses;

namespace ApiPool.Data.Seed
{
    public class CoursesSeedData
    {
        public static List<Instructor> GetInstructors()
        {
            List<Instructor> items = new List<Instructor>()
            {
                new Instructor() { InstructorId = 1, FirstName = "Zhang", LastName = "Liu", Email = "zhang.liu@qq.com" },
                new Instructor() { InstructorId = 2, FirstName = "Jin", LastName = "Ling", Email = "jin.ling@123.com" },
                new Instructor() { InstructorId = 3, FirstName = "Sam", LastName = "Sun", Email = "sam.sun@gmail.com" },
                new Instructor() { InstructorId = 4, FirstName = "Ann", LastName = "Fox", Email = "ann.fox@outlook.com" }
            };

            return items;
        }

        public static List<Course> GetCourses()
        {
            List<Course> items = new List<Course>()
            {
                new Course() { Id = "COMP2910", Name = "Project Management", InstructorId = 1 },
                new Course() { Id = "COMP3973", Name = "ASP.NET", InstructorId = 2 },
                new Course() { Id = "COMP3717", Name = "Android", InstructorId = 3 },
                new Course() { Id = "COMP1536", Name = "HTML & CSS", InstructorId = 4 }
            };

            return items;
        }

    }
}
