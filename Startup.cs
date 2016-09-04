using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClosedXMLOnline.Startup))]
namespace ClosedXMLOnline
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
