using InventoryManagement.Hubs;
using Microsoft.Owin;
using Owin;


[assembly: OwinStartup("Startup", typeof(Startup))]
namespace InventoryManagement.Hubs
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}