using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IStorage storage=null;
            StorageFactory storageF = new StorageFactory();
            SalesManager sm = new SalesManager(storageF.createStorage("ListStorage"));
            sm.addSale();
        }
    }
}
