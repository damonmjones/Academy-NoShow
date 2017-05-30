using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnShow.Startup))]
namespace OnShow
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
