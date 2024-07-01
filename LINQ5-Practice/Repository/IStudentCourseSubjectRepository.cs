using LINQ5_Practice.Models.Dto;

namespace LINQ5_Practice.Repository
{
    public interface IStudentCourseSubjectRepository
    {
        List<StudentCourseSubjectDto> GetAll();
    }
}
