using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bank_System.Startup))]
namespace Bank_System
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
