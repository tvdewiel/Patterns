using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public class Printer : IProduct
    {
        public Printer(string productName, double productionCost)
        {
            this.productName = productName;
            this.productionCost = productionCost;
        }

        public string productName { get; set; }
        public double productionCost { get; set; }
        public override string ToString()
        {
            return $"[Printer {productName},{productionCost}]";
        }
    }
}
