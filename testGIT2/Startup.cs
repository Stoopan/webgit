using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(testGIT2.Startup))]
namespace testGIT2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
