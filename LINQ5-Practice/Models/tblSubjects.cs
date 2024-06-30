using System.ComponentModel.DataAnnotations;

namespace LINQ5_Practice.Models
{
    public class tblSubjects
    {
        [Key]
        public int SubjectId { get; set; }
        [Required]
        public string SubjectName { get; set; }
        [Required]
        public double SubjectUnit { get; set; }
    }
}
