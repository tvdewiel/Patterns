using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public class Desktop : IProduct
    {
        public string productName { get; set; }
        public double productionCost { get; set; }
        public override string ToString()
        {
            return $"[Desktop {productName},{productionCost}]";
        }
    }
}
