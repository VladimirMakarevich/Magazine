using Magazine.BL.Repository;

namespace Magazine.BL.UnityOfWork
{
    public interface IUnityOfWork
    {
        RepositoryItem Items { get; }
        RepositoryStore Stores { get; }
        void Save();
    }
}
