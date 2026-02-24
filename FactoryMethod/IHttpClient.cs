using System;

namespace FactoryMethod
{
    public interface IHttpClient
    {
        string Get(string url);
    }

    public class HttpClient : IHttpClient
    {
        public string Get(string url)
        {
            return $"Response from {url}";
        }
    }
}
