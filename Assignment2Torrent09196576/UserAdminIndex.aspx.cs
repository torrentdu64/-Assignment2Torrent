using Assignment2Torrent09196576.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment2Torrent09196576
{
    public partial class UserAdminIndex : System.Web.UI.Page
    {
       
        private ApplicationDbContext _context;

        protected List<ApplicationUser> users;
     

        public UserAdminIndex()
        {
            _context = new ApplicationDbContext();
        }
        public override void Dispose()
        {
            base.Dispose();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            users = _context.Users.ToList();

        }
    }
}