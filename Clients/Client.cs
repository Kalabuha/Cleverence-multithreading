using Interfaces;
using Servers;

namespace Clients
{
    public class Client : IClient
    {
        private static readonly Random _random = new Random();

        public async Task StartClientWork(CancellationToken stoppingToken)
        {
            int i = 0;
            while (i < 5 && !stoppingToken.IsCancellationRequested)
            {
                await Task.Delay(_random.Next(200, 1000), stoppingToken);
                Console.WriteLine(Server2.GetCount());
                Server2.AddToCount(1);
                i++;
            }
        }
    }
}