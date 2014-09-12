using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CrudTdeA.Startup))]
namespace CrudTdeA
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
