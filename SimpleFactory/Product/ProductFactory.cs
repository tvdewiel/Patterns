using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public class ProductFactory
    {
        public IProduct createProduct(string type)
        {
            switch (type)
            {
                case "Laptop": return new Laptop("Acer",750);
                case "Desktop": return new Desktop("IBM",900);
                case "Printer": return new Printer("HP",80);
                default: return null;
            }
        }
    }
}
