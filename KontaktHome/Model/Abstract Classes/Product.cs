using System;
using System.Collections.Generic;
using System.Text;

namespace KontaktHome.Model
{
    public abstract class Product
    {
        public Product() { }
        protected Product(string name, float price, float discount, string imageUrl, int categoryId)
        {
            Name = name;
            Price = price;
            Discount = discount;
            ImageUrl = imageUrl;
            CategoryId = categoryId;
        }

        public string Name { get; set; }
        public float Price { get; set; }
        public float Discount { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
    }
}
