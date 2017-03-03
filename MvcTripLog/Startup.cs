using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcTripLog.Startup))]
namespace MvcTripLog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
