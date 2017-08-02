using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(scapholding.Startup))]
namespace scapholding
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
