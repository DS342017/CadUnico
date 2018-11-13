using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CadUnico.Startup))]
namespace CadUnico
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
