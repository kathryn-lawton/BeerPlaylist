using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BeerPlaylist.Startup))]
namespace BeerPlaylist
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
