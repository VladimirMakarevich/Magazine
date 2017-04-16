using System.Collections.Generic;
using Magazine.BL.UnityOfWork;
using Magazine.Api.Mappers;
using System.Threading.Tasks;
using Magazine.Api.Models;

namespace Magazine.Api.Controllers
{
    public class ItemsController : BaseController
    {
        public ItemsController(IUnityOfWork unityOfWork, StoreMapper storeMapper, ItemMapper itemMapper) 
            : base(unityOfWork, storeMapper, itemMapper)
        {
        }

        public async Task<IEnumerable<ItemModel>> Get(int id)
        {
            var itemsList = await _unityOfWork.Items.GetStoresByIdAsync(id);
            var itemsListModel = _itemMapper.ToItemListModel(itemsList);

            return itemsListModel;
        }
    }
}
