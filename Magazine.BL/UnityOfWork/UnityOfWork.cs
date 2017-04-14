using Magazine.BL.Repository;
using Magazine.DAL.Context;
using System;

namespace Magazine.BL.UnityOfWork
{
    public class UnityOfWork : IUnityOfWork, IDisposable
    {
        private MagazineContext _db;
        private RepositoryItem _itemRepository;
        private RepositoryStore _storeRepository;

        public UnityOfWork(MagazineContext db)
        {
            _db = db;
        }

        public UnityOfWork()
        {
            _db = new MagazineContext();
        }

        public RepositoryItem Items
        {
            get
            {
                if (_itemRepository == null)
                    _itemRepository = new RepositoryItem(_db);
                return _itemRepository;
            }
        }

        public RepositoryStore Stores
        {
            get
            {
                if (_storeRepository == null)
                    _storeRepository = new RepositoryStore(_db);
                return _storeRepository;
            }
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _db.Dispose();
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
