using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleCalculatorWebApplication.Startup))]
namespace SimpleCalculatorWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
