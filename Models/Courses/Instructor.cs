using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApiPool.Models.Courses
{
    public class Instructor
    {
        public int InstructorId { get; set; }

        [Required]        
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
 
        [Required]
        public string Email { get; set; }

        public List<Course> Courses { get; set; }
    }
}