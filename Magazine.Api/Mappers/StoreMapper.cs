using AutoMapper;
using Magazine.DAL.Entities;
using Magazine.Api.Models;
using System.Collections.Generic;
using System.Linq;

namespace Magazine.Api.Mappers
{
    public class StoreMapper
    {
        private IMapper _mapper;

        public StoreMapper(IMapper mapper)
        {
            _mapper = mapper;
        }

        public IEnumerable<StoreModel> ToStoreListModel(IEnumerable<Store> store)
        {
            var storeListModel = store.Select(ToStoreModel).ToList();

            return storeListModel;
        }

        public StoreModel ToStoreModel(Store store)
        {
            return _mapper.Map<Store, StoreModel>(store);
        }
    }
}