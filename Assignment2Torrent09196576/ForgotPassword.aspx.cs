using Assignment2Torrent09196576.Models;
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
    public partial class ForgotPassword : System.Web.UI.Page
    {
        private ApplicationDbContext _context;
        public ForgotPassword()
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

        public static string encrypt(string password)
        {

            SHA256CryptoServiceProvider sha256 = new SHA256CryptoServiceProvider();

            byte[] keyBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password + "SALT"));
            string val = Convert.ToBase64String(keyBytes);
            return val;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var email = Request.Params["Cname"];

            var newPassword = Request.Params["Ppassword"];

            var customer = _context.Customers.Single(m => m.Name == email);

            customer.Password = encrypt(newPassword);

            _context.SaveChanges();


            Response.Redirect("/Product/ProductIndex.aspx");
            Response.End();


        }
    }
}