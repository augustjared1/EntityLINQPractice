using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EntityLINQPractice.Startup))]
namespace EntityLINQPractice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
