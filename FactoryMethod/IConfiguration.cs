using System;
using System.Collections.Generic;

namespace FactoryMethod
{
    public interface IConfiguration
    {
        string GetValue(string key);
    }

    public class Configuration : IConfiguration
    {
        private readonly Dictionary<string, string> _settings = new Dictionary<string, string>
        {
            ["MilleniumName"] = "Millenium ERP System"
        };

        public string GetValue(string key)
        {
            return _settings.TryGetValue(key, out var value) ? value : null;
        }
    }
}
