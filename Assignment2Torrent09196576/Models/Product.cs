﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment2Torrent09196576.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double  Price { get; set; }
        public string Discount { get; set; }
        public string Category { get; set; }

        public virtual ICollection<ProductTrolley> ProductTrolleys { get; set; }


    }
}