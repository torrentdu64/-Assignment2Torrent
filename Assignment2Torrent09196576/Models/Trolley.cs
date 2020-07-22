using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Assignment2Torrent09196576.Models
{
    public class Trolley
    {
        public int Id { get; set; }
        public string  Name { get; set; }

        
        public int UserId 
        public virtual ICollection<ProductTrolley> ProductTrolleys { get; set; }
    }
}