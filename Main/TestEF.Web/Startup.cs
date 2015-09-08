using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestEF.Web.Startup))]
namespace TestEF.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
