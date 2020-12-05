using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDesignPattern.Model.Models
{
    public class ShoppingCart : IShoppingCart
    {
        public List<IProduct> Cart { get; set; } = new List<IProduct>();

        public void AddToCart(IProduct product)
        {
            Cart.Add(product);
        }

        public void RemoveFromCart(IProduct product)
        {
            Cart.Remove(product);
        }
    }
}