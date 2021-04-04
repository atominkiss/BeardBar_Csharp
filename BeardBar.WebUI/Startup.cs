using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BeardBar.WebUI.Startup))]
namespace BeardBar.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
