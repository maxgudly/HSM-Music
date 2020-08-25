using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HSM_Music.Startup))]
namespace HSM_Music
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
