using Magazine.Api.Models;
using Magazine.BL.UnityOfWork;
using Magazine.Mappers;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Magazine.Api.Controllers
{
    public class StoresController : BaseController
    {
        public StoresController(IUnityOfWork unityOfWork, StoreMapper storeMapper, ItemMapper itemMapper) 
            : base(unityOfWork, storeMapper, itemMapper)
        {
        }

        public async Task<IEnumerable<StoreModel>> Get()
        {
            var storeList = await _unityOfWork.Stores.GetAllAsync();
            var storeListModel = _storeMapper.ToStoreListModel(storeList);

            return storeListModel;
        }
    }
}
