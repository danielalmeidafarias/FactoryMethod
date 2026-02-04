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
            var httpParameter = (IHttpParameter)serviceProvider.GetService(typeof(IHttpParameter));

            var erpFactory = new ERPFactory(httpParameter);
            var erp = erpFactory.GetERP();

            while(true)
            {
                MainFunction(erp);
            }
        }     
        
        static void MainFunction(IERP erp)
        {
            Console.WriteLine(erp.GetName());
        }

    }

}

