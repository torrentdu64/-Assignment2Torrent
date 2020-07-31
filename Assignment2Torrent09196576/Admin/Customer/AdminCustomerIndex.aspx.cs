using Assignment2Torrent09196576.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment2Torrent09196576
{
    public partial class AdminCustomerIndex : System.Web.UI.Page
    {
        private ApplicationDbContext _context;
        protected List<Customer> customers;

        public AdminCustomerIndex()
        {
            _context = new ApplicationDbContext();
        }
        public override void Dispose()
        {
            base.Dispose();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
           
            customers = _context.Customers.ToList();
        }

     
        protected void Button1_Click1(object sender, EventArgs e)
        {
            var name = Request.Params["Pname"];
            var password = Request.Params["Ppassword"];
            var role = Request.Params["Prole"];

            Customer customer = new Customer();
            customer.Name = name;
            customer.Password = password;
            customer.Role = role;

            _context.Customers.Add(customer);
            _context.SaveChanges();

            name = null;
            Response.Redirect("/Admin/Customer/AdminCustomerIndex.aspx");

        }
    }
}