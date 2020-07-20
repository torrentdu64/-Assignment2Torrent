using Assignment2Torrent09196576.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;



namespace Assignment2Torrent09196576
{
    [Authorize]
    public partial class ProductShow : System.Web.UI.Page
    {

        protected Product product;

        
        private ApplicationDbContext _context;

        
        public ProductShow()
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

            var dbproduct = _context.Products.SingleOrDefault(m => m.Id == id);

            product = new Product();
            product.Id = dbproduct.Id;
            product.Name = dbproduct.Name;
            product.Description = dbproduct.Description;
            product.Price = dbproduct.Price;
            product.Discount = dbproduct.Discount;

        }

        public void AddTrolley()
        {
            var productId = int.Parse(Request.Params["id"]);
            var dbproduct = _context.Products.Single(m => m.Id == productId);

            var troll = new Trolley { Name = "Future Person" };
            troll.ProductTrolleys = new List<ProductTrolley>
            {
              new ProductTrolley {
                Product = dbproduct
              }
            };

            //Now add this Trolley, with all its relationships, to the database
            _context.Trolleys.Add(troll);
           // _context.SaveChanges();

            Response.Redirect("Default.aspx");
        }

        public bool IsLogIn()
        {
            var currentUser = System.Web.HttpContext.Current.User.Identity.GetUserId();
            if (currentUser != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}