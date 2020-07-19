using Assignment2Torrent09196576.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment2Torrent09196576
{
    public partial class TrolleyShow : System.Web.UI.Page
    {
        private ApplicationDbContext _context;
        protected List<Trolley> trolleys;
        public TrolleyShow()
        {
            _context = new ApplicationDbContext();
        }
        public override void Dispose()
        {
            base.Dispose();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            //var productId = int.Parse(Request.Params["id"]);
            //var dbproduct = _context.Products.Single(m => m.Id == productId);

            //var troll = new Trolley { Name = "Future Person" };
            //troll.ProductTrolleys = new List<ProductTrolley>
            //{
            //  new ProductTrolley {
            //    Product = dbproduct    
            //  }
            //};

            ////Now add this Trolley, with all its relationships, to the database
            //_context.Trolleys.Add(troll);
            //_context.SaveChanges();

            var userId = System.Web.HttpContext.Current.User.Identity.GetUserId();
            var currentUser = _context.Users.Single(u => u.Id == userId);

            trolleys = _context.Trolleys.Where(t => t.User.Id == currentUser.Id).ToList();
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var look = Request.Params;
            Button btn = (Button)sender;
            btn.CommandArgument.ToString();

        }
    }
}