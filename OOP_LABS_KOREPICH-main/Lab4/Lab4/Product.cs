using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Lab4
{
    [Table("Products")]
    public class Product
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int id { get; set; }
        public string name { get; set; } // название товара
        public int count { get; set; } // количество товара
        public int price { get; set; } // цена товара
    }
}
