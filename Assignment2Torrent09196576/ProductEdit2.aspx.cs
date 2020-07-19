using Assignment2Torrent09196576.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment2Torrent09196576
{
    public partial class ProductEdit : System.Web.UI.Page
    {

        private ApplicationDbContext _context;

        protected Product product;


        public ProductEdit()
        {
            _context = new ApplicationDbContext();
        }
        public override void Dispose()
        {
            base.Dispose();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            var id = int.Parse(Request.Params["id"]);
            var dbproduct = _context.Products.Single(m => m.Id == id);
            product = new Product();
            product.Id = dbproduct.Id;
            product.Name = dbproduct.Name;
            product.Description = dbproduct.Description;
            product.Price = dbproduct.Price;
            product.Discount = dbproduct.Discount;
            product.Category = dbproduct.Category;
           
        }
    }
}