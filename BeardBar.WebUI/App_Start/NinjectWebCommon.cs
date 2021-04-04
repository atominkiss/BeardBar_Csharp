using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeardBar.WebUI.App_Start
{
    private static void RegisterServices(IKernel kernel)
    {
        System.Web.Mvc.DependencyResolver.SetResolver(new GameStore.WebUI.Infrastructure.NinjectDependencyResolver(kernel));
    }
}