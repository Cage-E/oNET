using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TempMVC.Startup))]
namespace TempMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
