using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment2Torrent09196576.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Token { get; set; }
    }
}