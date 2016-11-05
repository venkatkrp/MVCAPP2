using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCAPP2.Startup))]
namespace MVCAPP2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
