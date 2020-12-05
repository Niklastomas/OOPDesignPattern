using System.Collections.Generic;

namespace OOPDesignPattern.Model.Models
{
    public interface IShoppingCart
    {
        List<IProduct> Cart { get; set; }

        void AddToCart(IProduct product);

        void RemoveFromCart(IProduct product);
    }
}