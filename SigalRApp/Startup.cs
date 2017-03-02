using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SigalRApp.Startup))]
namespace SigalRApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
            ConfigureAuth(app);
        }
    }
}
