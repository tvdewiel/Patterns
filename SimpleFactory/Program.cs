using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            StorageFactory storageF = new StorageFactory();
            ProductFactory productF = new ProductFactory();
            SalesFactory salesF = new SalesFactory(productF);
            SalesManager sm = new SalesManager(storageF.createStorage("ListStorage"));
            sm.addSale(salesF.createSale("online",5, "Laptop",1500,1));
            sm.addSale(salesF.createSale("online", 3, "Desktop", 1800, 2));
            sm.addSale(salesF.createSale("online", 15, "Printer", 500, 3));
            sm.addSale(salesF.createSale("shop", 25, "Laptop", 1500, 4));
            foreach(ISale s in sm.getSales())
            {
                Console.WriteLine(s);
            }
            sm.processSales();
            Console.WriteLine($"Profit {sm.getTotalProfit()}");
        }
    }
}
