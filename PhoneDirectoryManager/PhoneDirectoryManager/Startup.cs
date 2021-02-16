using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhoneDirectoryManager.Startup))]
namespace PhoneDirectoryManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
