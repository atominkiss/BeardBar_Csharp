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
            Mock<IBeerRepository> mock = new Mock<IBeerRepository>();
            mock.Setup(m => m.Beers).Returns(new List<Beer>
            {
                new Beer { Name = "Maisels Wise", Price = 1499 },
                new Beer { Name = "Prachka", Price=2299 },
                new Beer { Name = "Sint Gumarus", Price=899.4M }
            });
            kernel.Bind<IGameRepository>().ToConstant(mock.Object);
        }
    }
}