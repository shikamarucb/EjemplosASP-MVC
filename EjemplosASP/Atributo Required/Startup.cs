using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Atributo_Required.Startup))]
namespace Atributo_Required
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
