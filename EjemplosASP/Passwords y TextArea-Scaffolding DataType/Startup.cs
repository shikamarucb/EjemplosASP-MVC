using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Passwords_y_TextArea_Scaffolding_DataType.Startup))]
namespace Passwords_y_TextArea_Scaffolding_DataType
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
