using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SalsaDeLourdes.Startup))]
namespace SalsaDeLourdes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
