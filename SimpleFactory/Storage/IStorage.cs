using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public interface IStorage
    {
        void storeSale(ISale sale);
        ISale retrieveSale(int saleId);
        int nrOfSales();
        IList<ISale> allSales();
    }
}
