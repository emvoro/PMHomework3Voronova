﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._1
{
    public class Product
    {
        public string Id { get; }
        public string Brand { get; }
        public string Model { get; }
        public decimal Price { get; }

        public Product(string id, string brand, string model, decimal price)
        {
            Id = id;
            Brand = brand;
            Model = model;
            Price = price;
        }

        public override string ToString()
        {
            return " Id : " + Id + " Brand : " + Brand + " Model : " + Model + " Price : " + Price + " USD";
        }
    }
}
