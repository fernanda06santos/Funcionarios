using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Funcionarios.Startup))]
namespace Funcionarios
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
