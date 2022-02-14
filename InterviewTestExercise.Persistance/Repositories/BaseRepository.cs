using InterviewTestExercise.Domain.Entities;
using InterviewTestExercise.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTestExercise.Persistance.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _dbContext;

        public BaseRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbContext.Database.EnsureCreated();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task Save()
        {
            await _dbContext.SaveChangesAsync();
        }

        public async Task Add(T newElement)
        {
            await _dbContext.Set<T>().AddAsync(newElement);
        }

        public IQueryable<T> Include(Expression<Func<T, object>> includes)
        {
            return _dbContext.Set<T>().Include(includes);
        }
    }
}
