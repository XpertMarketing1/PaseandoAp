using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PaseandoAp.Backend.Startup))]
namespace PaseandoAp.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
