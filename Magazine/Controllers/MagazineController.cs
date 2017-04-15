using Magazine.BL.UnityOfWork;
using Magazine.Mappers;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Magazine.Controllers
{
    public class MagazineController : BaseController
    {
        private StoreMapper _storeMapper;
        private ItemMapper _itemMapper;

        public MagazineController(IUnityOfWork unityOfWork, StoreMapper storeMapper, ItemMapper itemMapper)
        {
            _unityOfWork = unityOfWork;
            _storeMapper = storeMapper;
            _itemMapper = itemMapper;
        }

        public async Task<ActionResult> Index()
        {
            var storeList = await _unityOfWork.Stores.GetAllAsync();
            var storeListViewModel = _storeMapper.ToStoreListViewModel(storeList);

            return View(storeListViewModel);
        }

        public async Task<JsonResult> GetListItems(int id)
        {
            var itemsList = await _unityOfWork.Items.GetByStoreIdAsync(id);
            var itemsListJsonModel = _itemMapper.ToItemListJsonModel(itemsList);

            return Json(itemsListJsonModel, JsonRequestBehavior.AllowGet);
        }
    }
}
