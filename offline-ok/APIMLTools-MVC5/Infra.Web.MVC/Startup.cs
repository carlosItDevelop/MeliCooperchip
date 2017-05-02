using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(tools.App.Startup))]
namespace tools.App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
