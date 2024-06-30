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
    }
}
