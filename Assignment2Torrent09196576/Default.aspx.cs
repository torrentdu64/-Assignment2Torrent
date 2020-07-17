using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assignment2Torrent09196576.Models;
using System.Data.Entity;


namespace Assignment2Torrent09196576
{
    public partial class _Default : Page
    {
        private ApplicationDbContext _context;

        public _Default()
        {
            _context = new ApplicationDbContext();
        }

        protected  void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        //public int Id { get; set; }
        //public string Name { get; set; }
        //public string Description { get; set; }
        //public string Price { get; set; }
        //var products = new Product();
        }
    }
}