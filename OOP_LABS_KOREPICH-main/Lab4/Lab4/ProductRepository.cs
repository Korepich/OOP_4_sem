using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Lab4
{
    public class ProductRepository
    {
        SQLiteConnection database;
        static object locker = new object();
        public ProductRepository(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<Product>();
        }
        public IEnumerable<Product> GetItems()
        {
            return database.Table<Product>().ToList();
        }
        public Product GetItem(int id)
        {
            return database.Get<Product>(id);
        }
        public int DeleteItem(int id)
        {
            lock (locker)
            {
                return database.Delete<Product>(id);
            }
        }
        public int SaveItem(Product item)
        {
            if (item.id != 0)
            {
                database.Update(item);
                return item.id;
            }
            else
            {
                return database.Insert(item);
            }
        }
    }
}
