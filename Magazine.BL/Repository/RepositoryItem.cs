using Magazine.BL.Repository.Interfaces;
using Magazine.DAL.Context;
using Magazine.DAL.Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Magazine.BL.Repository
{
    public class RepositoryItem : IRepository<Item>, IRepositoryItem<Item>
    {
        private MagazineContext _db;

        public RepositoryItem(MagazineContext context)
        {
            _db = context;
        }

        public async Task<IEnumerable<Item>> GetByStoreIdAsync(int id)
        {
            return await _db.Items.Where(m => m.StoreId == id).ToListAsync();
        }

        public async Task<Item> GetAsync(int id)
        {
            return await _db.Items.FindAsync(id);
        }

        public async Task<IEnumerable<Item>> GetAllAsync()
        {
            return await _db.Items.OrderBy(m => m.Id).ToListAsync();
        }
    }
}
