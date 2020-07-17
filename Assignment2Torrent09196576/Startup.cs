using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assignment2Torrent09196576.Startup))]
namespace Assignment2Torrent09196576
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
