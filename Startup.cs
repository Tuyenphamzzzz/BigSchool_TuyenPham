using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LAB4_5_6.Startup))]
namespace LAB4_5_6
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
