using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ocultando_campos_con_ScaffoldColumn.Startup))]
namespace Ocultando_campos_con_ScaffoldColumn
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
