using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MembershipsWebApp.Startup))]
namespace MembershipsWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
