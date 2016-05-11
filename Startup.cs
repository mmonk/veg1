using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(veg1.Startup))]
namespace veg1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
