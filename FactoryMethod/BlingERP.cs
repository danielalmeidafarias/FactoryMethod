using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class BlingERP : IERP
    {
        public string GetName()
        {
            return "Bling";
        }
    }

    public class BlingERPFactory : ERPFactory
    {
        public override IERP CreateERP()
        {
            return new BlingERP();
        }
    }
}
