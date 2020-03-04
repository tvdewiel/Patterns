using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public class DictionaryStorage : IStorage
    {
        private Dictionary<int,ISale> sales;

        public DictionaryStorage()
        {
            sales = new Dictionary<int, ISale>();
        }

        public IList<ISale> allSales()
        {
            return new List<ISale>(sales.Values);
        }

        public int nrOfSales()
        {
            return sales.Count;
        }

        public ISale retrieveSale(int saleId)
        {
            return sales[saleId];
        }

        public void storeSale(ISale sale)
        {
           sales.Add(sale.salesID,sale);
        }
    }
}
