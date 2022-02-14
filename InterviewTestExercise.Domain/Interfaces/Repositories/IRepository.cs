using InterviewTestExercise.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTestExercise.Domain.Interfaces.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task Save();
        Task Add(T newElement);
        IQueryable<T> Include(Expression<Func<T, object>> includes);
    }
}
