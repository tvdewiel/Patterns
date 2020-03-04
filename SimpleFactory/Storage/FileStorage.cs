using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public class FileStorage : IStorage
    {
        public IList<ISale> allSales()
        {
            throw new NotImplementedException();
        }

        public int nrOfSales()
        {
            throw new NotImplementedException();
        }

        public ISale retrieveSale(int saleId)
        {
            throw new NotImplementedException();
        }

        public void storeSale(ISale sale)
        {
            throw new NotImplementedException();
        }
    }
}
