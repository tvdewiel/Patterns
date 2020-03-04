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
                case "Laptop": return new Laptop();
                case "Desktop": return new Desktop();
                case "Printer": return new Printer();
                default: return null;
            }
        }
    }
}
