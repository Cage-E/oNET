using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ViewStatDemo.Startup))]
namespace ViewStatDemo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
