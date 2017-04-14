using AutoMapper;
using Magazine.DAL.Entities;
using Magazine.Models;
using Magazine.Models.Json;
using Ninject.Activation;

namespace Magazine.Mappers
{
    public class AutoMapperConfig
    {
        public static IMapper GetMapper(IContext context)
        {
            MapperConfiguration config = new MapperConfiguration(RegisterMappings);
            IMapper mapper = config.CreateMapper();
            return mapper;
        }

        private static void RegisterMappings(IMapperConfigurationExpression config)
        {
            config.CreateMap<StoreViewModel, Store>().ReverseMap();
            config.CreateMap<ItemJsonModel, Item>().ReverseMap();
        }
    }
}