using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Rahbaran_Andishe.Startup))]
namespace Rahbaran_Andishe
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
