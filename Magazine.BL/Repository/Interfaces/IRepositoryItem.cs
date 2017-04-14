using System.Collections.Generic;
using System.Threading.Tasks;

namespace Magazine.BL.Repository.Interfaces
{
    public interface IRepositoryItem<T> where T : class
    {
        Task<IEnumerable<T>> GetByStoreIdAsync(int id);
    }
}
