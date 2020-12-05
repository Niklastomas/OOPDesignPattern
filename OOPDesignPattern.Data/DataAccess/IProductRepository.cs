using OOPDesignPattern.Model.Models;
using System.Collections.Generic;

namespace OOPDesignPattern.Data.DataAccess
{
    public interface IProductRepository
    {
        List<Product> Products { get; set; }

        List<Product> GetProducts();
    }
}