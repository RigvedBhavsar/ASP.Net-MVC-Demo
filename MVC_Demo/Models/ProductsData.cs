using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Demo.Models
{
    public class ProductsData
    {
        //Creating Property of Name ProductList
        public IEnumerable<Product> ProductList
        {
            get 
            {
                List<Product> products = new List<Product>()
                {
                    new Product{ ProductId=1 , Name="Samsung TV", Price=34000},
                    new Product{ ProductId=2 , Name="Apple Watch", Price=21000},
                    new Product{ ProductId=3 , Name="One Plus 8", Price=45000},
                    new Product{ ProductId=4 , Name="HP Laptop", Price=55000}
                };
                return products;
            }
        }
    }
}