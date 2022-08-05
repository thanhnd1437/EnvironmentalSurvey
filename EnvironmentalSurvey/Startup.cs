using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EnvironmentalSurvey.Startup))]
namespace EnvironmentalSurvey
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
