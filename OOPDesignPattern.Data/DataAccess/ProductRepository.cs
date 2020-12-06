using OOPDesignPattern.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDesignPattern.Data.DataAccess
{
    public class ProductRepository : IProductRepository
    {
        public List<IProduct> Products { get; set; } = new List<IProduct>()
        {
            new Product(){Id = 1, Title = "AMD Ryzen 9 5900X", Price = 6090, Image = "https://inetimg2.se/img/688x386/5303476_4.jpg", Quantity = 10 },
            new Product(){Id = 2, Title = "Microsoft Xbox Series X", Price = 5695, Image = "https://inetimg3.se/img/688x386/6335950_5.jpg", Quantity = 50},
            new Product(){Id = 3, Title = "Sony Playstation 5", Price = 5999, Image = "https://inetimg3.se/img/688x386/6609649_5.jpg", Quantity = 20 },
        };

        public List<IProduct> GetProducts()
        {
            return Products;
        }
    }
}