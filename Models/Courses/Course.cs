using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiPool.Models.Courses
{
    public class Course
    {
        [Key]
        public string CourseId { get; set; }

        [Required]
        public string Name { get; set; }

        public int InstructorId { get; set; }
                
        [ForeignKey("InstructorId")] 
        public Instructor Instructor { get; set; }
    }
}