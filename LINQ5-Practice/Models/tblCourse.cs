using System.ComponentModel.DataAnnotations;

namespace LINQ5_Practice.Models
{
    public class tblCourse
    {
        [Key]
        public int CourseId { get; set; }
        [Required]
        public string CourseName { get; set; }
        public ICollection<tblStudent> tblStudent { get; set; }
        public ICollection<tblSubject> tblSubject { get; set; }
    }
}
