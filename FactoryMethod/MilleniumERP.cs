using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class MilleniumERP : IERP
    {
        public string GetName()
        {
            return "Millenium";
        }
    }
}
