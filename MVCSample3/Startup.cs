using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCSample3.Startup))]
namespace MVCSample3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
