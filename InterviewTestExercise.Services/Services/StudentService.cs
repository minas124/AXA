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

        public double AvgGrade(int IdStudenta)
        {
            Student student = _dbContext.Students.Where(u => u.IdStudent == IdStudenta).FirstOrDefault();
            if (student == null)
            {
                return 0;
            }
                return student.AverageGrade;
        }

        public bool NewGrade(int IdStudenta,int newgrade)
        {
            Student student = _dbContext.Students.Where(u => u.IdStudent == IdStudenta).FirstOrDefault();
            if (student == null)
            {
                return false;
            }
            Grade grade = new Grade();
            grade.GivenGrade = newgrade;
            student.Grades.Add(grade);
            _dbContext.Grades.Add(grade);
            _dbContext.SaveChanges();
            return true;
        }

    }
}
