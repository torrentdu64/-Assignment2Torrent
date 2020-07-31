using Assignment2Torrent09196576.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment2Torrent09196576
{
    public partial class EditCustomer : System.Web.UI.Page
    {
        protected Customer customer;
      
        private ApplicationDbContext _context;
        public EditCustomer()
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
            customer = _context.Customers.Single(m => m.Id == id);
        }
      

        protected void Button1_Click(object sender, EventArgs e)
        {
            var name = Request.Params["Cname"];

            customer.Name = name;

            

            _context.SaveChanges();

            Response.Redirect("AdminCustomerIndex.aspx");

        }
    }
}