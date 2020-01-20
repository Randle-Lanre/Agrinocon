using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AgrinoconWebApi.Startup))]
namespace AgrinoconWebApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
