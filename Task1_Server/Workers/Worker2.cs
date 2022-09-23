using Interfaces;

namespace Task1_Server.Workers
{
    public class Worker2 : BackgroundService
    {
        private readonly ILogger<Worker2> _logger;
        private readonly IClient _client;

        public Worker2(ILogger<Worker2> logger, IClient client)
        {
            _logger = logger;
            _client = client;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Worker-2 запущен.");
            var task = Task.Run(() => _client.StartClientWork(stoppingToken));
            return task;
        }
    }
}