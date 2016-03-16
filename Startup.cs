using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestNewsSite.Startup))]
namespace TestNewsSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
