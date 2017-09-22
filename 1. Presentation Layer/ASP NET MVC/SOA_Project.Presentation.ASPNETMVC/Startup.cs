using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SOA_Project.Presentation.ASPNETMVC.Startup))]
namespace SOA_Project.Presentation.ASPNETMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
