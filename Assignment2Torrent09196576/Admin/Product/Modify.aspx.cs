using Assignment2Torrent09196576.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment2Torrent09196576
{
    public partial class Modify : System.Web.UI.Page
    {
        private ApplicationDbContext _context;
        protected Product product;

        public Modify()
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            var id = int.Parse(Request.Params["Pid"]);
            var name = Request.Params["Pname"];
            var description = Request.Params["Pdes"];
            var price = Request.Params["Pprice"];
            var discount = Request.Params["Pdiscount"];
            var category = Request.Params["Pcategory"];


            var p = _context.Products.Single(m => m.Id == id);
            
            p.Name = name;
            p.Description = description;
            p.Price = double.Parse(price);
            if (discount == "")
            {
                p.Discount = null;
            }
            else
            {
                p.Discount = discount;
            }
            
            p.Category = category;

            _context.Products.AddOrUpdate(p);
            _context.SaveChanges();

            Response.Redirect("/Admin/Product/ProductAdminIndex.aspx"); 
        }
    }
}