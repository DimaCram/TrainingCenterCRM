using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TrainingCenterCRM.Core.Filters;

namespace TrainingCenterCRM.DAL.EF.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAll();
        Task<T> Get(int id);
        Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate);
        Task Create(T item);
        Task Update(T item);
        Task Delete(int id);
    }
}
