using Magazine.BL.UnityOfWork;
using Magazine.Mappers;
using Ninject;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Magazine.Dependencies
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel _kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            _kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return _kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            // unity of work binding
            _kernel.Bind<IUnityOfWork>().To<UnityOfWork>();

            // repository binding
            //TODO:

            // Identity
            //TODO:

            // mappers binding
            _kernel.Bind<StoreMapper>().ToSelf().InSingletonScope();

        }
    }
}