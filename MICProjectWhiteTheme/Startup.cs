using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MICProjectWhiteTheme.Startup))]
namespace MICProjectWhiteTheme
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
