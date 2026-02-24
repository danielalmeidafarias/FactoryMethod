using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var startup = new Startup();
            var serviceProvider = startup.ConfigureServices();

            // Http Parameter para representar a fonte de configurações do serviço
            // Nesse caso aqui, a configuração depende de informações retornadas por API
            var httpParameter = (IHttpParameter)serviceProvider.GetService(typeof(IHttpParameter));

            // ERP Provider é responsável por saber as implementações de ERP que existem
            // A informação das implementações concretas do ERP passam apenas por ele
            // Metodo GetFactory retorna a factory do ERP em questão
            var erpProvider = (IERPFactoryProvider)serviceProvider.GetService(typeof(IERPFactoryProvider));

            var erpFactory = erpProvider.GetFactory(httpParameter);

            // ERP factory é a classe abstrata que cada ERP deve implementar
            // A classe é responsável por criar o ERP, adicionando todas as dependencias que precisar
            var erp = erpFactory.GetERP();

            while(true)
            {
                Exec(erp);
            }
        }     
        
        static void Exec(IERP erp)
        {
            Console.WriteLine(erp.GetName());
        }

    }

}

