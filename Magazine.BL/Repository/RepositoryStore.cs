using Magazine.BL.Repository.Interfaces;
using Magazine.DAL.Context;
using Magazine.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public async Task<Store> GetAsync(int id)
        {
            return await _db.Stores.FindAsync(id);
        }

        public async Task<IEnumerable<Store>> GetAllAsync()
        {
            return await _db.Stores.OrderBy(m => m.Id).ToListAsync();
        }
    }
}
