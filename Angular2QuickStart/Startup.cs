using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Angular2QuickStart.Startup))]
namespace Angular2QuickStart
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
