using Assignment2Torrent09196576.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment2Torrent09196576
{
    public partial class Logout : System.Web.UI.Page
    {
        private ApplicationDbContext _context;

        public Logout()
        {
            _context = new ApplicationDbContext();
        }

        public override void Dispose()
        {
            base.Dispose();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
        
         


            

            HttpCookie currentUserCookie = HttpContext.Current.Request.Cookies["Customer"];
            HttpContext.Current.Response.Cookies.Remove("Customer");
            currentUserCookie.Expires = DateTime.Now.AddDays(-12);
            currentUserCookie.Value = null;
            HttpContext.Current.Response.SetCookie(currentUserCookie);
            Response.Redirect("/Product/ProductIndex.aspx");


        }
    }
}