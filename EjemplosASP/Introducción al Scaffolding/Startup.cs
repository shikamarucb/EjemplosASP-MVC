using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Introducción_al_Scaffolding.Startup))]
namespace Introducción_al_Scaffolding
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
