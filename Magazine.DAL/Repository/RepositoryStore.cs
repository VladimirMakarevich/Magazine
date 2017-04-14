using Magazine.DAL.Context;
using Magazine.DAL.Entities;
using Magazine.DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.DAL.Repository
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
            throw new NotImplementedException();
        }

        public IEnumerable<Store> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
