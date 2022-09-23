using Task1_Server.Workers;
using Clients.Extensions;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker1>();
        services.AddHostedService<Worker2>();
        services.AddHostedService<Worker3>();
        services.AddHostedService<Worker4>();
        services.RegisterClients();
    })
    .Build();

await host.RunAsync();
