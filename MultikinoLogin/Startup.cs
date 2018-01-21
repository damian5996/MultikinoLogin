using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MultikinoLogin.Startup))]
namespace MultikinoLogin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
