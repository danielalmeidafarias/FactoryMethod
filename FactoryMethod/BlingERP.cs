using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    // Implementação concreta de Bling da interface IERP
    public class BlingERP : IERP
    {
        private readonly ILogger _logger;
        private readonly IHttpClient _httpClient;
        
        public BlingERP(ILogger logger, IHttpClient httpClient)
        {
            _logger = logger;
            _httpClient = httpClient;
        }
        
        public string GetName()
        {
            _logger.Log("Obtendo nome do Bling ERP");
            return "Bling";
        }
    }


    // ImplementaçÃo da classe abstrata ERPFacotory
    // Essa classe é responsável por instanciar a classe BlingERP com todas as suas dependências
    public class BlingERPFactory : ERPFactory
    {
        private readonly ILogger _logger;
        private readonly IHttpClient _httpClient;
        
        public BlingERPFactory(ILogger logger, IHttpClient httpClient)
        {
            _logger = logger;
            _httpClient = httpClient;
        }
        
        public override IERP CreateERP()
        {
            return new BlingERP(_logger, _httpClient);
        }
    }
}
