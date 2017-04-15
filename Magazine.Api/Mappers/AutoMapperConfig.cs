using AutoMapper;
using Magazine.Api.Models;
using Magazine.DAL.Entities;
using Ninject.Activation;

namespace Magazine.Api.Mappers
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
            config.CreateMap<StoreModel, Store>().ReverseMap();
            config.CreateMap<ItemModel, Item>().ReverseMap();
        }
    }
}