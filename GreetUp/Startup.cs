using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GreetUp.Startup))]
namespace GreetUp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
