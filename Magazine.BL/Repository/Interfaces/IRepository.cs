using System.Collections.Generic;
using System.Threading.Tasks;

namespace Magazine.BL.Repository.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetAsync(int id);
        Task CreateAsync();
        Task UpdateAsync();
        Task DeleteAsync();
    }
}
