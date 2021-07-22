using System;
using System.Collections.Generic;
using System.Text;

namespace KontaktHome.Model
{
    public class Phone : Product
    {
        public Phone() { }
        public Phone(string name, float price, float discount, string imageUrl, int categoryId, string color, int storage, int ram, int battery)
            : base(name, price, discount, imageUrl, categoryId)
        {
            Color = color;
            Storage = storage;
            Ram = ram;
            Battery = battery;
        }

        public string Color { get; set; }
        public int Storage { get; set; }
        public int Ram { get; set; }
        public int Battery { get; set; }
    }
}
