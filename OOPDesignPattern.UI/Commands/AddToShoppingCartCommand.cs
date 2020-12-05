using OOPDesignPattern.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPDesignPattern.UI.Commands
{
    public class AddToShoppingCartCommand : ICommand
    {
        private readonly Product _product;
        private readonly IShoppingCart _shoppingCart;

        public AddToShoppingCartCommand(Product product, IShoppingCart shoppingCart)
        {
            _product = product;
            _shoppingCart = shoppingCart;
        }

        public void Execute()
        {
            _shoppingCart.AddToCart(_product);
        }

        public void Undo()
        {
            _shoppingCart.RemoveFromCart(_product);
        }
    }
}