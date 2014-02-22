using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuickResolve.Web.Startup))]
namespace QuickResolve.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
