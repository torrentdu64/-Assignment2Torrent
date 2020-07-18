using Assignment2Torrent09196576.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment2Torrent09196576
{
    public partial class AddTrolley : System.Web.UI.Page
    {
        private ApplicationDbContext _context;

        public AddTrolley()
        {
            _context = new ApplicationDbContext();
        }
        public override void Dispose()
        {
            base.Dispose();
        }
        protected void Page_Load(object sender, EventArgs e)
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
            _context.SaveChanges();

            Response.Redirect("ProductIndex.aspx");
        }
    }
}