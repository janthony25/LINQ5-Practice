using System.ComponentModel.DataAnnotations;

namespace LINQ5_Practice.Models
{
    public class tblSubject
    {
        [Key]
        public int SubjectId { get; set; }
        [Required]
        public string SubjectName { get; set; }
        [Required]
        public decimal SubjectUnit { get; set; }
        public ICollection<tblStudent>? tblStudent { get; set; }
        public int CourseId { get; set; }
        public tblCourse? tblCourse { get; set; }
    }
}
