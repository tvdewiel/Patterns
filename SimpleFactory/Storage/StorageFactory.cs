using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public class StorageFactory
    {
        public IStorage createStorage(string type)
        {
            switch (type)
            {
                case "ListStorage": return new ListStorage();
                case "DictionaryStorage":return new DictionaryStorage();
                case "FileStorage":return new FileStorage();
                case "DataBaseStorage":return new DatabaseStorage();
                default: return null;
            }
        }
    }
}
