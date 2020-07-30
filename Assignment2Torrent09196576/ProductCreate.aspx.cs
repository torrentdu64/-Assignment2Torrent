using Assignment2Torrent09196576.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment2Torrent09196576
{
    public partial class ProductCreate : System.Web.UI.Page
    {
        private ApplicationDbContext _context;

       

        public ProductCreate()
        {
            _context = new ApplicationDbContext();
        }
        public override void Dispose()
        {
            base.Dispose();
        }
        
        protected void Page_Load(object sender, EventArgs e)
        {
            var name = Request.Params["Pname"];
            var description = Request.Params["Pdes"];
            var price = Request.Params["Pprice"];
            var discount = Request.Params["Pdiscount"];
            var category = Request.Params["Pcategory"];

          

         

            Product product = new Product();
            product.Name = name;
            product.Description = description;
            product.Price = double.Parse(price);
            if (discount == "")
            {
                product.Discount = null;
            }
            else
            {
                product.Discount = discount;
            }
            
            product.Category = category;

            _context.Products.Add(product);
            _context.SaveChanges();

            Response.Redirect("/ProductAdminIndex.aspx");
    
        }
    }
}