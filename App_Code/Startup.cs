using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestWebsiteGit.Startup))]
namespace TestWebsiteGit
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
