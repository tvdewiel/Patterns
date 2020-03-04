using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public class ShopSale
    {
        public int amount { get; set; }
        public IProduct product { get; set; }
        public double price { get; set; }
        public int salesID { get; set; }
        public void processSale()
        {
            Console.WriteLine("process shop sale");
        }
    }
}
