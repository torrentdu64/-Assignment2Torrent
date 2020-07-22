using Assignment2Torrent09196576.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment2Torrent09196576
{
    public partial class ProductUpdate : System.Web.UI.Page
    {
        private ApplicationDbContext _context;



        public ProductUpdate()
        {
            _context = new ApplicationDbContext();
        }
        public override void Dispose()
        {
            base.Dispose();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            var id = int.Parse(Request.Params["PIid"]);
            var name = Request.Params["Pname"];
            var description = Request.Params["Pdes"];
            var price = Request.Params["Pprice"];
            var discount = Request.Params["Pdiscount"];
            var category = Request.Params["Pcategory"];

           
            var p = _context.Products.Single(m => m.Id == id);
            p.Id = id;
            p.Name = name;
            p.Description = description;
            p.Price = double.Parse(price);
            p.Discount = discount;
            p.Category = category;

            _context.Products.Add(p);
            _context.SaveChanges();

            Response.Redirect("/ProductAdminIndex.aspx");

        }
    }
}