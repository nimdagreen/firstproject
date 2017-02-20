using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public static IEnumerable<Product> GetData(int Count)
        {
            var Persons = new List<Product>();
            for (int i = 1; i <= Count; i++)
            {
                Persons.Add(new Product { ID = i, Name = "Person" + i.ToString() });
            }
            return Persons;
        }

    }
}