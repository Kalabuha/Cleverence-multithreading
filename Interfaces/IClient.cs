namespace Interfaces
{
    public interface IClient
    {
        Task StartClientWork(CancellationToken stoppingToken);

    }
}