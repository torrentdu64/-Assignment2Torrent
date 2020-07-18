using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment2Torrent09196576.Models
{
    public class ProductTrolley
    {
        [Key]
        [Column(Order = 0)]
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        [Key]
        [Column(Order = 1)]
        [ForeignKey("Trolley")]
        public int TrolleyId { get; set; }
        public virtual Product Product { get; set; }
        public virtual Trolley Trolley { get; set; }
    }
}