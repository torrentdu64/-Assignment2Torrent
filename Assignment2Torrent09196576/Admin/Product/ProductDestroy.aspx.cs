using Assignment2Torrent09196576.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment2Torrent09196576
{
    public partial class ProductDestroy : System.Web.UI.Page
    {
        private ApplicationDbContext _context;

        public ProductDestroy()
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
            var t = _context.Products.Single(m => m.Id == id);
            
            _context.Products.Attach(t);
            _context.Products.Remove(t);
            _context.SaveChanges();
            Response.Redirect("/Admin/Product/ProductAdminIndex.aspx");
        }
    }
}