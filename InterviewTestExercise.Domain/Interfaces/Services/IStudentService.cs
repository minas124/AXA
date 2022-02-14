using InterviewTestExercise.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InterviewTestExercise.Domain.Interfaces.Services
{
    public interface IStudentService
    {
        Task<IEnumerable<Student>> GetStudentsAsync();
        Task<IEnumerable<Student>> GetAllStudentsWithGradesAsync();

    }
}
