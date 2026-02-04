using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public interface IERPFactoryProvider
    {
        ERPFactory GetFactory(IHttpParameter httpParameter);
    }
}
