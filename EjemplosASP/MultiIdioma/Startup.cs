using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MultiIdioma.Startup))]
namespace MultiIdioma
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
