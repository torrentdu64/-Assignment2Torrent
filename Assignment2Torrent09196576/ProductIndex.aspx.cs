using Assignment2Torrent09196576.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;    
using System.Configuration;
using System.Data.Entity;

namespace Assignment2Torrent09196576
{
    public partial class ProductIndex : System.Web.UI.Page
    {

        protected List<Product> dbProducts;
        public List<string> test;

        private ApplicationDbContext _context;

        public ProductIndex()
        {
            _context = new ApplicationDbContext();
        }
        public override void Dispose()
        {
            base.Dispose();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            dbProducts = _context.Products.ToList();
            
            //dbProduct = new List<String>();
            //foreach (var item in dbProducts)
            //{
            //    dbProduct.Add(item.Name);
            //}

          

        }

        //public  List<Product> Products()
        //{
        //    var dbProducts = _context.Products.ToList();

        //    return dbProducts;
        //}

    }
}