using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fs_test.Startup))]
namespace Fs_test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
