using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeardBar.WebUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetService(Type serviceType)
        {
            return kernel.GetAll(serviceType)
        }

        private void AddBindings()
        {
            //Здесь будут привязки
        }
    }
}