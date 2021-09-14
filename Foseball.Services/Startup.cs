using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Foseball.Services.StartupOwin))]

namespace Foseball.Services
{
    public partial class StartupOwin
    {
        public void Configuration(IAppBuilder app)
        {
            //AuthStartup.ConfigureAuth(app);
        }
    }
}
