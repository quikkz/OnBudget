using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(OnBudget.MobileAppService.Startup))]

namespace OnBudget.MobileAppService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}