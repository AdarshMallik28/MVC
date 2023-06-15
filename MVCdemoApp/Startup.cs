using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCdemoApp.Startup))]
namespace MVCdemoApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
