using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TeamCityHPFortifyPOC.Startup))]
namespace TeamCityHPFortifyPOC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
