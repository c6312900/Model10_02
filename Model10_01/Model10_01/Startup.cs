using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Model10_01.Startup))]
namespace Model10_01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
