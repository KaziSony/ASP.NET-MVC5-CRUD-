using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProductApplication.Startup))]
namespace ProductApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
