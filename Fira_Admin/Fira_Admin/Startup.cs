using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fira_Admin.Startup))]
namespace Fira_Admin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
