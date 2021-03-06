using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.SignalR.Protocol;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace aspcorer.hubs
{
	public class DataHub : Hub
	{
		public Task SendData(string user, object data)
		{
			return Clients.All.SendAsync("Data", user, data);
		}

		public async Task Welcome()
		{
            Debug.WriteLine("Call Welcome");
			await Clients.All.SendAsync("welcome", new[] { new HubMessage(), new HubMessage(), new HubMessage() });
		}

		public override async Task OnConnectedAsync()
		{
            Debug.WriteLine("On Connected");
			await Welcome();
			await base.OnConnectedAsync();

		}
	}
}
