using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class HttpParameter : IHttpParameter
    {
        private readonly Dictionary<string, string> _parameters = new Dictionary<string, string>();

        public string GetParameter()
        {
            return "Bling";
        }
    }
}
