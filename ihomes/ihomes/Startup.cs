using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ihomes.Startup))]
namespace ihomes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
