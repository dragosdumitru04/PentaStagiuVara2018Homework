using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Module02Homework03.Startup))]
namespace Module02Homework03
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
