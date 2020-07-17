using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment2Torrent09196576.Models
{
    public class ProductTrolley
    {

        public int ProductId { get; set; }
        public int TrolleyId { get; set; }

        public virtual Product Product { get; set; }
        public virtual Trolley Trolley { get; set; }
    }
}