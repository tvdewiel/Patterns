using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public class ListStorage : IStorage
    {
        private List<ISale> sales;

        public ListStorage()
        {
            sales = new List<ISale>();
        }

        public IList<ISale> allSales()
        {
            return sales;
        }

        public int nrOfSales()
        {
            return sales.Count;
        }

        public ISale retrieveSale(int salesId)
        {
            return sales.Find(x => x.salesID == salesId);
        }

        public void storeSale(ISale sale)
        {
            sales.Add(sale);
        }
    }
}
