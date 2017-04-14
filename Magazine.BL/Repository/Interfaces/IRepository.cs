using System.Collections.Generic;

namespace Magazine.BL.Repository.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        void Create();
        void Update();
        void Delete();
    }
}
