using Microsoft.Extensions.DependencyInjection;
using System;

namespace FactoryMethod
{
    public class Startup
    {
        public IServiceProvider ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddSingleton<IHttpParameter, HttpParameter>();
            serviceCollection.AddSingleton<IERPFactoryProvider, ERPFactoryProvider>();

            return serviceCollection.BuildServiceProvider();
        }
    }
}
