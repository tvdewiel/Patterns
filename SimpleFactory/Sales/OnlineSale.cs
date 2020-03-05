using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public class OnlineSale : ISale
    {
        public OnlineSale(int amount, IProduct product, double price, int salesID)
        {
            this.amount = amount;
            this.product = product;
            this.price = price;
            this.salesID = salesID;
        }

        public int amount { get; set; }
        public IProduct product { get; set; }
        public double price { get; set; }
        public int salesID { get; set; }
        public void processSale() {
            Console.WriteLine($"process online sale {this}");
        }
        public override string ToString()
        {
            return $"Online = {product.productName},{amount},{price},{salesID}";
        }
    }
}
