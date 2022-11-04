using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(addUser.Startup))]
namespace addUser
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
