using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CoolBooksFinal.Startup))]
namespace CoolBooksFinal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
