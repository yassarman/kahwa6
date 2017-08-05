using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(kahwaService.Startup))]

namespace kahwaService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}