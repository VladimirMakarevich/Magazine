using Magazine.DAL.Context;
using Magazine.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.DAL.UnityOfWork
{
    public class UnityOfWork : IDisposable
    {
        private MagazineContext db = new MagazineContext();
        private RepositoryItem _itemRepository;
        private RepositoryStore _storeRepository;

        public RepositoryItem Items
        {
            get
            {
                if (_itemRepository == null)
                    _itemRepository = new RepositoryItem(db);
                return _itemRepository;
            }
        }

        public RepositoryStore Stores
        {
            get
            {
                if (_storeRepository == null)
                    _storeRepository = new RepositoryStore(db);
                return _storeRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
