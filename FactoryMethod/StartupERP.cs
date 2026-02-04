using System;

namespace FactoryMethod
{
    public class ERPFactory
    {
        public ERPFactory(IHttpParameter httpParameter)
        {
            var erpType = httpParameter.GetParameter();

            switch (erpType)
            {
                case "BLING": { Erp = new BlingERP(); }
                    break;
                case "MILLENIUM": { Erp = new MilleniumERP(); }
                    break;
                default:
                    throw new ArgumentException("No valid ERP argument");
            }
        }
        public IERP GetERP() { return Erp; }

        private readonly IERP Erp;
    }
}

