using InterviewTestExercise.Domain.Entities;
using InterviewTestExercise.Domain.Interfaces.Services;
using InterviewTestExercise.Persistance;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewTestExercise.Services
{
    public class StudentService : IStudentService
    {
        private readonly ApplicationDbContext _dbContext;

        public StudentService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Student>> GetStudentsAsync()
        {
            return await _dbContext.Students.ToListAsync();
        }

    }
}
