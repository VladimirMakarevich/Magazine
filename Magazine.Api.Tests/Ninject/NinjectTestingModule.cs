using AutoMapper;
using Magazine.BL.UnityOfWork;
using Magazine.Api.Controllers;
using Ninject.Modules;
using Magazine.Api.Mappers;

namespace Magazine.Api.Tests.Ninject
{
    public class NinjectTestingModule : NinjectModule
    {
        public override void Load()
        {
            // UOW binding
            Bind<IUnityOfWork>().To<UnityOfWork>();

            // mappers binding
            Bind<StoreMapper>().ToSelf().InSingletonScope();
            Bind<ItemMapper>().ToSelf().InSingletonScope();

            // AutoMapperConfiguration binding
            Bind<IMapper>().ToMethod(AutoMapperConfig.GetMapper).InSingletonScope();

            // controllers
            Bind<StoresController>().ToSelf().InSingletonScope();
            Bind<ItemsController>().ToSelf().InSingletonScope();
        }
    }
}
