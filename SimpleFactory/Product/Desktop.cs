using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public class Desktop : IProduct
    {
        public Desktop(string productName, double productionCost)
        {
            this.productName = productName;
            this.productionCost = productionCost;
        }

        public string productName { get; set; }
        public double productionCost { get; set; }
        public override string ToString()
        {
            return $"[Desktop {productName},{productionCost}]";
        }
    }
}
