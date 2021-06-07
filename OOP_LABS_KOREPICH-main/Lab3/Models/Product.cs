using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3.Models
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; } // название товара
        public int count { get; set; } // количество товара
        public double price { get; set; } // цена товара
    }
}