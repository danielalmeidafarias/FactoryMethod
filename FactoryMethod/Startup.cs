using Microsoft.Extensions.DependencyInjection;
using System;

namespace FactoryMethod
{
    public class Startup
    {
        public IServiceProvider ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();

            // Registra dependências compartilhadas
            serviceCollection.AddSingleton<IHttpParameter, HttpParameter>();
            serviceCollection.AddSingleton<ILogger, ConsoleLogger>();
            serviceCollection.AddSingleton<IHttpClient, HttpClient>();
            serviceCollection.AddSingleton<IConfiguration, Configuration>();
            
            // Registra as factories com suas dependências
            serviceCollection.AddTransient<BlingERPFactory>();
            serviceCollection.AddTransient<MilleniumERPFactory>();
            
            serviceCollection.AddSingleton<IERPFactoryProvider, ERPFactoryProvider>();

            return serviceCollection.BuildServiceProvider();
        }
    }
}
