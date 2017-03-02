using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace SigalRApp.Models
{
    [HubName("tenantHub")]
    public class DevTestHub : Hub
    {
        [HubMethodName("NotifyClients")]
        public static void NotifyCurrentDevInformationToAllClients()
        {
            IHubContext context = GlobalHost.ConnectionManager.GetHubContext<DevTestHub>();

            // the update client method will update the connected client about any recent changes in the server data
            context.Clients.All.updatedClients();
        }
    }
}