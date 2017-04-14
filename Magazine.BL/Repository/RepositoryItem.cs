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
    public class RepositoryItem : IRepository<Item>
    {
        private MagazineContext _db;

        public RepositoryItem(MagazineContext context)
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

        public Item Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Item> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
