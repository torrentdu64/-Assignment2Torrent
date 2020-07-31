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
            try
            {
                ////Assuming user comes back after several hours. several < 12.
                ////Read the cookie from Request.
                HttpCookie myCookie = Request.Cookies["Customer"];
                if (myCookie == null)
                {
                    //No cookie found or cookie expired.
                    //Can read product
                    Response.Redirect("ProductIndex.aspx");
                }

                ////ok - cookie is found.
                ////Gracefully check if the cookie has the key-value as expected.

                myCookie.Expires = DateTime.Now.AddHours(-12);

                Response.Redirect("ProductIndex.aspx");

            }
            catch (Exception err)
            {

                Response.Write(err);
            }
        }
    }
}