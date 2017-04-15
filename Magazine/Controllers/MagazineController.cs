using Magazine.BL.UnityOfWork;
using Magazine.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
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
            var store = await _unityOfWork.Stores.GetAllAsync();
            var storeListViewModel = _storeMapper.ToStoreListViewModel(store);

            return View(storeListViewModel);
        }

        public async Task<JsonResult> GetListItems(int id)
        {
            var items = await _unityOfWork.Items.GetByStoreIdAsync(id);
            var itemsListJsonModel = _itemMapper.ToItemListJsonModel(items);

            return Json(itemsListJsonModel, JsonRequestBehavior.AllowGet);
        }
    }
}
