using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPNETproject.Startup))]
namespace ASPNETproject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
