using AutoMapper;
using Magazine.DAL.Context;
using Magazine.DAL.Entities;
using Magazine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Magazine.Mappers
{
    public class AutoMapperConfig
    {
        public static IMapper GetMapper(MagazineContext context)
        {
            MapperConfiguration config = new MapperConfiguration(RegisterMappings);
            IMapper mapper = config.CreateMapper();
            return mapper;
        }

        private static void RegisterMappings(IMapperConfigurationExpression config)
        {
            config.CreateMap<IEnumerable<StoreViewModel>, IEnumerable<Store>>().ReverseMap();
        }
    }
}