using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SimpleFactory
{
    public class SalesManager
    {
        private IStorage storage;

        public SalesManager(IStorage storage)
        {
            this.storage = storage;
        }
        public void addSale(ISale sale)
        {
            storage.storeSale(sale);
        }
        public double getTotalProfit()
        {
            return storage.allSales().Sum(x => (x.price - x.product.productionCost) * x.amount);
        }
        public IList<ISale> getSales()
        {
            return storage.allSales();
        }
        public void processSales()
        {
            foreach(ISale s in storage.allSales())
            {
                s.processSale();
            }
        }
    }
}
