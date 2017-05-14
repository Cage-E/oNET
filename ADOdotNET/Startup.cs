using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ADOdotNET.Startup))]
namespace ADOdotNET
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
