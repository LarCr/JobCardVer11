using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JobCardVer11.Startup))]
namespace JobCardVer11
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
