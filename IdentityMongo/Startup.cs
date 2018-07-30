using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(IdentityMongo.Startup))]
namespace IdentityMongo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}