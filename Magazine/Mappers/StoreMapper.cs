using AutoMapper;
using Magazine.DAL.Entities;
using Magazine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Magazine.Mappers
{
    public class StoreMapper
    {
        private IMapper _mapper;

        public StoreMapper(IMapper mapper)
        {
            _mapper = mapper;
        }

        public IEnumerable<StoreViewModel> ToStoreViewModel(IEnumerable<Store> store)
        {
            return _mapper.Map<IEnumerable<Store>, IEnumerable<StoreViewModel>>(store);
        }
    }
}