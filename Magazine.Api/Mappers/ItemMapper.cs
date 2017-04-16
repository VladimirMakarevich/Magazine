using AutoMapper;
using Magazine.DAL.Entities;
using Magazine.Api.Models;
using System.Collections.Generic;
using System.Linq;

namespace Magazine.Api.Mappers
{
    public class ItemMapper
    {
        private IMapper _mapper;

        public ItemMapper(IMapper mapper)
        {
            _mapper = mapper;
        }

        public IEnumerable<ItemModel> ToItemListModel(IEnumerable<Item> item)
        {
            var itemListModel = item.Select(ToItemModel).ToList();

            return itemListModel;
        }

        public ItemModel ToItemModel(Item item)
        {
            return _mapper.Map<Item, ItemModel>(item);
        }
    }
}