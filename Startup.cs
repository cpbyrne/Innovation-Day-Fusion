using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EmployeeLocationBasedServices.Startup))]
namespace EmployeeLocationBasedServices
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
