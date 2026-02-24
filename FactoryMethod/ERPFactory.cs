using System;
using Microsoft.Extensions.DependencyInjection;

namespace FactoryMethod
{
    public abstract class ERPFactory
    {
        public abstract IERP CreateERP();

        public IERP GetERP()
        {
            return CreateERP();
        }
    }
    
    // Factory Provider é a classe responsável por manter a informação das implementações concretas
    // Dessa maneira, a informação fica completamente isolada, tanto da utilizaçAo das interfaces
    // Como também como elas são instanciadas
    // A classe recebe o ServiceProvider para utilizar a injeção de dependencias do .NET
    public class ERPFactoryProvider : IERPFactoryProvider
    {
        private readonly IServiceProvider _serviceProvider;
        
        public ERPFactoryProvider(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        
        public ERPFactory GetFactory(IHttpParameter httpParameter)
        {
            var erpType = httpParameter.GetParameter();

            return erpType switch
            {
                "BLING" => _serviceProvider.GetRequiredService<BlingERPFactory>(),
                "MILLENIUM" => _serviceProvider.GetRequiredService<MilleniumERPFactory>(),
                _ => throw new ArgumentException("No valid ERP argument")
            };
        }
    }
}

