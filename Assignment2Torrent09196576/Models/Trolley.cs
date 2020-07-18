using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment2Torrent09196576.Models
{
    public class Trolley
    {
        public int Id { get; set; }
        public string  Name { get; set; }

        public virtual ICollection<ProductTrolley> ProductTrolleys { get; set; }
    }
}