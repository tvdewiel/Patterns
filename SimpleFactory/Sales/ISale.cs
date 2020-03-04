using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public interface ISale
    {
        int amount { get; set; }
        IProduct product { get; set; }
        double price { get; set; }
        int salesID { get; set; }
        void processSale();
    }
}
