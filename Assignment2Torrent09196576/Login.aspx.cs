﻿using Assignment2Torrent09196576.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment2Torrent09196576
{
    public partial class Login : System.Web.UI.Page
    {
        private ApplicationDbContext _context;

        public Login()
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

            var email = Request.Params["email"];
            var password = Request.Params["password"];
            var pass = decrypt(password);
            Customer customer = new Customer();
            try
            {
                customer = _context.Customers.SingleOrDefault(m => m.Name == email);
            }
            catch (Exception d)
            {

                Label1.Text = "Somethink is wrong " + d;
            }
            

            if(customer.Name != null)
            {
                HttpCookie customerCookie = new HttpCookie("Customer");

                //Add key-values in the cookie
                customerCookie.Values.Add("customer_id", customer.Id.ToString());
                customerCookie.Values.Add("customer_name", customer.Name.ToString());

                //set cookie expiry date-time. Made it to last for next 12 hours.
                customerCookie.Expires = DateTime.Now.AddHours(12);

                //Most important, write the cookie to client.
                Response.Cookies.Add(customerCookie);

                Response.Redirect("/Product/ProductIndex.aspx");
            }
            else
            {
                Label1.Text = "Somethink is wrong";
            }
            //create a cookie
            
        }

      

        public static string decrypt(string password)
        {

            SHA256CryptoServiceProvider sha256 = new SHA256CryptoServiceProvider();

            byte[] keyBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password + "SALT"));
            string val = Convert.ToBase64String(keyBytes);
            return val;
        }


        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {

        }
    }
}