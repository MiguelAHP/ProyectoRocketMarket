using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(APP_MARKEPLACE.Startup))]
namespace APP_MARKEPLACE
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
