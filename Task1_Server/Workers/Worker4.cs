using Interfaces;

namespace Task1_Server.Workers
{
    public class Worker4 : BackgroundService
    {
        private readonly ILogger<Worker4> _logger;

        public Worker4(ILogger<Worker4> logger)
        {
            _logger = logger;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var asyncCaller = new AsyncCaller((o, e) =>
            {
                Thread.Sleep(4000);
            });

            var result = asyncCaller.Invoke(5000, null, EventArgs.Empty);

            _logger.LogInformation("Результат вызова метода: {IsCompleted}", result);
            return Task.CompletedTask;
        }
    }
}