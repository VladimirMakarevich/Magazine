using AutoMapper;
using Magazine.DAL.Entities;
using Magazine.Models.Json;
using System.Collections.Generic;
using System.Linq;

namespace Magazine.Mappers
{
    public class ItemMapper
    {
        private IMapper _mapper;

        public ItemMapper(IMapper mapper)
        {
            _mapper = mapper;
        }

        public IEnumerable<ItemJsonModel> ToItemListJsonModel(IEnumerable<Item> item)
        {
            var itemListJsonModel = item.Select(ToItemJsonModel).ToList();
            return itemListJsonModel;
        }

        public ItemJsonModel ToItemJsonModel(Item item)
        {
            return _mapper.Map<Item, ItemJsonModel>(item);
        }
    }
}