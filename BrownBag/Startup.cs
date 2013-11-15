using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BrownBag.Startup))]
namespace BrownBag
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
