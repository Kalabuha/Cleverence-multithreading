using Interfaces;

namespace Task1_Server.Workers
{
    public class Worker3 : BackgroundService
    {
        private readonly ILogger<Worker3> _logger;
        private readonly IClient _client;

        public Worker3(ILogger<Worker3> logger, IClient client)
        {
            _logger = logger;
            _client = client;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Worker-3 запущен.");
            var task = Task.Run(async () => await _client.StartClientWork(stoppingToken));
            return task;
        }
    }
}