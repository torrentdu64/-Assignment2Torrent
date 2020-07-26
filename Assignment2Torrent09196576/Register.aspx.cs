using Assignment2Torrent09196576.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment2Torrent09196576
{
    public partial class Register : System.Web.UI.Page
    {
        private ApplicationDbContext _context;
        
        public Register()
        {
            _context = new ApplicationDbContext();
        }

        public override void Dispose()
        {
            base.Dispose();
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           var email =  Request.Params["email"];
            var password = Request.Params["ctl00$MainContent$exampleInputPassword1"];

            var remember = Request.Params["remember"];

            Customer customer = new Customer();
            customer.Name = email;
            customer.Password = password;
            customer.Role = "Customer";

            _context.Customers.Add(customer);
            _context.SaveChanges();

            //create a cookie
            HttpCookie myCookie = new HttpCookie("Customer");

            //Add key-values in the cookie
            myCookie.Values.Add("customer_id", customer.Id.ToString());
            myCookie.Values.Add("customer_name", customer.Name.ToString());
           

            //set cookie expiry date-time. Made it to last for next 12 hours.
            myCookie.Expires = DateTime.Now.AddHours(12);

            //Most important, write the cookie to client.
            Response.Cookies.Add(myCookie);

            Response.Redirect("ProductIndex.aspx");

        }
    }
}


