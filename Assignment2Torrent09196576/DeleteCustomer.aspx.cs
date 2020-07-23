using Assignment2Torrent09196576.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment2Torrent09196576
{
    public partial class DeleteCustomer : System.Web.UI.Page
    {
        private ApplicationDbContext _context;

        public DeleteCustomer()
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
            var t = _context.Customers.Single(m => m.Id == id);
           
            _context.Customers.Attach(t);
            _context.Customers.Remove(t);
            _context.SaveChanges();
            Response.Redirect("/AdminCustomerIndex.aspx");

        }
    }
}