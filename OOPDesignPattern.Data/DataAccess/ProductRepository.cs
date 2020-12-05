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
            new Product(){Id = 1, Title = "AMD Ryzen 9 5900X", Price = 6090, Image = "https://inetimg2.se/img/688x386/5303476_4.jpg", Description = "Högre hastigheter, mer minne och större bandbredd än den tidigare generationen. 3:e gen. AMD Ryzen™-processorer med 7 nm ”Zen 2” core sätter standarden för hög prestation: exklusiv tillverkningsteknik, historisk on-chip-genomströmning, och revolutionerande övergripande prestanda för spel. Från början designades AMD:s 3:e gen. Ryzen™-processorer med denna filosofi, att bryta förväntningar och sätta en ny standard för högpresterande gamingprocessorer."},
            new Product(){Id = 2, Title = "Microsoft Xbox Series X", Price = 5695, Image = "https://inetimg3.se/img/688x386/6335950_5.jpg", Description = "Konsolen i sig ser mycket mer ut som en dator än tidigare Xbox-konsoler, och Microsofts trailer ger en kort inblick i den nya designen. Konsolen i utformad för att användas i både vertikalt och horisontellt läge, och Microsofts Xbox-chef Phil Spencer lovar att den kommer att leverera fyra gånger mer bearbetningskraft än Xbox One X på det mest tysta och effektiva sättet."},
            new Product(){Id = 3, Title = "Sony Playstation 5", Price = 5999, Image = "https://inetimg3.se/img/688x386/6609649_5.jpg", Description = "PS5 -konsolen möjliggör det du aldrig hade förväntat dig i spelväg. Upplev blixtsnabb laddning med en ultrahög hastighet SSD, med stöd för haptisk feedback, adaptiva utlösare och 3D-ljud och en helt ny generation av otroliga spel."},
        };

        public List<IProduct> GetProducts()
        {
            return Products;
        }
    }
}