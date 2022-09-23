using Interfaces;

namespace Task1_Server.Workers
{
    public class Worker1 : BackgroundService
    {
        private readonly ILogger<Worker1> _logger;
        private readonly IClient _client;

        public Worker1(ILogger<Worker1> logger, IClient client)
        {
            _logger = logger;
            _client = client;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Worker-1 запущен.");
            var task = Task.Run(() => _client.StartClientWork(stoppingToken));
            return task;
        }
    }
}