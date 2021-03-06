using Microsoft.AspNetCore.SignalR.Client;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            Console.WriteLine("SignalR client");
            try
            {
                HubConnection connection = new HubConnectionBuilder().WithUrl(new Uri("http://localhost:11577/datahub/")).WithAutomaticReconnect().Build();
                await connection.StartAsync();
                var state = connection.State;
                Console.WriteLine("State: " + state);
                await connection.InvokeAsync("Welcome");
            }
            catch(Exception e)
            {
                Console.WriteLine($"Exception: {e.Message}");
            }
        }
    }
}
