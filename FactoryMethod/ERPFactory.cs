using System;
using static FactoryMethod.MilleniumERP;

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
    public class ERPFactoryProvider: IERPFactoryProvider
    {
        public ERPFactory GetFactory(IHttpParameter httpParameter)
        {
            var erpType = httpParameter.GetParameter();

            return erpType switch
            {
                "BLING" => new BlingERPFactory(),
                "MILLENIUM" => new MilleniumERPFactory(),
                _ => throw new ArgumentException("No valid ERP argument")
            };
        }
    }
}

