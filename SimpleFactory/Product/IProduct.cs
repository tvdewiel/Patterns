using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public interface IProduct
    {
        string productName { get; set; }
        double productionCost { get; set; }
    }
}
