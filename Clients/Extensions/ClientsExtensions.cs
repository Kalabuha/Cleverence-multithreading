using Microsoft.Extensions.DependencyInjection;
using Interfaces;

namespace Clients.Extensions
{
    public static class ClientsExtensions
    {
        public static IServiceCollection RegisterClients(this IServiceCollection services)
        {
            services.AddTransient<IClient, Client>();

            return services;
        }
    }
}
