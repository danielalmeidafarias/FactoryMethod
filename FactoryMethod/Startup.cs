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
            
            return serviceCollection.BuildServiceProvider();
        }
    }
}
