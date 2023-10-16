using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace TcpOlimpoClient.Manager;

public static class TcpOlimpoClientHostBuilder
{
    public static IHostBuilder RegisterTcpOlimpoClient(this IHostBuilder builder)
    {
        builder.ConfigureServices((hostContext, services) => 
        {
            services.AddSingleton<IClient, Client>();
        });

        return builder;
    }  
}
