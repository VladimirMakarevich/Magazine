using Magazine.BL.UnityOfWork;
using Magazine.Api.Mappers;
using System.Web.Http;

namespace Magazine.Api.Controllers
{
    public class BaseController : ApiController
    {
        public IUnityOfWork _unityOfWork;
        public StoreMapper _storeMapper;
        public ItemMapper _itemMapper;

        public BaseController(IUnityOfWork unityOfWork, StoreMapper storeMapper, ItemMapper itemMapper)
        {
            _unityOfWork = unityOfWork;
            _storeMapper = storeMapper;
            _itemMapper = itemMapper;
        }
    }
}
