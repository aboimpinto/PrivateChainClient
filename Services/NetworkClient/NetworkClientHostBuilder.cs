using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Olimpo;

namespace NetworkClient
{
    public static class NetworkClientHostBuilder
    {
        public static IHostBuilder RegisterNetworkClient(this IHostBuilder builder)
        {
            builder.ConfigureServices((hostContext, services) => 
            {
                services.AddSingleton<IBootstrapper, NetworkClientBootstrapper>();
                services.AddSingleton<INetworkClientService, NetworkClientService>();
            });

            return builder;
        }
    }
}