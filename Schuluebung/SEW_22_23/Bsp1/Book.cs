﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IArticle_2_1
{
    internal class Book : IArticle
    {
        public double Price { get; set; }
        public string Description { get; set; }

        public Book(double price, string description)
        {
            Price = price;
            Description = description;
        }
    }
}
