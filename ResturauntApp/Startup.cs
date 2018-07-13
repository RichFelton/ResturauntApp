using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ResturauntApp.Startup))]
namespace ResturauntApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
