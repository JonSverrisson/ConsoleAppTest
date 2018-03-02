using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Model
    {
        public IList<Room> rooms { get; set; }
    }


    public class Inventory
    {
        public string epcSku { get; set; }
        public string epcTag { get; set; }
    }

    public class Product
    {
        public string name { get; set; }
        public string articleNumber { get; set; }
        public string thumbnailUrl { get; set; }
        public IList<Inventory> inventory { get; set; }
    }

    public class Category
    {
        public string name { get; set; }
        public IList<Product> products { get; set; }
    }

    public class Room
    {
        public string code { get; set; }
        public string name { get; set; }
        public string thumbnailUrl { get; set; }
        public string imageUrl { get; set; }
        public IList<Category> categories { get; set; } 
    }

    
}
