using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Wasim.Startup))]
namespace Wasim
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
