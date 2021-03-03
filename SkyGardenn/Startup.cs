using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SkyGardenn.Startup))]
namespace SkyGardenn
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
