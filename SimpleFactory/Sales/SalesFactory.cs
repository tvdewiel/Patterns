using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public class SalesFactory
    {
        public ISale createSale(string type)
        {
            switch (type)
            {
                case "online": return new OnlineSale();
                case "shop": return new ShopSale();
                default: return null;
            }
        }
    }
}
