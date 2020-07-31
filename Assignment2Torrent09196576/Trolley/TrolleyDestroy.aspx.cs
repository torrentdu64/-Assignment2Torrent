using Assignment2Torrent09196576.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment2Torrent09196576
{
    public partial class TrolleyDestroy : System.Web.UI.Page
    {
        private ApplicationDbContext _context;

        public TrolleyDestroy()
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
            var t = _context.Trolleys.Single(m => m.Id == id);
            //Trolley trolley = new Trolley() { Id = id };
            _context.Trolleys.Attach(t);
            _context.Trolleys.Remove(t);
            _context.SaveChanges();
            Response.Redirect("/Trolley/TrolleyShow.aspx");
        }
    }
}