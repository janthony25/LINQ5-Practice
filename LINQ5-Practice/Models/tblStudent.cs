using System.ComponentModel.DataAnnotations;

namespace LINQ5_Practice.Models
{
    public class tblStudent
    {
        [Key]
        public int StudentId { get; set; }
        [Required]
        public string StudentName { get; set; }
        public int? StudentAge { get; set; }
        public int SubjectId { get; set; }
        public tblSubject tblSubject { get; set; }
        public int CourseId { get; set; }
        public tblCourse tblCourse { get; set; }
    }
}
