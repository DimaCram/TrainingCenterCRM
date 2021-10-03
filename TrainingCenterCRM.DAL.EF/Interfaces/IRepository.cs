using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TrainingCenterCRM.DAL.EF.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetAsync(int id);
        IEnumerable<T> Find(Func<T, bool> predicate);
        Task CreateAsync(T item);
        Task UpdateAsync(T item);
        Task DeleteAsync(int id);
    }
}
