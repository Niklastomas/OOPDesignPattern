﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDesignPattern.Model.Models
{
    public class Product : IProduct
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public int Quantity { get; set; }
    }
}