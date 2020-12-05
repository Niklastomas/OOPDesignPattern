using OOPDesignPattern.Model.Models;
using System.Collections.Generic;

namespace OOPDesignPattern.Data.DataAccess
{
    public interface IProductRepository
    {
        List<IProduct> Products { get; set; }

        List<IProduct> GetProducts();
    }
}