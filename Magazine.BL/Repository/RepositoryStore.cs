using Magazine.BL.Repository.Interfaces;
using Magazine.DAL.Context;
using Magazine.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.BL.Repository
{
    public class RepositoryStore : IRepository<Store>
    {
        private MagazineContext _db;

        public RepositoryStore(MagazineContext context)
        {
            _db = context;
        }

        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public Store Get(int id)
        {
            return _db.Stores.Find(id);
        }

        public IEnumerable<Store> GetAll()
        {
            return _db.Stores.OrderBy(m => m.Id);
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
