using InterviewTestExercise.Domain.Entities;
using InterviewTestExercise.Domain.Interfaces.Repositories;
using InterviewTestExercise.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InterviewTestExercise.Domain.Services
{
    public class StudentService : IStudentService
    {
        private readonly IRepository<Student> _repository;

        public StudentService(IRepository<Student> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Student>> GetStudentsAsync()
        {
            return await _repository.GetAllAsync();
        }

        public Task<IEnumerable<Student>> GetAllStudentsWithGradesAsync()
        {
            return null;
        }
    }
}
