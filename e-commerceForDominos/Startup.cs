using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(e_commerceForDominos.Startup))]
namespace e_commerceForDominos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
