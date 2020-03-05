using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public class SalesFactory
    {
        private ProductFactory pFac;

        public SalesFactory(ProductFactory pFac)
        {
            this.pFac = pFac;
        }

        public ISale createSale(string type, int amount, string product, double price, int salesID)
        {
            switch (type)
            {
                case "online": return new OnlineSale(amount,pFac.createProduct(product),price,salesID);
                case "shop": return new ShopSale(amount, pFac.createProduct(product), price, salesID);
                default: return null;
            }
        }
    }
}
