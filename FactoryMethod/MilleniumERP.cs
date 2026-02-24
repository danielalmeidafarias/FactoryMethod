using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class MilleniumERP : IERP
    {
        private readonly ILogger _logger;
        private readonly IConfiguration _config;
        
        public MilleniumERP(ILogger logger, IConfiguration config)
        {
            _logger = logger;
            _config = config;
        }
        
        public string GetName()
        {
            var name = _config.GetValue("MilleniumName");
            _logger.Log($"Obtendo nome do Millenium: {name}");
            return name ?? "Millenium";
        }
    }

    public class MilleniumERPFactory : ERPFactory
    {
        private readonly ILogger _logger;
        private readonly IConfiguration _config;
        
        public MilleniumERPFactory(ILogger logger, IConfiguration config)
        {
            _logger = logger;
            _config = config;
        }
        
        public override IERP CreateERP()
        {
            return new MilleniumERP(_logger, _config);
        }
    }
}
