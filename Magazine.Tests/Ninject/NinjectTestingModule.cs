using AutoMapper;
using Magazine.BL.UnityOfWork;
using Magazine.Controllers;
using Magazine.Mappers;
using Ninject.Modules;

namespace Magazine.Tests.Ninject
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
            Bind<MagazineController>().ToSelf().InSingletonScope();
        }
    }
}
