using System.ComponentModel.DataAnnotations;

namespace LINQ5_Practice.Models
{
    public class tblCourse
    {
        [Key]
        public int CourseId { get; set; }
        [Required]
        public string CourseName { get; set; }
    }
}
