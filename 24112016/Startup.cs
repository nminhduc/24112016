using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_24112016.Startup))]
namespace _24112016
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
